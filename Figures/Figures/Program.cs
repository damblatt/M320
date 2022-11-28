namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRotatable rechteck = new Rechteck();
            IRotatable dreieck = new Dreieck();
            IRotatable dreieck2 = new Dreieck();

            var list = new List<IRotatable>();
            list.Add(rechteck);
            list.Add(dreieck);
            list.Add(dreieck2);

            foreach (var item in list)
            {
                item.Rotate();
            }
        }
    }
}