using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04_Vererbung
{
    public class Lagerist : Person
    {
        public int Groesse { get; set; }

        public Lagerist(int identNr) : base(identNr)
        {

        }

        public void LagereEin()
        {
            Console.WriteLine("Ich als Lagerist lagere ein.");
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Lagerist trage die Ware herum.");
        }
    }
}
