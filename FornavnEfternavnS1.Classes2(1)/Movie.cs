using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes2_1_
{
    class Movie
    {
        private string titel;
        private string instruktør;
        private string hovedPerson;
        private double længde;


        public Movie(string titel, string instruktør, string hovedPerson, double længde)
        {
            Titel = titel;
            Instruktør = instruktør;
            HovedPerson = hovedPerson;
            Længde = længde;
        }


        public string Titel { get; set; }
        public string Instruktør { get; set; }
        public string HovedPerson { get; set; }
        public double Længde { get; set; }



        public override string ToString()
        {
            return $"{Titel} ({længde})";
        }
    }
}
