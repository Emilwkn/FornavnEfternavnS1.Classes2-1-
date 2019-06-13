using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes2_1_
{
    class Playlist
    {
        private string navn;
        private string sange;


        public Playlist(string navn, string sange)
        {
            Navn = navn;
            Sange = sange;
        }


        public string Navn { get; set; }
        public string Sange { get; set; }

        public override string ToString()
        {
            return $"{Navn} indeholder {Sange}, hvilket varer ((";
        }
    }
}
