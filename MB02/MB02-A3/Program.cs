namespace MB02_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.Write("first number: ");
            var firstNumberVar = Console.ReadLine();
            var firstNumber = Convert.ToInt32(firstNumberVar);
            Console.Write("second number: ");
            var secondNumberVar = Console.ReadLine();
            var secondNumber = Convert.ToInt32(secondNumberVar);

            int result = calculator.Division(firstNumber, secondNumber);
            Console.WriteLine(result);
            result = calculator.Division(secondNumber);
            Console.WriteLine(result);
        }
    }
}