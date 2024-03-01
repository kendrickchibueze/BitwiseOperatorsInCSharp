namespace BitwiseOperatorsInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

     
            /*Console.WriteLine("**Building A Simple Calculator in C#...**");
            Console.WriteLine();

            MyCalculator cal = new MyCalculator();
            Console.WriteLine("Enter the first Operand: ");
            cal.OperandOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Operand : ");
            cal.OperandTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Operator: (+, -, /, &, *, =, !, %, |, >, <)");
            cal.Op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            cal.MakeCalculation();
            Console.WriteLine("The result is {0} ", cal.Result);
            Console.WriteLine("The  boolean result is {0} ", cal.BoolResult);*/

            Console.WriteLine("**Building A Simple Calculator in C#...**");
            Console.WriteLine();
            
        
     Input: while (true)
            {
                try
                {
                        MyCalculator cal = new MyCalculator();
                        Console.WriteLine("Enter the first Operand: ");
                        cal.OperandOne = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Second Operand : ");
                        cal.OperandTwo = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Operator: (+, -, /, &, *, =, !, %, |, >, <)");
                        cal.Op = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        cal.MakeCalculation();
                        Console.WriteLine("The result is {0} ", cal.Result);
                        Console.WriteLine("The boolean result is {0} ", cal.BoolResult);
                        Console.WriteLine();

                        Console.WriteLine("Press Enter to continue or type 'exit' to quit.");
                        string userInput = Console.ReadLine().Trim();
                        if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Exiting the program...");
                            break;
                        }
                        goto Input;
                }
             
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    goto Input;
                }
            }
        }
    }
}