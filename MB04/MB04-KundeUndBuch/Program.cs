using System.Reflection;

namespace MB04_KundeUndBuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mueller = new Kunde();
            var meier = new Kunde();

            var herrDerRinge = new Buch();
            var derHobbit = new Buch();
            var python = new Buch();

            mueller.Leiht(herrDerRinge);
            mueller.Leiht(derHobbit);
            meier.Leiht(python);
            meier.Leiht(derHobbit);
        }
    }

    public class Kunde
    {
        public List<Buch> buecher { get; set; } = new List<Buch>();

        public void Leiht(Buch buch)
        {
            if (buch.IstAusgeliehen)
            {
                Console.WriteLine("Buch ist bereits ausgeliehen.");
            }
            else
            {
                this.buecher.Add(buch);
                buch.IstAusgeliehen = true;
            }
        }
    }

    public class Buch
    {
        public bool IstAusgeliehen { get; set; } = false;
    }
}