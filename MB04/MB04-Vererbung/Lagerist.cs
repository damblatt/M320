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

        }

        public override void Trage()
        {
        }
    }
}
