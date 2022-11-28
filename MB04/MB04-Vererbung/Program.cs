namespace MB04_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kunde1 = new Kunde(1)
            {
                Umsatz = 100
            };
            var lagerist1 = new Lagerist(2)
            {
                Groesse = 180
            };
        }
    }
}