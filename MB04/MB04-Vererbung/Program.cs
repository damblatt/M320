namespace MB04_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();

            var kunde1 = new Kunde(1);
            var lagerist1 = new Lagerist(2);
            var kind1 = new Kind(3);

            list.Add(kunde1);
            list.Add(lagerist1);
            list.Add(kind1);

            foreach (var person in list)
            {
                person.Trage();
                person.Esse();
            }

            // Die Funktion einlagern kann nicht aufgerufen werden, da Sie nur in der Subklasse 'Lagerist' und nicht in der Klasse 'Person' definiert ist.
        }
    }
}