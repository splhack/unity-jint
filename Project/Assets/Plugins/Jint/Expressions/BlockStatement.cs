using System;
using System.Collections.Generic;
using System.Text;

namespace Jint.Expressions {
    [Serializable]
    public class BlockStatement : Statement {
        public LinkedList<Statement> Statements { get; set; }

        public BlockStatement() {
            Statements = new LinkedList<Statement>();
        }

        [System.Diagnostics.DebuggerStepThrough]
        public override void Accept(IStatementVisitor visitor) {
            visitor.Visit(this);
        }


        private bool reordered = false;

        public LinkedList<Statement> ReorderStatements() {
            if (!reordered) {
                var iter = Statements.First;

                var nodeVars = new LinkedListNode<Statement>(null);
                var nodeFuncs = new LinkedListNode<Statement>(null);

                Statements.AddFirst(nodeVars);
                Statements.AddFirst(nodeFuncs);

                while (iter != null) {
                    var next = iter.Next;
                    if (iter.Value is VariableDeclarationStatement) {
                        //Statements.Remove(iter);
                        var varDecl = new VariableDeclarationStatement();
                        varDecl.Identifier = ((VariableDeclarationStatement)iter.Value).Identifier;
                        varDecl.Global = ((VariableDeclarationStatement)iter.Value).Global;
                        Statements.AddBefore(nodeVars, varDecl);
                    }
                    if (iter.Value is FunctionDeclarationStatement) {
                        Statements.Remove(iter);
                        Statements.AddBefore(nodeFuncs, iter);
                    }

                    iter = next;
                }


                Statements.Remove(nodeFuncs);
                Statements.Remove(nodeVars);

                reordered = true;
            }

            return Statements;
        }
    }
}
