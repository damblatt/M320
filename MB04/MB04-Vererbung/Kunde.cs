using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04_Vererbung
{
    public class Kunde : Person
    {
        public int Umsatz { get; set; }

        public Kunde(int identNr) : base(identNr)
        {

        }

        public void Kaufe()
        {

        }

        public override void Trage()
        {
        }
    }
}
