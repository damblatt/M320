using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Reception
    {
        private int telefonNummer;
        private string emailAdresse;

        public Hotel Hotel { get; set; }

        public Reception(Hotel hotel)
        {
            if (hotel.Reception == null)
            {
                hotel.Reception = this;
                Hotel = hotel;
            } else
            {
                Console.WriteLine("Das Hotel hat bereits die maximale Anzahl an Receptions erreicht.");
            }
        }
    }
}
