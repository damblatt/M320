namespace MB02_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int result;
            string firstNumberVar;
            int firstNumber;
            string secondNumberVar;
            int secondNumber;

            Console.Write("first number: ");
            firstNumberVar = Console.ReadLine();
            firstNumber = Convert.ToInt32(firstNumberVar);
            Console.Write("second number: ");
            secondNumberVar = Console.ReadLine();
            secondNumber = Convert.ToInt32(secondNumberVar);

            result = calculator.Addition(firstNumber, secondNumber);
            Console.WriteLine(result);
            result = calculator.Addition(5);
            Console.WriteLine(result);
        }
    }
}