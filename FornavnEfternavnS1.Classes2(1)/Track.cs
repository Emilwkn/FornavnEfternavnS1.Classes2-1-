using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes2_1_
{
    class Track
    {
        public string kunstner;
        public string titel;
        public int antalMin;
        public int antalSek;


        public Track(string kunstner, string titel, int antalMin, int antalSek)
        {
            Kunstner = kunstner;
            Titel = titel;
            AntalMin = antalMin;
            AntalSek = antalSek;
        }


        public string Kunstner { get; set; }
        public string Titel { get; set; }
        public int AntalMin { get; set; }
        public int AntalSek { get; set; }


        public override string ToString()
        {
            return $"{Titel}: {Kunstner} ({AntalMin}:{AntalSek})";
        }
    }
}
