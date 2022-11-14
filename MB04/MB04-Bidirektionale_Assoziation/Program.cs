namespace MB04_BidirektionaleAssoziation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var child = new Child();
            var father = new Father();

            child.Father = father;
            father.Child = child;
        }

        public class Child
        {
            public Father Father { get; set; }
        }

        public class Father
        {
            public Child Child { get; set; }
        }
    }
}