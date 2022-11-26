using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Hotel
    {
        public string Name { get; set; }
        public string Adresse { get; set; }

        public Reception Reception { get; set; }
        public List<Zimmer> Zimmer { get; set; } = new List<Zimmer>(); // muss eines haben
        public List<Sitzungszimmer> Sitzungszimmer { get; set; } = new List<Sitzungszimmer>(); // kann haben
    }
}
