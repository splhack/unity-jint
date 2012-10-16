using System;
using System.Collections.Generic;
using System.Text;

namespace Jint.Native {
    [Serializable]
    public class JsObject : JsDictionaryObject {

        public INativeIndexer Indexer { get; set; }
        
        public JsObject() {
        }

        public JsObject(object value, JsObject prototype)
            : base(prototype) {
            this.value = value;
        }

        public JsObject(JsObject prototype)
            : base(prototype) {
        }

        public override bool IsClr
        {
            get
            {
                // if this instance holds a native value
                return Value != null;
            }
        }

        public override string Class {
            get { return CLASS_OBJECT; }
        }

        public override string Type
        {
            get { return TYPE_OBJECT; }
        }

        protected object value;

        public override object Value {
            get { return value; }
            set { this.value = value; }
        }

        public override int GetHashCode() {
            return System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this);
        }

        #region primitive operations
        public override JsInstance ToPrimitive(IGlobal global) {
            switch (Convert.GetTypeCode(Value)) {
                case TypeCode.Boolean:
                    return global.BooleanClass.New((bool)Value);
                case TypeCode.Char:
                case TypeCode.String:
                case TypeCode.Object:
                    return global.StringClass.New(Value.ToString());
                case TypeCode.DateTime:
                    return global.DateClass.New((DateTime)Value);
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return global.NumberClass.New(Convert.ToDouble(Value));
                case TypeCode.DBNull:
                case TypeCode.Empty:
                default:
                    break;
            }

            return JsUndefined.Instance;
        }

        public override bool ToBoolean() {

            switch (Convert.GetTypeCode(Value))
            {
                case TypeCode.Boolean:
                    return (bool)Value;
                case TypeCode.Char:
                case TypeCode.String:
                    return JsString.StringToBoolean((string)Value);
                case TypeCode.DateTime:
                    return JsNumber.NumberToBoolean(JsDate.DateToDouble((DateTime)Value));
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return JsNumber.NumberToBoolean((double)Value);
                case TypeCode.Object:
                    return Convert.ToBoolean(Value);
                case TypeCode.DBNull:
                case TypeCode.Empty:
                default:
                    if (value is IConvertible) {
                        return Convert.ToBoolean(Value);
                    }
                    else {
                        return true;
                    }
            }
        }

        public override double ToNumber() {
            if (Value == null)
            {
                return 0;
            }

            switch (Convert.GetTypeCode(Value))
            {
                case TypeCode.Boolean:
                    return JsBoolean.BooleanToNumber((bool)Value);
                case TypeCode.Char:
                case TypeCode.String:
                    return JsString.StringToNumber((string)Value);
                case TypeCode.DateTime:
                    return JsDate.DateToDouble((DateTime)Value);
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return Convert.ToDouble(Value);
                case TypeCode.Object:
                    return Convert.ToDouble(Value);
                case TypeCode.DBNull:
                case TypeCode.Empty:
                default:
                    if (value is IConvertible) {
                        return Convert.ToDouble(Value);
                    }
                    else {
                        return double.NaN;
                    }
            }
        }

        public override string ToString() {
            if (value == null) {
                return null;
            }

            if (value is IConvertible)
                return Convert.ToString(Value);

            return value.ToString();
        }
        #endregion
    }
}
