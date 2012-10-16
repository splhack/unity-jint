using System;
using System.Collections.Generic;
using System.Text;
using Jint.Expressions;
using Jint.Delegates;

namespace Jint.Native {
    [Serializable]
    public class JsFunctionConstructor : JsConstructor {

        public JsFunctionConstructor(IGlobal global, JsObject prototype)
            : base(global, prototype) {
            Name = "Function";
            DefineOwnProperty(PROTOTYPE, prototype, PropertyAttributes.DontEnum | PropertyAttributes.DontDelete | PropertyAttributes.ReadOnly);
        }

        public override void InitPrototype(IGlobal global) {
            var Prototype = PrototypeProperty;

            // ((JsFunction)Prototype).Scope = global.ObjectClass.Scope;

            Prototype.DefineOwnProperty("constructor", this, PropertyAttributes.DontEnum);

            Prototype.DefineOwnProperty(CALL.ToString(), new JsCallFunction(this), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty(APPLY.ToString(), new JsApplyFunction(this), PropertyAttributes.DontEnum);

            Prototype.DefineOwnProperty("toString", New<JsDictionaryObject>(ToString2), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty("toLocaleString", New<JsDictionaryObject>(ToString2), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty("length", new PropertyDescriptor<JsObject>(global, Prototype, "length", GetLengthImpl, SetLengthImpl));
        }



        public JsInstance GetLengthImpl(JsDictionaryObject target) {
            return Global.NumberClass.New(target.Length);
        }

        public JsInstance SetLengthImpl(JsInstance target, JsInstance[] parameters) {
            int length = (int)parameters[0].ToNumber();

            if (length < 0 || double.IsNaN(length) || double.IsInfinity(length)) {
                throw new JsException(Global.RangeErrorClass.New("invalid length"));
            }

            JsDictionaryObject obj = (JsDictionaryObject)target;
            obj.Length = length;

            return parameters[0];
        }

        public JsInstance GetLength(JsDictionaryObject target) {
            return Global.NumberClass.New(target.Length);
        }

        public JsFunction New() {
            JsFunction function = new JsFunction(PrototypeProperty);
            function.PrototypeProperty = Global.ObjectClass.New(function);
            return function;
        }

        public JsFunction New<T>(Jint.Delegates.Func<T, JsInstance> impl) where T : JsInstance {
            JsFunction function = new ClrImplDefinition<T>(impl, PrototypeProperty);
            function.PrototypeProperty = Global.ObjectClass.New(function);
            //function.Scope = new JsScope(PrototypeProperty);
            return function;
        }
        public JsFunction New<T>(Jint.Delegates.Func<T, JsInstance> impl, int length) where T : JsInstance {
            JsFunction function = new ClrImplDefinition<T>(impl, length, PrototypeProperty);
            function.PrototypeProperty = Global.ObjectClass.New(function);
            //function.Scope = new JsScope(PrototypeProperty);
            return function;
        }

        public JsFunction New<T>(Jint.Delegates.Func<T, JsInstance[], JsInstance> impl) where T : JsInstance {
            JsFunction function = new ClrImplDefinition<T>(impl, PrototypeProperty);
            function.PrototypeProperty = Global.ObjectClass.New(function);
            //function.Scope = new JsScope(PrototypeProperty);
            return function;
        }
        public JsFunction New<T>(Jint.Delegates.Func<T, JsInstance[], JsInstance> impl, int length) where T : JsInstance {
            JsFunction function = new ClrImplDefinition<T>(impl, length, PrototypeProperty);
            function.PrototypeProperty = Global.ObjectClass.New(function);
            //function.Scope = new JsScope(PrototypeProperty);
            return function;
        }

        public JsFunction New(Delegate d) {
            JsFunction function = new ClrFunction(d, PrototypeProperty);
            function.PrototypeProperty = Global.ObjectClass.New(function);
            //function.Scope = new JsScope(PrototypeProperty);
            return function;
        }

        public override JsInstance Execute(IJintVisitor visitor, JsDictionaryObject that, JsInstance[] parameters) {
            return visitor.Return( Construct(parameters,null,visitor) );
        }

        public override JsObject Construct(JsInstance[] parameters, Type[] genericArgs, IJintVisitor visitor)
        {
            JsFunction instance = New();

            instance.Arguments = new List<string>();

            for (int i = 0; i < parameters.Length - 1; i++)
            {
                string arg = parameters[i].ToString();

                foreach (string a in arg.Split(','))
                {
                    instance.Arguments.Add(a.Trim());
                }
            }

            if (parameters.Length >= 1)
            {
                Program p = JintEngine.Compile(parameters[parameters.Length - 1].Value.ToString(), visitor.DebugMode);
                instance.Statement = new BlockStatement() { Statements = p.Statements };
            }

            return instance;
        }

        public JsInstance ToString2(JsDictionaryObject target, JsInstance[] parameters) {
            return Global.StringClass.New(target.ToSource());
        }
    }
}
