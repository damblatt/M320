using System.Security.Cryptography.X509Certificates;

namespace MB04_KundeUndKonto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kunde = new Kunde();
            var konto1 = new Konto(kunde);
            var konto2 = new Konto(kunde);
        }
    }

    public class Kunde
    {
        public List<Konto> Konten = new List<Konto>();

        public void AddKonto(Konto konto)
        {
            if (Konten.Count < 5)
            {
                this.Konten.Add(konto);
            } else
            {
                Console.WriteLine("Kunde kann nicht mehr Konten haben.");
            }
        }
    }

    public class Konto
    {
        public Konto(Kunde kunde)
        {
            kunde.AddKonto(this);
        }
    }
}