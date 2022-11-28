using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04_Vererbung
{
    internal class Kind : Person
    {
        public int Alter { get; set; }

        public Kind(int identNr) : base(identNr)
        {

        }

        public override void Trage()
        {
        }

        public override void Esse()
        {
            base.Esse();
        }
    }
}
