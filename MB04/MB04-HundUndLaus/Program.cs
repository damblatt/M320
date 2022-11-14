namespace MB04_HundUndLaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ben = new Hund();
            
            var laus1 = new Laus(ben);
            var laus2 = new Laus(ben);
            var laus3 = new Laus(ben);

            ben.Laeuse.Add(laus1);
            ben.Laeuse.Add(laus2);
            ben.Laeuse.Add(laus3);
        }
    }

    public class Hund
    {
        public List<Laus> Laeuse { get; set; } = new List<Laus>();
    }

    public class Laus
    {
        public Hund Hund { get; set; }

        public Laus(Hund hund)
        {
            Hund = hund;
        }
    }
}