using System;
using System.Collections.Generic;
using System.Text;

namespace Jint.Native {
    [Serializable]
    public class ValueDescriptor : Descriptor {
        public ValueDescriptor(JsDictionaryObject owner, string name)
            : base(owner, name) {
            Enumerable = true;
            Writable = true;
            Configurable = true;
        }

        JsInstance value;

        public ValueDescriptor(JsDictionaryObject owner, string name, JsInstance value)
            : this(owner, name) {
            Set(null, value);
        }

        public override JsInstance Get(JsDictionaryObject that) {
            return value ?? JsUndefined.Instance;
        }

        public override void Set(JsDictionaryObject that, JsInstance value) {
            if (!Writable)
                throw new JintException("This property is not writable");
            this.value = value;
        }

        internal override DescriptorType DescriptorType {
            get { return DescriptorType.Value; }
        }

        public override object Value {
            get {
                return value;
            }
            set {
                this.value = (JsInstance)value;
            }
        }
    }
}
