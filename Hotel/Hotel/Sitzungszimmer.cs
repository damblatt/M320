using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Sitzungszimmer
    {
        public int Nummer { get; set; }
        public int AnzahlPlätze { get; set; }

        public Hotel Hotel { get; set; }

        public List<Beamer> Beamer { get; set; }

        public Sitzungszimmer(Hotel hotel)
        {
            if (hotel.Zimmer.Count < 3)
            {
                hotel.Sitzungszimmer.Add(this);
                Hotel = hotel;
            }
            else
            {
                Console.WriteLine("Das Hotel hat bereits die maximale Anzahl an Sitzungszimmern erreicht.");
            }
        }

        public void BeamerHinzufügen(Beamer beamer)
        {
            if (Beamer.Count < 2)
            {
                Beamer.Add(beamer);
            } else
            {
                Console.WriteLine("Das Sitzungszimmer hat bereits die maximale Anzahl an Beamern erreicht.");
            }
        }
    }
}
