using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes2_1_
{
    class book
    {
        private string forfatter;
        private string titel;
        private int antalSider;
        private string forlag;


        public book(string forfatter, string titel, int antalSider, string forlag)
        {
            Forfatter = forfatter;
            Titel = titel;
            AntalSider = antalSider;
            Forlag = forlag;
        }


        public string Forfatter { get; set; }
        public string Titel { get; set; }
        public int AntalSider { get; set; }
        public string Forlag { get; set; }

        public override string ToString()
        {
            return $"{Titel}-{Forfatter}";
        }
    }
}
