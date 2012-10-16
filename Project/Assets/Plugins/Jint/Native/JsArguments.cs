using System;
using System.Collections.Generic;
using System.Text;
using Jint.Delegates;

namespace Jint.Native {
    [Serializable]
    public class JsArguments : JsObject {
        public const string CALLEE = "callee";

        protected ValueDescriptor calleeDescriptor;

        protected JsFunction Callee {
            get { return this[CALLEE] as JsFunction; }
            set { this[CALLEE] = value; }
        }

        public JsArguments(IGlobal global, JsFunction callee, JsInstance[] arguments)
            : base(global.ObjectClass.New()) {
            this.global = global;
            // Add the named parameters
            for (int i = 0; i < Math.Max(arguments.Length, callee.Arguments.Count); i++) {
                ValueDescriptor d = new ValueDescriptor(this, i < callee.Arguments.Count ? callee.Arguments[i] : i.ToString()) { Attributes = PropertyAttributes.DontDelete };

                d.Set(this, i < arguments.Length ? arguments[i] : JsUndefined.Instance);

                this.DefineOwnProperty(i.ToString(), d);
            }

            length = arguments.Length;

            calleeDescriptor = new ValueDescriptor(this, CALLEE) { Attributes = PropertyAttributes.DontEnum };
            DefineOwnProperty(CALLEE, calleeDescriptor);
            calleeDescriptor.Set(this, callee);

            DefineOwnProperty("length", new PropertyDescriptor<JsArguments>(global, this, "length", GetLength) { Attributes = PropertyAttributes.DontEnum });
        }

        private int length;
        private IGlobal global;

        public override bool IsClr
        {
            get
            {
                return false;
            }
        }

        public override bool ToBoolean() {
            return false;
        }

        public override double ToNumber() {
            return Length;
        }

        /// <summary>
        /// The number of the actually passed arguments
        /// </summary>
        public override int Length {
            get {
                return length;
            }
            set {
                length = value;
            }
        }

        public override string Class {
            get { return CLASS_ARGUMENTS; }
        }

        public JsInstance GetLength(JsArguments target) {
            return global.NumberClass.New(target.length);
        }
    }
}
