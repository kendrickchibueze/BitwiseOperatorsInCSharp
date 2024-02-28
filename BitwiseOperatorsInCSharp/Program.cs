namespace BitwiseOperatorsInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Building A Simple Calculator in C#...**");
            Console.WriteLine();

            Calculator cal = new Calculator();
            Console.WriteLine("Enter the first Operand: ");
            cal.OperandOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Operand : ");
            cal.OperandTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Operator: (+, -, /, &, *, =, !, %, |, >, <)");
            cal.Op  = Console.ReadKey().KeyChar;
            Console.WriteLine();
            cal.MakeCalculation();
           Console.WriteLine("The result is {0} ", cal.Result);
           Console.WriteLine("The  boolean result is {0} ", cal.BoolResult);
        }
    }
}