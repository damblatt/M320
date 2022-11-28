using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Beamer
    {
        public string Name { get; set; }
        public int Auflösung { get; }

        public Beamer(Sitzungszimmer sitzungszimmer)
        {
            sitzungszimmer.BeamerHinzufügen(this);
        }
    }
}
