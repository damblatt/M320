namespace MB04_UndirektionaleAssoziationen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var star = new Star();
            var fan = new Fan();

            fan.Star = star;
        }
    }

    public class Star
    {
    }

    public class Fan
    {
        public Star Star { get; set; }
    }
}