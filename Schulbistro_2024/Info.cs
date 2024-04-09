using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulbistro_2024
{
    public class Info
    {
        string name, info, preis, kategorie, ampel;
        string[] allergen, zusatzstoffe;
        public Info(string name, string info, string preis, string kategorie, string ampel, string[] allergen, string[] zusatzstoffe) 
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
