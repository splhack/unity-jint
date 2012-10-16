// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g 2010-11-11 09:14:41

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Jint.Expressions;
using Jint.Debugger;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class ES3Parser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"NULL", 
		"TRUE", 
		"FALSE", 
		"BREAK", 
		"CASE", 
		"CATCH", 
		"CONTINUE", 
		"DEFAULT", 
		"DELETE", 
		"DO", 
		"ELSE", 
		"FINALLY", 
		"FOR", 
		"FUNCTION", 
		"IF", 
		"IN", 
		"INSTANCEOF", 
		"NEW", 
		"RETURN", 
		"SWITCH", 
		"THIS", 
		"THROW", 
		"TRY", 
		"TYPEOF", 
		"VAR", 
		"VOID", 
		"WHILE", 
		"WITH", 
		"ABSTRACT", 
		"BOOLEAN", 
		"BYTE", 
		"CHAR", 
		"CLASS", 
		"CONST", 
		"DEBUGGER", 
		"DOUBLE", 
		"ENUM", 
		"EXPORT", 
		"EXTENDS", 
		"FINAL", 
		"FLOAT", 
		"GOTO", 
		"IMPLEMENTS", 
		"IMPORT", 
		"INT", 
		"INTERFACE", 
		"LONG", 
		"NATIVE", 
		"PACKAGE", 
		"PRIVATE", 
		"PROTECTED", 
		"PUBLIC", 
		"SHORT", 
		"STATIC", 
		"SUPER", 
		"SYNCHRONIZED", 
		"THROWS", 
		"TRANSIENT", 
		"VOLATILE", 
		"LBRACE", 
		"RBRACE", 
		"LPAREN", 
		"RPAREN", 
		"LBRACK", 
		"RBRACK", 
		"DOT", 
		"SEMIC", 
		"COMMA", 
		"LT", 
		"GT", 
		"LTE", 
		"GTE", 
		"EQ", 
		"NEQ", 
		"SAME", 
		"NSAME", 
		"ADD", 
		"SUB", 
		"MUL", 
		"MOD", 
		"INC", 
		"DEC", 
		"SHL", 
		"SHR", 
		"SHU", 
		"AND", 
		"OR", 
		"XOR", 
		"NOT", 
		"INV", 
		"LAND", 
		"LOR", 
		"QUE", 
		"COLON", 
		"ASSIGN", 
		"ADDASS", 
		"SUBASS", 
		"MULASS", 
		"MODASS", 
		"SHLASS", 
		"SHRASS", 
		"SHUASS", 
		"ANDASS", 
		"ORASS", 
		"XORASS", 
		"DIV", 
		"DIVASS", 
		"ARGS", 
		"ARRAY", 
		"BLOCK", 
		"BYFIELD", 
		"BYINDEX", 
		"CALL", 
		"CEXPR", 
		"EXPR", 
		"FORITER", 
		"FORSTEP", 
		"ITEM", 
		"LABELLED", 
		"NAMEDVALUE", 
		"NEG", 
		"OBJECT", 
		"PAREXPR", 
		"PDEC", 
		"PINC", 
		"POS", 
		"BSLASH", 
		"DQUOTE", 
		"SQUOTE", 
		"TAB", 
		"VT", 
		"FF", 
		"SP", 
		"NBSP", 
		"USP", 
		"WhiteSpace", 
		"LF", 
		"CR", 
		"LS", 
		"PS", 
		"LineTerminator", 
		"EOL", 
		"MultiLineComment", 
		"SingleLineComment", 
		"Identifier", 
		"StringLiteral", 
		"HexDigit", 
		"IdentifierStartASCII", 
		"DecimalDigit", 
		"IdentifierPart", 
		"IdentifierNameASCIIStart", 
		"RegularExpressionLiteral", 
		"OctalDigit", 
		"ExponentPart", 
		"DecimalIntegerLiteral", 
		"DecimalLiteral", 
		"OctalIntegerLiteral", 
		"HexIntegerLiteral", 
		"CharacterEscapeSequence", 
		"ZeroToThree", 
		"OctalEscapeSequence", 
		"HexEscapeSequence", 
		"UnicodeEscapeSequence", 
		"EscapeSequence", 
		"BackslashSequence", 
		"RegularExpressionFirstChar", 
		"RegularExpressionChar"
    };

    public const int VT = 134;
    public const int LOR = 95;
    public const int FUNCTION = 17;
    public const int PACKAGE = 52;
    public const int SHR = 87;
    public const int RegularExpressionChar = 170;
    public const int LT = 72;
    public const int WHILE = 30;
    public const int MOD = 83;
    public const int SHL = 86;
    public const int CONST = 37;
    public const int BackslashSequence = 168;
    public const int LS = 142;
    public const int CASE = 8;
    public const int CHAR = 35;
    public const int NEW = 21;
    public const int DQUOTE = 131;
    public const int DO = 13;
    public const int NOT = 92;
    public const int DecimalDigit = 152;
    public const int BYFIELD = 114;
    public const int EOF = -1;
    public const int CEXPR = 117;
    public const int BREAK = 7;
    public const int Identifier = 148;
    public const int DIVASS = 110;
    public const int BYINDEX = 115;
    public const int FORSTEP = 120;
    public const int FINAL = 43;
    public const int RPAREN = 66;
    public const int INC = 84;
    public const int IMPORT = 47;
    public const int EOL = 145;
    public const int POS = 129;
    public const int OctalDigit = 156;
    public const int THIS = 24;
    public const int RETURN = 22;
    public const int ExponentPart = 157;
    public const int ARGS = 111;
    public const int DOUBLE = 39;
    public const int WhiteSpace = 139;
    public const int VAR = 28;
    public const int EXPORT = 41;
    public const int VOID = 29;
    public const int LABELLED = 122;
    public const int SUPER = 58;
    public const int GOTO = 45;
    public const int EQ = 76;
    public const int XORASS = 108;
    public const int ADDASS = 99;
    public const int ARRAY = 112;
    public const int SHU = 88;
    public const int RBRACK = 68;
    public const int RBRACE = 64;
    public const int PRIVATE = 53;
    public const int STATIC = 57;
    public const int INV = 93;
    public const int SWITCH = 23;
    public const int NULL = 4;
    public const int ELSE = 14;
    public const int NATIVE = 51;
    public const int THROWS = 60;
    public const int INT = 48;
    public const int DELETE = 12;
    public const int MUL = 82;
    public const int IdentifierStartASCII = 151;
    public const int TRY = 26;
    public const int FF = 135;
    public const int SHLASS = 103;
    public const int OctalEscapeSequence = 164;
    public const int USP = 138;
    public const int RegularExpressionFirstChar = 169;
    public const int ANDASS = 106;
    public const int TYPEOF = 27;
    public const int IdentifierNameASCIIStart = 154;
    public const int QUE = 96;
    public const int OR = 90;
    public const int DEBUGGER = 38;
    public const int GT = 73;
    public const int PDEC = 127;
    public const int CALL = 116;
    public const int CharacterEscapeSequence = 162;
    public const int CATCH = 9;
    public const int FALSE = 6;
    public const int EscapeSequence = 167;
    public const int LAND = 94;
    public const int MULASS = 101;
    public const int THROW = 25;
    public const int PINC = 128;
    public const int OctalIntegerLiteral = 160;
    public const int PROTECTED = 54;
    public const int DEC = 85;
    public const int CLASS = 36;
    public const int LBRACK = 67;
    public const int HexEscapeSequence = 165;
    public const int ORASS = 107;
    public const int SingleLineComment = 147;
    public const int NAMEDVALUE = 123;
    public const int LBRACE = 63;
    public const int GTE = 75;
    public const int FOR = 16;
    public const int RegularExpressionLiteral = 155;
    public const int SUB = 81;
    public const int FLOAT = 44;
    public const int ABSTRACT = 32;
    public const int AND = 89;
    public const int DecimalIntegerLiteral = 158;
    public const int HexDigit = 150;
    public const int LTE = 74;
    public const int LPAREN = 65;
    public const int IF = 18;
    public const int SUBASS = 100;
    public const int EXPR = 118;
    public const int BOOLEAN = 33;
    public const int SYNCHRONIZED = 59;
    public const int IN = 19;
    public const int IMPLEMENTS = 46;
    public const int OBJECT = 125;
    public const int CONTINUE = 10;
    public const int COMMA = 71;
    public const int FORITER = 119;
    public const int TRANSIENT = 61;
    public const int SHRASS = 104;
    public const int MODASS = 102;
    public const int PS = 143;
    public const int DOT = 69;
    public const int IdentifierPart = 153;
    public const int MultiLineComment = 146;
    public const int WITH = 31;
    public const int ADD = 80;
    public const int BYTE = 34;
    public const int XOR = 91;
    public const int ZeroToThree = 163;
    public const int ITEM = 121;
    public const int VOLATILE = 62;
    public const int UnicodeEscapeSequence = 166;
    public const int SHUASS = 105;
    public const int DEFAULT = 11;
    public const int NSAME = 79;
    public const int TAB = 133;
    public const int SHORT = 56;
    public const int INSTANCEOF = 20;
    public const int SQUOTE = 132;
    public const int DecimalLiteral = 159;
    public const int TRUE = 5;
    public const int SAME = 78;
    public const int StringLiteral = 149;
    public const int COLON = 97;
    public const int PAREXPR = 126;
    public const int NEQ = 77;
    public const int ENUM = 40;
    public const int FINALLY = 15;
    public const int HexIntegerLiteral = 161;
    public const int NBSP = 137;
    public const int SP = 136;
    public const int BLOCK = 113;
    public const int LineTerminator = 144;
    public const int NEG = 124;
    public const int ASSIGN = 98;
    public const int INTERFACE = 49;
    public const int DIV = 109;
    public const int SEMIC = 70;
    public const int CR = 141;
    public const int LONG = 50;
    public const int EXTENDS = 42;
    public const int PUBLIC = 55;
    public const int BSLASH = 130;
    public const int LF = 140;

    // delegates
    // delegators



        public ES3Parser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public ES3Parser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return ES3Parser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g"; }
    }


        private const char BS = '\\';
        private bool IsLeftHandSideAssign(Expression lhs, object[] cached)
        {
        	if (cached[0] != null)
        	{
        		return Convert.ToBoolean(cached[0]);
        	}
        	
        	bool result;
        	if(IsLeftHandSideExpression(lhs))
        	{
        		switch (input.LA(1))
        		{
        			case ASSIGN:
        			case MULASS:
        			case DIVASS:
        			case MODASS:
        			case ADDASS:
        			case SUBASS:
        			case SHLASS:
        			case SHRASS:
        			case SHUASS:
        			case ANDASS:
        			case XORASS:
        			case ORASS:
        				result = true;
        				break;
        			default:
        				result = false;
        				break;
        		}
        	}
        	else
        	{
        		result = false;
        	}
        	
        	cached[0] = result;
        	return result;
        }

        private static bool IsLeftHandSideExpression(Expression lhs)
        {
            if (lhs == null)
            {
                return true;
            }

            return lhs is Identifier || lhs is PropertyExpression || lhs is MemberExpression;
        }
        	
        private bool IsLeftHandSideIn(Expression lhs, object[] cached)
        {
        	if (cached[0] != null)
        	{
        		return Convert.ToBoolean(cached[0]);
        	}
        	
        	bool result = IsLeftHandSideExpression(lhs) && (input.LA(1) == IN);
        	cached[0] = result;
        	return result;
        }

        private void PromoteEOL(ParserRuleReturnScope rule)
        {
        	// Get current token and its type (the possibly offending token).
        	IToken lt = input.LT(1);
        	int la = lt.Type;
        	
        	// We only need to promote an EOL when the current token is offending (not a SEMIC, EOF, RBRACE, EOL or MultiLineComment).
        	// EOL and MultiLineComment are not offending as they're already promoted in a previous call to this method.
        	// Promoting an EOL means switching it from off channel to on channel.
        	// A MultiLineComment gets promoted when it contains an EOL.
        	if (!(la == SEMIC || la == EOF || la == RBRACE || la == EOL || la == MultiLineComment))
        	{
        		// Start on the possition before the current token and scan backwards off channel tokens until the previous on channel token.
        		for (int ix = lt.TokenIndex - 1; ix > 0; ix--)
        		{
        			lt = input.Get(ix);
        			if (lt.Channel == Token.DEFAULT_CHANNEL)
        			{
        				// On channel token found: stop scanning.
        				break;
        			}
        			else if (lt.Type == EOL || (lt.Type == MultiLineComment && (lt.Text.EndsWith("\r") || lt.Text.EndsWith("\n"))))
        			{
        				// We found our EOL: promote the token to on channel, position the input on it and reset the rule start.
        				lt.Channel = Token.DEFAULT_CHANNEL;
        				input.Seek(lt.TokenIndex);
        				if (rule != null)
        				{
        					rule.Start = lt;
        				}
        				break;
        			}
        		}
        	}
        }	
        
        private static NumberFormatInfo numberFormatInfo = new NumberFormatInfo();

        private string extractRegExpPattern(string text) {
            return text.Substring(1, text.LastIndexOf('/')-1);
        }

        private string extractRegExpOption(string text) {
            if(text[text.Length-1] != '/')
            {
    		return text.Substring(text.LastIndexOf('/')+1);
            }
            return String.Empty;
        }
        
        private static Encoding Latin1 = Encoding.GetEncoding("iso-8859-1");
        
        private string extractString(string text) {
        
        // https://developer.mozilla.org/en/Core_JavaScript_1.5_Guide/Literals#String Literals    
            StringBuilder sb = new StringBuilder(text);
            int startIndex = 1; // Skip initial quote
            int slashIndex = -1;

            while ((slashIndex = sb.ToString().IndexOf(BS, startIndex)) != -1)
            {
                char escapeType = sb[slashIndex + 1];
                switch (escapeType)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
    		  string octalCode = String.Concat(sb[slashIndex+1], sb[slashIndex+2], sb[slashIndex+3]);   
    		  char octalChar = Latin1.GetChars(new byte[] { System.Convert.ToByte(octalCode, 8) } )[0]; 
    		  sb.Remove(slashIndex, 4).Insert(slashIndex, octalChar);         
    		  break;                 
                    case 'x':
    		  string asciiCode = String.Concat(sb[slashIndex+2], sb[slashIndex+3]);   
    		  char asciiChar = Latin1.GetChars(new byte[] { System.Convert.ToByte(asciiCode, 16) } )[0]; 
    		  sb.Remove(slashIndex, 4).Insert(slashIndex, asciiChar);         
    		  break;   	
                    case 'u':
                      char unicodeChar = Convert.ToChar(Int32.Parse(sb[slashIndex + 2].ToString() + sb[slashIndex + 3] + sb[slashIndex+4] + sb[slashIndex+5], System.Globalization.NumberStyles.AllowHexSpecifier));
                      sb.Remove(slashIndex, 6).Insert(slashIndex, unicodeChar); 
                      break;
                    case 'b': sb.Remove(slashIndex, 2).Insert(slashIndex, '\b'); break;
                    case 'f': sb.Remove(slashIndex, 2).Insert(slashIndex, '\f'); break;
                    case 'n': sb.Remove(slashIndex, 2).Insert(slashIndex, '\n'); break;
                    case 'r': sb.Remove(slashIndex, 2).Insert(slashIndex, '\r'); break;
                    case 't': sb.Remove(slashIndex, 2).Insert(slashIndex, '\t'); break;
                    case 'v': sb.Remove(slashIndex, 2).Insert(slashIndex, '\v'); break;
                    case '\'': sb.Remove(slashIndex, 2).Insert(slashIndex, '\''); break;
                    case '"': sb.Remove(slashIndex, 2).Insert(slashIndex, '"'); break;
                    case '\\': sb.Remove(slashIndex, 2).Insert(slashIndex, '\\'); break;
                    case '\r': if (sb[slashIndex+2] == '\n') sb.Remove(slashIndex, 3); else sb.Remove(slashIndex, 2); break;
                    default:  sb.Remove(slashIndex, 2).Insert(slashIndex, escapeType); break;
                }

                startIndex = slashIndex + 1;

            }

            sb.Remove(0, 1);
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        public List<string> Errors { get; private set; }

        public override void DisplayRecognitionError(String[] tokenNames, RecognitionException e) {
            
            base.DisplayRecognitionError(tokenNames, e);
            
            if(Errors == null)
            {
            	Errors = new List<string>();
            }
            
            String hdr = GetErrorHeader(e);
            String msg = GetErrorMessage(e, tokenNames);
            Errors.Add(msg + " at " + hdr);
        }    

        private string[] script = new string[0];
        
        	public bool DebugMode { get; set; }
        	
            private SourceCodeDescriptor ExtractSourceCode(CommonToken start, CommonToken stop)
            {
                if(!DebugMode)
                {
                	return new SourceCodeDescriptor(start.Line, start.CharPositionInLine, stop.Line, stop.CharPositionInLine, "No source code available.");
                }
                
                try
                {
                    StringBuilder source = new StringBuilder();

                    for (int i = start.Line - 1; i <= stop.Line - 1; i++)
                    {
                        int charStart = 0;
                        int charStop = script[i].Length;

                        if (i == start.Line - 1)
                        {
                            charStart = start.CharPositionInLine;
                        }

                        if (i == stop.Line - 1)
                        {
                            charStop = stop.CharPositionInLine;
                        }

                        int length = charStop - charStart;

                        source.Append(script[i].Substring(charStart, length)).Append(Environment.NewLine);
                    }

                    return new SourceCodeDescriptor(start.Line, start.CharPositionInLine, stop.Line, stop.CharPositionInLine, source.ToString());
                }
                catch
                {
                    return new SourceCodeDescriptor(start.Line, start.CharPositionInLine, stop.Line, stop.CharPositionInLine, "No source code available.");
                }

            }

        public AssignmentOperator ResolveAssignmentOperator(string op)
        {
        	switch(op)
        	{
        	    case "=" : return AssignmentOperator.Assign;
        	    case "+=" : return AssignmentOperator.Add;
        	    case "-=" : return AssignmentOperator.Substract;
        	    case "*=" : return AssignmentOperator.Multiply;
        	    case "%=" : return AssignmentOperator.Modulo;
        	    case "<<=" : return AssignmentOperator.ShiftLeft;
        	    case ">>=" : return AssignmentOperator.ShiftRight;
        	    case ">>>=" : return AssignmentOperator.UnsignedRightShift;
        	    case "&=" : return AssignmentOperator.And;
        	    case "|=" : return AssignmentOperator.Or;
        	    case "^=" : return AssignmentOperator.XOr;
        	    case "/=" : return AssignmentOperator.Divide;
        	    default : throw new NotSupportedException("Invalid assignment operator: " + op);
        	}
        }


    public class token_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "token"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:646:1: token : ( reservedWord | Identifier | punctuator | numericLiteral | StringLiteral );
    public ES3Parser.token_return token() // throws RecognitionException [1]
    {   
        ES3Parser.token_return retval = new ES3Parser.token_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier2 = null;
        IToken StringLiteral5 = null;
        ES3Parser.reservedWord_return reservedWord1 = default(ES3Parser.reservedWord_return);

        ES3Parser.punctuator_return punctuator3 = default(ES3Parser.punctuator_return);

        ES3Parser.numericLiteral_return numericLiteral4 = default(ES3Parser.numericLiteral_return);


        object Identifier2_tree=null;
        object StringLiteral5_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:647:2: ( reservedWord | Identifier | punctuator | numericLiteral | StringLiteral )
            int alt1 = 5;
            switch ( input.LA(1) ) 
            {
            case NULL:
            case TRUE:
            case FALSE:
            case BREAK:
            case CASE:
            case CATCH:
            case CONTINUE:
            case DEFAULT:
            case DELETE:
            case DO:
            case ELSE:
            case FINALLY:
            case FOR:
            case FUNCTION:
            case IF:
            case IN:
            case INSTANCEOF:
            case NEW:
            case RETURN:
            case SWITCH:
            case THIS:
            case THROW:
            case TRY:
            case TYPEOF:
            case VAR:
            case VOID:
            case WHILE:
            case WITH:
            case ABSTRACT:
            case BOOLEAN:
            case BYTE:
            case CHAR:
            case CLASS:
            case CONST:
            case DEBUGGER:
            case DOUBLE:
            case ENUM:
            case EXPORT:
            case EXTENDS:
            case FINAL:
            case FLOAT:
            case GOTO:
            case IMPLEMENTS:
            case IMPORT:
            case INT:
            case INTERFACE:
            case LONG:
            case NATIVE:
            case PACKAGE:
            case PRIVATE:
            case PROTECTED:
            case PUBLIC:
            case SHORT:
            case STATIC:
            case SUPER:
            case SYNCHRONIZED:
            case THROWS:
            case TRANSIENT:
            case VOLATILE:
            	{
                alt1 = 1;
                }
                break;
            case Identifier:
            	{
                alt1 = 2;
                }
                break;
            case LBRACE:
            case RBRACE:
            case LPAREN:
            case RPAREN:
            case LBRACK:
            case RBRACK:
            case DOT:
            case SEMIC:
            case COMMA:
            case LT:
            case GT:
            case LTE:
            case GTE:
            case EQ:
            case NEQ:
            case SAME:
            case NSAME:
            case ADD:
            case SUB:
            case MUL:
            case MOD:
            case INC:
            case DEC:
            case SHL:
            case SHR:
            case SHU:
            case AND:
            case OR:
            case XOR:
            case NOT:
            case INV:
            case LAND:
            case LOR:
            case QUE:
            case COLON:
            case ASSIGN:
            case ADDASS:
            case SUBASS:
            case MULASS:
            case MODASS:
            case SHLASS:
            case SHRASS:
            case SHUASS:
            case ANDASS:
            case ORASS:
            case XORASS:
            case DIV:
            case DIVASS:
            	{
                alt1 = 3;
                }
                break;
            case DecimalLiteral:
            case OctalIntegerLiteral:
            case HexIntegerLiteral:
            	{
                alt1 = 4;
                }
                break;
            case StringLiteral:
            	{
                alt1 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:647:4: reservedWord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_reservedWord_in_token1749);
                    	reservedWord1 = reservedWord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, reservedWord1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:648:4: Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Identifier2=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_token1754); 
                    		Identifier2_tree = (object)adaptor.Create(Identifier2);
                    		adaptor.AddChild(root_0, Identifier2_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:649:4: punctuator
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_punctuator_in_token1759);
                    	punctuator3 = punctuator();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, punctuator3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:650:4: numericLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numericLiteral_in_token1764);
                    	numericLiteral4 = numericLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, numericLiteral4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:651:4: StringLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	StringLiteral5=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_token1769); 
                    		StringLiteral5_tree = (object)adaptor.Create(StringLiteral5);
                    		adaptor.AddChild(root_0, StringLiteral5_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "token"

    public class reservedWord_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "reservedWord"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:656:1: reservedWord : ( keyword | futureReservedWord | NULL | booleanLiteral );
    public ES3Parser.reservedWord_return reservedWord() // throws RecognitionException [1]
    {   
        ES3Parser.reservedWord_return retval = new ES3Parser.reservedWord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NULL8 = null;
        ES3Parser.keyword_return keyword6 = default(ES3Parser.keyword_return);

        ES3Parser.futureReservedWord_return futureReservedWord7 = default(ES3Parser.futureReservedWord_return);

        ES3Parser.booleanLiteral_return booleanLiteral9 = default(ES3Parser.booleanLiteral_return);


        object NULL8_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:657:2: ( keyword | futureReservedWord | NULL | booleanLiteral )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case BREAK:
            case CASE:
            case CATCH:
            case CONTINUE:
            case DEFAULT:
            case DELETE:
            case DO:
            case ELSE:
            case FINALLY:
            case FOR:
            case FUNCTION:
            case IF:
            case IN:
            case INSTANCEOF:
            case NEW:
            case RETURN:
            case SWITCH:
            case THIS:
            case THROW:
            case TRY:
            case TYPEOF:
            case VAR:
            case VOID:
            case WHILE:
            case WITH:
            	{
                alt2 = 1;
                }
                break;
            case ABSTRACT:
            case BOOLEAN:
            case BYTE:
            case CHAR:
            case CLASS:
            case CONST:
            case DEBUGGER:
            case DOUBLE:
            case ENUM:
            case EXPORT:
            case EXTENDS:
            case FINAL:
            case FLOAT:
            case GOTO:
            case IMPLEMENTS:
            case IMPORT:
            case INT:
            case INTERFACE:
            case LONG:
            case NATIVE:
            case PACKAGE:
            case PRIVATE:
            case PROTECTED:
            case PUBLIC:
            case SHORT:
            case STATIC:
            case SUPER:
            case SYNCHRONIZED:
            case THROWS:
            case TRANSIENT:
            case VOLATILE:
            	{
                alt2 = 2;
                }
                break;
            case NULL:
            	{
                alt2 = 3;
                }
                break;
            case TRUE:
            case FALSE:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:657:4: keyword
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_keyword_in_reservedWord1782);
                    	keyword6 = keyword();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, keyword6.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:658:4: futureReservedWord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_futureReservedWord_in_reservedWord1787);
                    	futureReservedWord7 = futureReservedWord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, futureReservedWord7.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:659:4: NULL
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NULL8=(IToken)Match(input,NULL,FOLLOW_NULL_in_reservedWord1792); 
                    		NULL8_tree = (object)adaptor.Create(NULL8);
                    		adaptor.AddChild(root_0, NULL8_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:660:4: booleanLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_booleanLiteral_in_reservedWord1797);
                    	booleanLiteral9 = booleanLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, booleanLiteral9.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "reservedWord"

    public class keyword_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "keyword"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:667:1: keyword : ( BREAK | CASE | CATCH | CONTINUE | DEFAULT | DELETE | DO | ELSE | FINALLY | FOR | FUNCTION | IF | IN | INSTANCEOF | NEW | RETURN | SWITCH | THIS | THROW | TRY | TYPEOF | VAR | VOID | WHILE | WITH );
    public ES3Parser.keyword_return keyword() // throws RecognitionException [1]
    {   
        ES3Parser.keyword_return retval = new ES3Parser.keyword_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set10 = null;

        object set10_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:668:2: ( BREAK | CASE | CATCH | CONTINUE | DEFAULT | DELETE | DO | ELSE | FINALLY | FOR | FUNCTION | IF | IN | INSTANCEOF | NEW | RETURN | SWITCH | THIS | THROW | TRY | TYPEOF | VAR | VOID | WHILE | WITH )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set10 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BREAK && input.LA(1) <= WITH) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set10));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "keyword"

    public class futureReservedWord_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "futureReservedWord"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:699:1: futureReservedWord : ( ABSTRACT | BOOLEAN | BYTE | CHAR | CLASS | CONST | DEBUGGER | DOUBLE | ENUM | EXPORT | EXTENDS | FINAL | FLOAT | GOTO | IMPLEMENTS | IMPORT | INT | INTERFACE | LONG | NATIVE | PACKAGE | PRIVATE | PROTECTED | PUBLIC | SHORT | STATIC | SUPER | SYNCHRONIZED | THROWS | TRANSIENT | VOLATILE );
    public ES3Parser.futureReservedWord_return futureReservedWord() // throws RecognitionException [1]
    {   
        ES3Parser.futureReservedWord_return retval = new ES3Parser.futureReservedWord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set11 = null;

        object set11_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:700:2: ( ABSTRACT | BOOLEAN | BYTE | CHAR | CLASS | CONST | DEBUGGER | DOUBLE | ENUM | EXPORT | EXTENDS | FINAL | FLOAT | GOTO | IMPLEMENTS | IMPORT | INT | INTERFACE | LONG | NATIVE | PACKAGE | PRIVATE | PROTECTED | PUBLIC | SHORT | STATIC | SUPER | SYNCHRONIZED | THROWS | TRANSIENT | VOLATILE )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set11 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= ABSTRACT && input.LA(1) <= VOLATILE) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set11));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "futureReservedWord"

    public class punctuator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "punctuator"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:777:1: punctuator : ( LBRACE | RBRACE | LPAREN | RPAREN | LBRACK | RBRACK | DOT | SEMIC | COMMA | LT | GT | LTE | GTE | EQ | NEQ | SAME | NSAME | ADD | SUB | MUL | MOD | INC | DEC | SHL | SHR | SHU | AND | OR | XOR | NOT | INV | LAND | LOR | QUE | COLON | ASSIGN | ADDASS | SUBASS | MULASS | MODASS | SHLASS | SHRASS | SHUASS | ANDASS | ORASS | XORASS | DIV | DIVASS );
    public ES3Parser.punctuator_return punctuator() // throws RecognitionException [1]
    {   
        ES3Parser.punctuator_return retval = new ES3Parser.punctuator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set12 = null;

        object set12_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:778:2: ( LBRACE | RBRACE | LPAREN | RPAREN | LBRACK | RBRACK | DOT | SEMIC | COMMA | LT | GT | LTE | GTE | EQ | NEQ | SAME | NSAME | ADD | SUB | MUL | MOD | INC | DEC | SHL | SHR | SHU | AND | OR | XOR | NOT | INV | LAND | LOR | QUE | COLON | ASSIGN | ADDASS | SUBASS | MULASS | MODASS | SHLASS | SHRASS | SHUASS | ANDASS | ORASS | XORASS | DIV | DIVASS )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set12 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= LBRACE && input.LA(1) <= DIVASS) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set12));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "punctuator"

    public class literal_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "literal"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:832:1: literal returns [Expression value] : (exp1= NULL | exp2= booleanLiteral | exp3= numericLiteral | exp4= StringLiteral | exp5= RegularExpressionLiteral );
    public ES3Parser.literal_return literal() // throws RecognitionException [1]
    {   
        ES3Parser.literal_return retval = new ES3Parser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken exp1 = null;
        IToken exp4 = null;
        IToken exp5 = null;
        ES3Parser.booleanLiteral_return exp2 = default(ES3Parser.booleanLiteral_return);

        ES3Parser.numericLiteral_return exp3 = default(ES3Parser.numericLiteral_return);


        object exp1_tree=null;
        object exp4_tree=null;
        object exp5_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:833:2: (exp1= NULL | exp2= booleanLiteral | exp3= numericLiteral | exp4= StringLiteral | exp5= RegularExpressionLiteral )
            int alt3 = 5;
            switch ( input.LA(1) ) 
            {
            case NULL:
            	{
                alt3 = 1;
                }
                break;
            case TRUE:
            case FALSE:
            	{
                alt3 = 2;
                }
                break;
            case DecimalLiteral:
            case OctalIntegerLiteral:
            case HexIntegerLiteral:
            	{
                alt3 = 3;
                }
                break;
            case StringLiteral:
            	{
                alt3 = 4;
                }
                break;
            case RegularExpressionLiteral:
            	{
                alt3 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:833:4: exp1= NULL
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	exp1=(IToken)Match(input,NULL,FOLLOW_NULL_in_literal2484); 
                    		exp1_tree = (object)adaptor.Create(exp1);
                    		adaptor.AddChild(root_0, exp1_tree);

                    	 retval.value =  new Identifier(exp1.Text); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:834:4: exp2= booleanLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_booleanLiteral_in_literal2493);
                    	exp2 = booleanLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, exp2.Tree);
                    	 retval.value =  new ValueExpression(exp2.value, TypeCode.Boolean); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:835:4: exp3= numericLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numericLiteral_in_literal2502);
                    	exp3 = numericLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, exp3.Tree);
                    	 retval.value =  new ValueExpression(exp3.value, TypeCode.Double); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:836:4: exp4= StringLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	exp4=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_literal2511); 
                    		exp4_tree = (object)adaptor.Create(exp4);
                    		adaptor.AddChild(root_0, exp4_tree);

                    	 retval.value =  new ValueExpression(extractString(exp4.Text), TypeCode.String); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:837:4: exp5= RegularExpressionLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	exp5=(IToken)Match(input,RegularExpressionLiteral,FOLLOW_RegularExpressionLiteral_in_literal2521); 
                    		exp5_tree = (object)adaptor.Create(exp5);
                    		adaptor.AddChild(root_0, exp5_tree);

                    	 retval.value =  new RegexpExpression(extractRegExpPattern(exp5.Text), extractRegExpOption(exp5.Text)); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal"

    public class booleanLiteral_return : ParserRuleReturnScope
    {
        public bool value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "booleanLiteral"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:840:1: booleanLiteral returns [bool value] : ( TRUE | FALSE );
    public ES3Parser.booleanLiteral_return booleanLiteral() // throws RecognitionException [1]
    {   
        ES3Parser.booleanLiteral_return retval = new ES3Parser.booleanLiteral_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TRUE13 = null;
        IToken FALSE14 = null;

        object TRUE13_tree=null;
        object FALSE14_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:841:2: ( TRUE | FALSE )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == TRUE) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == FALSE) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:841:4: TRUE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRUE13=(IToken)Match(input,TRUE,FOLLOW_TRUE_in_booleanLiteral2538); 
                    		TRUE13_tree = (object)adaptor.Create(TRUE13);
                    		adaptor.AddChild(root_0, TRUE13_tree);

                    	 retval.value =  true; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:842:4: FALSE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FALSE14=(IToken)Match(input,FALSE,FOLLOW_FALSE_in_booleanLiteral2545); 
                    		FALSE14_tree = (object)adaptor.Create(FALSE14);
                    		adaptor.AddChild(root_0, FALSE14_tree);

                    	 retval.value =  false; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "booleanLiteral"

    public class numericLiteral_return : ParserRuleReturnScope
    {
        public double value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "numericLiteral"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:887:1: numericLiteral returns [double value] : (ex1= DecimalLiteral | ex2= OctalIntegerLiteral | ex3= HexIntegerLiteral );
    public ES3Parser.numericLiteral_return numericLiteral() // throws RecognitionException [1]
    {   
        ES3Parser.numericLiteral_return retval = new ES3Parser.numericLiteral_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ex1 = null;
        IToken ex2 = null;
        IToken ex3 = null;

        object ex1_tree=null;
        object ex2_tree=null;
        object ex3_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:888:2: (ex1= DecimalLiteral | ex2= OctalIntegerLiteral | ex3= HexIntegerLiteral )
            int alt5 = 3;
            switch ( input.LA(1) ) 
            {
            case DecimalLiteral:
            	{
                alt5 = 1;
                }
                break;
            case OctalIntegerLiteral:
            	{
                alt5 = 2;
                }
                break;
            case HexIntegerLiteral:
            	{
                alt5 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            }

            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:888:4: ex1= DecimalLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex1=(IToken)Match(input,DecimalLiteral,FOLLOW_DecimalLiteral_in_numericLiteral2756); 
                    		ex1_tree = (object)adaptor.Create(ex1);
                    		adaptor.AddChild(root_0, ex1_tree);

                    	 retval.value =  double.Parse(ex1.Text, NumberStyles.Float, numberFormatInfo); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:889:4: ex2= OctalIntegerLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex2=(IToken)Match(input,OctalIntegerLiteral,FOLLOW_OctalIntegerLiteral_in_numericLiteral2765); 
                    		ex2_tree = (object)adaptor.Create(ex2);
                    		adaptor.AddChild(root_0, ex2_tree);

                    	 retval.value =  Convert.ToInt64(ex2.Text, 8); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:890:4: ex3= HexIntegerLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex3=(IToken)Match(input,HexIntegerLiteral,FOLLOW_HexIntegerLiteral_in_numericLiteral2774); 
                    		ex3_tree = (object)adaptor.Create(ex3);
                    		adaptor.AddChild(root_0, ex3_tree);

                    	 retval.value =  Convert.ToInt64(ex3.Text, 16); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "numericLiteral"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:976:1: primaryExpression returns [Expression value] : (ex1= THIS | ex2= Identifier | ex3= literal | ex4= arrayLiteral | ex5= objectLiteral | lpar= LPAREN ex6= expression RPAREN );
    public ES3Parser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        ES3Parser.primaryExpression_return retval = new ES3Parser.primaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ex1 = null;
        IToken ex2 = null;
        IToken lpar = null;
        IToken RPAREN15 = null;
        ES3Parser.literal_return ex3 = default(ES3Parser.literal_return);

        ES3Parser.arrayLiteral_return ex4 = default(ES3Parser.arrayLiteral_return);

        ES3Parser.objectLiteral_return ex5 = default(ES3Parser.objectLiteral_return);

        ES3Parser.expression_return ex6 = default(ES3Parser.expression_return);


        object ex1_tree=null;
        object ex2_tree=null;
        object lpar_tree=null;
        object RPAREN15_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:977:2: (ex1= THIS | ex2= Identifier | ex3= literal | ex4= arrayLiteral | ex5= objectLiteral | lpar= LPAREN ex6= expression RPAREN )
            int alt6 = 6;
            switch ( input.LA(1) ) 
            {
            case THIS:
            	{
                alt6 = 1;
                }
                break;
            case Identifier:
            	{
                alt6 = 2;
                }
                break;
            case NULL:
            case TRUE:
            case FALSE:
            case StringLiteral:
            case RegularExpressionLiteral:
            case DecimalLiteral:
            case OctalIntegerLiteral:
            case HexIntegerLiteral:
            	{
                alt6 = 3;
                }
                break;
            case LBRACK:
            	{
                alt6 = 4;
                }
                break;
            case LBRACE:
            	{
                alt6 = 5;
                }
                break;
            case LPAREN:
            	{
                alt6 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:977:4: ex1= THIS
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex1=(IToken)Match(input,THIS,FOLLOW_THIS_in_primaryExpression3175); 
                    		ex1_tree = (object)adaptor.Create(ex1);
                    		adaptor.AddChild(root_0, ex1_tree);

                    	 retval.value =  new Identifier(ex1.Text); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:978:4: ex2= Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex2=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_primaryExpression3184); 
                    		ex2_tree = (object)adaptor.Create(ex2);
                    		adaptor.AddChild(root_0, ex2_tree);

                    	 retval.value =  new Identifier(ex2.Text); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:979:4: ex3= literal
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression3193);
                    	ex3 = literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex3.Tree);
                    	 retval.value =  ex3.value; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:980:4: ex4= arrayLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayLiteral_in_primaryExpression3202);
                    	ex4 = arrayLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex4.Tree);
                    	 retval.value =  ex4.value; 

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:981:4: ex5= objectLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectLiteral_in_primaryExpression3211);
                    	ex5 = objectLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex5.Tree);
                    	 retval.value =  ex5.value; 

                    }
                    break;
                case 6 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:982:4: lpar= LPAREN ex6= expression RPAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	lpar=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_primaryExpression3220); 
                    		lpar_tree = (object)adaptor.Create(lpar);
                    		adaptor.AddChild(root_0, lpar_tree);

                    	PushFollow(FOLLOW_expression_in_primaryExpression3224);
                    	ex6 = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex6.Tree);
                    	RPAREN15=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_primaryExpression3227); 
                    		RPAREN15_tree = (object)adaptor.Create(RPAREN15);
                    		adaptor.AddChild(root_0, RPAREN15_tree);

                    	 retval.value =  ex6.value; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class arrayLiteral_return : ParserRuleReturnScope
    {
        public ArrayDeclaration value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arrayLiteral"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:985:1: arrayLiteral returns [ArrayDeclaration value] : lb= LBRACK (first= arrayItem ( COMMA follow= arrayItem )* )? RBRACK ;
    public ES3Parser.arrayLiteral_return arrayLiteral() // throws RecognitionException [1]
    {   
        ES3Parser.arrayLiteral_return retval = new ES3Parser.arrayLiteral_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken COMMA16 = null;
        IToken RBRACK17 = null;
        ES3Parser.arrayItem_return first = default(ES3Parser.arrayItem_return);

        ES3Parser.arrayItem_return follow = default(ES3Parser.arrayItem_return);


        object lb_tree=null;
        object COMMA16_tree=null;
        object RBRACK17_tree=null;


        	retval.value =  new ArrayDeclaration();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:989:2: (lb= LBRACK (first= arrayItem ( COMMA follow= arrayItem )* )? RBRACK )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:989:4: lb= LBRACK (first= arrayItem ( COMMA follow= arrayItem )* )? RBRACK
            {
            	root_0 = (object)adaptor.GetNilNode();

            	lb=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_arrayLiteral3253); 
            		lb_tree = (object)adaptor.Create(lb);
            		adaptor.AddChild(root_0, lb_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:989:14: (first= arrayItem ( COMMA follow= arrayItem )* )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= NULL && LA8_0 <= FALSE) || LA8_0 == DELETE || LA8_0 == FUNCTION || LA8_0 == NEW || LA8_0 == THIS || LA8_0 == TYPEOF || LA8_0 == VOID || LA8_0 == LBRACE || LA8_0 == LPAREN || LA8_0 == LBRACK || LA8_0 == COMMA || (LA8_0 >= ADD && LA8_0 <= SUB) || (LA8_0 >= INC && LA8_0 <= DEC) || (LA8_0 >= NOT && LA8_0 <= INV) || (LA8_0 >= Identifier && LA8_0 <= StringLiteral) || LA8_0 == RegularExpressionLiteral || (LA8_0 >= DecimalLiteral && LA8_0 <= HexIntegerLiteral)) )
            	{
            	    alt8 = 1;
            	}
            	else if ( (LA8_0 == RBRACK) )
            	{
            	    int LA8_2 = input.LA(2);

            	    if ( ((( input.LA(1) == COMMA )|| ( input.LA(1) == RBRACK ))) )
            	    {
            	        alt8 = 1;
            	    }
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:989:16: first= arrayItem ( COMMA follow= arrayItem )*
            	        {
            	        	PushFollow(FOLLOW_arrayItem_in_arrayLiteral3259);
            	        	first = arrayItem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, first.Tree);
            	        	 if(first.value != null) retval.value.Parameters.Add(first.value); 
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:989:96: ( COMMA follow= arrayItem )*
            	        	do 
            	        	{
            	        	    int alt7 = 2;
            	        	    int LA7_0 = input.LA(1);

            	        	    if ( (LA7_0 == COMMA) )
            	        	    {
            	        	        alt7 = 1;
            	        	    }


            	        	    switch (alt7) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:989:98: COMMA follow= arrayItem
            	        			    {
            	        			    	COMMA16=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_arrayLiteral3265); 
            	        			    		COMMA16_tree = (object)adaptor.Create(COMMA16);
            	        			    		adaptor.AddChild(root_0, COMMA16_tree);

            	        			    	PushFollow(FOLLOW_arrayItem_in_arrayLiteral3269);
            	        			    	follow = arrayItem();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, follow.Tree);
            	        			    	 if(follow.value != null) retval.value.Parameters.Add(follow.value); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop7;
            	        	    }
            	        	} while (true);

            	        	loop7:
            	        		;	// Stops C# compiler whining that label 'loop7' has no statements


            	        }
            	        break;

            	}

            	RBRACK17=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_arrayLiteral3279); 
            		RBRACK17_tree = (object)adaptor.Create(RBRACK17);
            		adaptor.AddChild(root_0, RBRACK17_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arrayLiteral"

    public class arrayItem_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arrayItem"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:993:1: arrayItem returns [Statement value] : (expr= assignmentExpression | {...}? | {...}?) ;
    public ES3Parser.arrayItem_return arrayItem() // throws RecognitionException [1]
    {   
        ES3Parser.arrayItem_return retval = new ES3Parser.arrayItem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.assignmentExpression_return expr = default(ES3Parser.assignmentExpression_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:994:2: ( (expr= assignmentExpression | {...}? | {...}?) )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:994:4: (expr= assignmentExpression | {...}? | {...}?)
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:994:4: (expr= assignmentExpression | {...}? | {...}?)
            	int alt9 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case NULL:
            	case TRUE:
            	case FALSE:
            	case DELETE:
            	case FUNCTION:
            	case NEW:
            	case THIS:
            	case TYPEOF:
            	case VOID:
            	case LBRACE:
            	case LPAREN:
            	case LBRACK:
            	case ADD:
            	case SUB:
            	case INC:
            	case DEC:
            	case NOT:
            	case INV:
            	case Identifier:
            	case StringLiteral:
            	case RegularExpressionLiteral:
            	case DecimalLiteral:
            	case OctalIntegerLiteral:
            	case HexIntegerLiteral:
            		{
            	    alt9 = 1;
            	    }
            	    break;
            	case COMMA:
            		{
            	    int LA9_2 = input.LA(2);

            	    if ( (( input.LA(1) == COMMA )) )
            	    {
            	        alt9 = 2;
            	    }
            	    else if ( (( input.LA(1) == RBRACK )) )
            	    {
            	        alt9 = 3;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d9s2 =
            	            new NoViableAltException("", 9, 2, input);

            	        throw nvae_d9s2;
            	    }
            	    }
            	    break;
            	case RBRACK:
            		{
            	    int LA9_3 = input.LA(2);

            	    if ( (( input.LA(1) == COMMA )) )
            	    {
            	        alt9 = 2;
            	    }
            	    else if ( (( input.LA(1) == RBRACK )) )
            	    {
            	        alt9 = 3;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d9s3 =
            	            new NoViableAltException("", 9, 3, input);

            	        throw nvae_d9s3;
            	    }
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d9s0 =
            		        new NoViableAltException("", 9, 0, input);

            		    throw nvae_d9s0;
            	}

            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:994:6: expr= assignmentExpression
            	        {
            	        	PushFollow(FOLLOW_assignmentExpression_in_arrayItem3300);
            	        	expr = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expr.Tree);
            	        	 retval.value =  expr.value; 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:994:60: {...}?
            	        {
            	        	if ( !(( input.LA(1) == COMMA )) ) 
            	        	{
            	        	    throw new FailedPredicateException(input, "arrayItem", " input.LA(1) == COMMA ");
            	        	}
            	        	 retval.value =  new Identifier("undefined"); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:994:130: {...}?
            	        {
            	        	if ( !(( input.LA(1) == RBRACK )) ) 
            	        	{
            	        	    throw new FailedPredicateException(input, "arrayItem", " input.LA(1) == RBRACK ");
            	        	}
            	        	 retval.value =  null; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arrayItem"

    public class objectLiteral_return : ParserRuleReturnScope
    {
        public JsonExpression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectLiteral"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:998:1: objectLiteral returns [JsonExpression value] : lb= LBRACE (first= propertyAssignment ( COMMA follow= propertyAssignment )* )? RBRACE ;
    public ES3Parser.objectLiteral_return objectLiteral() // throws RecognitionException [1]
    {   
        ES3Parser.objectLiteral_return retval = new ES3Parser.objectLiteral_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken COMMA18 = null;
        IToken RBRACE19 = null;
        ES3Parser.propertyAssignment_return first = default(ES3Parser.propertyAssignment_return);

        ES3Parser.propertyAssignment_return follow = default(ES3Parser.propertyAssignment_return);


        object lb_tree=null;
        object COMMA18_tree=null;
        object RBRACE19_tree=null;


        	retval.value =  new JsonExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1002:2: (lb= LBRACE (first= propertyAssignment ( COMMA follow= propertyAssignment )* )? RBRACE )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1002:4: lb= LBRACE (first= propertyAssignment ( COMMA follow= propertyAssignment )* )? RBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	lb=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_objectLiteral3341); 
            		lb_tree = (object)adaptor.Create(lb);
            		adaptor.AddChild(root_0, lb_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1002:14: (first= propertyAssignment ( COMMA follow= propertyAssignment )* )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( ((LA11_0 >= Identifier && LA11_0 <= StringLiteral) || (LA11_0 >= DecimalLiteral && LA11_0 <= HexIntegerLiteral)) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1002:16: first= propertyAssignment ( COMMA follow= propertyAssignment )*
            	        {
            	        	PushFollow(FOLLOW_propertyAssignment_in_objectLiteral3347);
            	        	first = propertyAssignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, first.Tree);
            	        	 retval.value.Push(first.value); 
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1002:72: ( COMMA follow= propertyAssignment )*
            	        	do 
            	        	{
            	        	    int alt10 = 2;
            	        	    int LA10_0 = input.LA(1);

            	        	    if ( (LA10_0 == COMMA) )
            	        	    {
            	        	        alt10 = 1;
            	        	    }


            	        	    switch (alt10) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1002:74: COMMA follow= propertyAssignment
            	        			    {
            	        			    	COMMA18=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objectLiteral3354); 
            	        			    		COMMA18_tree = (object)adaptor.Create(COMMA18);
            	        			    		adaptor.AddChild(root_0, COMMA18_tree);

            	        			    	PushFollow(FOLLOW_propertyAssignment_in_objectLiteral3358);
            	        			    	follow = propertyAssignment();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, follow.Tree);
            	        			    	 retval.value.Push(follow.value); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop10;
            	        	    }
            	        	} while (true);

            	        	loop10:
            	        		;	// Stops C# compiler whining that label 'loop10' has no statements


            	        }
            	        break;

            	}

            	RBRACE19=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_objectLiteral3368); 
            		RBRACE19_tree = (object)adaptor.Create(RBRACE19);
            		adaptor.AddChild(root_0, RBRACE19_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectLiteral"

    public class propertyAssignment_return : ParserRuleReturnScope
    {
        public PropertyDeclarationExpression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "propertyAssignment"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1005:1: propertyAssignment returns [PropertyDeclarationExpression value] : (acc= accessor prop2= propertyName (parameters= formalParameterList )? statements= functionBody | prop1= propertyName COLON ass= assignmentExpression );
    public ES3Parser.propertyAssignment_return propertyAssignment() // throws RecognitionException [1]
    {   
        ES3Parser.propertyAssignment_return retval = new ES3Parser.propertyAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COLON20 = null;
        ES3Parser.accessor_return acc = default(ES3Parser.accessor_return);

        ES3Parser.propertyName_return prop2 = default(ES3Parser.propertyName_return);

        ES3Parser.formalParameterList_return parameters = default(ES3Parser.formalParameterList_return);

        ES3Parser.functionBody_return statements = default(ES3Parser.functionBody_return);

        ES3Parser.propertyName_return prop1 = default(ES3Parser.propertyName_return);

        ES3Parser.assignmentExpression_return ass = default(ES3Parser.assignmentExpression_return);


        object COLON20_tree=null;


        	retval.value =  new PropertyDeclarationExpression();
        	FunctionExpression func=new FunctionExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1010:2: (acc= accessor prop2= propertyName (parameters= formalParameterList )? statements= functionBody | prop1= propertyName COLON ass= assignmentExpression )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == Identifier) )
            {
                int LA13_1 = input.LA(2);

                if ( (LA13_1 == COLON) )
                {
                    alt13 = 2;
                }
                else if ( ((LA13_1 >= Identifier && LA13_1 <= StringLiteral) || (LA13_1 >= DecimalLiteral && LA13_1 <= HexIntegerLiteral)) )
                {
                    alt13 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("", 13, 1, input);

                    throw nvae_d13s1;
                }
            }
            else if ( (LA13_0 == StringLiteral || (LA13_0 >= DecimalLiteral && LA13_0 <= HexIntegerLiteral)) )
            {
                alt13 = 2;
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1010:4: acc= accessor prop2= propertyName (parameters= formalParameterList )? statements= functionBody
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_accessor_in_propertyAssignment3391);
                    	acc = accessor();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, acc.Tree);
                    	 retval.value.Mode=acc.value; 
                    	 retval.value.Expression=func; 
                    	PushFollow(FOLLOW_propertyName_in_propertyAssignment3399);
                    	prop2 = propertyName();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, prop2.Tree);
                    	 retval.value.Name=func.Name=prop2.value; 
                    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1010:130: (parameters= formalParameterList )?
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == LPAREN) )
                    	{
                    	    alt12 = 1;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1010:131: parameters= formalParameterList
                    	        {
                    	        	PushFollow(FOLLOW_formalParameterList_in_propertyAssignment3406);
                    	        	parameters = formalParameterList();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, parameters.Tree);
                    	        	 func.Parameters.AddRange(parameters.value); 

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_functionBody_in_propertyAssignment3414);
                    	statements = functionBody();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, statements.Tree);
                    	 func.Statement=statements.value; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1011:4: prop1= propertyName COLON ass= assignmentExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_propertyName_in_propertyAssignment3424);
                    	prop1 = propertyName();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, prop1.Tree);
                    	 retval.value.Name=prop1.value; 
                    	COLON20=(IToken)Match(input,COLON,FOLLOW_COLON_in_propertyAssignment3428); 
                    		COLON20_tree = (object)adaptor.Create(COLON20);
                    		adaptor.AddChild(root_0, COLON20_tree);

                    	PushFollow(FOLLOW_assignmentExpression_in_propertyAssignment3432);
                    	ass = assignmentExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ass.Tree);
                    	 retval.value.Expression=ass.value; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyAssignment"

    public class accessor_return : ParserRuleReturnScope
    {
        public PropertyExpressionType value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "accessor"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1014:1: accessor returns [PropertyExpressionType value] : ex1= Identifier {...}? =>;
    public ES3Parser.accessor_return accessor() // throws RecognitionException [1]
    {   
        ES3Parser.accessor_return retval = new ES3Parser.accessor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ex1 = null;

        object ex1_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1015:2: (ex1= Identifier {...}? =>)
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1015:4: ex1= Identifier {...}? =>
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ex1=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_accessor3452); 
            		ex1_tree = (object)adaptor.Create(ex1);
            		adaptor.AddChild(root_0, ex1_tree);

            	if ( !(( ex1.Text=="get" || ex1.Text=="set" )) ) 
            	{
            	    throw new FailedPredicateException(input, "accessor", " ex1.Text==\"get\" || ex1.Text==\"set\" ");
            	}
            	 if(ex1.Text=="get") retval.value =  PropertyExpressionType.Get; if(ex1.Text=="set") retval.value = PropertyExpressionType.Set; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "accessor"

    public class propertyName_return : ParserRuleReturnScope
    {
        public string value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "propertyName"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1018:1: propertyName returns [string value] : (ex1= Identifier | ex2= StringLiteral | ex3= numericLiteral );
    public ES3Parser.propertyName_return propertyName() // throws RecognitionException [1]
    {   
        ES3Parser.propertyName_return retval = new ES3Parser.propertyName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ex1 = null;
        IToken ex2 = null;
        ES3Parser.numericLiteral_return ex3 = default(ES3Parser.numericLiteral_return);


        object ex1_tree=null;
        object ex2_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1019:2: (ex1= Identifier | ex2= StringLiteral | ex3= numericLiteral )
            int alt14 = 3;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                alt14 = 1;
                }
                break;
            case StringLiteral:
            	{
                alt14 = 2;
                }
                break;
            case DecimalLiteral:
            case OctalIntegerLiteral:
            case HexIntegerLiteral:
            	{
                alt14 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1019:4: ex1= Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex1=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_propertyName3474); 
                    		ex1_tree = (object)adaptor.Create(ex1);
                    		adaptor.AddChild(root_0, ex1_tree);

                    	 retval.value =  ex1.Text; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1020:4: ex2= StringLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ex2=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_propertyName3483); 
                    		ex2_tree = (object)adaptor.Create(ex2);
                    		adaptor.AddChild(root_0, ex2_tree);

                    	 retval.value =  extractString(ex2.Text); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1021:4: ex3= numericLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numericLiteral_in_propertyName3492);
                    	ex3 = numericLiteral();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex3.Tree);
                    	 retval.value =  ex3.value.ToString(); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyName"

    public class memberExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "memberExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1033:1: memberExpression returns [Expression value] : (prim= primaryExpression | func= functionExpression | exp= newExpression );
    public ES3Parser.memberExpression_return memberExpression() // throws RecognitionException [1]
    {   
        ES3Parser.memberExpression_return retval = new ES3Parser.memberExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.primaryExpression_return prim = default(ES3Parser.primaryExpression_return);

        ES3Parser.functionExpression_return func = default(ES3Parser.functionExpression_return);

        ES3Parser.newExpression_return exp = default(ES3Parser.newExpression_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1034:2: (prim= primaryExpression | func= functionExpression | exp= newExpression )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case NULL:
            case TRUE:
            case FALSE:
            case THIS:
            case LBRACE:
            case LPAREN:
            case LBRACK:
            case Identifier:
            case StringLiteral:
            case RegularExpressionLiteral:
            case DecimalLiteral:
            case OctalIntegerLiteral:
            case HexIntegerLiteral:
            	{
                alt15 = 1;
                }
                break;
            case FUNCTION:
            	{
                alt15 = 2;
                }
                break;
            case NEW:
            	{
                alt15 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1034:4: prim= primaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_memberExpression3518);
                    	prim = primaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, prim.Tree);
                    	 retval.value =  prim.value; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1035:4: func= functionExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionExpression_in_memberExpression3527);
                    	func = functionExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, func.Tree);
                    	 retval.value =  func.value; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1036:4: exp= newExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_newExpression_in_memberExpression3536);
                    	exp = newExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, exp.Tree);
                    	 retval.value =  exp.value; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "memberExpression"

    public class newExpression_return : ParserRuleReturnScope
    {
        public NewExpression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "newExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1039:1: newExpression returns [NewExpression value] : NEW first= memberExpression ;
    public ES3Parser.newExpression_return newExpression() // throws RecognitionException [1]
    {   
        ES3Parser.newExpression_return retval = new ES3Parser.newExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEW21 = null;
        ES3Parser.memberExpression_return first = default(ES3Parser.memberExpression_return);


        object NEW21_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1040:2: ( NEW first= memberExpression )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1040:4: NEW first= memberExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NEW21=(IToken)Match(input,NEW,FOLLOW_NEW_in_newExpression3553); 
            		NEW21_tree = (object)adaptor.Create(NEW21);
            		root_0 = (object)adaptor.BecomeRoot(NEW21_tree, root_0);

            	PushFollow(FOLLOW_memberExpression_in_newExpression3558);
            	first = memberExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, first.Tree);
            	 retval.value =  new NewExpression(first.value); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "newExpression"

    public class arguments_return : ParserRuleReturnScope
    {
        public List<Expression> value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arguments"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1043:1: arguments returns [List<Expression> value] : LPAREN (first= assignmentExpression ( COMMA follow= assignmentExpression )* )? RPAREN ;
    public ES3Parser.arguments_return arguments() // throws RecognitionException [1]
    {   
        ES3Parser.arguments_return retval = new ES3Parser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LPAREN22 = null;
        IToken COMMA23 = null;
        IToken RPAREN24 = null;
        ES3Parser.assignmentExpression_return first = default(ES3Parser.assignmentExpression_return);

        ES3Parser.assignmentExpression_return follow = default(ES3Parser.assignmentExpression_return);


        object LPAREN22_tree=null;
        object COMMA23_tree=null;
        object RPAREN24_tree=null;


        	retval.value =  new List<Expression>();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1047:2: ( LPAREN (first= assignmentExpression ( COMMA follow= assignmentExpression )* )? RPAREN )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1047:4: LPAREN (first= assignmentExpression ( COMMA follow= assignmentExpression )* )? RPAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LPAREN22=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_arguments3581); 
            		LPAREN22_tree = (object)adaptor.Create(LPAREN22);
            		adaptor.AddChild(root_0, LPAREN22_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1047:11: (first= assignmentExpression ( COMMA follow= assignmentExpression )* )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( ((LA17_0 >= NULL && LA17_0 <= FALSE) || LA17_0 == DELETE || LA17_0 == FUNCTION || LA17_0 == NEW || LA17_0 == THIS || LA17_0 == TYPEOF || LA17_0 == VOID || LA17_0 == LBRACE || LA17_0 == LPAREN || LA17_0 == LBRACK || (LA17_0 >= ADD && LA17_0 <= SUB) || (LA17_0 >= INC && LA17_0 <= DEC) || (LA17_0 >= NOT && LA17_0 <= INV) || (LA17_0 >= Identifier && LA17_0 <= StringLiteral) || LA17_0 == RegularExpressionLiteral || (LA17_0 >= DecimalLiteral && LA17_0 <= HexIntegerLiteral)) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1047:13: first= assignmentExpression ( COMMA follow= assignmentExpression )*
            	        {
            	        	PushFollow(FOLLOW_assignmentExpression_in_arguments3587);
            	        	first = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, first.Tree);
            	        	 retval.value.Add(first.value); 
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1047:69: ( COMMA follow= assignmentExpression )*
            	        	do 
            	        	{
            	        	    int alt16 = 2;
            	        	    int LA16_0 = input.LA(1);

            	        	    if ( (LA16_0 == COMMA) )
            	        	    {
            	        	        alt16 = 1;
            	        	    }


            	        	    switch (alt16) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1047:71: COMMA follow= assignmentExpression
            	        			    {
            	        			    	COMMA23=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_arguments3593); 
            	        			    		COMMA23_tree = (object)adaptor.Create(COMMA23);
            	        			    		adaptor.AddChild(root_0, COMMA23_tree);

            	        			    	PushFollow(FOLLOW_assignmentExpression_in_arguments3597);
            	        			    	follow = assignmentExpression();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, follow.Tree);
            	        			    	 retval.value.Add(follow.value); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop16;
            	        	    }
            	        	} while (true);

            	        	loop16:
            	        		;	// Stops C# compiler whining that label 'loop16' has no statements


            	        }
            	        break;

            	}

            	RPAREN24=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_arguments3606); 
            		RPAREN24_tree = (object)adaptor.Create(RPAREN24);
            		adaptor.AddChild(root_0, RPAREN24_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class generics_return : ParserRuleReturnScope
    {
        public List<Expression> value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "generics"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1051:1: generics returns [List<Expression> value] : LBRACE (first= assignmentExpression ( COMMA follow= assignmentExpression )* )? RBRACE ;
    public ES3Parser.generics_return generics() // throws RecognitionException [1]
    {   
        ES3Parser.generics_return retval = new ES3Parser.generics_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRACE25 = null;
        IToken COMMA26 = null;
        IToken RBRACE27 = null;
        ES3Parser.assignmentExpression_return first = default(ES3Parser.assignmentExpression_return);

        ES3Parser.assignmentExpression_return follow = default(ES3Parser.assignmentExpression_return);


        object LBRACE25_tree=null;
        object COMMA26_tree=null;
        object RBRACE27_tree=null;


        	retval.value =  new List<Expression>();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1055:2: ( LBRACE (first= assignmentExpression ( COMMA follow= assignmentExpression )* )? RBRACE )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1055:4: LBRACE (first= assignmentExpression ( COMMA follow= assignmentExpression )* )? RBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LBRACE25=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_generics3628); 
            		LBRACE25_tree = (object)adaptor.Create(LBRACE25);
            		adaptor.AddChild(root_0, LBRACE25_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1055:11: (first= assignmentExpression ( COMMA follow= assignmentExpression )* )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= NULL && LA19_0 <= FALSE) || LA19_0 == DELETE || LA19_0 == FUNCTION || LA19_0 == NEW || LA19_0 == THIS || LA19_0 == TYPEOF || LA19_0 == VOID || LA19_0 == LBRACE || LA19_0 == LPAREN || LA19_0 == LBRACK || (LA19_0 >= ADD && LA19_0 <= SUB) || (LA19_0 >= INC && LA19_0 <= DEC) || (LA19_0 >= NOT && LA19_0 <= INV) || (LA19_0 >= Identifier && LA19_0 <= StringLiteral) || LA19_0 == RegularExpressionLiteral || (LA19_0 >= DecimalLiteral && LA19_0 <= HexIntegerLiteral)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1055:13: first= assignmentExpression ( COMMA follow= assignmentExpression )*
            	        {
            	        	PushFollow(FOLLOW_assignmentExpression_in_generics3634);
            	        	first = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, first.Tree);
            	        	 retval.value.Add(first.value); 
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1055:69: ( COMMA follow= assignmentExpression )*
            	        	do 
            	        	{
            	        	    int alt18 = 2;
            	        	    int LA18_0 = input.LA(1);

            	        	    if ( (LA18_0 == COMMA) )
            	        	    {
            	        	        alt18 = 1;
            	        	    }


            	        	    switch (alt18) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1055:71: COMMA follow= assignmentExpression
            	        			    {
            	        			    	COMMA26=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_generics3640); 
            	        			    		COMMA26_tree = (object)adaptor.Create(COMMA26);
            	        			    		adaptor.AddChild(root_0, COMMA26_tree);

            	        			    	PushFollow(FOLLOW_assignmentExpression_in_generics3644);
            	        			    	follow = assignmentExpression();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, follow.Tree);
            	        			    	 retval.value.Add(follow.value); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop18;
            	        	    }
            	        	} while (true);

            	        	loop18:
            	        		;	// Stops C# compiler whining that label 'loop18' has no statements


            	        }
            	        break;

            	}

            	RBRACE27=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_generics3653); 
            		RBRACE27_tree = (object)adaptor.Create(RBRACE27);
            		adaptor.AddChild(root_0, RBRACE27_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "generics"

    public class leftHandSideExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "leftHandSideExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1060:1: leftHandSideExpression returns [Expression value] : (mem= memberExpression ) ( (gen= generics )? arg= arguments | LBRACK exp= expression RBRACK | DOT id= Identifier )* ;
    public ES3Parser.leftHandSideExpression_return leftHandSideExpression() // throws RecognitionException [1]
    {   
        ES3Parser.leftHandSideExpression_return retval = new ES3Parser.leftHandSideExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken LBRACK28 = null;
        IToken RBRACK29 = null;
        IToken DOT30 = null;
        ES3Parser.memberExpression_return mem = default(ES3Parser.memberExpression_return);

        ES3Parser.generics_return gen = default(ES3Parser.generics_return);

        ES3Parser.arguments_return arg = default(ES3Parser.arguments_return);

        ES3Parser.expression_return exp = default(ES3Parser.expression_return);


        object id_tree=null;
        object LBRACK28_tree=null;
        object RBRACK29_tree=null;
        object DOT30_tree=null;


        	List<Expression> gens = new List<Expression>();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1067:2: ( (mem= memberExpression ) ( (gen= generics )? arg= arguments | LBRACK exp= expression RBRACK | DOT id= Identifier )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1068:2: (mem= memberExpression ) ( (gen= generics )? arg= arguments | LBRACK exp= expression RBRACK | DOT id= Identifier )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1068:2: (mem= memberExpression )
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1069:3: mem= memberExpression
            	{
            		PushFollow(FOLLOW_memberExpression_in_leftHandSideExpression3689);
            		mem = memberExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, mem.Tree);
            		 retval.value =  mem.value; 

            	}

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1071:2: ( (gen= generics )? arg= arguments | LBRACK exp= expression RBRACK | DOT id= Identifier )*
            	do 
            	{
            	    int alt21 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case LBRACE:
            	    case LPAREN:
            	    	{
            	        alt21 = 1;
            	        }
            	        break;
            	    case LBRACK:
            	    	{
            	        alt21 = 2;
            	        }
            	        break;
            	    case DOT:
            	    	{
            	        alt21 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1072:3: (gen= generics )? arg= arguments
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1072:3: (gen= generics )?
            			    	int alt20 = 2;
            			    	int LA20_0 = input.LA(1);

            			    	if ( (LA20_0 == LBRACE) )
            			    	{
            			    	    alt20 = 1;
            			    	}
            			    	switch (alt20) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1072:4: gen= generics
            			    	        {
            			    	        	PushFollow(FOLLOW_generics_in_leftHandSideExpression3705);
            			    	        	gen = generics();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, gen.Tree);
            			    	        	 gens = gen.value; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_arguments_in_leftHandSideExpression3714);
            			    	arg = arguments();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, arg.Tree);
            			    	 if(retval.value is NewExpression) { ((NewExpression)retval.value).Generics = gens; ((NewExpression)retval.value).Arguments = arg.value; retval.value =  new MemberExpression(retval.value, null); } else { retval.value =  new MemberExpression(new MethodCall(arg.value) { Generics = gens }, retval.value); } 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1074:5: LBRACK exp= expression RBRACK
            			    {
            			    	LBRACK28=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_leftHandSideExpression3725); 
            			    		LBRACK28_tree = (object)adaptor.Create(LBRACK28);
            			    		adaptor.AddChild(root_0, LBRACK28_tree);

            			    	PushFollow(FOLLOW_expression_in_leftHandSideExpression3729);
            			    	exp = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, exp.Tree);
            			    	RBRACK29=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_leftHandSideExpression3731); 
            			    		RBRACK29_tree = (object)adaptor.Create(RBRACK29);
            			    		adaptor.AddChild(root_0, RBRACK29_tree);

            			    	 retval.value =  new MemberExpression(new Indexer(exp.value), retval.value); 

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1076:5: DOT id= Identifier
            			    {
            			    	DOT30=(IToken)Match(input,DOT,FOLLOW_DOT_in_leftHandSideExpression3744); 
            			    		DOT30_tree = (object)adaptor.Create(DOT30);
            			    		adaptor.AddChild(root_0, DOT30_tree);

            			    	id=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_leftHandSideExpression3748); 
            			    		id_tree = (object)adaptor.Create(id);
            			    		adaptor.AddChild(root_0, id_tree);

            			    	  if(retval.value is NewExpression) { ((NewExpression)retval.value).Expression = new MemberExpression(new PropertyExpression(id.Text), ((NewExpression)retval.value).Expression); } else { retval.value =  new MemberExpression(new PropertyExpression(id.Text), retval.value); } 

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);

            	retval.value.Source = ExtractSourceCode((CommonToken)retval.Start, (CommonToken)retval.Stop);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "leftHandSideExpression"

    public class postfixExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "postfixExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1091:1: postfixExpression returns [Expression value] : left= leftHandSideExpression (post= postfixOperator )? ;
    public ES3Parser.postfixExpression_return postfixExpression() // throws RecognitionException [1]
    {   
        ES3Parser.postfixExpression_return retval = new ES3Parser.postfixExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.leftHandSideExpression_return left = default(ES3Parser.leftHandSideExpression_return);

        ES3Parser.postfixOperator_return post = default(ES3Parser.postfixOperator_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1092:2: (left= leftHandSideExpression (post= postfixOperator )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1092:4: left= leftHandSideExpression (post= postfixOperator )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftHandSideExpression_in_postfixExpression3782);
            	left = leftHandSideExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; if (input.LA(1) == INC || input.LA(1) == DEC) PromoteEOL(null);  
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1092:122: (post= postfixOperator )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( ((LA22_0 >= INC && LA22_0 <= DEC)) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1092:124: post= postfixOperator
            	        {
            	        	PushFollow(FOLLOW_postfixOperator_in_postfixExpression3790);
            	        	post = postfixOperator();
            	        	state.followingStackPointer--;

            	        	root_0 = (object)adaptor.BecomeRoot(post.Tree, root_0);
            	        	 retval.value =  new UnaryExpression(post.value, retval.value); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "postfixExpression"

    public class postfixOperator_return : ParserRuleReturnScope
    {
        public UnaryExpressionType value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "postfixOperator"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1095:1: postfixOperator returns [UnaryExpressionType value] : (op= INC | op= DEC );
    public ES3Parser.postfixOperator_return postfixOperator() // throws RecognitionException [1]
    {   
        ES3Parser.postfixOperator_return retval = new ES3Parser.postfixOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken op = null;

        object op_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1096:2: (op= INC | op= DEC )
            int alt23 = 2;
            int LA23_0 = input.LA(1);

            if ( (LA23_0 == INC) )
            {
                alt23 = 1;
            }
            else if ( (LA23_0 == DEC) )
            {
                alt23 = 2;
            }
            else 
            {
                NoViableAltException nvae_d23s0 =
                    new NoViableAltException("", 23, 0, input);

                throw nvae_d23s0;
            }
            switch (alt23) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1096:4: op= INC
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	op=(IToken)Match(input,INC,FOLLOW_INC_in_postfixOperator3813); 
                    		op_tree = (object)adaptor.Create(op);
                    		adaptor.AddChild(root_0, op_tree);

                    	 op.Type = PINC; retval.value =  UnaryExpressionType.PostfixPlusPlus; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1097:4: op= DEC
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	op=(IToken)Match(input,DEC,FOLLOW_DEC_in_postfixOperator3822); 
                    		op_tree = (object)adaptor.Create(op);
                    		adaptor.AddChild(root_0, op_tree);

                    	 op.Type = PDEC; retval.value =  UnaryExpressionType.PostfixMinusMinus; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "postfixOperator"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1104:1: unaryExpression returns [Expression value] : (post= postfixExpression | op= unaryOperator exp= unaryExpression );
    public ES3Parser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        ES3Parser.unaryExpression_return retval = new ES3Parser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.postfixExpression_return post = default(ES3Parser.postfixExpression_return);

        ES3Parser.unaryOperator_return op = default(ES3Parser.unaryOperator_return);

        ES3Parser.unaryExpression_return exp = default(ES3Parser.unaryExpression_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1105:2: (post= postfixExpression | op= unaryOperator exp= unaryExpression )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( ((LA24_0 >= NULL && LA24_0 <= FALSE) || LA24_0 == FUNCTION || LA24_0 == NEW || LA24_0 == THIS || LA24_0 == LBRACE || LA24_0 == LPAREN || LA24_0 == LBRACK || (LA24_0 >= Identifier && LA24_0 <= StringLiteral) || LA24_0 == RegularExpressionLiteral || (LA24_0 >= DecimalLiteral && LA24_0 <= HexIntegerLiteral)) )
            {
                alt24 = 1;
            }
            else if ( (LA24_0 == DELETE || LA24_0 == TYPEOF || LA24_0 == VOID || (LA24_0 >= ADD && LA24_0 <= SUB) || (LA24_0 >= INC && LA24_0 <= DEC) || (LA24_0 >= NOT && LA24_0 <= INV)) )
            {
                alt24 = 2;
            }
            else 
            {
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1105:4: post= postfixExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_postfixExpression_in_unaryExpression3845);
                    	post = postfixExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, post.Tree);
                    	 retval.value =  post.value; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1106:4: op= unaryOperator exp= unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryOperator_in_unaryExpression3854);
                    	op = unaryOperator();
                    	state.followingStackPointer--;

                    	root_0 = (object)adaptor.BecomeRoot(op.Tree, root_0);
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression3859);
                    	exp = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, exp.Tree);
                    	 retval.value =  new UnaryExpression(op.value, exp.value); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class unaryOperator_return : ParserRuleReturnScope
    {
        public UnaryExpressionType value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryOperator"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1109:1: unaryOperator returns [UnaryExpressionType value] : ( DELETE | VOID | TYPEOF | INC | DEC | op= ADD | op= SUB | INV | NOT );
    public ES3Parser.unaryOperator_return unaryOperator() // throws RecognitionException [1]
    {   
        ES3Parser.unaryOperator_return retval = new ES3Parser.unaryOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken op = null;
        IToken DELETE31 = null;
        IToken VOID32 = null;
        IToken TYPEOF33 = null;
        IToken INC34 = null;
        IToken DEC35 = null;
        IToken INV36 = null;
        IToken NOT37 = null;

        object op_tree=null;
        object DELETE31_tree=null;
        object VOID32_tree=null;
        object TYPEOF33_tree=null;
        object INC34_tree=null;
        object DEC35_tree=null;
        object INV36_tree=null;
        object NOT37_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1110:2: ( DELETE | VOID | TYPEOF | INC | DEC | op= ADD | op= SUB | INV | NOT )
            int alt25 = 9;
            switch ( input.LA(1) ) 
            {
            case DELETE:
            	{
                alt25 = 1;
                }
                break;
            case VOID:
            	{
                alt25 = 2;
                }
                break;
            case TYPEOF:
            	{
                alt25 = 3;
                }
                break;
            case INC:
            	{
                alt25 = 4;
                }
                break;
            case DEC:
            	{
                alt25 = 5;
                }
                break;
            case ADD:
            	{
                alt25 = 6;
                }
                break;
            case SUB:
            	{
                alt25 = 7;
                }
                break;
            case INV:
            	{
                alt25 = 8;
                }
                break;
            case NOT:
            	{
                alt25 = 9;
                }
                break;
            	default:
            	    NoViableAltException nvae_d25s0 =
            	        new NoViableAltException("", 25, 0, input);

            	    throw nvae_d25s0;
            }

            switch (alt25) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1110:4: DELETE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DELETE31=(IToken)Match(input,DELETE,FOLLOW_DELETE_in_unaryOperator3877); 
                    		DELETE31_tree = (object)adaptor.Create(DELETE31);
                    		adaptor.AddChild(root_0, DELETE31_tree);

                    	 retval.value =  UnaryExpressionType.Delete; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1111:4: VOID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	VOID32=(IToken)Match(input,VOID,FOLLOW_VOID_in_unaryOperator3884); 
                    		VOID32_tree = (object)adaptor.Create(VOID32);
                    		adaptor.AddChild(root_0, VOID32_tree);

                    	 retval.value =  UnaryExpressionType.Void; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1112:4: TYPEOF
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TYPEOF33=(IToken)Match(input,TYPEOF,FOLLOW_TYPEOF_in_unaryOperator3891); 
                    		TYPEOF33_tree = (object)adaptor.Create(TYPEOF33);
                    		adaptor.AddChild(root_0, TYPEOF33_tree);

                    	 retval.value =  UnaryExpressionType.TypeOf; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1113:4: INC
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	INC34=(IToken)Match(input,INC,FOLLOW_INC_in_unaryOperator3898); 
                    		INC34_tree = (object)adaptor.Create(INC34);
                    		adaptor.AddChild(root_0, INC34_tree);

                    	 retval.value =  UnaryExpressionType.PrefixPlusPlus; 

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1114:4: DEC
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DEC35=(IToken)Match(input,DEC,FOLLOW_DEC_in_unaryOperator3905); 
                    		DEC35_tree = (object)adaptor.Create(DEC35);
                    		adaptor.AddChild(root_0, DEC35_tree);

                    	 retval.value =  UnaryExpressionType.PrefixMinusMinus; 

                    }
                    break;
                case 6 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1115:4: op= ADD
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	op=(IToken)Match(input,ADD,FOLLOW_ADD_in_unaryOperator3914); 
                    		op_tree = (object)adaptor.Create(op);
                    		adaptor.AddChild(root_0, op_tree);

                    	 op.Type = POS; retval.value =  UnaryExpressionType.Positive; 

                    }
                    break;
                case 7 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1116:4: op= SUB
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	op=(IToken)Match(input,SUB,FOLLOW_SUB_in_unaryOperator3923); 
                    		op_tree = (object)adaptor.Create(op);
                    		adaptor.AddChild(root_0, op_tree);

                    	 op.Type = NEG; retval.value =  UnaryExpressionType.Negate; 

                    }
                    break;
                case 8 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1117:4: INV
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	INV36=(IToken)Match(input,INV,FOLLOW_INV_in_unaryOperator3930); 
                    		INV36_tree = (object)adaptor.Create(INV36);
                    		adaptor.AddChild(root_0, INV36_tree);

                    	 retval.value =  UnaryExpressionType.Inv; 

                    }
                    break;
                case 9 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1118:4: NOT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NOT37=(IToken)Match(input,NOT,FOLLOW_NOT_in_unaryOperator3937); 
                    		NOT37_tree = (object)adaptor.Create(NOT37);
                    		adaptor.AddChild(root_0, NOT37_tree);

                    	 retval.value =  UnaryExpressionType.Not; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryOperator"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1125:1: multiplicativeExpression returns [Expression value] : left= unaryExpression ( ( MUL | DIV | MOD ) right= unaryExpression )* ;
    public ES3Parser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        ES3Parser.multiplicativeExpression_return retval = new ES3Parser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MUL38 = null;
        IToken DIV39 = null;
        IToken MOD40 = null;
        ES3Parser.unaryExpression_return left = default(ES3Parser.unaryExpression_return);

        ES3Parser.unaryExpression_return right = default(ES3Parser.unaryExpression_return);


        object MUL38_tree=null;
        object DIV39_tree=null;
        object MOD40_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1129:2: (left= unaryExpression ( ( MUL | DIV | MOD ) right= unaryExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1129:4: left= unaryExpression ( ( MUL | DIV | MOD ) right= unaryExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression3965);
            	left = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1129:50: ( ( MUL | DIV | MOD ) right= unaryExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= MUL && LA27_0 <= MOD) || LA27_0 == DIV) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1130:3: ( MUL | DIV | MOD ) right= unaryExpression
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1130:3: ( MUL | DIV | MOD )
            			    	int alt26 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MUL:
            			    		{
            			    	    alt26 = 1;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt26 = 2;
            			    	    }
            			    	    break;
            			    	case MOD:
            			    		{
            			    	    alt26 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d26s0 =
            			    		        new NoViableAltException("", 26, 0, input);

            			    		    throw nvae_d26s0;
            			    	}

            			    	switch (alt26) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1130:5: MUL
            			    	        {
            			    	        	MUL38=(IToken)Match(input,MUL,FOLLOW_MUL_in_multiplicativeExpression3976); 
            			    	        		MUL38_tree = (object)adaptor.Create(MUL38);
            			    	        		adaptor.AddChild(root_0, MUL38_tree);

            			    	        	 type= BinaryExpressionType.Times; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1131:5: DIV
            			    	        {
            			    	        	DIV39=(IToken)Match(input,DIV,FOLLOW_DIV_in_multiplicativeExpression3985); 
            			    	        		DIV39_tree = (object)adaptor.Create(DIV39);
            			    	        		adaptor.AddChild(root_0, DIV39_tree);

            			    	        	 type= BinaryExpressionType.Div; 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1132:5: MOD
            			    	        {
            			    	        	MOD40=(IToken)Match(input,MOD,FOLLOW_MOD_in_multiplicativeExpression3993); 
            			    	        		MOD40_tree = (object)adaptor.Create(MOD40);
            			    	        		adaptor.AddChild(root_0, MOD40_tree);

            			    	        	 type= BinaryExpressionType.Modulo; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression4004);
            			    	right = unaryExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1140:1: additiveExpression returns [Expression value] : left= multiplicativeExpression ( ( ADD | SUB ) right= multiplicativeExpression )* ;
    public ES3Parser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        ES3Parser.additiveExpression_return retval = new ES3Parser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ADD41 = null;
        IToken SUB42 = null;
        ES3Parser.multiplicativeExpression_return left = default(ES3Parser.multiplicativeExpression_return);

        ES3Parser.multiplicativeExpression_return right = default(ES3Parser.multiplicativeExpression_return);


        object ADD41_tree=null;
        object SUB42_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1144:2: (left= multiplicativeExpression ( ( ADD | SUB ) right= multiplicativeExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1144:4: left= multiplicativeExpression ( ( ADD | SUB ) right= multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression4034);
            	left = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1144:59: ( ( ADD | SUB ) right= multiplicativeExpression )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= ADD && LA29_0 <= SUB)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1145:3: ( ADD | SUB ) right= multiplicativeExpression
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1145:3: ( ADD | SUB )
            			    	int alt28 = 2;
            			    	int LA28_0 = input.LA(1);

            			    	if ( (LA28_0 == ADD) )
            			    	{
            			    	    alt28 = 1;
            			    	}
            			    	else if ( (LA28_0 == SUB) )
            			    	{
            			    	    alt28 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d28s0 =
            			    	        new NoViableAltException("", 28, 0, input);

            			    	    throw nvae_d28s0;
            			    	}
            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1145:5: ADD
            			    	        {
            			    	        	ADD41=(IToken)Match(input,ADD,FOLLOW_ADD_in_additiveExpression4045); 
            			    	        		ADD41_tree = (object)adaptor.Create(ADD41);
            			    	        		adaptor.AddChild(root_0, ADD41_tree);

            			    	        	 type= BinaryExpressionType.Plus; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1146:5: SUB
            			    	        {
            			    	        	SUB42=(IToken)Match(input,SUB,FOLLOW_SUB_in_additiveExpression4053); 
            			    	        		SUB42_tree = (object)adaptor.Create(SUB42);
            			    	        		adaptor.AddChild(root_0, SUB42_tree);

            			    	        	 type= BinaryExpressionType.Minus; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression4064);
            			    	right = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class shiftExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "shiftExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1154:1: shiftExpression returns [Expression value] : left= additiveExpression ( ( SHL | SHR | SHU ) right= additiveExpression )* ;
    public ES3Parser.shiftExpression_return shiftExpression() // throws RecognitionException [1]
    {   
        ES3Parser.shiftExpression_return retval = new ES3Parser.shiftExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SHL43 = null;
        IToken SHR44 = null;
        IToken SHU45 = null;
        ES3Parser.additiveExpression_return left = default(ES3Parser.additiveExpression_return);

        ES3Parser.additiveExpression_return right = default(ES3Parser.additiveExpression_return);


        object SHL43_tree=null;
        object SHR44_tree=null;
        object SHU45_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1158:2: (left= additiveExpression ( ( SHL | SHR | SHU ) right= additiveExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1158:4: left= additiveExpression ( ( SHL | SHR | SHU ) right= additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_shiftExpression4095);
            	left = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1158:53: ( ( SHL | SHR | SHU ) right= additiveExpression )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( ((LA31_0 >= SHL && LA31_0 <= SHU)) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1159:3: ( SHL | SHR | SHU ) right= additiveExpression
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1159:3: ( SHL | SHR | SHU )
            			    	int alt30 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case SHL:
            			    		{
            			    	    alt30 = 1;
            			    	    }
            			    	    break;
            			    	case SHR:
            			    		{
            			    	    alt30 = 2;
            			    	    }
            			    	    break;
            			    	case SHU:
            			    		{
            			    	    alt30 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d30s0 =
            			    		        new NoViableAltException("", 30, 0, input);

            			    		    throw nvae_d30s0;
            			    	}

            			    	switch (alt30) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1159:5: SHL
            			    	        {
            			    	        	SHL43=(IToken)Match(input,SHL,FOLLOW_SHL_in_shiftExpression4106); 
            			    	        		SHL43_tree = (object)adaptor.Create(SHL43);
            			    	        		adaptor.AddChild(root_0, SHL43_tree);

            			    	        	 type= BinaryExpressionType.LeftShift; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1160:5: SHR
            			    	        {
            			    	        	SHR44=(IToken)Match(input,SHR,FOLLOW_SHR_in_shiftExpression4114); 
            			    	        		SHR44_tree = (object)adaptor.Create(SHR44);
            			    	        		adaptor.AddChild(root_0, SHR44_tree);

            			    	        	 type= BinaryExpressionType.RightShift; 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1161:5: SHU
            			    	        {
            			    	        	SHU45=(IToken)Match(input,SHU,FOLLOW_SHU_in_shiftExpression4122); 
            			    	        		SHU45_tree = (object)adaptor.Create(SHU45);
            			    	        		adaptor.AddChild(root_0, SHU45_tree);

            			    	        	 type= BinaryExpressionType.UnsignedRightShift; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_shiftExpression4133);
            			    	right = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "shiftExpression"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1169:1: relationalExpression returns [Expression value] : left= shiftExpression ( ( LT | GT | LTE | GTE | INSTANCEOF | IN ) right= shiftExpression )* ;
    public ES3Parser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        ES3Parser.relationalExpression_return retval = new ES3Parser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT46 = null;
        IToken GT47 = null;
        IToken LTE48 = null;
        IToken GTE49 = null;
        IToken INSTANCEOF50 = null;
        IToken IN51 = null;
        ES3Parser.shiftExpression_return left = default(ES3Parser.shiftExpression_return);

        ES3Parser.shiftExpression_return right = default(ES3Parser.shiftExpression_return);


        object LT46_tree=null;
        object GT47_tree=null;
        object LTE48_tree=null;
        object GTE49_tree=null;
        object INSTANCEOF50_tree=null;
        object IN51_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1173:2: (left= shiftExpression ( ( LT | GT | LTE | GTE | INSTANCEOF | IN ) right= shiftExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1173:4: left= shiftExpression ( ( LT | GT | LTE | GTE | INSTANCEOF | IN ) right= shiftExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_shiftExpression_in_relationalExpression4164);
            	left = shiftExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1173:50: ( ( LT | GT | LTE | GTE | INSTANCEOF | IN ) right= shiftExpression )*
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( ((LA33_0 >= IN && LA33_0 <= INSTANCEOF) || (LA33_0 >= LT && LA33_0 <= GTE)) )
            	    {
            	        alt33 = 1;
            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1174:3: ( LT | GT | LTE | GTE | INSTANCEOF | IN ) right= shiftExpression
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1174:3: ( LT | GT | LTE | GTE | INSTANCEOF | IN )
            			    	int alt32 = 6;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case LT:
            			    		{
            			    	    alt32 = 1;
            			    	    }
            			    	    break;
            			    	case GT:
            			    		{
            			    	    alt32 = 2;
            			    	    }
            			    	    break;
            			    	case LTE:
            			    		{
            			    	    alt32 = 3;
            			    	    }
            			    	    break;
            			    	case GTE:
            			    		{
            			    	    alt32 = 4;
            			    	    }
            			    	    break;
            			    	case INSTANCEOF:
            			    		{
            			    	    alt32 = 5;
            			    	    }
            			    	    break;
            			    	case IN:
            			    		{
            			    	    alt32 = 6;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d32s0 =
            			    		        new NoViableAltException("", 32, 0, input);

            			    		    throw nvae_d32s0;
            			    	}

            			    	switch (alt32) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1174:5: LT
            			    	        {
            			    	        	LT46=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression4175); 
            			    	        		LT46_tree = (object)adaptor.Create(LT46);
            			    	        		adaptor.AddChild(root_0, LT46_tree);

            			    	        	 type= BinaryExpressionType.Lesser; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1175:5: GT
            			    	        {
            			    	        	GT47=(IToken)Match(input,GT,FOLLOW_GT_in_relationalExpression4183); 
            			    	        		GT47_tree = (object)adaptor.Create(GT47);
            			    	        		adaptor.AddChild(root_0, GT47_tree);

            			    	        	 type= BinaryExpressionType.Greater; 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1176:5: LTE
            			    	        {
            			    	        	LTE48=(IToken)Match(input,LTE,FOLLOW_LTE_in_relationalExpression4191); 
            			    	        		LTE48_tree = (object)adaptor.Create(LTE48);
            			    	        		adaptor.AddChild(root_0, LTE48_tree);

            			    	        	 type= BinaryExpressionType.LesserOrEqual; 

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1177:5: GTE
            			    	        {
            			    	        	GTE49=(IToken)Match(input,GTE,FOLLOW_GTE_in_relationalExpression4199); 
            			    	        		GTE49_tree = (object)adaptor.Create(GTE49);
            			    	        		adaptor.AddChild(root_0, GTE49_tree);

            			    	        	 type= BinaryExpressionType.GreaterOrEqual; 

            			    	        }
            			    	        break;
            			    	    case 5 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1178:5: INSTANCEOF
            			    	        {
            			    	        	INSTANCEOF50=(IToken)Match(input,INSTANCEOF,FOLLOW_INSTANCEOF_in_relationalExpression4207); 
            			    	        		INSTANCEOF50_tree = (object)adaptor.Create(INSTANCEOF50);
            			    	        		adaptor.AddChild(root_0, INSTANCEOF50_tree);

            			    	        	 type= BinaryExpressionType.InstanceOf;  

            			    	        }
            			    	        break;
            			    	    case 6 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1179:5: IN
            			    	        {
            			    	        	IN51=(IToken)Match(input,IN,FOLLOW_IN_in_relationalExpression4215); 
            			    	        		IN51_tree = (object)adaptor.Create(IN51);
            			    	        		adaptor.AddChild(root_0, IN51_tree);

            			    	        	 type= BinaryExpressionType.In;  

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_shiftExpression_in_relationalExpression4226);
            			    	right = shiftExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public class relationalExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relationalExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1183:1: relationalExpressionNoIn returns [Expression value] : left= shiftExpression ( ( LT | GT | LTE | GTE | INSTANCEOF ) right= shiftExpression )* ;
    public ES3Parser.relationalExpressionNoIn_return relationalExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.relationalExpressionNoIn_return retval = new ES3Parser.relationalExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT52 = null;
        IToken GT53 = null;
        IToken LTE54 = null;
        IToken GTE55 = null;
        IToken INSTANCEOF56 = null;
        ES3Parser.shiftExpression_return left = default(ES3Parser.shiftExpression_return);

        ES3Parser.shiftExpression_return right = default(ES3Parser.shiftExpression_return);


        object LT52_tree=null;
        object GT53_tree=null;
        object LTE54_tree=null;
        object GTE55_tree=null;
        object INSTANCEOF56_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1187:2: (left= shiftExpression ( ( LT | GT | LTE | GTE | INSTANCEOF ) right= shiftExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1187:4: left= shiftExpression ( ( LT | GT | LTE | GTE | INSTANCEOF ) right= shiftExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_shiftExpression_in_relationalExpressionNoIn4252);
            	left = shiftExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1187:50: ( ( LT | GT | LTE | GTE | INSTANCEOF ) right= shiftExpression )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == INSTANCEOF || (LA35_0 >= LT && LA35_0 <= GTE)) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1188:3: ( LT | GT | LTE | GTE | INSTANCEOF ) right= shiftExpression
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1188:3: ( LT | GT | LTE | GTE | INSTANCEOF )
            			    	int alt34 = 5;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case LT:
            			    		{
            			    	    alt34 = 1;
            			    	    }
            			    	    break;
            			    	case GT:
            			    		{
            			    	    alt34 = 2;
            			    	    }
            			    	    break;
            			    	case LTE:
            			    		{
            			    	    alt34 = 3;
            			    	    }
            			    	    break;
            			    	case GTE:
            			    		{
            			    	    alt34 = 4;
            			    	    }
            			    	    break;
            			    	case INSTANCEOF:
            			    		{
            			    	    alt34 = 5;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d34s0 =
            			    		        new NoViableAltException("", 34, 0, input);

            			    		    throw nvae_d34s0;
            			    	}

            			    	switch (alt34) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1188:5: LT
            			    	        {
            			    	        	LT52=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpressionNoIn4263); 
            			    	        		LT52_tree = (object)adaptor.Create(LT52);
            			    	        		adaptor.AddChild(root_0, LT52_tree);

            			    	        	 type= BinaryExpressionType.Lesser; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1189:5: GT
            			    	        {
            			    	        	GT53=(IToken)Match(input,GT,FOLLOW_GT_in_relationalExpressionNoIn4271); 
            			    	        		GT53_tree = (object)adaptor.Create(GT53);
            			    	        		adaptor.AddChild(root_0, GT53_tree);

            			    	        	 type= BinaryExpressionType.Greater; 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1190:5: LTE
            			    	        {
            			    	        	LTE54=(IToken)Match(input,LTE,FOLLOW_LTE_in_relationalExpressionNoIn4279); 
            			    	        		LTE54_tree = (object)adaptor.Create(LTE54);
            			    	        		adaptor.AddChild(root_0, LTE54_tree);

            			    	        	 type= BinaryExpressionType.LesserOrEqual; 

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1191:5: GTE
            			    	        {
            			    	        	GTE55=(IToken)Match(input,GTE,FOLLOW_GTE_in_relationalExpressionNoIn4287); 
            			    	        		GTE55_tree = (object)adaptor.Create(GTE55);
            			    	        		adaptor.AddChild(root_0, GTE55_tree);

            			    	        	 type= BinaryExpressionType.GreaterOrEqual; 

            			    	        }
            			    	        break;
            			    	    case 5 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1192:5: INSTANCEOF
            			    	        {
            			    	        	INSTANCEOF56=(IToken)Match(input,INSTANCEOF,FOLLOW_INSTANCEOF_in_relationalExpressionNoIn4295); 
            			    	        		INSTANCEOF56_tree = (object)adaptor.Create(INSTANCEOF56);
            			    	        		adaptor.AddChild(root_0, INSTANCEOF56_tree);

            			    	        	 type= BinaryExpressionType.InstanceOf;  

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_shiftExpression_in_relationalExpressionNoIn4307);
            			    	right = shiftExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpressionNoIn"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1200:1: equalityExpression returns [Expression value] : left= relationalExpression ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpression )* ;
    public ES3Parser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        ES3Parser.equalityExpression_return retval = new ES3Parser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ57 = null;
        IToken NEQ58 = null;
        IToken SAME59 = null;
        IToken NSAME60 = null;
        ES3Parser.relationalExpression_return left = default(ES3Parser.relationalExpression_return);

        ES3Parser.relationalExpression_return right = default(ES3Parser.relationalExpression_return);


        object EQ57_tree=null;
        object NEQ58_tree=null;
        object SAME59_tree=null;
        object NSAME60_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1204:2: (left= relationalExpression ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1204:4: left= relationalExpression ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression4338);
            	left = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1204:55: ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpression )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( ((LA37_0 >= EQ && LA37_0 <= NSAME)) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1205:3: ( EQ | NEQ | SAME | NSAME ) right= relationalExpression
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1205:3: ( EQ | NEQ | SAME | NSAME )
            			    	int alt36 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case EQ:
            			    		{
            			    	    alt36 = 1;
            			    	    }
            			    	    break;
            			    	case NEQ:
            			    		{
            			    	    alt36 = 2;
            			    	    }
            			    	    break;
            			    	case SAME:
            			    		{
            			    	    alt36 = 3;
            			    	    }
            			    	    break;
            			    	case NSAME:
            			    		{
            			    	    alt36 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d36s0 =
            			    		        new NoViableAltException("", 36, 0, input);

            			    		    throw nvae_d36s0;
            			    	}

            			    	switch (alt36) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1205:5: EQ
            			    	        {
            			    	        	EQ57=(IToken)Match(input,EQ,FOLLOW_EQ_in_equalityExpression4349); 
            			    	        		EQ57_tree = (object)adaptor.Create(EQ57);
            			    	        		adaptor.AddChild(root_0, EQ57_tree);

            			    	        	 type= BinaryExpressionType.Equal; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1206:5: NEQ
            			    	        {
            			    	        	NEQ58=(IToken)Match(input,NEQ,FOLLOW_NEQ_in_equalityExpression4357); 
            			    	        		NEQ58_tree = (object)adaptor.Create(NEQ58);
            			    	        		adaptor.AddChild(root_0, NEQ58_tree);

            			    	        	 type= BinaryExpressionType.NotEqual; 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1207:5: SAME
            			    	        {
            			    	        	SAME59=(IToken)Match(input,SAME,FOLLOW_SAME_in_equalityExpression4365); 
            			    	        		SAME59_tree = (object)adaptor.Create(SAME59);
            			    	        		adaptor.AddChild(root_0, SAME59_tree);

            			    	        	 type= BinaryExpressionType.Same; 

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1208:5: NSAME
            			    	        {
            			    	        	NSAME60=(IToken)Match(input,NSAME,FOLLOW_NSAME_in_equalityExpression4373); 
            			    	        		NSAME60_tree = (object)adaptor.Create(NSAME60);
            			    	        		adaptor.AddChild(root_0, NSAME60_tree);

            			    	        	 type= BinaryExpressionType.NotSame; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression4384);
            			    	right = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class equalityExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equalityExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1212:1: equalityExpressionNoIn returns [Expression value] : left= relationalExpressionNoIn ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpressionNoIn )* ;
    public ES3Parser.equalityExpressionNoIn_return equalityExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.equalityExpressionNoIn_return retval = new ES3Parser.equalityExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ61 = null;
        IToken NEQ62 = null;
        IToken SAME63 = null;
        IToken NSAME64 = null;
        ES3Parser.relationalExpressionNoIn_return left = default(ES3Parser.relationalExpressionNoIn_return);

        ES3Parser.relationalExpressionNoIn_return right = default(ES3Parser.relationalExpressionNoIn_return);


        object EQ61_tree=null;
        object NEQ62_tree=null;
        object SAME63_tree=null;
        object NSAME64_tree=null;


        	BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1216:2: (left= relationalExpressionNoIn ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1216:4: left= relationalExpressionNoIn ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn4410);
            	left = relationalExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1216:59: ( ( EQ | NEQ | SAME | NSAME ) right= relationalExpressionNoIn )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( ((LA39_0 >= EQ && LA39_0 <= NSAME)) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1217:3: ( EQ | NEQ | SAME | NSAME ) right= relationalExpressionNoIn
            			    {
            			    	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1217:3: ( EQ | NEQ | SAME | NSAME )
            			    	int alt38 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case EQ:
            			    		{
            			    	    alt38 = 1;
            			    	    }
            			    	    break;
            			    	case NEQ:
            			    		{
            			    	    alt38 = 2;
            			    	    }
            			    	    break;
            			    	case SAME:
            			    		{
            			    	    alt38 = 3;
            			    	    }
            			    	    break;
            			    	case NSAME:
            			    		{
            			    	    alt38 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d38s0 =
            			    		        new NoViableAltException("", 38, 0, input);

            			    		    throw nvae_d38s0;
            			    	}

            			    	switch (alt38) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1217:5: EQ
            			    	        {
            			    	        	EQ61=(IToken)Match(input,EQ,FOLLOW_EQ_in_equalityExpressionNoIn4421); 
            			    	        		EQ61_tree = (object)adaptor.Create(EQ61);
            			    	        		adaptor.AddChild(root_0, EQ61_tree);

            			    	        	 type= BinaryExpressionType.Equal; 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1218:5: NEQ
            			    	        {
            			    	        	NEQ62=(IToken)Match(input,NEQ,FOLLOW_NEQ_in_equalityExpressionNoIn4429); 
            			    	        		NEQ62_tree = (object)adaptor.Create(NEQ62);
            			    	        		adaptor.AddChild(root_0, NEQ62_tree);

            			    	        	 type= BinaryExpressionType.NotEqual; 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1219:5: SAME
            			    	        {
            			    	        	SAME63=(IToken)Match(input,SAME,FOLLOW_SAME_in_equalityExpressionNoIn4437); 
            			    	        		SAME63_tree = (object)adaptor.Create(SAME63);
            			    	        		adaptor.AddChild(root_0, SAME63_tree);

            			    	        	 type= BinaryExpressionType.Same; 

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1220:5: NSAME
            			    	        {
            			    	        	NSAME64=(IToken)Match(input,NSAME,FOLLOW_NSAME_in_equalityExpressionNoIn4445); 
            			    	        		NSAME64_tree = (object)adaptor.Create(NSAME64);
            			    	        		adaptor.AddChild(root_0, NSAME64_tree);

            			    	        	 type= BinaryExpressionType.NotSame; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn4456);
            			    	right = relationalExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(type, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpressionNoIn"

    public class bitwiseANDExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseANDExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1228:1: bitwiseANDExpression returns [Expression value] : left= equalityExpression ( AND right= equalityExpression )* ;
    public ES3Parser.bitwiseANDExpression_return bitwiseANDExpression() // throws RecognitionException [1]
    {   
        ES3Parser.bitwiseANDExpression_return retval = new ES3Parser.bitwiseANDExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND65 = null;
        ES3Parser.equalityExpression_return left = default(ES3Parser.equalityExpression_return);

        ES3Parser.equalityExpression_return right = default(ES3Parser.equalityExpression_return);


        object AND65_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1229:2: (left= equalityExpression ( AND right= equalityExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1229:4: left= equalityExpression ( AND right= equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_bitwiseANDExpression4483);
            	left = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1229:53: ( AND right= equalityExpression )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == AND) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1229:55: AND right= equalityExpression
            			    {
            			    	AND65=(IToken)Match(input,AND,FOLLOW_AND_in_bitwiseANDExpression4489); 
            			    		AND65_tree = (object)adaptor.Create(AND65);
            			    		root_0 = (object)adaptor.BecomeRoot(AND65_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_bitwiseANDExpression4494);
            			    	right = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.BitwiseAnd, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseANDExpression"

    public class bitwiseANDExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseANDExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1232:1: bitwiseANDExpressionNoIn returns [Expression value] : left= equalityExpressionNoIn ( AND right= equalityExpressionNoIn )* ;
    public ES3Parser.bitwiseANDExpressionNoIn_return bitwiseANDExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.bitwiseANDExpressionNoIn_return retval = new ES3Parser.bitwiseANDExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND66 = null;
        ES3Parser.equalityExpressionNoIn_return left = default(ES3Parser.equalityExpressionNoIn_return);

        ES3Parser.equalityExpressionNoIn_return right = default(ES3Parser.equalityExpressionNoIn_return);


        object AND66_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1233:2: (left= equalityExpressionNoIn ( AND right= equalityExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1233:4: left= equalityExpressionNoIn ( AND right= equalityExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn4515);
            	left = equalityExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1233:57: ( AND right= equalityExpressionNoIn )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == AND) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1233:59: AND right= equalityExpressionNoIn
            			    {
            			    	AND66=(IToken)Match(input,AND,FOLLOW_AND_in_bitwiseANDExpressionNoIn4521); 
            			    		AND66_tree = (object)adaptor.Create(AND66);
            			    		root_0 = (object)adaptor.BecomeRoot(AND66_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn4526);
            			    	right = equalityExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.BitwiseAnd, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseANDExpressionNoIn"

    public class bitwiseXORExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseXORExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1236:1: bitwiseXORExpression returns [Expression value] : left= bitwiseANDExpression ( XOR right= bitwiseANDExpression )* ;
    public ES3Parser.bitwiseXORExpression_return bitwiseXORExpression() // throws RecognitionException [1]
    {   
        ES3Parser.bitwiseXORExpression_return retval = new ES3Parser.bitwiseXORExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken XOR67 = null;
        ES3Parser.bitwiseANDExpression_return left = default(ES3Parser.bitwiseANDExpression_return);

        ES3Parser.bitwiseANDExpression_return right = default(ES3Parser.bitwiseANDExpression_return);


        object XOR67_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1237:2: (left= bitwiseANDExpression ( XOR right= bitwiseANDExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1237:4: left= bitwiseANDExpression ( XOR right= bitwiseANDExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression4549);
            	left = bitwiseANDExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1237:55: ( XOR right= bitwiseANDExpression )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == XOR) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1237:57: XOR right= bitwiseANDExpression
            			    {
            			    	XOR67=(IToken)Match(input,XOR,FOLLOW_XOR_in_bitwiseXORExpression4555); 
            			    		XOR67_tree = (object)adaptor.Create(XOR67);
            			    		root_0 = (object)adaptor.BecomeRoot(XOR67_tree, root_0);

            			    	PushFollow(FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression4560);
            			    	right = bitwiseANDExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.BitwiseXOr, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseXORExpression"

    public class bitwiseXORExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseXORExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1240:1: bitwiseXORExpressionNoIn returns [Expression value] : left= bitwiseANDExpressionNoIn ( XOR right= bitwiseANDExpressionNoIn )* ;
    public ES3Parser.bitwiseXORExpressionNoIn_return bitwiseXORExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.bitwiseXORExpressionNoIn_return retval = new ES3Parser.bitwiseXORExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken XOR68 = null;
        ES3Parser.bitwiseANDExpressionNoIn_return left = default(ES3Parser.bitwiseANDExpressionNoIn_return);

        ES3Parser.bitwiseANDExpressionNoIn_return right = default(ES3Parser.bitwiseANDExpressionNoIn_return);


        object XOR68_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1241:2: (left= bitwiseANDExpressionNoIn ( XOR right= bitwiseANDExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1241:4: left= bitwiseANDExpressionNoIn ( XOR right= bitwiseANDExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn4583);
            	left = bitwiseANDExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1241:59: ( XOR right= bitwiseANDExpressionNoIn )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == XOR) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1241:61: XOR right= bitwiseANDExpressionNoIn
            			    {
            			    	XOR68=(IToken)Match(input,XOR,FOLLOW_XOR_in_bitwiseXORExpressionNoIn4589); 
            			    		XOR68_tree = (object)adaptor.Create(XOR68);
            			    		root_0 = (object)adaptor.BecomeRoot(XOR68_tree, root_0);

            			    	PushFollow(FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn4594);
            			    	right = bitwiseANDExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.BitwiseXOr, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseXORExpressionNoIn"

    public class bitwiseORExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseORExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1244:1: bitwiseORExpression returns [Expression value] : left= bitwiseXORExpression ( OR right= bitwiseXORExpression )* ;
    public ES3Parser.bitwiseORExpression_return bitwiseORExpression() // throws RecognitionException [1]
    {   
        ES3Parser.bitwiseORExpression_return retval = new ES3Parser.bitwiseORExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR69 = null;
        ES3Parser.bitwiseXORExpression_return left = default(ES3Parser.bitwiseXORExpression_return);

        ES3Parser.bitwiseXORExpression_return right = default(ES3Parser.bitwiseXORExpression_return);


        object OR69_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1245:2: (left= bitwiseXORExpression ( OR right= bitwiseXORExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1245:4: left= bitwiseXORExpression ( OR right= bitwiseXORExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseXORExpression_in_bitwiseORExpression4616);
            	left = bitwiseXORExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1245:55: ( OR right= bitwiseXORExpression )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( (LA44_0 == OR) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1245:57: OR right= bitwiseXORExpression
            			    {
            			    	OR69=(IToken)Match(input,OR,FOLLOW_OR_in_bitwiseORExpression4622); 
            			    		OR69_tree = (object)adaptor.Create(OR69);
            			    		root_0 = (object)adaptor.BecomeRoot(OR69_tree, root_0);

            			    	PushFollow(FOLLOW_bitwiseXORExpression_in_bitwiseORExpression4627);
            			    	right = bitwiseXORExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.BitwiseOr, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseORExpression"

    public class bitwiseORExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseORExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1248:1: bitwiseORExpressionNoIn returns [Expression value] : left= bitwiseXORExpressionNoIn ( OR right= bitwiseXORExpressionNoIn )* ;
    public ES3Parser.bitwiseORExpressionNoIn_return bitwiseORExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.bitwiseORExpressionNoIn_return retval = new ES3Parser.bitwiseORExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR70 = null;
        ES3Parser.bitwiseXORExpressionNoIn_return left = default(ES3Parser.bitwiseXORExpressionNoIn_return);

        ES3Parser.bitwiseXORExpressionNoIn_return right = default(ES3Parser.bitwiseXORExpressionNoIn_return);


        object OR70_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1249:2: (left= bitwiseXORExpressionNoIn ( OR right= bitwiseXORExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1249:4: left= bitwiseXORExpressionNoIn ( OR right= bitwiseXORExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn4649);
            	left = bitwiseXORExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1249:59: ( OR right= bitwiseXORExpressionNoIn )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( (LA45_0 == OR) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1249:61: OR right= bitwiseXORExpressionNoIn
            			    {
            			    	OR70=(IToken)Match(input,OR,FOLLOW_OR_in_bitwiseORExpressionNoIn4655); 
            			    		OR70_tree = (object)adaptor.Create(OR70);
            			    		root_0 = (object)adaptor.BecomeRoot(OR70_tree, root_0);

            			    	PushFollow(FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn4660);
            			    	right = bitwiseXORExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.BitwiseOr, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseORExpressionNoIn"

    public class logicalANDExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicalANDExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1256:1: logicalANDExpression returns [Expression value] : left= bitwiseORExpression ( LAND right= bitwiseORExpression )* ;
    public ES3Parser.logicalANDExpression_return logicalANDExpression() // throws RecognitionException [1]
    {   
        ES3Parser.logicalANDExpression_return retval = new ES3Parser.logicalANDExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LAND71 = null;
        ES3Parser.bitwiseORExpression_return left = default(ES3Parser.bitwiseORExpression_return);

        ES3Parser.bitwiseORExpression_return right = default(ES3Parser.bitwiseORExpression_return);


        object LAND71_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1257:2: (left= bitwiseORExpression ( LAND right= bitwiseORExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1257:3: left= bitwiseORExpression ( LAND right= bitwiseORExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseORExpression_in_logicalANDExpression4686);
            	left = bitwiseORExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1257:54: ( LAND right= bitwiseORExpression )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( (LA46_0 == LAND) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1257:56: LAND right= bitwiseORExpression
            			    {
            			    	LAND71=(IToken)Match(input,LAND,FOLLOW_LAND_in_logicalANDExpression4692); 
            			    		LAND71_tree = (object)adaptor.Create(LAND71);
            			    		root_0 = (object)adaptor.BecomeRoot(LAND71_tree, root_0);

            			    	PushFollow(FOLLOW_bitwiseORExpression_in_logicalANDExpression4697);
            			    	right = bitwiseORExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.And, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalANDExpression"

    public class logicalANDExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicalANDExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1260:1: logicalANDExpressionNoIn returns [Expression value] : left= bitwiseORExpressionNoIn ( LAND right= bitwiseORExpressionNoIn )* ;
    public ES3Parser.logicalANDExpressionNoIn_return logicalANDExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.logicalANDExpressionNoIn_return retval = new ES3Parser.logicalANDExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LAND72 = null;
        ES3Parser.bitwiseORExpressionNoIn_return left = default(ES3Parser.bitwiseORExpressionNoIn_return);

        ES3Parser.bitwiseORExpressionNoIn_return right = default(ES3Parser.bitwiseORExpressionNoIn_return);


        object LAND72_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1261:2: (left= bitwiseORExpressionNoIn ( LAND right= bitwiseORExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1261:3: left= bitwiseORExpressionNoIn ( LAND right= bitwiseORExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn4718);
            	left = bitwiseORExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1261:58: ( LAND right= bitwiseORExpressionNoIn )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( (LA47_0 == LAND) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1261:60: LAND right= bitwiseORExpressionNoIn
            			    {
            			    	LAND72=(IToken)Match(input,LAND,FOLLOW_LAND_in_logicalANDExpressionNoIn4724); 
            			    		LAND72_tree = (object)adaptor.Create(LAND72);
            			    		root_0 = (object)adaptor.BecomeRoot(LAND72_tree, root_0);

            			    	PushFollow(FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn4729);
            			    	right = bitwiseORExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.And, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalANDExpressionNoIn"

    public class logicalORExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicalORExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1264:1: logicalORExpression returns [Expression value] : left= logicalANDExpression ( LOR right= logicalANDExpression )* ;
    public ES3Parser.logicalORExpression_return logicalORExpression() // throws RecognitionException [1]
    {   
        ES3Parser.logicalORExpression_return retval = new ES3Parser.logicalORExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOR73 = null;
        ES3Parser.logicalANDExpression_return left = default(ES3Parser.logicalANDExpression_return);

        ES3Parser.logicalANDExpression_return right = default(ES3Parser.logicalANDExpression_return);


        object LOR73_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1265:2: (left= logicalANDExpression ( LOR right= logicalANDExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1265:4: left= logicalANDExpression ( LOR right= logicalANDExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalANDExpression_in_logicalORExpression4751);
            	left = logicalANDExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1265:55: ( LOR right= logicalANDExpression )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == LOR) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1265:57: LOR right= logicalANDExpression
            			    {
            			    	LOR73=(IToken)Match(input,LOR,FOLLOW_LOR_in_logicalORExpression4757); 
            			    		LOR73_tree = (object)adaptor.Create(LOR73);
            			    		root_0 = (object)adaptor.BecomeRoot(LOR73_tree, root_0);

            			    	PushFollow(FOLLOW_logicalANDExpression_in_logicalORExpression4762);
            			    	right = logicalANDExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.Or, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalORExpression"

    public class logicalORExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicalORExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1268:1: logicalORExpressionNoIn returns [Expression value] : left= logicalANDExpressionNoIn ( LOR right= logicalANDExpressionNoIn )* ;
    public ES3Parser.logicalORExpressionNoIn_return logicalORExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.logicalORExpressionNoIn_return retval = new ES3Parser.logicalORExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOR74 = null;
        ES3Parser.logicalANDExpressionNoIn_return left = default(ES3Parser.logicalANDExpressionNoIn_return);

        ES3Parser.logicalANDExpressionNoIn_return right = default(ES3Parser.logicalANDExpressionNoIn_return);


        object LOR74_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1269:2: (left= logicalANDExpressionNoIn ( LOR right= logicalANDExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1269:4: left= logicalANDExpressionNoIn ( LOR right= logicalANDExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn4784);
            	left = logicalANDExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, left.Tree);
            	 retval.value =  left.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1269:59: ( LOR right= logicalANDExpressionNoIn )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( (LA49_0 == LOR) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1269:61: LOR right= logicalANDExpressionNoIn
            			    {
            			    	LOR74=(IToken)Match(input,LOR,FOLLOW_LOR_in_logicalORExpressionNoIn4790); 
            			    		LOR74_tree = (object)adaptor.Create(LOR74);
            			    		root_0 = (object)adaptor.BecomeRoot(LOR74_tree, root_0);

            			    	PushFollow(FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn4795);
            			    	right = logicalANDExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, right.Tree);
            			    	 retval.value =  new BinaryExpression(BinaryExpressionType.Or, retval.value, right.value); 

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalORExpressionNoIn"

    public class conditionalExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1276:1: conditionalExpression returns [Expression value] : expr1= logicalORExpression ( QUE expr2= assignmentExpression COLON expr3= assignmentExpression )? ;
    public ES3Parser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        ES3Parser.conditionalExpression_return retval = new ES3Parser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QUE75 = null;
        IToken COLON76 = null;
        ES3Parser.logicalORExpression_return expr1 = default(ES3Parser.logicalORExpression_return);

        ES3Parser.assignmentExpression_return expr2 = default(ES3Parser.assignmentExpression_return);

        ES3Parser.assignmentExpression_return expr3 = default(ES3Parser.assignmentExpression_return);


        object QUE75_tree=null;
        object COLON76_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1277:2: (expr1= logicalORExpression ( QUE expr2= assignmentExpression COLON expr3= assignmentExpression )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1277:4: expr1= logicalORExpression ( QUE expr2= assignmentExpression COLON expr3= assignmentExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalORExpression_in_conditionalExpression4822);
            	expr1 = logicalORExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expr1.Tree);
            	 retval.value =  expr1.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1277:56: ( QUE expr2= assignmentExpression COLON expr3= assignmentExpression )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == QUE) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1277:58: QUE expr2= assignmentExpression COLON expr3= assignmentExpression
            	        {
            	        	QUE75=(IToken)Match(input,QUE,FOLLOW_QUE_in_conditionalExpression4828); 
            	        		QUE75_tree = (object)adaptor.Create(QUE75);
            	        		root_0 = (object)adaptor.BecomeRoot(QUE75_tree, root_0);

            	        	PushFollow(FOLLOW_assignmentExpression_in_conditionalExpression4833);
            	        	expr2 = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expr2.Tree);
            	        	COLON76=(IToken)Match(input,COLON,FOLLOW_COLON_in_conditionalExpression4835); 
            	        	PushFollow(FOLLOW_assignmentExpression_in_conditionalExpression4840);
            	        	expr3 = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expr3.Tree);
            	        	 retval.value =  new TernaryExpression(expr1.value, expr2.value, expr3.value); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionalExpression"

    public class conditionalExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1280:1: conditionalExpressionNoIn returns [Expression value] : expr1= logicalORExpressionNoIn ( QUE expr2= assignmentExpressionNoIn COLON expr3= assignmentExpressionNoIn )? ;
    public ES3Parser.conditionalExpressionNoIn_return conditionalExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.conditionalExpressionNoIn_return retval = new ES3Parser.conditionalExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QUE77 = null;
        IToken COLON78 = null;
        ES3Parser.logicalORExpressionNoIn_return expr1 = default(ES3Parser.logicalORExpressionNoIn_return);

        ES3Parser.assignmentExpressionNoIn_return expr2 = default(ES3Parser.assignmentExpressionNoIn_return);

        ES3Parser.assignmentExpressionNoIn_return expr3 = default(ES3Parser.assignmentExpressionNoIn_return);


        object QUE77_tree=null;
        object COLON78_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1281:2: (expr1= logicalORExpressionNoIn ( QUE expr2= assignmentExpressionNoIn COLON expr3= assignmentExpressionNoIn )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1281:4: expr1= logicalORExpressionNoIn ( QUE expr2= assignmentExpressionNoIn COLON expr3= assignmentExpressionNoIn )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalORExpressionNoIn_in_conditionalExpressionNoIn4861);
            	expr1 = logicalORExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expr1.Tree);
            	 retval.value =  expr1.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1281:60: ( QUE expr2= assignmentExpressionNoIn COLON expr3= assignmentExpressionNoIn )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == QUE) )
            	{
            	    alt51 = 1;
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1281:62: QUE expr2= assignmentExpressionNoIn COLON expr3= assignmentExpressionNoIn
            	        {
            	        	QUE77=(IToken)Match(input,QUE,FOLLOW_QUE_in_conditionalExpressionNoIn4867); 
            	        		QUE77_tree = (object)adaptor.Create(QUE77);
            	        		root_0 = (object)adaptor.BecomeRoot(QUE77_tree, root_0);

            	        	PushFollow(FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn4872);
            	        	expr2 = assignmentExpressionNoIn();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expr2.Tree);
            	        	COLON78=(IToken)Match(input,COLON,FOLLOW_COLON_in_conditionalExpressionNoIn4874); 
            	        	PushFollow(FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn4879);
            	        	expr3 = assignmentExpressionNoIn();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expr3.Tree);
            	        	 retval.value =  new TernaryExpression(expr1.value, expr2.value, expr3.value); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionalExpressionNoIn"

    public class assignmentExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1310:1: assignmentExpression returns [Expression value] : lhs= conditionalExpression ({...}?ass= assignmentOperator exp= assignmentExpression )? ;
    public ES3Parser.assignmentExpression_return assignmentExpression() // throws RecognitionException [1]
    {   
        ES3Parser.assignmentExpression_return retval = new ES3Parser.assignmentExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.conditionalExpression_return lhs = default(ES3Parser.conditionalExpression_return);

        ES3Parser.assignmentOperator_return ass = default(ES3Parser.assignmentOperator_return);

        ES3Parser.assignmentExpression_return exp = default(ES3Parser.assignmentExpression_return);




        	Object[] isLhs = new Object[1];
        	var assignment = new AssignmentExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1316:2: (lhs= conditionalExpression ({...}?ass= assignmentOperator exp= assignmentExpression )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1316:4: lhs= conditionalExpression ({...}?ass= assignmentOperator exp= assignmentExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_assignmentExpression4912);
            	lhs = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, lhs.Tree);
            	 retval.value =  assignment.Left = lhs.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1317:2: ({...}?ass= assignmentOperator exp= assignmentExpression )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( ((LA52_0 >= ASSIGN && LA52_0 <= XORASS) || LA52_0 == DIVASS) )
            	{
            	    int LA52_1 = input.LA(2);

            	    if ( (( IsLeftHandSideAssign(lhs.value, isLhs) )) )
            	    {
            	        alt52 = 1;
            	    }
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1317:5: {...}?ass= assignmentOperator exp= assignmentExpression
            	        {
            	        	if ( !(( IsLeftHandSideAssign(lhs.value, isLhs) )) ) 
            	        	{
            	        	    throw new FailedPredicateException(input, "assignmentExpression", " IsLeftHandSideAssign(lhs.value, isLhs) ");
            	        	}
            	        	PushFollow(FOLLOW_assignmentOperator_in_assignmentExpression4924);
            	        	ass = assignmentOperator();
            	        	state.followingStackPointer--;

            	        	root_0 = (object)adaptor.BecomeRoot(ass.Tree, root_0);
            	        	 assignment.AssignmentOperator = ResolveAssignmentOperator(((ass != null) ? input.ToString((IToken)(ass.Start),(IToken)(ass.Stop)) : null)); 
            	        	PushFollow(FOLLOW_assignmentExpression_in_assignmentExpression4931);
            	        	exp = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, exp.Tree);
            	        	  assignment.Right = exp.value; retval.value =  assignment; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignmentExpression"

    public class assignmentOperator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentOperator"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1320:1: assignmentOperator : ( ASSIGN | MULASS | DIVASS | MODASS | ADDASS | SUBASS | SHLASS | SHRASS | SHUASS | ANDASS | XORASS | ORASS );
    public ES3Parser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        ES3Parser.assignmentOperator_return retval = new ES3Parser.assignmentOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set79 = null;

        object set79_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1321:2: ( ASSIGN | MULASS | DIVASS | MODASS | ADDASS | SUBASS | SHLASS | SHRASS | SHUASS | ANDASS | XORASS | ORASS )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set79 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= ASSIGN && input.LA(1) <= XORASS) || input.LA(1) == DIVASS ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set79));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignmentOperator"

    public class assignmentExpressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentExpressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1335:1: assignmentExpressionNoIn returns [Expression value] : lhs= conditionalExpressionNoIn ({...}?ass= assignmentOperator exp= assignmentExpressionNoIn )? ;
    public ES3Parser.assignmentExpressionNoIn_return assignmentExpressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.assignmentExpressionNoIn_return retval = new ES3Parser.assignmentExpressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.conditionalExpressionNoIn_return lhs = default(ES3Parser.conditionalExpressionNoIn_return);

        ES3Parser.assignmentOperator_return ass = default(ES3Parser.assignmentOperator_return);

        ES3Parser.assignmentExpressionNoIn_return exp = default(ES3Parser.assignmentExpressionNoIn_return);




        	object[] isLhs = new object[1];
        	var assignment = new AssignmentExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1341:2: (lhs= conditionalExpressionNoIn ({...}?ass= assignmentOperator exp= assignmentExpressionNoIn )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1341:4: lhs= conditionalExpressionNoIn ({...}?ass= assignmentOperator exp= assignmentExpressionNoIn )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpressionNoIn_in_assignmentExpressionNoIn5026);
            	lhs = conditionalExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, lhs.Tree);
            	  assignment.Left = retval.value =  ((lhs != null) ? lhs.value : default(Expression)); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1342:2: ({...}?ass= assignmentOperator exp= assignmentExpressionNoIn )?
            	int alt53 = 2;
            	int LA53_0 = input.LA(1);

            	if ( ((LA53_0 >= ASSIGN && LA53_0 <= XORASS) || LA53_0 == DIVASS) )
            	{
            	    int LA53_1 = input.LA(2);

            	    if ( (( IsLeftHandSideAssign(lhs.value, isLhs) )) )
            	    {
            	        alt53 = 1;
            	    }
            	}
            	switch (alt53) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1342:4: {...}?ass= assignmentOperator exp= assignmentExpressionNoIn
            	        {
            	        	if ( !(( IsLeftHandSideAssign(lhs.value, isLhs) )) ) 
            	        	{
            	        	    throw new FailedPredicateException(input, "assignmentExpressionNoIn", " IsLeftHandSideAssign(lhs.value, isLhs) ");
            	        	}
            	        	PushFollow(FOLLOW_assignmentOperator_in_assignmentExpressionNoIn5038);
            	        	ass = assignmentOperator();
            	        	state.followingStackPointer--;

            	        	root_0 = (object)adaptor.BecomeRoot(ass.Tree, root_0);
            	        	 assignment.AssignmentOperator = ResolveAssignmentOperator(((ass != null) ? input.ToString((IToken)(ass.Start),(IToken)(ass.Stop)) : null)); 
            	        	PushFollow(FOLLOW_assignmentExpressionNoIn_in_assignmentExpressionNoIn5045);
            	        	exp = assignmentExpressionNoIn();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, exp.Tree);
            	        	  assignment.Right = exp.value; retval.value =  assignment; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignmentExpressionNoIn"

    public class expression_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1349:1: expression returns [Expression value] : first= assignmentExpression ( COMMA follow= assignmentExpression )* ;
    public ES3Parser.expression_return expression() // throws RecognitionException [1]
    {   
        ES3Parser.expression_return retval = new ES3Parser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA80 = null;
        ES3Parser.assignmentExpression_return first = default(ES3Parser.assignmentExpression_return);

        ES3Parser.assignmentExpression_return follow = default(ES3Parser.assignmentExpression_return);


        object COMMA80_tree=null;


        	var cs = new CommaOperatorStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1353:2: (first= assignmentExpression ( COMMA follow= assignmentExpression )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1353:4: first= assignmentExpression ( COMMA follow= assignmentExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignmentExpression_in_expression5077);
            	first = assignmentExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, first.Tree);
            	 retval.value =  first.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1353:57: ( COMMA follow= assignmentExpression )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( (LA54_0 == COMMA) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1353:59: COMMA follow= assignmentExpression
            			    {
            			    	COMMA80=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_expression5083); 
            			    		COMMA80_tree = (object)adaptor.Create(COMMA80);
            			    		adaptor.AddChild(root_0, COMMA80_tree);

            			    	 if(cs.Statements.Count == 0) { cs.Statements.Add(retval.value); retval.value =  cs; } 
            			    	PushFollow(FOLLOW_assignmentExpression_in_expression5089);
            			    	follow = assignmentExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, follow.Tree);
            			    	 cs.Statements.Add(follow.value); 

            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class expressionNoIn_return : ParserRuleReturnScope
    {
        public Expression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expressionNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1356:1: expressionNoIn returns [Expression value] : first= assignmentExpressionNoIn ( COMMA follow= assignmentExpressionNoIn )* ;
    public ES3Parser.expressionNoIn_return expressionNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.expressionNoIn_return retval = new ES3Parser.expressionNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA81 = null;
        ES3Parser.assignmentExpressionNoIn_return first = default(ES3Parser.assignmentExpressionNoIn_return);

        ES3Parser.assignmentExpressionNoIn_return follow = default(ES3Parser.assignmentExpressionNoIn_return);


        object COMMA81_tree=null;


        	var cs = new CommaOperatorStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1360:2: (first= assignmentExpressionNoIn ( COMMA follow= assignmentExpressionNoIn )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1360:4: first= assignmentExpressionNoIn ( COMMA follow= assignmentExpressionNoIn )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignmentExpressionNoIn_in_expressionNoIn5117);
            	first = assignmentExpressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, first.Tree);
            	 retval.value =  first.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1360:61: ( COMMA follow= assignmentExpressionNoIn )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == COMMA) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1360:63: COMMA follow= assignmentExpressionNoIn
            			    {
            			    	COMMA81=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_expressionNoIn5123); 
            			    		COMMA81_tree = (object)adaptor.Create(COMMA81);
            			    		adaptor.AddChild(root_0, COMMA81_tree);

            			    	if(cs.Statements.Count == 0) { cs.Statements.Add(retval.value); retval.value =  cs; } 
            			    	PushFollow(FOLLOW_assignmentExpressionNoIn_in_expressionNoIn5129);
            			    	follow = assignmentExpressionNoIn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, follow.Tree);
            			    	 cs.Statements.Add(follow.value); 

            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionNoIn"

    public class semic_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "semic"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1385:1: semic : ( SEMIC | EOF | RBRACE | EOL | MultiLineComment );
    public ES3Parser.semic_return semic() // throws RecognitionException [1]
    {   
        ES3Parser.semic_return retval = new ES3Parser.semic_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMIC82 = null;
        IToken EOF83 = null;
        IToken RBRACE84 = null;
        IToken EOL85 = null;
        IToken MultiLineComment86 = null;

        object SEMIC82_tree=null;
        object EOF83_tree=null;
        object RBRACE84_tree=null;
        object EOL85_tree=null;
        object MultiLineComment86_tree=null;


        	// Mark current position so we can unconsume a RBRACE.
        	int marker = input.Mark();
        	// Promote EOL if appropriate	
        	PromoteEOL(retval);

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1393:2: ( SEMIC | EOF | RBRACE | EOL | MultiLineComment )
            int alt56 = 5;
            switch ( input.LA(1) ) 
            {
            case SEMIC:
            	{
                alt56 = 1;
                }
                break;
            case EOF:
            	{
                alt56 = 2;
                }
                break;
            case RBRACE:
            	{
                alt56 = 3;
                }
                break;
            case EOL:
            	{
                alt56 = 4;
                }
                break;
            case MultiLineComment:
            	{
                alt56 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d56s0 =
            	        new NoViableAltException("", 56, 0, input);

            	    throw nvae_d56s0;
            }

            switch (alt56) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1393:4: SEMIC
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	SEMIC82=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_semic5163); 
                    		SEMIC82_tree = (object)adaptor.Create(SEMIC82);
                    		adaptor.AddChild(root_0, SEMIC82_tree);


                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1394:4: EOF
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	EOF83=(IToken)Match(input,EOF,FOLLOW_EOF_in_semic5168); 
                    		EOF83_tree = (object)adaptor.Create(EOF83);
                    		adaptor.AddChild(root_0, EOF83_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1395:4: RBRACE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	RBRACE84=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_semic5173); 
                    		RBRACE84_tree = (object)adaptor.Create(RBRACE84);
                    		adaptor.AddChild(root_0, RBRACE84_tree);

                    	 input.Rewind(marker); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1396:4: EOL
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	EOL85=(IToken)Match(input,EOL,FOLLOW_EOL_in_semic5180); 
                    		EOL85_tree = (object)adaptor.Create(EOL85);
                    		adaptor.AddChild(root_0, EOL85_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1396:10: MultiLineComment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	MultiLineComment86=(IToken)Match(input,MultiLineComment,FOLLOW_MultiLineComment_in_semic5184); 
                    		MultiLineComment86_tree = (object)adaptor.Create(MultiLineComment86);
                    		adaptor.AddChild(root_0, MultiLineComment86_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "semic"

    public class statement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1404:1: statement returns [Statement value] options {k=1; } : ({...}? block | {...}?func= functionDeclaration | statementTail );
    public ES3Parser.statement_return statement() // throws RecognitionException [1]
    {   
        ES3Parser.statement_return retval = new ES3Parser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.functionDeclaration_return func = default(ES3Parser.functionDeclaration_return);

        ES3Parser.block_return block87 = default(ES3Parser.block_return);

        ES3Parser.statementTail_return statementTail88 = default(ES3Parser.statementTail_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1410:2: ({...}? block | {...}?func= functionDeclaration | statementTail )
            int alt57 = 3;
            alt57 = dfa57.Predict(input);
            switch (alt57) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1410:4: {...}? block
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !(( input.LA(1) == LBRACE )) ) 
                    	{
                    	    throw new FailedPredicateException(input, "statement", " input.LA(1) == LBRACE ");
                    	}
                    	PushFollow(FOLLOW_block_in_statement5218);
                    	block87 = block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block87.Tree);
                    	 retval.value =  ((block87 != null) ? block87.value : default(BlockStatement)); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1411:4: {...}?func= functionDeclaration
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !(( input.LA(1) == FUNCTION )) ) 
                    	{
                    	    throw new FailedPredicateException(input, "statement", " input.LA(1) == FUNCTION ");
                    	}
                    	PushFollow(FOLLOW_functionDeclaration_in_statement5229);
                    	func = functionDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, func.Tree);
                    	 retval.value =  func.value; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1412:4: statementTail
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statementTail_in_statement5236);
                    	statementTail88 = statementTail();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, statementTail88.Tree);
                    	 retval.value =  ((statementTail88 != null) ? statementTail88.value : default(Statement)); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class statementTail_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statementTail"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1415:1: statementTail returns [Statement value] : ( variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement );
    public ES3Parser.statementTail_return statementTail() // throws RecognitionException [1]
    {   
        ES3Parser.statementTail_return retval = new ES3Parser.statementTail_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.variableStatement_return variableStatement89 = default(ES3Parser.variableStatement_return);

        ES3Parser.emptyStatement_return emptyStatement90 = default(ES3Parser.emptyStatement_return);

        ES3Parser.expressionStatement_return expressionStatement91 = default(ES3Parser.expressionStatement_return);

        ES3Parser.ifStatement_return ifStatement92 = default(ES3Parser.ifStatement_return);

        ES3Parser.iterationStatement_return iterationStatement93 = default(ES3Parser.iterationStatement_return);

        ES3Parser.continueStatement_return continueStatement94 = default(ES3Parser.continueStatement_return);

        ES3Parser.breakStatement_return breakStatement95 = default(ES3Parser.breakStatement_return);

        ES3Parser.returnStatement_return returnStatement96 = default(ES3Parser.returnStatement_return);

        ES3Parser.withStatement_return withStatement97 = default(ES3Parser.withStatement_return);

        ES3Parser.labelledStatement_return labelledStatement98 = default(ES3Parser.labelledStatement_return);

        ES3Parser.switchStatement_return switchStatement99 = default(ES3Parser.switchStatement_return);

        ES3Parser.throwStatement_return throwStatement100 = default(ES3Parser.throwStatement_return);

        ES3Parser.tryStatement_return tryStatement101 = default(ES3Parser.tryStatement_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1427:2: ( variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement )
            int alt58 = 13;
            alt58 = dfa58.Predict(input);
            switch (alt58) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1427:4: variableStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableStatement_in_statementTail5259);
                    	variableStatement89 = variableStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableStatement89.Tree);
                    	 retval.value =  ((variableStatement89 != null) ? variableStatement89.value : default(Statement)); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1428:4: emptyStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_emptyStatement_in_statementTail5266);
                    	emptyStatement90 = emptyStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, emptyStatement90.Tree);
                    	 retval.value =  ((emptyStatement90 != null) ? emptyStatement90.value : default(Statement)); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1429:4: expressionStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expressionStatement_in_statementTail5273);
                    	expressionStatement91 = expressionStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expressionStatement91.Tree);
                    	 retval.value =  ((expressionStatement91 != null) ? expressionStatement91.value : default(Statement)); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1430:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statementTail5280);
                    	ifStatement92 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement92.Tree);
                    	 retval.value =  ((ifStatement92 != null) ? ifStatement92.value : default(Statement)); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1431:4: iterationStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_iterationStatement_in_statementTail5287);
                    	iterationStatement93 = iterationStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, iterationStatement93.Tree);
                    	 retval.value =  ((iterationStatement93 != null) ? iterationStatement93.value : default(Statement)); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1432:4: continueStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_continueStatement_in_statementTail5294);
                    	continueStatement94 = continueStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, continueStatement94.Tree);
                    	 retval.value =  ((continueStatement94 != null) ? continueStatement94.value : default(Statement)); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1433:4: breakStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_breakStatement_in_statementTail5301);
                    	breakStatement95 = breakStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, breakStatement95.Tree);
                    	 retval.value =  ((breakStatement95 != null) ? breakStatement95.value : default(Statement)); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1434:4: returnStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_returnStatement_in_statementTail5308);
                    	returnStatement96 = returnStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, returnStatement96.Tree);
                    	 retval.value =  ((returnStatement96 != null) ? returnStatement96.value : default(ReturnStatement)); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1435:4: withStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_withStatement_in_statementTail5315);
                    	withStatement97 = withStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, withStatement97.Tree);
                    	 retval.value =  ((withStatement97 != null) ? withStatement97.value : default(Statement)); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1436:4: labelledStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_labelledStatement_in_statementTail5322);
                    	labelledStatement98 = labelledStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, labelledStatement98.Tree);
                    	 retval.value =  ((labelledStatement98 != null) ? labelledStatement98.value : default(Statement)); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1437:4: switchStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_switchStatement_in_statementTail5329);
                    	switchStatement99 = switchStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, switchStatement99.Tree);
                    	 retval.value =  ((switchStatement99 != null) ? switchStatement99.value : default(Statement)); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1438:4: throwStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_throwStatement_in_statementTail5336);
                    	throwStatement100 = throwStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, throwStatement100.Tree);
                    	 retval.value =  ((throwStatement100 != null) ? throwStatement100.value : default(Statement)); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1439:4: tryStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tryStatement_in_statementTail5343);
                    	tryStatement101 = tryStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tryStatement101.Tree);
                    	 retval.value =  ((tryStatement101 != null) ? tryStatement101.value : default(TryStatement)); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);

                    if (!(retval.value is ForStatement ||
                        retval.value is BlockStatement ||
                        retval.value is WhileStatement ||
                        retval.value is DoWhileStatement ||
                        retval.value is SwitchStatement ||
                        retval.value is TryStatement ||
                        retval.value is IfStatement)) {
                        retval.value.Source = ExtractSourceCode((CommonToken)retval.Start, (CommonToken)retval.Stop);
                    }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statementTail"

    public class block_return : ParserRuleReturnScope
    {
        public BlockStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1444:1: block returns [BlockStatement value] : lb= LBRACE ( statement )* RBRACE ;
    public ES3Parser.block_return block() // throws RecognitionException [1]
    {   
        ES3Parser.block_return retval = new ES3Parser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken RBRACE103 = null;
        ES3Parser.statement_return statement102 = default(ES3Parser.statement_return);


        object lb_tree=null;
        object RBRACE103_tree=null;


        	retval.value =  new BlockStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1451:2: (lb= LBRACE ( statement )* RBRACE )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1451:4: lb= LBRACE ( statement )* RBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	lb=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_block5373); 
            		lb_tree = (object)adaptor.Create(lb);
            		adaptor.AddChild(root_0, lb_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1451:14: ( statement )*
            	do 
            	{
            	    int alt59 = 2;
            	    int LA59_0 = input.LA(1);

            	    if ( ((LA59_0 >= NULL && LA59_0 <= BREAK) || LA59_0 == CONTINUE || (LA59_0 >= DELETE && LA59_0 <= DO) || (LA59_0 >= FOR && LA59_0 <= IF) || (LA59_0 >= NEW && LA59_0 <= WITH) || LA59_0 == LBRACE || LA59_0 == LPAREN || LA59_0 == LBRACK || LA59_0 == SEMIC || (LA59_0 >= ADD && LA59_0 <= SUB) || (LA59_0 >= INC && LA59_0 <= DEC) || (LA59_0 >= NOT && LA59_0 <= INV) || (LA59_0 >= Identifier && LA59_0 <= StringLiteral) || LA59_0 == RegularExpressionLiteral || (LA59_0 >= DecimalLiteral && LA59_0 <= HexIntegerLiteral)) )
            	    {
            	        alt59 = 1;
            	    }


            	    switch (alt59) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1451:15: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block5376);
            			    	statement102 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement102.Tree);
            			    	 retval.value.Statements.AddLast(((statement102 != null) ? statement102.value : default(Statement))); 

            			    }
            			    break;

            			default:
            			    goto loop59;
            	    }
            	} while (true);

            	loop59:
            		;	// Stops C# compiler whining that label 'loop59' has no statements

            	RBRACE103=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_block5382); 
            		RBRACE103_tree = (object)adaptor.Create(RBRACE103);
            		adaptor.AddChild(root_0, RBRACE103_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);

            	retval.value.Source = ExtractSourceCode((CommonToken)retval.Start, (CommonToken)retval.Stop);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block"

    public class variableStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1459:1: variableStatement returns [Statement value] : VAR first= variableDeclaration ( COMMA follow= variableDeclaration )* semic ;
    public ES3Parser.variableStatement_return variableStatement() // throws RecognitionException [1]
    {   
        ES3Parser.variableStatement_return retval = new ES3Parser.variableStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VAR104 = null;
        IToken COMMA105 = null;
        ES3Parser.variableDeclaration_return first = default(ES3Parser.variableDeclaration_return);

        ES3Parser.variableDeclaration_return follow = default(ES3Parser.variableDeclaration_return);

        ES3Parser.semic_return semic106 = default(ES3Parser.semic_return);


        object VAR104_tree=null;
        object COMMA105_tree=null;


        	var cs = new CommaOperatorStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1463:2: ( VAR first= variableDeclaration ( COMMA follow= variableDeclaration )* semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1463:4: VAR first= variableDeclaration ( COMMA follow= variableDeclaration )* semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VAR104=(IToken)Match(input,VAR,FOLLOW_VAR_in_variableStatement5408); 
            		VAR104_tree = (object)adaptor.Create(VAR104);
            		adaptor.AddChild(root_0, VAR104_tree);

            	PushFollow(FOLLOW_variableDeclaration_in_variableStatement5412);
            	first = variableDeclaration();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, first.Tree);
            	 first.value.Global = false; retval.value =  first.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1463:88: ( COMMA follow= variableDeclaration )*
            	do 
            	{
            	    int alt60 = 2;
            	    int LA60_0 = input.LA(1);

            	    if ( (LA60_0 == COMMA) )
            	    {
            	        alt60 = 1;
            	    }


            	    switch (alt60) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1463:90: COMMA follow= variableDeclaration
            			    {
            			    	COMMA105=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_variableStatement5418); 
            			    		COMMA105_tree = (object)adaptor.Create(COMMA105);
            			    		adaptor.AddChild(root_0, COMMA105_tree);

            			    	 if( cs.Statements.Count == 0) { cs.Statements.Add(retval.value); retval.value =  cs; } 
            			    	PushFollow(FOLLOW_variableDeclaration_in_variableStatement5424);
            			    	follow = variableDeclaration();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, follow.Tree);
            			    	 cs.Statements.Add(follow.value); follow.value.Global = false; 

            			    }
            			    break;

            			default:
            			    goto loop60;
            	    }
            	} while (true);

            	loop60:
            		;	// Stops C# compiler whining that label 'loop60' has no statements

            	PushFollow(FOLLOW_semic_in_variableStatement5432);
            	semic106 = semic();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, semic106.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableStatement"

    public class variableDeclaration_return : ParserRuleReturnScope
    {
        public VariableDeclarationStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclaration"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1467:1: variableDeclaration returns [VariableDeclarationStatement value] : id= Identifier ( ASSIGN ass= assignmentExpression )? ;
    public ES3Parser.variableDeclaration_return variableDeclaration() // throws RecognitionException [1]
    {   
        ES3Parser.variableDeclaration_return retval = new ES3Parser.variableDeclaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken ASSIGN107 = null;
        ES3Parser.assignmentExpression_return ass = default(ES3Parser.assignmentExpression_return);


        object id_tree=null;
        object ASSIGN107_tree=null;


        	retval.value =  new VariableDeclarationStatement();
        	retval.value.Global = true;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1472:2: (id= Identifier ( ASSIGN ass= assignmentExpression )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1472:4: id= Identifier ( ASSIGN ass= assignmentExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	id=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableDeclaration5456); 
            		id_tree = (object)adaptor.Create(id);
            		adaptor.AddChild(root_0, id_tree);

            	 retval.value.Identifier = id.Text; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1472:51: ( ASSIGN ass= assignmentExpression )?
            	int alt61 = 2;
            	int LA61_0 = input.LA(1);

            	if ( (LA61_0 == ASSIGN) )
            	{
            	    alt61 = 1;
            	}
            	switch (alt61) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1472:53: ASSIGN ass= assignmentExpression
            	        {
            	        	ASSIGN107=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableDeclaration5462); 
            	        		ASSIGN107_tree = (object)adaptor.Create(ASSIGN107);
            	        		root_0 = (object)adaptor.BecomeRoot(ASSIGN107_tree, root_0);

            	        	PushFollow(FOLLOW_assignmentExpression_in_variableDeclaration5467);
            	        	ass = assignmentExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, ass.Tree);
            	        	 retval.value.Expression = ass.value; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclaration"

    public class variableDeclarationNoIn_return : ParserRuleReturnScope
    {
        public VariableDeclarationStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclarationNoIn"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1475:1: variableDeclarationNoIn returns [VariableDeclarationStatement value] : id= Identifier ( ASSIGN ass= assignmentExpressionNoIn )? ;
    public ES3Parser.variableDeclarationNoIn_return variableDeclarationNoIn() // throws RecognitionException [1]
    {   
        ES3Parser.variableDeclarationNoIn_return retval = new ES3Parser.variableDeclarationNoIn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken ASSIGN108 = null;
        ES3Parser.assignmentExpressionNoIn_return ass = default(ES3Parser.assignmentExpressionNoIn_return);


        object id_tree=null;
        object ASSIGN108_tree=null;


        	retval.value =  new VariableDeclarationStatement();
        	retval.value.Global = true;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1480:2: (id= Identifier ( ASSIGN ass= assignmentExpressionNoIn )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1480:4: id= Identifier ( ASSIGN ass= assignmentExpressionNoIn )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	id=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableDeclarationNoIn5495); 
            		id_tree = (object)adaptor.Create(id);
            		adaptor.AddChild(root_0, id_tree);

            	 retval.value.Identifier = id.Text; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1480:51: ( ASSIGN ass= assignmentExpressionNoIn )?
            	int alt62 = 2;
            	int LA62_0 = input.LA(1);

            	if ( (LA62_0 == ASSIGN) )
            	{
            	    alt62 = 1;
            	}
            	switch (alt62) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1480:53: ASSIGN ass= assignmentExpressionNoIn
            	        {
            	        	ASSIGN108=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableDeclarationNoIn5501); 
            	        		ASSIGN108_tree = (object)adaptor.Create(ASSIGN108);
            	        		root_0 = (object)adaptor.BecomeRoot(ASSIGN108_tree, root_0);

            	        	PushFollow(FOLLOW_assignmentExpressionNoIn_in_variableDeclarationNoIn5506);
            	        	ass = assignmentExpressionNoIn();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, ass.Tree);
            	        	 retval.value.Expression = ass.value; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclarationNoIn"

    public class emptyStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "emptyStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1487:1: emptyStatement returns [Statement value] : SEMIC ;
    public ES3Parser.emptyStatement_return emptyStatement() // throws RecognitionException [1]
    {   
        ES3Parser.emptyStatement_return retval = new ES3Parser.emptyStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMIC109 = null;

        object SEMIC109_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1488:2: ( SEMIC )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1488:4: SEMIC
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SEMIC109=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_emptyStatement5531); 
            	 retval.value =  new EmptyStatement(); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "emptyStatement"

    public class expressionStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expressionStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1501:1: expressionStatement returns [Statement value] : expression semic ;
    public ES3Parser.expressionStatement_return expressionStatement() // throws RecognitionException [1]
    {   
        ES3Parser.expressionStatement_return retval = new ES3Parser.expressionStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.expression_return expression110 = default(ES3Parser.expression_return);

        ES3Parser.semic_return semic111 = default(ES3Parser.semic_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1502:2: ( expression semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1502:4: expression semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionStatement5556);
            	expression110 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression110.Tree);
            	PushFollow(FOLLOW_semic_in_expressionStatement5558);
            	semic111 = semic();
            	state.followingStackPointer--;

            	 retval.value =  new ExpressionStatement(((expression110 != null) ? expression110.value : default(Expression))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionStatement"

    public class ifStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1509:1: ifStatement returns [Statement value] : IF LPAREN expression RPAREN then= statement ({...}? ELSE els= statement )? ;
    public ES3Parser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        ES3Parser.ifStatement_return retval = new ES3Parser.ifStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF112 = null;
        IToken LPAREN113 = null;
        IToken RPAREN115 = null;
        IToken ELSE116 = null;
        ES3Parser.statement_return then = default(ES3Parser.statement_return);

        ES3Parser.statement_return els = default(ES3Parser.statement_return);

        ES3Parser.expression_return expression114 = default(ES3Parser.expression_return);


        object IF112_tree=null;
        object LPAREN113_tree=null;
        object RPAREN115_tree=null;
        object ELSE116_tree=null;


        var st = new IfStatement();
        retval.value =  st;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1515:2: ( IF LPAREN expression RPAREN then= statement ({...}? ELSE els= statement )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1515:4: IF LPAREN expression RPAREN then= statement ({...}? ELSE els= statement )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IF112=(IToken)Match(input,IF,FOLLOW_IF_in_ifStatement5587); 
            		IF112_tree = (object)adaptor.Create(IF112);
            		adaptor.AddChild(root_0, IF112_tree);

            	LPAREN113=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_ifStatement5589); 
            		LPAREN113_tree = (object)adaptor.Create(LPAREN113);
            		adaptor.AddChild(root_0, LPAREN113_tree);

            	PushFollow(FOLLOW_expression_in_ifStatement5591);
            	expression114 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression114.Tree);
            	 st.Expression = ((expression114 != null) ? expression114.value : default(Expression)); 
            	RPAREN115=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_ifStatement5595); 
            		RPAREN115_tree = (object)adaptor.Create(RPAREN115);
            		adaptor.AddChild(root_0, RPAREN115_tree);

            	PushFollow(FOLLOW_statement_in_ifStatement5599);
            	then = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, then.Tree);
            	 st.Then = ((then != null) ? then.value : default(Statement)); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1515:113: ({...}? ELSE els= statement )?
            	int alt63 = 2;
            	int LA63_0 = input.LA(1);

            	if ( (LA63_0 == ELSE) )
            	{
            	    int LA63_1 = input.LA(2);

            	    if ( (( input.LA(1) == ELSE )) )
            	    {
            	        alt63 = 1;
            	    }
            	}
            	switch (alt63) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1515:115: {...}? ELSE els= statement
            	        {
            	        	if ( !(( input.LA(1) == ELSE )) ) 
            	        	{
            	        	    throw new FailedPredicateException(input, "ifStatement", " input.LA(1) == ELSE ");
            	        	}
            	        	ELSE116=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_ifStatement5607); 
            	        		ELSE116_tree = (object)adaptor.Create(ELSE116);
            	        		adaptor.AddChild(root_0, ELSE116_tree);

            	        	PushFollow(FOLLOW_statement_in_ifStatement5611);
            	        	els = statement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, els.Tree);
            	        	 st.Else = ((els != null) ? els.value : default(Statement)); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifStatement"

    public class iterationStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "iterationStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1524:1: iterationStatement returns [Statement value] : (dos= doStatement | wh= whileStatement | fo= forStatement );
    public ES3Parser.iterationStatement_return iterationStatement() // throws RecognitionException [1]
    {   
        ES3Parser.iterationStatement_return retval = new ES3Parser.iterationStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.doStatement_return dos = default(ES3Parser.doStatement_return);

        ES3Parser.whileStatement_return wh = default(ES3Parser.whileStatement_return);

        ES3Parser.forStatement_return fo = default(ES3Parser.forStatement_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1525:2: (dos= doStatement | wh= whileStatement | fo= forStatement )
            int alt64 = 3;
            switch ( input.LA(1) ) 
            {
            case DO:
            	{
                alt64 = 1;
                }
                break;
            case WHILE:
            	{
                alt64 = 2;
                }
                break;
            case FOR:
            	{
                alt64 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d64s0 =
            	        new NoViableAltException("", 64, 0, input);

            	    throw nvae_d64s0;
            }

            switch (alt64) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1525:4: dos= doStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doStatement_in_iterationStatement5641);
                    	dos = doStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, dos.Tree);
                    	 retval.value =  dos.value; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1526:4: wh= whileStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_iterationStatement5650);
                    	wh = whileStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, wh.Tree);
                    	 retval.value =  wh.value; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1527:4: fo= forStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forStatement_in_iterationStatement5660);
                    	fo = forStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fo.Tree);
                    	 retval.value =  (Statement)fo.value; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "iterationStatement"

    public class doStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "doStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1530:1: doStatement returns [Statement value] : DO statement WHILE LPAREN expression RPAREN semic ;
    public ES3Parser.doStatement_return doStatement() // throws RecognitionException [1]
    {   
        ES3Parser.doStatement_return retval = new ES3Parser.doStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DO117 = null;
        IToken WHILE119 = null;
        IToken LPAREN120 = null;
        IToken RPAREN122 = null;
        ES3Parser.statement_return statement118 = default(ES3Parser.statement_return);

        ES3Parser.expression_return expression121 = default(ES3Parser.expression_return);

        ES3Parser.semic_return semic123 = default(ES3Parser.semic_return);


        object DO117_tree=null;
        object WHILE119_tree=null;
        object LPAREN120_tree=null;
        object RPAREN122_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1531:2: ( DO statement WHILE LPAREN expression RPAREN semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1531:4: DO statement WHILE LPAREN expression RPAREN semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	DO117=(IToken)Match(input,DO,FOLLOW_DO_in_doStatement5679); 
            		DO117_tree = (object)adaptor.Create(DO117);
            		adaptor.AddChild(root_0, DO117_tree);

            	PushFollow(FOLLOW_statement_in_doStatement5681);
            	statement118 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement118.Tree);
            	WHILE119=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_doStatement5683); 
            		WHILE119_tree = (object)adaptor.Create(WHILE119);
            		adaptor.AddChild(root_0, WHILE119_tree);

            	LPAREN120=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_doStatement5685); 
            		LPAREN120_tree = (object)adaptor.Create(LPAREN120);
            		adaptor.AddChild(root_0, LPAREN120_tree);

            	PushFollow(FOLLOW_expression_in_doStatement5687);
            	expression121 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression121.Tree);
            	RPAREN122=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_doStatement5689); 
            		RPAREN122_tree = (object)adaptor.Create(RPAREN122);
            		adaptor.AddChild(root_0, RPAREN122_tree);

            	PushFollow(FOLLOW_semic_in_doStatement5691);
            	semic123 = semic();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, semic123.Tree);
            	 retval.value =  new DoWhileStatement(((expression121 != null) ? expression121.value : default(Expression)), ((statement118 != null) ? statement118.value : default(Statement))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "doStatement"

    public class whileStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "whileStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1535:1: whileStatement returns [Statement value] : WHILE LPAREN expression RPAREN statement ;
    public ES3Parser.whileStatement_return whileStatement() // throws RecognitionException [1]
    {   
        ES3Parser.whileStatement_return retval = new ES3Parser.whileStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE124 = null;
        IToken LPAREN125 = null;
        IToken RPAREN127 = null;
        ES3Parser.expression_return expression126 = default(ES3Parser.expression_return);

        ES3Parser.statement_return statement128 = default(ES3Parser.statement_return);


        object WHILE124_tree=null;
        object LPAREN125_tree=null;
        object RPAREN127_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1536:2: ( WHILE LPAREN expression RPAREN statement )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1536:4: WHILE LPAREN expression RPAREN statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	WHILE124=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_whileStatement5711); 
            		WHILE124_tree = (object)adaptor.Create(WHILE124);
            		root_0 = (object)adaptor.BecomeRoot(WHILE124_tree, root_0);

            	LPAREN125=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_whileStatement5714); 
            	PushFollow(FOLLOW_expression_in_whileStatement5717);
            	expression126 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression126.Tree);
            	RPAREN127=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_whileStatement5719); 
            	PushFollow(FOLLOW_statement_in_whileStatement5722);
            	statement128 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement128.Tree);
            	 retval.value =  new WhileStatement(((expression126 != null) ? expression126.value : default(Expression)), ((statement128 != null) ? statement128.value : default(Statement))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whileStatement"

    public class forStatement_return : ParserRuleReturnScope
    {
        public IForStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1580:1: forStatement returns [IForStatement value] : FOR LPAREN fo= forControl RPAREN st= statement ;
    public ES3Parser.forStatement_return forStatement() // throws RecognitionException [1]
    {   
        ES3Parser.forStatement_return retval = new ES3Parser.forStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR129 = null;
        IToken LPAREN130 = null;
        IToken RPAREN131 = null;
        ES3Parser.forControl_return fo = default(ES3Parser.forControl_return);

        ES3Parser.statement_return st = default(ES3Parser.statement_return);


        object FOR129_tree=null;
        object LPAREN130_tree=null;
        object RPAREN131_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1581:2: ( FOR LPAREN fo= forControl RPAREN st= statement )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1581:4: FOR LPAREN fo= forControl RPAREN st= statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	FOR129=(IToken)Match(input,FOR,FOLLOW_FOR_in_forStatement5741); 
            		FOR129_tree = (object)adaptor.Create(FOR129);
            		root_0 = (object)adaptor.BecomeRoot(FOR129_tree, root_0);

            	LPAREN130=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_forStatement5744); 
            	PushFollow(FOLLOW_forControl_in_forStatement5749);
            	fo = forControl();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, fo.Tree);
            	 retval.value =  fo.value; 
            	RPAREN131=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_forStatement5754); 
            	PushFollow(FOLLOW_statement_in_forStatement5759);
            	st = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, st.Tree);
            	  retval.value.Statement = st.value; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forStatement"

    public class forControl_return : ParserRuleReturnScope
    {
        public IForStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forControl"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1584:1: forControl returns [IForStatement value] : (ex1= forControlVar | ex2= forControlExpression | ex3= forControlSemic );
    public ES3Parser.forControl_return forControl() // throws RecognitionException [1]
    {   
        ES3Parser.forControl_return retval = new ES3Parser.forControl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.forControlVar_return ex1 = default(ES3Parser.forControlVar_return);

        ES3Parser.forControlExpression_return ex2 = default(ES3Parser.forControlExpression_return);

        ES3Parser.forControlSemic_return ex3 = default(ES3Parser.forControlSemic_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1585:2: (ex1= forControlVar | ex2= forControlExpression | ex3= forControlSemic )
            int alt65 = 3;
            switch ( input.LA(1) ) 
            {
            case VAR:
            	{
                alt65 = 1;
                }
                break;
            case NULL:
            case TRUE:
            case FALSE:
            case DELETE:
            case FUNCTION:
            case NEW:
            case THIS:
            case TYPEOF:
            case VOID:
            case LBRACE:
            case LPAREN:
            case LBRACK:
            case ADD:
            case SUB:
            case INC:
            case DEC:
            case NOT:
            case INV:
            case Identifier:
            case StringLiteral:
            case RegularExpressionLiteral:
            case DecimalLiteral:
            case OctalIntegerLiteral:
            case HexIntegerLiteral:
            	{
                alt65 = 2;
                }
                break;
            case SEMIC:
            	{
                alt65 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d65s0 =
            	        new NoViableAltException("", 65, 0, input);

            	    throw nvae_d65s0;
            }

            switch (alt65) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1585:4: ex1= forControlVar
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forControlVar_in_forControl5778);
                    	ex1 = forControlVar();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex1.Tree);
                    	 retval.value =  ex1.value; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1586:4: ex2= forControlExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forControlExpression_in_forControl5787);
                    	ex2 = forControlExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex2.Tree);
                    	 retval.value =  ex2.value; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1587:4: ex3= forControlSemic
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forControlSemic_in_forControl5796);
                    	ex3 = forControlSemic();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ex3.Tree);
                    	 retval.value =  ex3.value; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forControl"

    public class forControlVar_return : ParserRuleReturnScope
    {
        public IForStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forControlVar"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1590:1: forControlVar returns [IForStatement value] : VAR first= variableDeclarationNoIn ( ( IN ex= expression ) | ( ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )? ) ) ;
    public ES3Parser.forControlVar_return forControlVar() // throws RecognitionException [1]
    {   
        ES3Parser.forControlVar_return retval = new ES3Parser.forControlVar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VAR132 = null;
        IToken IN133 = null;
        IToken COMMA134 = null;
        IToken SEMIC135 = null;
        IToken SEMIC136 = null;
        ES3Parser.variableDeclarationNoIn_return first = default(ES3Parser.variableDeclarationNoIn_return);

        ES3Parser.expression_return ex = default(ES3Parser.expression_return);

        ES3Parser.variableDeclarationNoIn_return follow = default(ES3Parser.variableDeclarationNoIn_return);

        ES3Parser.expression_return ex1 = default(ES3Parser.expression_return);

        ES3Parser.expression_return ex2 = default(ES3Parser.expression_return);


        object VAR132_tree=null;
        object IN133_tree=null;
        object COMMA134_tree=null;
        object SEMIC135_tree=null;
        object SEMIC136_tree=null;


        	var forStatement = new ForStatement();
        	var foreachStatement = new ForEachInStatement();
        	var cs = new CommaOperatorStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1597:2: ( VAR first= variableDeclarationNoIn ( ( IN ex= expression ) | ( ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )? ) ) )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1597:4: VAR first= variableDeclarationNoIn ( ( IN ex= expression ) | ( ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )? ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VAR132=(IToken)Match(input,VAR,FOLLOW_VAR_in_forControlVar5819); 
            		VAR132_tree = (object)adaptor.Create(VAR132);
            		adaptor.AddChild(root_0, VAR132_tree);

            	PushFollow(FOLLOW_variableDeclarationNoIn_in_forControlVar5823);
            	first = variableDeclarationNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, first.Tree);
            	 foreachStatement.InitialisationStatement = forStatement.InitialisationStatement = first.value; first.value.Global = false;  
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1598:2: ( ( IN ex= expression ) | ( ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )? ) )
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == IN) )
            	{
            	    alt69 = 1;
            	}
            	else if ( ((LA69_0 >= SEMIC && LA69_0 <= COMMA)) )
            	{
            	    alt69 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d69s0 =
            	        new NoViableAltException("", 69, 0, input);

            	    throw nvae_d69s0;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1599:3: ( IN ex= expression )
            	        {
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1599:3: ( IN ex= expression )
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1600:4: IN ex= expression
            	        	{
            	        		IN133=(IToken)Match(input,IN,FOLLOW_IN_in_forControlVar5837); 
            	        			IN133_tree = (object)adaptor.Create(IN133);
            	        			adaptor.AddChild(root_0, IN133_tree);

            	        		PushFollow(FOLLOW_expression_in_forControlVar5841);
            	        		ex = expression();
            	        		state.followingStackPointer--;

            	        		adaptor.AddChild(root_0, ex.Tree);
            	        		 retval.value =  foreachStatement; foreachStatement.Expression = ((ex != null) ? ex.value : default(Expression)); 

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1604:3: ( ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )? )
            	        {
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1604:3: ( ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )? )
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1605:4: ( COMMA follow= variableDeclarationNoIn )* SEMIC (ex1= expression )? SEMIC (ex2= expression )?
            	        	{
            	        		// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1605:4: ( COMMA follow= variableDeclarationNoIn )*
            	        		do 
            	        		{
            	        		    int alt66 = 2;
            	        		    int LA66_0 = input.LA(1);

            	        		    if ( (LA66_0 == COMMA) )
            	        		    {
            	        		        alt66 = 1;
            	        		    }


            	        		    switch (alt66) 
            	        			{
            	        				case 1 :
            	        				    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1605:6: COMMA follow= variableDeclarationNoIn
            	        				    {
            	        				    	COMMA134=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_forControlVar5866); 
            	        				    		COMMA134_tree = (object)adaptor.Create(COMMA134);
            	        				    		adaptor.AddChild(root_0, COMMA134_tree);

            	        				    	 if( cs.Statements.Count == 0) { foreachStatement.InitialisationStatement = forStatement.InitialisationStatement = cs; cs.Statements.Add(first.value); } 
            	        				    	PushFollow(FOLLOW_variableDeclarationNoIn_in_forControlVar5872);
            	        				    	follow = variableDeclarationNoIn();
            	        				    	state.followingStackPointer--;

            	        				    	adaptor.AddChild(root_0, follow.Tree);
            	        				    	  follow.value.Global = false; cs.Statements.Add(follow.value); 

            	        				    }
            	        				    break;

            	        				default:
            	        				    goto loop66;
            	        		    }
            	        		} while (true);

            	        		loop66:
            	        			;	// Stops C# compiler whining that label 'loop66' has no statements

            	        		SEMIC135=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_forControlVar5883); 
            	        			SEMIC135_tree = (object)adaptor.Create(SEMIC135);
            	        			adaptor.AddChild(root_0, SEMIC135_tree);

            	        		// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1606:10: (ex1= expression )?
            	        		int alt67 = 2;
            	        		int LA67_0 = input.LA(1);

            	        		if ( ((LA67_0 >= NULL && LA67_0 <= FALSE) || LA67_0 == DELETE || LA67_0 == FUNCTION || LA67_0 == NEW || LA67_0 == THIS || LA67_0 == TYPEOF || LA67_0 == VOID || LA67_0 == LBRACE || LA67_0 == LPAREN || LA67_0 == LBRACK || (LA67_0 >= ADD && LA67_0 <= SUB) || (LA67_0 >= INC && LA67_0 <= DEC) || (LA67_0 >= NOT && LA67_0 <= INV) || (LA67_0 >= Identifier && LA67_0 <= StringLiteral) || LA67_0 == RegularExpressionLiteral || (LA67_0 >= DecimalLiteral && LA67_0 <= HexIntegerLiteral)) )
            	        		{
            	        		    alt67 = 1;
            	        		}
            	        		switch (alt67) 
            	        		{
            	        		    case 1 :
            	        		        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1606:12: ex1= expression
            	        		        {
            	        		        	PushFollow(FOLLOW_expression_in_forControlVar5889);
            	        		        	ex1 = expression();
            	        		        	state.followingStackPointer--;

            	        		        	adaptor.AddChild(root_0, ex1.Tree);
            	        		        	 forStatement.ConditionExpression = ((ex1 != null) ? ex1.value : default(Expression));

            	        		        }
            	        		        break;

            	        		}

            	        		SEMIC136=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_forControlVar5897); 
            	        			SEMIC136_tree = (object)adaptor.Create(SEMIC136);
            	        			adaptor.AddChild(root_0, SEMIC136_tree);

            	        		// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1606:87: (ex2= expression )?
            	        		int alt68 = 2;
            	        		int LA68_0 = input.LA(1);

            	        		if ( ((LA68_0 >= NULL && LA68_0 <= FALSE) || LA68_0 == DELETE || LA68_0 == FUNCTION || LA68_0 == NEW || LA68_0 == THIS || LA68_0 == TYPEOF || LA68_0 == VOID || LA68_0 == LBRACE || LA68_0 == LPAREN || LA68_0 == LBRACK || (LA68_0 >= ADD && LA68_0 <= SUB) || (LA68_0 >= INC && LA68_0 <= DEC) || (LA68_0 >= NOT && LA68_0 <= INV) || (LA68_0 >= Identifier && LA68_0 <= StringLiteral) || LA68_0 == RegularExpressionLiteral || (LA68_0 >= DecimalLiteral && LA68_0 <= HexIntegerLiteral)) )
            	        		{
            	        		    alt68 = 1;
            	        		}
            	        		switch (alt68) 
            	        		{
            	        		    case 1 :
            	        		        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1606:88: ex2= expression
            	        		        {
            	        		        	PushFollow(FOLLOW_expression_in_forControlVar5902);
            	        		        	ex2 = expression();
            	        		        	state.followingStackPointer--;

            	        		        	adaptor.AddChild(root_0, ex2.Tree);
            	        		        	  forStatement.IncrementExpression = ((ex2 != null) ? ex2.value : default(Expression)); 

            	        		        }
            	        		        break;

            	        		}

            	        		 retval.value =  forStatement; 

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forControlVar"

    public class forControlExpression_return : ParserRuleReturnScope
    {
        public IForStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forControlExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1612:1: forControlExpression returns [IForStatement value] : ex1= expressionNoIn ({...}? ( IN ex2= expression ) | ( SEMIC (ex2= expression )? SEMIC (ex3= expression )? ) ) ;
    public ES3Parser.forControlExpression_return forControlExpression() // throws RecognitionException [1]
    {   
        ES3Parser.forControlExpression_return retval = new ES3Parser.forControlExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IN137 = null;
        IToken SEMIC138 = null;
        IToken SEMIC139 = null;
        ES3Parser.expressionNoIn_return ex1 = default(ES3Parser.expressionNoIn_return);

        ES3Parser.expression_return ex2 = default(ES3Parser.expression_return);

        ES3Parser.expression_return ex3 = default(ES3Parser.expression_return);


        object IN137_tree=null;
        object SEMIC138_tree=null;
        object SEMIC139_tree=null;


        	var forStatement = new ForStatement();
        	var foreachStatement = new ForEachInStatement();

        	object[] isLhs = new object[1];

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1620:2: (ex1= expressionNoIn ({...}? ( IN ex2= expression ) | ( SEMIC (ex2= expression )? SEMIC (ex3= expression )? ) ) )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1620:4: ex1= expressionNoIn ({...}? ( IN ex2= expression ) | ( SEMIC (ex2= expression )? SEMIC (ex3= expression )? ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expressionNoIn_in_forControlExpression5941);
            	ex1 = expressionNoIn();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, ex1.Tree);
            	 foreachStatement.InitialisationStatement = forStatement.InitialisationStatement = ex1.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1621:2: ({...}? ( IN ex2= expression ) | ( SEMIC (ex2= expression )? SEMIC (ex3= expression )? ) )
            	int alt72 = 2;
            	int LA72_0 = input.LA(1);

            	if ( (LA72_0 == IN) )
            	{
            	    alt72 = 1;
            	}
            	else if ( (LA72_0 == SEMIC) )
            	{
            	    alt72 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d72s0 =
            	        new NoViableAltException("", 72, 0, input);

            	    throw nvae_d72s0;
            	}
            	switch (alt72) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1622:3: {...}? ( IN ex2= expression )
            	        {
            	        	if ( !(( IsLeftHandSideIn(ex1.value, isLhs) )) ) 
            	        	{
            	        	    throw new FailedPredicateException(input, "forControlExpression", " IsLeftHandSideIn(ex1.value, isLhs) ");
            	        	}
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1622:43: ( IN ex2= expression )
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1623:4: IN ex2= expression
            	        	{
            	        		IN137=(IToken)Match(input,IN,FOLLOW_IN_in_forControlExpression5958); 
            	        			IN137_tree = (object)adaptor.Create(IN137);
            	        			adaptor.AddChild(root_0, IN137_tree);

            	        		PushFollow(FOLLOW_expression_in_forControlExpression5962);
            	        		ex2 = expression();
            	        		state.followingStackPointer--;

            	        		adaptor.AddChild(root_0, ex2.Tree);
            	        		 retval.value =  foreachStatement; foreachStatement.Expression = ex2.value; 

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1627:3: ( SEMIC (ex2= expression )? SEMIC (ex3= expression )? )
            	        {
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1627:3: ( SEMIC (ex2= expression )? SEMIC (ex3= expression )? )
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1628:4: SEMIC (ex2= expression )? SEMIC (ex3= expression )?
            	        	{
            	        		SEMIC138=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_forControlExpression5985); 
            	        			SEMIC138_tree = (object)adaptor.Create(SEMIC138);
            	        			adaptor.AddChild(root_0, SEMIC138_tree);

            	        		// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1628:10: (ex2= expression )?
            	        		int alt70 = 2;
            	        		int LA70_0 = input.LA(1);

            	        		if ( ((LA70_0 >= NULL && LA70_0 <= FALSE) || LA70_0 == DELETE || LA70_0 == FUNCTION || LA70_0 == NEW || LA70_0 == THIS || LA70_0 == TYPEOF || LA70_0 == VOID || LA70_0 == LBRACE || LA70_0 == LPAREN || LA70_0 == LBRACK || (LA70_0 >= ADD && LA70_0 <= SUB) || (LA70_0 >= INC && LA70_0 <= DEC) || (LA70_0 >= NOT && LA70_0 <= INV) || (LA70_0 >= Identifier && LA70_0 <= StringLiteral) || LA70_0 == RegularExpressionLiteral || (LA70_0 >= DecimalLiteral && LA70_0 <= HexIntegerLiteral)) )
            	        		{
            	        		    alt70 = 1;
            	        		}
            	        		switch (alt70) 
            	        		{
            	        		    case 1 :
            	        		        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1628:12: ex2= expression
            	        		        {
            	        		        	PushFollow(FOLLOW_expression_in_forControlExpression5991);
            	        		        	ex2 = expression();
            	        		        	state.followingStackPointer--;

            	        		        	adaptor.AddChild(root_0, ex2.Tree);
            	        		        	 forStatement.ConditionExpression = ex2.value;

            	        		        }
            	        		        break;

            	        		}

            	        		SEMIC139=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_forControlExpression5999); 
            	        			SEMIC139_tree = (object)adaptor.Create(SEMIC139);
            	        			adaptor.AddChild(root_0, SEMIC139_tree);

            	        		// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1628:86: (ex3= expression )?
            	        		int alt71 = 2;
            	        		int LA71_0 = input.LA(1);

            	        		if ( ((LA71_0 >= NULL && LA71_0 <= FALSE) || LA71_0 == DELETE || LA71_0 == FUNCTION || LA71_0 == NEW || LA71_0 == THIS || LA71_0 == TYPEOF || LA71_0 == VOID || LA71_0 == LBRACE || LA71_0 == LPAREN || LA71_0 == LBRACK || (LA71_0 >= ADD && LA71_0 <= SUB) || (LA71_0 >= INC && LA71_0 <= DEC) || (LA71_0 >= NOT && LA71_0 <= INV) || (LA71_0 >= Identifier && LA71_0 <= StringLiteral) || LA71_0 == RegularExpressionLiteral || (LA71_0 >= DecimalLiteral && LA71_0 <= HexIntegerLiteral)) )
            	        		{
            	        		    alt71 = 1;
            	        		}
            	        		switch (alt71) 
            	        		{
            	        		    case 1 :
            	        		        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1628:87: ex3= expression
            	        		        {
            	        		        	PushFollow(FOLLOW_expression_in_forControlExpression6004);
            	        		        	ex3 = expression();
            	        		        	state.followingStackPointer--;

            	        		        	adaptor.AddChild(root_0, ex3.Tree);
            	        		        	  forStatement.IncrementExpression = ex3.value; 

            	        		        }
            	        		        break;

            	        		}

            	        		 retval.value =  forStatement; 

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forControlExpression"

    public class forControlSemic_return : ParserRuleReturnScope
    {
        public ForStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forControlSemic"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1634:1: forControlSemic returns [ForStatement value] : SEMIC (ex1= expression )? SEMIC (ex2= expression )? ;
    public ES3Parser.forControlSemic_return forControlSemic() // throws RecognitionException [1]
    {   
        ES3Parser.forControlSemic_return retval = new ES3Parser.forControlSemic_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMIC140 = null;
        IToken SEMIC141 = null;
        ES3Parser.expression_return ex1 = default(ES3Parser.expression_return);

        ES3Parser.expression_return ex2 = default(ES3Parser.expression_return);


        object SEMIC140_tree=null;
        object SEMIC141_tree=null;


        	retval.value =  new ForStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1638:2: ( SEMIC (ex1= expression )? SEMIC (ex2= expression )? )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1638:4: SEMIC (ex1= expression )? SEMIC (ex2= expression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SEMIC140=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_forControlSemic6040); 
            		SEMIC140_tree = (object)adaptor.Create(SEMIC140);
            		adaptor.AddChild(root_0, SEMIC140_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1638:10: (ex1= expression )?
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);

            	if ( ((LA73_0 >= NULL && LA73_0 <= FALSE) || LA73_0 == DELETE || LA73_0 == FUNCTION || LA73_0 == NEW || LA73_0 == THIS || LA73_0 == TYPEOF || LA73_0 == VOID || LA73_0 == LBRACE || LA73_0 == LPAREN || LA73_0 == LBRACK || (LA73_0 >= ADD && LA73_0 <= SUB) || (LA73_0 >= INC && LA73_0 <= DEC) || (LA73_0 >= NOT && LA73_0 <= INV) || (LA73_0 >= Identifier && LA73_0 <= StringLiteral) || LA73_0 == RegularExpressionLiteral || (LA73_0 >= DecimalLiteral && LA73_0 <= HexIntegerLiteral)) )
            	{
            	    alt73 = 1;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1638:12: ex1= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControlSemic6046);
            	        	ex1 = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, ex1.Tree);
            	        	 retval.value.ConditionExpression = ex1.value;

            	        }
            	        break;

            	}

            	SEMIC141=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_forControlSemic6054); 
            		SEMIC141_tree = (object)adaptor.Create(SEMIC141);
            		adaptor.AddChild(root_0, SEMIC141_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1638:80: (ex2= expression )?
            	int alt74 = 2;
            	int LA74_0 = input.LA(1);

            	if ( ((LA74_0 >= NULL && LA74_0 <= FALSE) || LA74_0 == DELETE || LA74_0 == FUNCTION || LA74_0 == NEW || LA74_0 == THIS || LA74_0 == TYPEOF || LA74_0 == VOID || LA74_0 == LBRACE || LA74_0 == LPAREN || LA74_0 == LBRACK || (LA74_0 >= ADD && LA74_0 <= SUB) || (LA74_0 >= INC && LA74_0 <= DEC) || (LA74_0 >= NOT && LA74_0 <= INV) || (LA74_0 >= Identifier && LA74_0 <= StringLiteral) || LA74_0 == RegularExpressionLiteral || (LA74_0 >= DecimalLiteral && LA74_0 <= HexIntegerLiteral)) )
            	{
            	    alt74 = 1;
            	}
            	switch (alt74) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1638:81: ex2= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControlSemic6059);
            	        	ex2 = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, ex2.Tree);
            	        	  retval.value.IncrementExpression = ex2.value; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forControlSemic"

    public class continueStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "continueStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1651:1: continueStatement returns [Statement value] : CONTINUE (lb= Identifier )? semic ;
    public ES3Parser.continueStatement_return continueStatement() // throws RecognitionException [1]
    {   
        ES3Parser.continueStatement_return retval = new ES3Parser.continueStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken CONTINUE142 = null;
        ES3Parser.semic_return semic143 = default(ES3Parser.semic_return);


        object lb_tree=null;
        object CONTINUE142_tree=null;

         
        	string label = String.Empty; 

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1655:2: ( CONTINUE (lb= Identifier )? semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1655:4: CONTINUE (lb= Identifier )? semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CONTINUE142=(IToken)Match(input,CONTINUE,FOLLOW_CONTINUE_in_continueStatement6093); 
            		CONTINUE142_tree = (object)adaptor.Create(CONTINUE142);
            		root_0 = (object)adaptor.BecomeRoot(CONTINUE142_tree, root_0);

            	 if (input.LA(1) == Identifier) PromoteEOL(null); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1655:67: (lb= Identifier )?
            	int alt75 = 2;
            	int LA75_0 = input.LA(1);

            	if ( (LA75_0 == Identifier) )
            	{
            	    alt75 = 1;
            	}
            	switch (alt75) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1655:68: lb= Identifier
            	        {
            	        	lb=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_continueStatement6101); 
            	        		lb_tree = (object)adaptor.Create(lb);
            	        		adaptor.AddChild(root_0, lb_tree);

            	        	 label = lb.Text; 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_semic_in_continueStatement6108);
            	semic143 = semic();
            	state.followingStackPointer--;

            	 retval.value =  new ContinueStatement() { Label = label }; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "continueStatement"

    public class breakStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "breakStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1667:1: breakStatement returns [Statement value] : BREAK (lb= Identifier )? semic ;
    public ES3Parser.breakStatement_return breakStatement() // throws RecognitionException [1]
    {   
        ES3Parser.breakStatement_return retval = new ES3Parser.breakStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken BREAK144 = null;
        ES3Parser.semic_return semic145 = default(ES3Parser.semic_return);


        object lb_tree=null;
        object BREAK144_tree=null;

         
        	string label = String.Empty; 

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1671:2: ( BREAK (lb= Identifier )? semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1671:4: BREAK (lb= Identifier )? semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BREAK144=(IToken)Match(input,BREAK,FOLLOW_BREAK_in_breakStatement6138); 
            		BREAK144_tree = (object)adaptor.Create(BREAK144);
            		root_0 = (object)adaptor.BecomeRoot(BREAK144_tree, root_0);

            	 if (input.LA(1) == Identifier) PromoteEOL(null); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1671:64: (lb= Identifier )?
            	int alt76 = 2;
            	int LA76_0 = input.LA(1);

            	if ( (LA76_0 == Identifier) )
            	{
            	    alt76 = 1;
            	}
            	switch (alt76) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1671:65: lb= Identifier
            	        {
            	        	lb=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_breakStatement6146); 
            	        		lb_tree = (object)adaptor.Create(lb);
            	        		adaptor.AddChild(root_0, lb_tree);

            	        	 label = lb.Text; 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_semic_in_breakStatement6153);
            	semic145 = semic();
            	state.followingStackPointer--;

            	 retval.value =  new BreakStatement() { Label = label }; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "breakStatement"

    public class returnStatement_return : ParserRuleReturnScope
    {
        public ReturnStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "returnStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1691:1: returnStatement returns [ReturnStatement value] : RETURN (expr= expression )? semic ;
    public ES3Parser.returnStatement_return returnStatement() // throws RecognitionException [1]
    {   
        ES3Parser.returnStatement_return retval = new ES3Parser.returnStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RETURN146 = null;
        ES3Parser.expression_return expr = default(ES3Parser.expression_return);

        ES3Parser.semic_return semic147 = default(ES3Parser.semic_return);


        object RETURN146_tree=null;


        	retval.value =  new ReturnStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1695:2: ( RETURN (expr= expression )? semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1695:4: RETURN (expr= expression )? semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	RETURN146=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_returnStatement6183); 
            		RETURN146_tree = (object)adaptor.Create(RETURN146);
            		root_0 = (object)adaptor.BecomeRoot(RETURN146_tree, root_0);

            	 PromoteEOL(null); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1695:34: (expr= expression )?
            	int alt77 = 2;
            	int LA77_0 = input.LA(1);

            	if ( ((LA77_0 >= NULL && LA77_0 <= FALSE) || LA77_0 == DELETE || LA77_0 == FUNCTION || LA77_0 == NEW || LA77_0 == THIS || LA77_0 == TYPEOF || LA77_0 == VOID || LA77_0 == LBRACE || LA77_0 == LPAREN || LA77_0 == LBRACK || (LA77_0 >= ADD && LA77_0 <= SUB) || (LA77_0 >= INC && LA77_0 <= DEC) || (LA77_0 >= NOT && LA77_0 <= INV) || (LA77_0 >= Identifier && LA77_0 <= StringLiteral) || LA77_0 == RegularExpressionLiteral || (LA77_0 >= DecimalLiteral && LA77_0 <= HexIntegerLiteral)) )
            	{
            	    alt77 = 1;
            	}
            	switch (alt77) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1695:35: expr= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_returnStatement6191);
            	        	expr = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expr.Tree);
            	        	 retval.value.Expression = expr.value; 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_semic_in_returnStatement6197);
            	semic147 = semic();
            	state.followingStackPointer--;


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "returnStatement"

    public class withStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "withStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1702:1: withStatement returns [Statement value] : WITH LPAREN exp= expression RPAREN smt= statement ;
    public ES3Parser.withStatement_return withStatement() // throws RecognitionException [1]
    {   
        ES3Parser.withStatement_return retval = new ES3Parser.withStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WITH148 = null;
        IToken LPAREN149 = null;
        IToken RPAREN150 = null;
        ES3Parser.expression_return exp = default(ES3Parser.expression_return);

        ES3Parser.statement_return smt = default(ES3Parser.statement_return);


        object WITH148_tree=null;
        object LPAREN149_tree=null;
        object RPAREN150_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1703:2: ( WITH LPAREN exp= expression RPAREN smt= statement )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1703:4: WITH LPAREN exp= expression RPAREN smt= statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	WITH148=(IToken)Match(input,WITH,FOLLOW_WITH_in_withStatement6218); 
            		WITH148_tree = (object)adaptor.Create(WITH148);
            		root_0 = (object)adaptor.BecomeRoot(WITH148_tree, root_0);

            	LPAREN149=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_withStatement6221); 
            	PushFollow(FOLLOW_expression_in_withStatement6226);
            	exp = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, exp.Tree);
            	RPAREN150=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_withStatement6228); 
            	PushFollow(FOLLOW_statement_in_withStatement6233);
            	smt = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, smt.Tree);
            	 retval.value =  new WithStatement(exp.value, smt.value); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "withStatement"

    public class switchStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "switchStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1710:1: switchStatement returns [Statement value] : SWITCH LPAREN expression RPAREN LBRACE ({...}? => defaultClause | caseClause )* RBRACE ;
    public ES3Parser.switchStatement_return switchStatement() // throws RecognitionException [1]
    {   
        ES3Parser.switchStatement_return retval = new ES3Parser.switchStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SWITCH151 = null;
        IToken LPAREN152 = null;
        IToken RPAREN154 = null;
        IToken LBRACE155 = null;
        IToken RBRACE158 = null;
        ES3Parser.expression_return expression153 = default(ES3Parser.expression_return);

        ES3Parser.defaultClause_return defaultClause156 = default(ES3Parser.defaultClause_return);

        ES3Parser.caseClause_return caseClause157 = default(ES3Parser.caseClause_return);


        object SWITCH151_tree=null;
        object LPAREN152_tree=null;
        object RPAREN154_tree=null;
        object LBRACE155_tree=null;
        object RBRACE158_tree=null;


        	SwitchStatement switchStatement = new SwitchStatement();
        	retval.value =  switchStatement;
        	int defaultClauseCount = 0;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1716:2: ( SWITCH LPAREN expression RPAREN LBRACE ({...}? => defaultClause | caseClause )* RBRACE )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1716:4: SWITCH LPAREN expression RPAREN LBRACE ({...}? => defaultClause | caseClause )* RBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SWITCH151=(IToken)Match(input,SWITCH,FOLLOW_SWITCH_in_switchStatement6260); 
            		SWITCH151_tree = (object)adaptor.Create(SWITCH151);
            		adaptor.AddChild(root_0, SWITCH151_tree);

            	LPAREN152=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_switchStatement6262); 
            		LPAREN152_tree = (object)adaptor.Create(LPAREN152);
            		adaptor.AddChild(root_0, LPAREN152_tree);

            	PushFollow(FOLLOW_expression_in_switchStatement6264);
            	expression153 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression153.Tree);
            	 switchStatement.Expression = ((expression153 != null) ? expression153.value : default(Expression)); 
            	RPAREN154=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_switchStatement6268); 
            		RPAREN154_tree = (object)adaptor.Create(RPAREN154);
            		adaptor.AddChild(root_0, RPAREN154_tree);

            	LBRACE155=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_switchStatement6273); 
            		LBRACE155_tree = (object)adaptor.Create(LBRACE155);
            		adaptor.AddChild(root_0, LBRACE155_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1717:10: ({...}? => defaultClause | caseClause )*
            	do 
            	{
            	    int alt78 = 3;
            	    int LA78_0 = input.LA(1);

            	    if ( (LA78_0 == DEFAULT) && (( defaultClauseCount == 0 )) )
            	    {
            	        alt78 = 1;
            	    }
            	    else if ( (LA78_0 == CASE) )
            	    {
            	        alt78 = 2;
            	    }


            	    switch (alt78) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1717:12: {...}? => defaultClause
            			    {
            			    	if ( !(( defaultClauseCount == 0 )) ) 
            			    	{
            			    	    throw new FailedPredicateException(input, "switchStatement", " defaultClauseCount == 0 ");
            			    	}
            			    	PushFollow(FOLLOW_defaultClause_in_switchStatement6280);
            			    	defaultClause156 = defaultClause();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, defaultClause156.Tree);
            			    	 defaultClauseCount++; switchStatement.DefaultStatements=((defaultClause156 != null) ? defaultClause156.value : default(BlockStatement)); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1717:141: caseClause
            			    {
            			    	PushFollow(FOLLOW_caseClause_in_switchStatement6286);
            			    	caseClause157 = caseClause();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, caseClause157.Tree);
            			    	 switchStatement.CaseClauses.Add(((caseClause157 != null) ? caseClause157.value : default(CaseClause))); 

            			    }
            			    break;

            			default:
            			    goto loop78;
            	    }
            	} while (true);

            	loop78:
            		;	// Stops C# compiler whining that label 'loop78' has no statements

            	RBRACE158=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_switchStatement6293); 
            		RBRACE158_tree = (object)adaptor.Create(RBRACE158);
            		adaptor.AddChild(root_0, RBRACE158_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "switchStatement"

    public class caseClause_return : ParserRuleReturnScope
    {
        public CaseClause value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "caseClause"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1721:1: caseClause returns [CaseClause value] : CASE expression COLON ( statement )* ;
    public ES3Parser.caseClause_return caseClause() // throws RecognitionException [1]
    {   
        ES3Parser.caseClause_return retval = new ES3Parser.caseClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CASE159 = null;
        IToken COLON161 = null;
        ES3Parser.expression_return expression160 = default(ES3Parser.expression_return);

        ES3Parser.statement_return statement162 = default(ES3Parser.statement_return);


        object CASE159_tree=null;
        object COLON161_tree=null;


        	retval.value =  new CaseClause();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1725:2: ( CASE expression COLON ( statement )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1725:4: CASE expression COLON ( statement )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CASE159=(IToken)Match(input,CASE,FOLLOW_CASE_in_caseClause6316); 
            		CASE159_tree = (object)adaptor.Create(CASE159);
            		root_0 = (object)adaptor.BecomeRoot(CASE159_tree, root_0);

            	PushFollow(FOLLOW_expression_in_caseClause6319);
            	expression160 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression160.Tree);
            	 retval.value.Expression = ((expression160 != null) ? expression160.value : default(Expression)); 
            	COLON161=(IToken)Match(input,COLON,FOLLOW_COLON_in_caseClause6323); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1725:70: ( statement )*
            	do 
            	{
            	    int alt79 = 2;
            	    int LA79_0 = input.LA(1);

            	    if ( ((LA79_0 >= NULL && LA79_0 <= BREAK) || LA79_0 == CONTINUE || (LA79_0 >= DELETE && LA79_0 <= DO) || (LA79_0 >= FOR && LA79_0 <= IF) || (LA79_0 >= NEW && LA79_0 <= WITH) || LA79_0 == LBRACE || LA79_0 == LPAREN || LA79_0 == LBRACK || LA79_0 == SEMIC || (LA79_0 >= ADD && LA79_0 <= SUB) || (LA79_0 >= INC && LA79_0 <= DEC) || (LA79_0 >= NOT && LA79_0 <= INV) || (LA79_0 >= Identifier && LA79_0 <= StringLiteral) || LA79_0 == RegularExpressionLiteral || (LA79_0 >= DecimalLiteral && LA79_0 <= HexIntegerLiteral)) )
            	    {
            	        alt79 = 1;
            	    }


            	    switch (alt79) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1725:72: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_caseClause6327);
            			    	statement162 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement162.Tree);
            			    	 retval.value.Statements.Statements.AddLast(((statement162 != null) ? statement162.value : default(Statement))); 

            			    }
            			    break;

            			default:
            			    goto loop79;
            	    }
            	} while (true);

            	loop79:
            		;	// Stops C# compiler whining that label 'loop79' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseClause"

    public class defaultClause_return : ParserRuleReturnScope
    {
        public BlockStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "defaultClause"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1728:1: defaultClause returns [BlockStatement value] : DEFAULT COLON ( statement )* ;
    public ES3Parser.defaultClause_return defaultClause() // throws RecognitionException [1]
    {   
        ES3Parser.defaultClause_return retval = new ES3Parser.defaultClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DEFAULT163 = null;
        IToken COLON164 = null;
        ES3Parser.statement_return statement165 = default(ES3Parser.statement_return);


        object DEFAULT163_tree=null;
        object COLON164_tree=null;


        	retval.value =  new BlockStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1732:2: ( DEFAULT COLON ( statement )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1732:4: DEFAULT COLON ( statement )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	DEFAULT163=(IToken)Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultClause6352); 
            		DEFAULT163_tree = (object)adaptor.Create(DEFAULT163);
            		root_0 = (object)adaptor.BecomeRoot(DEFAULT163_tree, root_0);

            	COLON164=(IToken)Match(input,COLON,FOLLOW_COLON_in_defaultClause6355); 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1732:20: ( statement )*
            	do 
            	{
            	    int alt80 = 2;
            	    int LA80_0 = input.LA(1);

            	    if ( ((LA80_0 >= NULL && LA80_0 <= BREAK) || LA80_0 == CONTINUE || (LA80_0 >= DELETE && LA80_0 <= DO) || (LA80_0 >= FOR && LA80_0 <= IF) || (LA80_0 >= NEW && LA80_0 <= WITH) || LA80_0 == LBRACE || LA80_0 == LPAREN || LA80_0 == LBRACK || LA80_0 == SEMIC || (LA80_0 >= ADD && LA80_0 <= SUB) || (LA80_0 >= INC && LA80_0 <= DEC) || (LA80_0 >= NOT && LA80_0 <= INV) || (LA80_0 >= Identifier && LA80_0 <= StringLiteral) || LA80_0 == RegularExpressionLiteral || (LA80_0 >= DecimalLiteral && LA80_0 <= HexIntegerLiteral)) )
            	    {
            	        alt80 = 1;
            	    }


            	    switch (alt80) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1732:21: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_defaultClause6359);
            			    	statement165 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement165.Tree);
            			    	 retval.value.Statements.AddLast(((statement165 != null) ? statement165.value : default(Statement))); 

            			    }
            			    break;

            			default:
            			    goto loop80;
            	    }
            	} while (true);

            	loop80:
            		;	// Stops C# compiler whining that label 'loop80' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defaultClause"

    public class labelledStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "labelledStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1739:1: labelledStatement returns [Statement value] : lb= Identifier COLON st= statement ;
    public ES3Parser.labelledStatement_return labelledStatement() // throws RecognitionException [1]
    {   
        ES3Parser.labelledStatement_return retval = new ES3Parser.labelledStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken COLON166 = null;
        ES3Parser.statement_return st = default(ES3Parser.statement_return);


        object lb_tree=null;
        object COLON166_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1740:2: (lb= Identifier COLON st= statement )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1740:4: lb= Identifier COLON st= statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	lb=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_labelledStatement6386); 
            		lb_tree = (object)adaptor.Create(lb);
            		adaptor.AddChild(root_0, lb_tree);

            	COLON166=(IToken)Match(input,COLON,FOLLOW_COLON_in_labelledStatement6388); 
            		COLON166_tree = (object)adaptor.Create(COLON166);
            		adaptor.AddChild(root_0, COLON166_tree);

            	PushFollow(FOLLOW_statement_in_labelledStatement6392);
            	st = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, st.Tree);
            	 retval.value =  st.value;  retval.value.Label = lb.Text; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "labelledStatement"

    public class throwStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "throwStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1763:1: throwStatement returns [Statement value] : THROW exp= expression semic ;
    public ES3Parser.throwStatement_return throwStatement() // throws RecognitionException [1]
    {   
        ES3Parser.throwStatement_return retval = new ES3Parser.throwStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken THROW167 = null;
        ES3Parser.expression_return exp = default(ES3Parser.expression_return);

        ES3Parser.semic_return semic168 = default(ES3Parser.semic_return);


        object THROW167_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1764:2: ( THROW exp= expression semic )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1764:4: THROW exp= expression semic
            {
            	root_0 = (object)adaptor.GetNilNode();

            	THROW167=(IToken)Match(input,THROW,FOLLOW_THROW_in_throwStatement6418); 
            		THROW167_tree = (object)adaptor.Create(THROW167);
            		root_0 = (object)adaptor.BecomeRoot(THROW167_tree, root_0);

            	 PromoteEOL(null); 
            	PushFollow(FOLLOW_expression_in_throwStatement6425);
            	exp = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, exp.Tree);
            	 retval.value =  new ThrowStatement(exp.value); 
            	PushFollow(FOLLOW_semic_in_throwStatement6429);
            	semic168 = semic();
            	state.followingStackPointer--;


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "throwStatement"

    public class tryStatement_return : ParserRuleReturnScope
    {
        public TryStatement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tryStatement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1771:1: tryStatement returns [TryStatement value] : TRY b= block (c= catchClause (first= finallyClause )? | last= finallyClause ) ;
    public ES3Parser.tryStatement_return tryStatement() // throws RecognitionException [1]
    {   
        ES3Parser.tryStatement_return retval = new ES3Parser.tryStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TRY169 = null;
        ES3Parser.block_return b = default(ES3Parser.block_return);

        ES3Parser.catchClause_return c = default(ES3Parser.catchClause_return);

        ES3Parser.finallyClause_return first = default(ES3Parser.finallyClause_return);

        ES3Parser.finallyClause_return last = default(ES3Parser.finallyClause_return);


        object TRY169_tree=null;


        	retval.value =  new TryStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:2: ( TRY b= block (c= catchClause (first= finallyClause )? | last= finallyClause ) )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:4: TRY b= block (c= catchClause (first= finallyClause )? | last= finallyClause )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TRY169=(IToken)Match(input,TRY,FOLLOW_TRY_in_tryStatement6454); 
            		TRY169_tree = (object)adaptor.Create(TRY169);
            		root_0 = (object)adaptor.BecomeRoot(TRY169_tree, root_0);

            	PushFollow(FOLLOW_block_in_tryStatement6459);
            	b = block();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, b.Tree);
            	 retval.value.Statement = b.value; 
            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:50: (c= catchClause (first= finallyClause )? | last= finallyClause )
            	int alt82 = 2;
            	int LA82_0 = input.LA(1);

            	if ( (LA82_0 == CATCH) )
            	{
            	    alt82 = 1;
            	}
            	else if ( (LA82_0 == FINALLY) )
            	{
            	    alt82 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d82s0 =
            	        new NoViableAltException("", 82, 0, input);

            	    throw nvae_d82s0;
            	}
            	switch (alt82) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:52: c= catchClause (first= finallyClause )?
            	        {
            	        	PushFollow(FOLLOW_catchClause_in_tryStatement6468);
            	        	c = catchClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, c.Tree);
            	        	 retval.value.Catch = c.value; 
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:94: (first= finallyClause )?
            	        	int alt81 = 2;
            	        	int LA81_0 = input.LA(1);

            	        	if ( (LA81_0 == FINALLY) )
            	        	{
            	        	    alt81 = 1;
            	        	}
            	        	switch (alt81) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:95: first= finallyClause
            	        	        {
            	        	        	PushFollow(FOLLOW_finallyClause_in_tryStatement6475);
            	        	        	first = finallyClause();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, first.Tree);
            	        	        	 retval.value.Finally = first.value; 

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1775:153: last= finallyClause
            	        {
            	        	PushFollow(FOLLOW_finallyClause_in_tryStatement6485);
            	        	last = finallyClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, last.Tree);
            	        	 retval.value.Finally = last.value; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tryStatement"

    public class catchClause_return : ParserRuleReturnScope
    {
        public CatchClause value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "catchClause"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1778:1: catchClause returns [CatchClause value] : CATCH LPAREN id= Identifier RPAREN block ;
    public ES3Parser.catchClause_return catchClause() // throws RecognitionException [1]
    {   
        ES3Parser.catchClause_return retval = new ES3Parser.catchClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken CATCH170 = null;
        IToken LPAREN171 = null;
        IToken RPAREN172 = null;
        ES3Parser.block_return block173 = default(ES3Parser.block_return);


        object id_tree=null;
        object CATCH170_tree=null;
        object LPAREN171_tree=null;
        object RPAREN172_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1779:2: ( CATCH LPAREN id= Identifier RPAREN block )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1779:4: CATCH LPAREN id= Identifier RPAREN block
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CATCH170=(IToken)Match(input,CATCH,FOLLOW_CATCH_in_catchClause6505); 
            		CATCH170_tree = (object)adaptor.Create(CATCH170);
            		root_0 = (object)adaptor.BecomeRoot(CATCH170_tree, root_0);

            	LPAREN171=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_catchClause6508); 
            	id=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_catchClause6513); 
            		id_tree = (object)adaptor.Create(id);
            		adaptor.AddChild(root_0, id_tree);

            	RPAREN172=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_catchClause6515); 
            	PushFollow(FOLLOW_block_in_catchClause6518);
            	block173 = block();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, block173.Tree);
            	 retval.value =  new CatchClause(((id != null) ? id.Text : null), ((block173 != null) ? block173.value : default(BlockStatement))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "catchClause"

    public class finallyClause_return : ParserRuleReturnScope
    {
        public FinallyClause value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "finallyClause"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1782:1: finallyClause returns [FinallyClause value] : FINALLY block ;
    public ES3Parser.finallyClause_return finallyClause() // throws RecognitionException [1]
    {   
        ES3Parser.finallyClause_return retval = new ES3Parser.finallyClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FINALLY174 = null;
        ES3Parser.block_return block175 = default(ES3Parser.block_return);


        object FINALLY174_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1783:2: ( FINALLY block )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1783:4: FINALLY block
            {
            	root_0 = (object)adaptor.GetNilNode();

            	FINALLY174=(IToken)Match(input,FINALLY,FOLLOW_FINALLY_in_finallyClause6536); 
            		FINALLY174_tree = (object)adaptor.Create(FINALLY174);
            		root_0 = (object)adaptor.BecomeRoot(FINALLY174_tree, root_0);

            	PushFollow(FOLLOW_block_in_finallyClause6539);
            	block175 = block();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, block175.Tree);
            	 retval.value =  new FinallyClause(((block175 != null) ? block175.value : default(BlockStatement))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "finallyClause"

    public class functionDeclaration_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionDeclaration"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1796:1: functionDeclaration returns [Statement value] : FUNCTION name= Identifier parameters= formalParameterList body= functionBody ;
    public ES3Parser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        ES3Parser.functionDeclaration_return retval = new ES3Parser.functionDeclaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken FUNCTION176 = null;
        ES3Parser.formalParameterList_return parameters = default(ES3Parser.formalParameterList_return);

        ES3Parser.functionBody_return body = default(ES3Parser.functionBody_return);


        object name_tree=null;
        object FUNCTION176_tree=null;


        FunctionDeclarationStatement statement = new FunctionDeclarationStatement();
        retval.value =  statement;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1801:2: ( FUNCTION name= Identifier parameters= formalParameterList body= functionBody )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1801:4: FUNCTION name= Identifier parameters= formalParameterList body= functionBody
            {
            	root_0 = (object)adaptor.GetNilNode();

            	FUNCTION176=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_functionDeclaration6571); 
            		FUNCTION176_tree = (object)adaptor.Create(FUNCTION176);
            		adaptor.AddChild(root_0, FUNCTION176_tree);

            	name=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration6576); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	 statement.Name = name.Text; 
            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration6586);
            	parameters = formalParameterList();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, parameters.Tree);
            	 statement.Parameters.AddRange(parameters.value); 
            	PushFollow(FOLLOW_functionBody_in_functionDeclaration6595);
            	body = functionBody();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, body.Tree);
            	 statement.Statement = body.value; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionDeclaration"

    public class functionExpression_return : ParserRuleReturnScope
    {
        public FunctionExpression value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionExpression"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1808:1: functionExpression returns [FunctionExpression value] : FUNCTION (name= Identifier )? formalParameterList functionBody ;
    public ES3Parser.functionExpression_return functionExpression() // throws RecognitionException [1]
    {   
        ES3Parser.functionExpression_return retval = new ES3Parser.functionExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken FUNCTION177 = null;
        ES3Parser.formalParameterList_return formalParameterList178 = default(ES3Parser.formalParameterList_return);

        ES3Parser.functionBody_return functionBody179 = default(ES3Parser.functionBody_return);


        object name_tree=null;
        object FUNCTION177_tree=null;


        	retval.value =  new FunctionExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1812:2: ( FUNCTION (name= Identifier )? formalParameterList functionBody )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1812:4: FUNCTION (name= Identifier )? formalParameterList functionBody
            {
            	root_0 = (object)adaptor.GetNilNode();

            	FUNCTION177=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_functionExpression6622); 
            		FUNCTION177_tree = (object)adaptor.Create(FUNCTION177);
            		adaptor.AddChild(root_0, FUNCTION177_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1812:13: (name= Identifier )?
            	int alt83 = 2;
            	int LA83_0 = input.LA(1);

            	if ( (LA83_0 == Identifier) )
            	{
            	    alt83 = 1;
            	}
            	switch (alt83) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1812:14: name= Identifier
            	        {
            	        	name=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionExpression6627); 
            	        		name_tree = (object)adaptor.Create(name);
            	        		adaptor.AddChild(root_0, name_tree);

            	        	 retval.value.Name = name.Text; 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_formalParameterList_in_functionExpression6634);
            	formalParameterList178 = formalParameterList();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, formalParameterList178.Tree);
            	 retval.value.Parameters.AddRange(((formalParameterList178 != null) ? formalParameterList178.value : default(List<string>))) ;
            	PushFollow(FOLLOW_functionBody_in_functionExpression6638);
            	functionBody179 = functionBody();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, functionBody179.Tree);
            	 retval.value.Statement = ((functionBody179 != null) ? functionBody179.value : default(Statement)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionExpression"

    public class formalParameterList_return : ParserRuleReturnScope
    {
        public List<string> value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formalParameterList"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1817:1: formalParameterList returns [List<string> value] : LPAREN (first= Identifier ( COMMA follow= Identifier )* )? RPAREN ;
    public ES3Parser.formalParameterList_return formalParameterList() // throws RecognitionException [1]
    {   
        ES3Parser.formalParameterList_return retval = new ES3Parser.formalParameterList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken first = null;
        IToken follow = null;
        IToken LPAREN180 = null;
        IToken COMMA181 = null;
        IToken RPAREN182 = null;

        object first_tree=null;
        object follow_tree=null;
        object LPAREN180_tree=null;
        object COMMA181_tree=null;
        object RPAREN182_tree=null;


        List<string> identifiers = new List<string>();
        retval.value =  identifiers;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1822:2: ( LPAREN (first= Identifier ( COMMA follow= Identifier )* )? RPAREN )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1822:4: LPAREN (first= Identifier ( COMMA follow= Identifier )* )? RPAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LPAREN180=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_formalParameterList6663); 
            		LPAREN180_tree = (object)adaptor.Create(LPAREN180);
            		adaptor.AddChild(root_0, LPAREN180_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1822:11: (first= Identifier ( COMMA follow= Identifier )* )?
            	int alt85 = 2;
            	int LA85_0 = input.LA(1);

            	if ( (LA85_0 == Identifier) )
            	{
            	    alt85 = 1;
            	}
            	switch (alt85) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1822:13: first= Identifier ( COMMA follow= Identifier )*
            	        {
            	        	first=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameterList6669); 
            	        		first_tree = (object)adaptor.Create(first);
            	        		adaptor.AddChild(root_0, first_tree);

            	        	 identifiers.Add(((first != null) ? first.Text : null)); 
            	        	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1822:64: ( COMMA follow= Identifier )*
            	        	do 
            	        	{
            	        	    int alt84 = 2;
            	        	    int LA84_0 = input.LA(1);

            	        	    if ( (LA84_0 == COMMA) )
            	        	    {
            	        	        alt84 = 1;
            	        	    }


            	        	    switch (alt84) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1822:66: COMMA follow= Identifier
            	        			    {
            	        			    	COMMA181=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_formalParameterList6675); 
            	        			    		COMMA181_tree = (object)adaptor.Create(COMMA181);
            	        			    		adaptor.AddChild(root_0, COMMA181_tree);

            	        			    	follow=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameterList6679); 
            	        			    		follow_tree = (object)adaptor.Create(follow);
            	        			    		adaptor.AddChild(root_0, follow_tree);

            	        			    	 identifiers.Add(((follow != null) ? follow.Text : null)); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop84;
            	        	    }
            	        	} while (true);

            	        	loop84:
            	        		;	// Stops C# compiler whining that label 'loop84' has no statements


            	        }
            	        break;

            	}

            	RPAREN182=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_formalParameterList6690); 
            		RPAREN182_tree = (object)adaptor.Create(RPAREN182);
            		adaptor.AddChild(root_0, RPAREN182_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "formalParameterList"

    public class functionBody_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionBody"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1826:1: functionBody returns [Statement value] : lb= LBRACE ( sourceElement )* RBRACE ;
    public ES3Parser.functionBody_return functionBody() // throws RecognitionException [1]
    {   
        ES3Parser.functionBody_return retval = new ES3Parser.functionBody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lb = null;
        IToken RBRACE184 = null;
        ES3Parser.sourceElement_return sourceElement183 = default(ES3Parser.sourceElement_return);


        object lb_tree=null;
        object RBRACE184_tree=null;


        BlockStatement block = new BlockStatement();
        retval.value =  block;

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1831:2: (lb= LBRACE ( sourceElement )* RBRACE )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1831:4: lb= LBRACE ( sourceElement )* RBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	lb=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_functionBody6713); 
            		lb_tree = (object)adaptor.Create(lb);
            		adaptor.AddChild(root_0, lb_tree);

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1831:14: ( sourceElement )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( ((LA86_0 >= NULL && LA86_0 <= BREAK) || LA86_0 == CONTINUE || (LA86_0 >= DELETE && LA86_0 <= DO) || (LA86_0 >= FOR && LA86_0 <= IF) || (LA86_0 >= NEW && LA86_0 <= WITH) || LA86_0 == LBRACE || LA86_0 == LPAREN || LA86_0 == LBRACK || LA86_0 == SEMIC || (LA86_0 >= ADD && LA86_0 <= SUB) || (LA86_0 >= INC && LA86_0 <= DEC) || (LA86_0 >= NOT && LA86_0 <= INV) || (LA86_0 >= Identifier && LA86_0 <= StringLiteral) || LA86_0 == RegularExpressionLiteral || (LA86_0 >= DecimalLiteral && LA86_0 <= HexIntegerLiteral)) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1831:15: sourceElement
            			    {
            			    	PushFollow(FOLLOW_sourceElement_in_functionBody6716);
            			    	sourceElement183 = sourceElement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, sourceElement183.Tree);
            			    	 block.Statements.AddLast(((sourceElement183 != null) ? sourceElement183.value : default(Statement))); 

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements

            	RBRACE184=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_functionBody6723); 
            		RBRACE184_tree = (object)adaptor.Create(RBRACE184);
            		adaptor.AddChild(root_0, RBRACE184_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionBody"

    public class program_return : ParserRuleReturnScope
    {
        public Program value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1839:1: program returns [Program value] : (follow= sourceElement )* ;
    public ES3Parser.program_return program() // throws RecognitionException [1]
    {   
        ES3Parser.program_return retval = new ES3Parser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.sourceElement_return follow = default(ES3Parser.sourceElement_return);




        script = input.ToString().Split('\n');
        Program program = new Program();

        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1844:2: ( (follow= sourceElement )* )
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1844:4: (follow= sourceElement )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1844:4: (follow= sourceElement )*
            	do 
            	{
            	    int alt87 = 2;
            	    int LA87_0 = input.LA(1);

            	    if ( ((LA87_0 >= NULL && LA87_0 <= BREAK) || LA87_0 == CONTINUE || (LA87_0 >= DELETE && LA87_0 <= DO) || (LA87_0 >= FOR && LA87_0 <= IF) || (LA87_0 >= NEW && LA87_0 <= WITH) || LA87_0 == LBRACE || LA87_0 == LPAREN || LA87_0 == LBRACK || LA87_0 == SEMIC || (LA87_0 >= ADD && LA87_0 <= SUB) || (LA87_0 >= INC && LA87_0 <= DEC) || (LA87_0 >= NOT && LA87_0 <= INV) || (LA87_0 >= Identifier && LA87_0 <= StringLiteral) || LA87_0 == RegularExpressionLiteral || (LA87_0 >= DecimalLiteral && LA87_0 <= HexIntegerLiteral)) )
            	    {
            	        alt87 = 1;
            	    }


            	    switch (alt87) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1844:5: follow= sourceElement
            			    {
            			    	PushFollow(FOLLOW_sourceElement_in_program6752);
            			    	follow = sourceElement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, follow.Tree);
            			    	 program.Statements.AddLast(follow.value); 

            			    }
            			    break;

            			default:
            			    goto loop87;
            	    }
            	} while (true);

            	loop87:
            		;	// Stops C# compiler whining that label 'loop87' has no statements

            	 retval.value =  program; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class sourceElement_return : ParserRuleReturnScope
    {
        public Statement value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sourceElement"
    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1852:1: sourceElement returns [Statement value] options {k=1; } : ({...}?func= functionDeclaration | stat= statement );
    public ES3Parser.sourceElement_return sourceElement() // throws RecognitionException [1]
    {   
        ES3Parser.sourceElement_return retval = new ES3Parser.sourceElement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ES3Parser.functionDeclaration_return func = default(ES3Parser.functionDeclaration_return);

        ES3Parser.statement_return stat = default(ES3Parser.statement_return);



        try 
    	{
            // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1858:2: ({...}?func= functionDeclaration | stat= statement )
            int alt88 = 2;
            alt88 = dfa88.Predict(input);
            switch (alt88) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1858:4: {...}?func= functionDeclaration
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !(( input.LA(1) == FUNCTION )) ) 
                    	{
                    	    throw new FailedPredicateException(input, "sourceElement", " input.LA(1) == FUNCTION ");
                    	}
                    	PushFollow(FOLLOW_functionDeclaration_in_sourceElement6793);
                    	func = functionDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, func.Tree);
                    	 retval.value =  func.value; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Projets\\Jint\\Jint\\ES3.g:1859:4: stat= statement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_sourceElement6802);
                    	stat = statement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stat.Tree);
                    	 retval.value =  stat.value; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sourceElement"

    // Delegated rules


   	protected DFA57 dfa57;
   	protected DFA58 dfa58;
   	protected DFA88 dfa88;
	private void InitializeCyclicDFAs()
	{
    	this.dfa57 = new DFA57(this);
    	this.dfa58 = new DFA58(this);
    	this.dfa88 = new DFA88(this);
	    this.dfa57.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA57_SpecialStateTransition);
	    this.dfa88.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA88_SpecialStateTransition);
	}

    const string DFA57_eotS =
        "\x28\uffff";
    const string DFA57_eofS =
        "\x28\uffff";
    const string DFA57_minS =
        "\x01\x04\x02\x00\x25\uffff";
    const string DFA57_maxS =
        "\x01\u00a1\x02\x00\x25\uffff";
    const string DFA57_acceptS =
        "\x03\uffff\x01\x03\x22\uffff\x01\x01\x01\x02";
    const string DFA57_specialS =
        "\x01\uffff\x01\x00\x01\x01\x25\uffff}>";
    static readonly string[] DFA57_transitionS = {
            "\x04\x03\x02\uffff\x01\x03\x01\uffff\x02\x03\x02\uffff\x01"+
            "\x03\x01\x02\x01\x03\x02\uffff\x0b\x03\x1f\uffff\x01\x01\x01"+
            "\uffff\x01\x03\x01\uffff\x01\x03\x02\uffff\x01\x03\x09\uffff"+
            "\x02\x03\x02\uffff\x02\x03\x06\uffff\x02\x03\x36\uffff\x02\x03"+
            "\x05\uffff\x01\x03\x03\uffff\x03\x03",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA57_eot = DFA.UnpackEncodedString(DFA57_eotS);
    static readonly short[] DFA57_eof = DFA.UnpackEncodedString(DFA57_eofS);
    static readonly char[] DFA57_min = DFA.UnpackEncodedStringToUnsignedChars(DFA57_minS);
    static readonly char[] DFA57_max = DFA.UnpackEncodedStringToUnsignedChars(DFA57_maxS);
    static readonly short[] DFA57_accept = DFA.UnpackEncodedString(DFA57_acceptS);
    static readonly short[] DFA57_special = DFA.UnpackEncodedString(DFA57_specialS);
    static readonly short[][] DFA57_transition = DFA.UnpackEncodedStringArray(DFA57_transitionS);

    protected class DFA57 : DFA
    {
        public DFA57(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 57;
            this.eot = DFA57_eot;
            this.eof = DFA57_eof;
            this.min = DFA57_min;
            this.max = DFA57_max;
            this.accept = DFA57_accept;
            this.special = DFA57_special;
            this.transition = DFA57_transition;

        }

        override public string Description
        {
            get { return "1404:1: statement returns [Statement value] options {k=1; } : ({...}? block | {...}?func= functionDeclaration | statementTail );"; }
        }

    }


    protected internal int DFA57_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA57_1 = input.LA(1);

                   	 
                   	int index57_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (( input.LA(1) == LBRACE )) ) { s = 38; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index57_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA57_2 = input.LA(1);

                   	 
                   	int index57_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (( input.LA(1) == FUNCTION )) ) { s = 39; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index57_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae57 =
            new NoViableAltException(dfa.Description, 57, _s, input);
        dfa.Error(nvae57);
        throw nvae57;
    }
    const string DFA58_eotS =
        "\x0f\uffff";
    const string DFA58_eofS =
        "\x04\uffff\x01\x03\x0a\uffff";
    const string DFA58_minS =
        "\x01\x04\x03\uffff\x01\x13\x0a\uffff";
    const string DFA58_maxS =
        "\x01\u00a1\x03\uffff\x01\u0092\x0a\uffff";
    const string DFA58_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\uffff\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0b\x01\x0c\x01\x0d\x01\x0a";
    const string DFA58_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA58_transitionS = {
            "\x03\x03\x01\x08\x02\uffff\x01\x07\x01\uffff\x01\x03\x01\x06"+
            "\x02\uffff\x01\x06\x01\x03\x01\x05\x02\uffff\x01\x03\x01\x09"+
            "\x01\x0b\x01\x03\x01\x0c\x01\x0d\x01\x03\x01\x01\x01\x03\x01"+
            "\x06\x01\x0a\x1f\uffff\x01\x03\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x03\x02\uffff\x01\x02\x09\uffff\x02\x03\x02\uffff\x02\x03\x06"+
            "\uffff\x02\x03\x36\uffff\x01\x04\x01\x03\x05\uffff\x01\x03\x03"+
            "\uffff\x03\x03",
            "",
            "",
            "",
            "\x02\x03\x2a\uffff\x03\x03\x01\uffff\x01\x03\x01\uffff\x17"+
            "\x03\x02\uffff\x03\x03\x01\x0e\x0d\x03\x22\uffff\x02\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA58_eot = DFA.UnpackEncodedString(DFA58_eotS);
    static readonly short[] DFA58_eof = DFA.UnpackEncodedString(DFA58_eofS);
    static readonly char[] DFA58_min = DFA.UnpackEncodedStringToUnsignedChars(DFA58_minS);
    static readonly char[] DFA58_max = DFA.UnpackEncodedStringToUnsignedChars(DFA58_maxS);
    static readonly short[] DFA58_accept = DFA.UnpackEncodedString(DFA58_acceptS);
    static readonly short[] DFA58_special = DFA.UnpackEncodedString(DFA58_specialS);
    static readonly short[][] DFA58_transition = DFA.UnpackEncodedStringArray(DFA58_transitionS);

    protected class DFA58 : DFA
    {
        public DFA58(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 58;
            this.eot = DFA58_eot;
            this.eof = DFA58_eof;
            this.min = DFA58_min;
            this.max = DFA58_max;
            this.accept = DFA58_accept;
            this.special = DFA58_special;
            this.transition = DFA58_transition;

        }

        override public string Description
        {
            get { return "1415:1: statementTail returns [Statement value] : ( variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement );"; }
        }

    }

    const string DFA88_eotS =
        "\x27\uffff";
    const string DFA88_eofS =
        "\x27\uffff";
    const string DFA88_minS =
        "\x01\x04\x01\x00\x25\uffff";
    const string DFA88_maxS =
        "\x01\u00a1\x01\x00\x25\uffff";
    const string DFA88_acceptS =
        "\x02\uffff\x01\x02\x23\uffff\x01\x01";
    const string DFA88_specialS =
        "\x01\uffff\x01\x00\x25\uffff}>";
    static readonly string[] DFA88_transitionS = {
            "\x04\x02\x02\uffff\x01\x02\x01\uffff\x02\x02\x02\uffff\x01"+
            "\x02\x01\x01\x01\x02\x02\uffff\x0b\x02\x1f\uffff\x01\x02\x01"+
            "\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x01\x02\x09\uffff"+
            "\x02\x02\x02\uffff\x02\x02\x06\uffff\x02\x02\x36\uffff\x02\x02"+
            "\x05\uffff\x01\x02\x03\uffff\x03\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA88_eot = DFA.UnpackEncodedString(DFA88_eotS);
    static readonly short[] DFA88_eof = DFA.UnpackEncodedString(DFA88_eofS);
    static readonly char[] DFA88_min = DFA.UnpackEncodedStringToUnsignedChars(DFA88_minS);
    static readonly char[] DFA88_max = DFA.UnpackEncodedStringToUnsignedChars(DFA88_maxS);
    static readonly short[] DFA88_accept = DFA.UnpackEncodedString(DFA88_acceptS);
    static readonly short[] DFA88_special = DFA.UnpackEncodedString(DFA88_specialS);
    static readonly short[][] DFA88_transition = DFA.UnpackEncodedStringArray(DFA88_transitionS);

    protected class DFA88 : DFA
    {
        public DFA88(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 88;
            this.eot = DFA88_eot;
            this.eof = DFA88_eof;
            this.min = DFA88_min;
            this.max = DFA88_max;
            this.accept = DFA88_accept;
            this.special = DFA88_special;
            this.transition = DFA88_transition;

        }

        override public string Description
        {
            get { return "1852:1: sourceElement returns [Statement value] options {k=1; } : ({...}?func= functionDeclaration | stat= statement );"; }
        }

    }


    protected internal int DFA88_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA88_1 = input.LA(1);

                   	 
                   	int index88_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (( input.LA(1) == FUNCTION )) ) { s = 38; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index88_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae88 =
            new NoViableAltException(dfa.Description, 88, _s, input);
        dfa.Error(nvae88);
        throw nvae88;
    }
 

    public static readonly BitSet FOLLOW_reservedWord_in_token1749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_token1754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_punctuator_in_token1759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numericLiteral_in_token1764 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_token1769 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_keyword_in_reservedWord1782 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_futureReservedWord_in_reservedWord1787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_reservedWord1792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanLiteral_in_reservedWord1797 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_keyword0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_futureReservedWord0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_punctuator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_literal2484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanLiteral_in_literal2493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numericLiteral_in_literal2502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_literal2511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RegularExpressionLiteral_in_literal2521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_booleanLiteral2538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_booleanLiteral2545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DecimalLiteral_in_numericLiteral2756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OctalIntegerLiteral_in_numericLiteral2765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HexIntegerLiteral_in_numericLiteral2774 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_THIS_in_primaryExpression3175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_primaryExpression3184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression3193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayLiteral_in_primaryExpression3202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectLiteral_in_primaryExpression3211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_primaryExpression3220 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_primaryExpression3224 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_primaryExpression3227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_arrayLiteral3253 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033009AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_arrayItem_in_arrayLiteral3259 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000090UL});
    public static readonly BitSet FOLLOW_COMMA_in_arrayLiteral3265 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033009AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_arrayItem_in_arrayLiteral3269 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000090UL});
    public static readonly BitSet FOLLOW_RBRACK_in_arrayLiteral3279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arrayItem3300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACE_in_objectLiteral3341 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL,0x0000000380300000UL});
    public static readonly BitSet FOLLOW_propertyAssignment_in_objectLiteral3347 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000081UL});
    public static readonly BitSet FOLLOW_COMMA_in_objectLiteral3354 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000380300000UL});
    public static readonly BitSet FOLLOW_propertyAssignment_in_objectLiteral3358 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000081UL});
    public static readonly BitSet FOLLOW_RBRACE_in_objectLiteral3368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_accessor_in_propertyAssignment3391 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000380300000UL});
    public static readonly BitSet FOLLOW_propertyName_in_propertyAssignment3399 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_propertyAssignment3406 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionBody_in_propertyAssignment3414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyName_in_propertyAssignment3424 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COLON_in_propertyAssignment3428 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_propertyAssignment3432 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_accessor3452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_propertyName3474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_propertyName3483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numericLiteral_in_propertyName3492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_memberExpression3518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionExpression_in_memberExpression3527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_newExpression_in_memberExpression3536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_newExpression3553 = new BitSet(new ulong[]{0x8000000001220070UL,0x000000000000000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_memberExpression_in_newExpression3558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_arguments3581 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000EUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arguments3587 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000084UL});
    public static readonly BitSet FOLLOW_COMMA_in_arguments3593 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arguments3597 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000084UL});
    public static readonly BitSet FOLLOW_RPAREN_in_arguments3606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACE_in_generics3628 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000BUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_generics3634 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000081UL});
    public static readonly BitSet FOLLOW_COMMA_in_generics3640 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_generics3644 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000081UL});
    public static readonly BitSet FOLLOW_RBRACE_in_generics3653 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberExpression_in_leftHandSideExpression3689 = new BitSet(new ulong[]{0x8000000000000002UL,0x000000000000002AUL});
    public static readonly BitSet FOLLOW_generics_in_leftHandSideExpression3705 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arguments_in_leftHandSideExpression3714 = new BitSet(new ulong[]{0x8000000000000002UL,0x000000000000002AUL});
    public static readonly BitSet FOLLOW_LBRACK_in_leftHandSideExpression3725 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_leftHandSideExpression3729 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_RBRACK_in_leftHandSideExpression3731 = new BitSet(new ulong[]{0x8000000000000002UL,0x000000000000002AUL});
    public static readonly BitSet FOLLOW_DOT_in_leftHandSideExpression3744 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_leftHandSideExpression3748 = new BitSet(new ulong[]{0x8000000000000002UL,0x000000000000002AUL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_postfixExpression3782 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_postfixOperator_in_postfixExpression3790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INC_in_postfixOperator3813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEC_in_postfixOperator3822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_postfixExpression_in_unaryExpression3845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryOperator_in_unaryExpression3854 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression3859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DELETE_in_unaryOperator3877 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VOID_in_unaryOperator3884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPEOF_in_unaryOperator3891 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INC_in_unaryOperator3898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEC_in_unaryOperator3905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ADD_in_unaryOperator3914 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SUB_in_unaryOperator3923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INV_in_unaryOperator3930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_unaryOperator3937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression3965 = new BitSet(new ulong[]{0x0000000000000002UL,0x00002000000C0000UL});
    public static readonly BitSet FOLLOW_MUL_in_multiplicativeExpression3976 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_DIV_in_multiplicativeExpression3985 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_MOD_in_multiplicativeExpression3993 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression4004 = new BitSet(new ulong[]{0x0000000000000002UL,0x00002000000C0000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression4034 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000030000UL});
    public static readonly BitSet FOLLOW_ADD_in_additiveExpression4045 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_SUB_in_additiveExpression4053 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression4064 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000030000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression4095 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001C00000UL});
    public static readonly BitSet FOLLOW_SHL_in_shiftExpression4106 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_SHR_in_shiftExpression4114 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_SHU_in_shiftExpression4122 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression4133 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001C00000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression4164 = new BitSet(new ulong[]{0x0000000000180002UL,0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression4175 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_GT_in_relationalExpression4183 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_LTE_in_relationalExpression4191 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_GTE_in_relationalExpression4199 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_INSTANCEOF_in_relationalExpression4207 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_IN_in_relationalExpression4215 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression4226 = new BitSet(new ulong[]{0x0000000000180002UL,0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpressionNoIn4252 = new BitSet(new ulong[]{0x0000000000100002UL,0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpressionNoIn4263 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_GT_in_relationalExpressionNoIn4271 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_LTE_in_relationalExpressionNoIn4279 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_GTE_in_relationalExpressionNoIn4287 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_INSTANCEOF_in_relationalExpressionNoIn4295 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpressionNoIn4307 = new BitSet(new ulong[]{0x0000000000100002UL,0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression4338 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_EQ_in_equalityExpression4349 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_NEQ_in_equalityExpression4357 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_SAME_in_equalityExpression4365 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_NSAME_in_equalityExpression4373 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression4384 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn4410 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_EQ_in_equalityExpressionNoIn4421 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_NEQ_in_equalityExpressionNoIn4429 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_SAME_in_equalityExpressionNoIn4437 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_NSAME_in_equalityExpressionNoIn4445 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn4456 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseANDExpression4483 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_AND_in_bitwiseANDExpression4489 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseANDExpression4494 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn4515 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_AND_in_bitwiseANDExpressionNoIn4521 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn4526 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression4549 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_XOR_in_bitwiseXORExpression4555 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression4560 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn4583 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_XOR_in_bitwiseXORExpressionNoIn4589 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn4594 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpression_in_bitwiseORExpression4616 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_OR_in_bitwiseORExpression4622 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpression_in_bitwiseORExpression4627 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn4649 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_OR_in_bitwiseORExpressionNoIn4655 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn4660 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpression_in_logicalANDExpression4686 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_LAND_in_logicalANDExpression4692 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpression_in_logicalANDExpression4697 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn4718 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_LAND_in_logicalANDExpressionNoIn4724 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn4729 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_logicalANDExpression_in_logicalORExpression4751 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_LOR_in_logicalORExpression4757 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_logicalANDExpression_in_logicalORExpression4762 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn4784 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_LOR_in_logicalORExpressionNoIn4790 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn4795 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_logicalORExpression_in_conditionalExpression4822 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_QUE_in_conditionalExpression4828 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_conditionalExpression4833 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COLON_in_conditionalExpression4835 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_conditionalExpression4840 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalORExpressionNoIn_in_conditionalExpressionNoIn4861 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_QUE_in_conditionalExpressionNoIn4867 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn4872 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COLON_in_conditionalExpressionNoIn4874 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn4879 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_assignmentExpression4912 = new BitSet(new ulong[]{0x0000000000000002UL,0x00005FFC00000000UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignmentExpression4924 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_assignmentExpression4931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpressionNoIn_in_assignmentExpressionNoIn5026 = new BitSet(new ulong[]{0x0000000000000002UL,0x00005FFC00000000UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignmentExpressionNoIn5038 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_assignmentExpressionNoIn5045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression5077 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_COMMA_in_expression5083 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression5089 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_expressionNoIn5117 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_COMMA_in_expressionNoIn5123 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_expressionNoIn5129 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_SEMIC_in_semic5163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EOF_in_semic5168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBRACE_in_semic5173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EOL_in_semic5180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MultiLineComment_in_semic5184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_statement5218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_statement5229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statementTail_in_statement5236 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableStatement_in_statementTail5259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_emptyStatement_in_statementTail5266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionStatement_in_statementTail5273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statementTail5280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_iterationStatement_in_statementTail5287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_continueStatement_in_statementTail5294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStatement_in_statementTail5301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStatement_in_statementTail5308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_withStatement_in_statementTail5315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_labelledStatement_in_statementTail5322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_switchStatement_in_statementTail5329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_throwStatement_in_statementTail5336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tryStatement_in_statementTail5343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACE_in_block5373 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004BUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_block5376 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004BUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_RBRACE_in_block5382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_variableStatement5408 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableStatement5412 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_COMMA_in_variableStatement5418 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableStatement5424 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_variableStatement5432 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclaration5456 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableDeclaration5462 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_variableDeclaration5467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclarationNoIn5495 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableDeclarationNoIn5501 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_variableDeclarationNoIn5506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_emptyStatement5531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionStatement5556 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_expressionStatement5558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement5587 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_ifStatement5589 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement5591 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_ifStatement5595 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement5599 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_ELSE_in_ifStatement5607 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement5611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doStatement_in_iterationStatement5641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_iterationStatement5650 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_iterationStatement5660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DO_in_doStatement5679 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_doStatement5681 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_WHILE_in_doStatement5683 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_doStatement5685 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_doStatement5687 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_doStatement5689 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_doStatement5691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_whileStatement5711 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_whileStatement5714 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_whileStatement5717 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_whileStatement5719 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_whileStatement5722 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_forStatement5741 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_forStatement5744 = new BitSet(new ulong[]{0x8000000039221070UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_forControl_in_forStatement5749 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_forStatement5754 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_forStatement5759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forControlVar_in_forControl5778 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forControlExpression_in_forControl5787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forControlSemic_in_forControl5796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_forControlVar5819 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableDeclarationNoIn_in_forControlVar5823 = new BitSet(new ulong[]{0x0000000000080000UL,0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_IN_in_forControlVar5837 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlVar5841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_forControlVar5866 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableDeclarationNoIn_in_forControlVar5872 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_SEMIC_in_forControlVar5883 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlVar5889 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_SEMIC_in_forControlVar5897 = new BitSet(new ulong[]{0x8000000029221072UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlVar5902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionNoIn_in_forControlExpression5941 = new BitSet(new ulong[]{0x0000000000080000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_IN_in_forControlExpression5958 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlExpression5962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_forControlExpression5985 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlExpression5991 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_SEMIC_in_forControlExpression5999 = new BitSet(new ulong[]{0x8000000029221072UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlExpression6004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_forControlSemic6040 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlSemic6046 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_SEMIC_in_forControlSemic6054 = new BitSet(new ulong[]{0x8000000029221072UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_forControlSemic6059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONTINUE_in_continueStatement6093 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000160000UL});
    public static readonly BitSet FOLLOW_Identifier_in_continueStatement6101 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_continueStatement6108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BREAK_in_breakStatement6138 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000160000UL});
    public static readonly BitSet FOLLOW_Identifier_in_breakStatement6146 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_breakStatement6153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_returnStatement6183 = new BitSet(new ulong[]{0x8000000029221070UL,0x00000000303300CBUL,0x0000000388360000UL});
    public static readonly BitSet FOLLOW_expression_in_returnStatement6191 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_returnStatement6197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WITH_in_withStatement6218 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_withStatement6221 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_withStatement6226 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_withStatement6228 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_withStatement6233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SWITCH_in_switchStatement6260 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_switchStatement6262 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_switchStatement6264 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_switchStatement6268 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_LBRACE_in_switchStatement6273 = new BitSet(new ulong[]{0x0000000000000900UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_defaultClause_in_switchStatement6280 = new BitSet(new ulong[]{0x0000000000000900UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_caseClause_in_switchStatement6286 = new BitSet(new ulong[]{0x0000000000000900UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_RBRACE_in_switchStatement6293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseClause6316 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_caseClause6319 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COLON_in_caseClause6323 = new BitSet(new ulong[]{0x80000000FFE734F2UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_caseClause6327 = new BitSet(new ulong[]{0x80000000FFE734F2UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultClause6352 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COLON_in_defaultClause6355 = new BitSet(new ulong[]{0x80000000FFE734F2UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_defaultClause6359 = new BitSet(new ulong[]{0x80000000FFE734F2UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_Identifier_in_labelledStatement6386 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COLON_in_labelledStatement6388 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_statement_in_labelledStatement6392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_THROW_in_throwStatement6418 = new BitSet(new ulong[]{0x8000000029221070UL,0x000000003033000AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_expression_in_throwStatement6425 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C1UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_semic_in_throwStatement6429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRY_in_tryStatement6454 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_block_in_tryStatement6459 = new BitSet(new ulong[]{0x0000000000008200UL});
    public static readonly BitSet FOLLOW_catchClause_in_tryStatement6468 = new BitSet(new ulong[]{0x0000000000008202UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement6475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement6485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CATCH_in_catchClause6505 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_catchClause6508 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_catchClause6513 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_RPAREN_in_catchClause6515 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_block_in_catchClause6518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FINALLY_in_finallyClause6536 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_block_in_finallyClause6539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_functionDeclaration6571 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration6576 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration6586 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionBody_in_functionDeclaration6595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_functionExpression6622 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionExpression6627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionExpression6634 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionBody_in_functionExpression6638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_formalParameterList6663 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterList6669 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000084UL});
    public static readonly BitSet FOLLOW_COMMA_in_formalParameterList6675 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterList6679 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000084UL});
    public static readonly BitSet FOLLOW_RPAREN_in_formalParameterList6690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACE_in_functionBody6713 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004BUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_sourceElement_in_functionBody6716 = new BitSet(new ulong[]{0x80000000FFE734F0UL,0x000000003033004BUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_RBRACE_in_functionBody6723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sourceElement_in_program6752 = new BitSet(new ulong[]{0x80000000FFE734F2UL,0x000000003033004AUL,0x0000000388300000UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_sourceElement6793 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_sourceElement6802 = new BitSet(new ulong[]{0x0000000000000002UL});

}
