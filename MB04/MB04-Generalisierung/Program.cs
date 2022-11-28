namespace MB04_Generalisierung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Blatt";
            person.Vorname = "Damian";
            person.Essen();

            var kunde = new Kunde();
            kunde.Name = "Brülisauer";
            kunde.Vorname = "Manuel";
            kunde.Essen();
            kunde.Kaufen();

            var lagerist = new Lagerist();
            lagerist.Name = "Inauen";
            lagerist.Vorname = "Maurin";
            lagerist.Groesse = 185;
            lagerist.Essen();
            lagerist.Einlagern();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }

        public void Essen()
        {

        }
    }

    public class Kunde : Person
    {
        public decimal Umsatz { get; set; }

        public void Kaufen()
        {

        }
    }

    public class Lagerist : Person
    {
        public int Groesse { get; set; }
        
        public void Einlagern()
        {

        }
    }
}