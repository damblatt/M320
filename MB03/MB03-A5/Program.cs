namespace MB03_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person(55, "manuel");
            Console.WriteLine(firstPerson.CurrentRage);

            firstPerson.RelieveRageWithSleep(3);
            Console.WriteLine($"{firstPerson.Operation}: Your rage went from {firstPerson.PreviousRage} to {firstPerson.CurrentRage}.");

            firstPerson.RelieveRageWithHugs(2);
            Console.WriteLine($"{firstPerson.Operation}: Your rage went from {firstPerson.PreviousRage} to {firstPerson.CurrentRage}.");

            firstPerson.RelieveRageWithCannabis();
            Console.WriteLine($"{firstPerson.Operation}: Your rage went from {firstPerson.PreviousRage} to {firstPerson.CurrentRage}.");
        }
    }
}