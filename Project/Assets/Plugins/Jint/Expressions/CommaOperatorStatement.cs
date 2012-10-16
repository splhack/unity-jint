using System;
using System.Collections.Generic;
using System.Text;

namespace Jint.Expressions {
    [Serializable]
    public class CommaOperatorStatement : Expression {
        public List<Statement> Statements { get; set; }

        public CommaOperatorStatement() {
            Statements = new List<Statement>();
        }

        [System.Diagnostics.DebuggerStepThrough]
        public override void Accept(IStatementVisitor visitor) {
            visitor.Visit(this);
        }

    }
}
