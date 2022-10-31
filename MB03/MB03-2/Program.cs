namespace MB03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(5, 10);
            var rectangle2 = new Rectangle(5);
            var rectangle3 = new Rectangle(5, 10, "red");
            var rectangle4 = new Rectangle(5, 10, 256);

            var rectangle5 = new Rectangle(3)
            {
                Color = "green",
                Alpha = 128
            };
        }
    }
}