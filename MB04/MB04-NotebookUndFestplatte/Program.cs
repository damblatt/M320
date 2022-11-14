namespace MB04_NotebookUndFestplatte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var festplatte = new Festplatte();

            var notebook1 = new Notebook(festplatte);
            var notebook2 = new Notebook(festplatte);
        }
    }

    public class Notebook
    {
        public Festplatte Festplatte { get; set; }
        public Notebook(Festplatte festplatte)
        {
            if (festplatte.IstEingebaut)
            {
                Console.WriteLine("Festplatte ist bereits eingebaut.");
            }
            else
            {
                Festplatte = festplatte;
                festplatte.IstEingebaut = true;
            }
        }

        public void FestplatteAustauschen(Festplatte neueFestplatte)
        {
            if (neueFestplatte.IstEingebaut)
            {
                Console.WriteLine("Neue Festplatte bereits eingebaut.");
                return;
            }

            var alteFestplatte = Festplatte;
            alteFestplatte.IstEingebaut = false;

            Festplatte = neueFestplatte;
            Festplatte.IstEingebaut = true;
        }
    }

    public class Festplatte
    {
        public bool IstEingebaut { get; set; } = false;
    }
}