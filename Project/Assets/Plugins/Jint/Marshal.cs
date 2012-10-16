using System;
using System.Collections.Generic;
using System.Text;
using Jint.Native;
using System.Reflection;
using System.Reflection.Emit;
using Jint.Marshal;
using Jint.Delegates;
using System.Text.RegularExpressions;

namespace Jint
{
    /// <summary>
    /// Marshals clr objects to js objects and back. It can marshal types, delegates and other types of objects.
    /// </summary>
    /// <remarks>
    /// <pre>
    /// Marshaller holds a reference to a global object which is used to get a prototype while marshalling from
    /// clr to js. Futhermore a marshaller is to be accessible while running a script, therefore it strictly
    /// linked to the global object which defines a runtime environment for the script.
    /// </pre>
    /// </remarks>
    public class Marshaller
    {

        IGlobal m_global;
        Dictionary<Type, Delegate> m_arrayMarshllers = new Dictionary<Type, Delegate>();

        /* Assuming that Object supports IConvertable
         *
         */
        static bool[,] IntegralTypeConvertions = {
        //      Empty   Object  DBNull  Boolean Char    SByte   Byte    Int16   UInt16  Int32   UInt32  Int64   UInt64  Single  Double  Decimal DateTim -----   String
/*Empty*/   {   false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  true    },
/*Objec*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  true    },
/*DBNul*/   {   false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  true    },
/*Boole*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Char */   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  false,  false,  false,  true    },
/*SByte*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Byte */   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Int16*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*UInt1*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Int32*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*UInt3*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Int64*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*UInt6*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Singl*/   {   false,  false,  false,  true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Doubl*/   {   false,  false,  false,  true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*Decim*/   {   false,  false,  false,  true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  false,  true    },
/*DateT*/   {   false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  true,   false,  true    },
/*-----*/   {   false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false   },
/*Strin*/   {   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false,  true    }
        };

        /// <summary>
        /// Constaructs a new marshaller object.
        /// </summary>
        /// <param name="global">A global object which can be used for constructing new JsObjects while marshalling.</param>
        public Marshaller(IGlobal global)
        {
            this.m_global = global;
        }

        TElem[] MarshalJsArrayHelper<TElem>(JsObject value)
        {
            int len = (int)value["length"].ToNumber();
            if (len < 0)
                len = 0;

            TElem[] res = new TElem[len];
            for (int i = 0; i < len; i++)
                res[i] = MarshalJsValue<TElem>(value[new JsNumber(i, JsUndefined.Instance)]);

            return res;
        }

        /// <summary>
        /// Marshals a JsInstance to a native value.
        /// </summary>
        /// <typeparam name="T">A native object type</typeparam>
        /// <param name="value">A JsInstance to marshal</param>
        /// <returns>A converted native velue</returns>
        public T MarshalJsValue<T>(JsInstance value)
        {
            if (value.Value is T)
            {
                return (T)value.Value;
            }
            else
            {
                if (typeof(T).IsArray)
                {
                    if (value == null || value == JsUndefined.Instance || value == JsNull.Instance)
                        return default(T);
                    if (m_global.ArrayClass.HasInstance(value as JsObject))
                    {
                        Delegate marshller;
                        if (!m_arrayMarshllers.TryGetValue(typeof(T), out marshller))
							throw new NotSupportedException();
                        return ((Jint.Delegates.Func<JsObject, T>)marshller)(value as JsObject);
                    }
                    else
                    {
                        throw new JintException("Array is required");
                    }
                }
                else if (typeof(Delegate).IsAssignableFrom(typeof(T)))
                {
                    if (value == null || value == JsUndefined.Instance || value == JsNull.Instance)
                        return default(T);

                    if (! (value is JsFunction) )
                        throw new JintException("Can't convert a non function object to a delegate type");
					throw new NotSupportedException();
                }
                else if (value != JsNull.Instance && value != JsUndefined.Instance && value is T)
                {
                    return (T)(object)value;
                }
                else
                {
                    // JsNull and JsUndefined will fall here and become a nulls
                    return (T)Convert.ChangeType(value.Value, typeof(T));
                }
            }
        }

        /// <summary>
        /// This is a temporary solution... Used when calling a members on value types.
        /// </summary>
        /// <remarks>
        /// This method used to get a reference to the boxed value type, then a reference is
        /// unboxed to managed pointer and then is used as the first argument in a method call.
        /// </remarks>
        /// <typeparam name="T">Type of value type, which we desire to get</typeparam>
        /// <param name="value">A js value which should be marshalled</param>
        /// <returns>A reference to a boxed value</returns>
        public object MarshalJsValueBoxed<T>(JsInstance value)
        {
            if (value.Value is T)
                return value.Value;
            else
                return null;
        }


        /// <summary>
        /// Gets a type of a native object represented by the current JsInstance.
        /// If JsInstance is a pure JsObject than returns a type of js object itself.
        /// </summary>
        /// <remarks>
        /// If a value is a wrapper around native value (like String, Number or a marshaled native value)
        /// this method returns a type of a stored value.
        /// If a value is an js object (constructed with a pure js function) this method returns
        /// a type of this value (for example JsArray, JsObject)
        /// </remarks>
        /// <param name="value">JsInstance value</param>
        /// <returns>A Type object</returns>
        public Type GetInstanceType(JsInstance value)
        {
            if (value == null || value == JsUndefined.Instance || value == JsNull.Instance )
                return null;

            if (value.Value != null )
                return value.Value.GetType();

            return value.GetType();
        }

        public bool IsAssignable(Type target, Type source)
        {
            return
                (typeof(IConvertible).IsAssignableFrom(source) && IntegralTypeConvertions[(int)Type.GetTypeCode(source), (int)Type.GetTypeCode(target)])
                || target.IsAssignableFrom(source);
        }
    }
}
