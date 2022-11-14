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
        }
    }

    public class Hund
    {
        public List<Laus> Laeuse { get; set; } = new List<Laus>();
    }

    public class Laus
    {
        public Hund Hund { get; set; }

        // Multiplizitäten mit 1 oder mehreren werden via Konstruktoren erzwungen
        public Laus(Hund hund)
        {
            this.Hund = hund;
            this.Hund.Laeuse.Add(this);
        }
    }
}