namespace BitwiseOperatorsInCSharp
{
    internal class Calculator
    {
        private double _operand1;
        private double _operand2;
        private char _op;
        public double OperandOne {
            get
            { 
                return _operand1;
            }
                
            set 
            {
                _operand1 = value;
            }
        }
        public double OperandTwo { 
            get
            { 
                return _operand2;
            } 
            set 
            { 
                _operand2 = value;
            } 
        }
        public char Op {
            get
            {
                return _op;
            }
            set
            {
                _op = value;

            }
        }
        
        public bool BoolResult{ get; private set; }
        public double Result { get; private set; }

        public void MakeCalculation()
        {
            switch(Op)
            {
                case '+':   
                    Result = OperandOne + OperandTwo;
                    break;
                case '-':
                    Result = OperandTwo - OperandOne;
                    break;
                case '*':
                    Result = OperandOne * OperandTwo;
                    break;
                case '/':
                    Result = OperandTwo > 0 ? OperandOne / OperandTwo: double.NaN;
                    break;
                case '=':
                    BoolResult = OperandOne == OperandTwo;
                    break;
                case '&':
                    BoolResult = (OperandOne > 0) && (OperandTwo >0);
                    break;
                case '%':
                    Result = OperandOne % OperandTwo;
                    break;
                case '>':
                    BoolResult = OperandTwo > OperandOne;
                    break;
                case '<':
                    BoolResult = OperandTwo < OperandOne;
                    break;
                case '!':
                    BoolResult = (OperandOne !=0) && (OperandTwo !=0);
                    break;
                case '|':
                    BoolResult = (OperandOne > 0) || (OperandTwo > 0);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

        }
    }
}
