using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulbistro_2024
{
    public class Info
    {
        public string name { get; set; }
        public string info { get; set; }
        public string preis { get; set; }
        public string kategorie { get; set; }
        public string ampel { get; set; }

        public List<string> allergen { get; set; }
        public List<string> zusatzstoffe { get; set; }
        public Info(string name, string info, string preis, string kategorie, string ampel, List<string> allergen, List<string> zusatzstoffe) 
        {
            this.name = name;
            this.info = info;
            this.preis = preis;
            this.kategorie = kategorie;
            this.ampel = ampel;
            this.allergen = allergen;
            this.zusatzstoffe = zusatzstoffe;
        }


    }
}
