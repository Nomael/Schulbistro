using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulbistro_2024
{
    public partial class Produkt_Information : Form
    {
        Info information;
        Dbase DB = new Dbase("localhost", "schulbistro", "root", "");
        List<string[]> data = new List<string[]>();
        List<string> allergen = new List<string>();
        List<string> zusatzstoffe = new List<string>();

        public Produkt_Information(string name, string info, string preis)
        {
            InitializeComponent();

            data = DB.QueryToArrayList($"SELECT prudukt.info, kategorie.Bezeichnung, ampelstatus.Farbe FROM prudukt, kategorie, ampelstatus WHERE prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.Kat_ID = kategorie.Kat_ID AND prudukt.Status_ID = ampelstatus.Status_ID;");
            allergen = DB.QueryToList($"SELECT allergen.Bezeichnung from allergen, allergeninprodukt, prudukt where prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.P_Nr = allergeninprodukt.P_Nr AND allergeninprodukt.A_ID = allergen.A_ID");
            zusatzstoffe = DB.QueryToList($"SELECT zusatzstoff.Bezeichnung from zusatzstoff, zusatzstoffinprodukt, prudukt where prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.P_Nr = zusatzstoffinprodukt.P_Nr AND zusatzstoffinprodukt.Z_ID = zusatzstoff.Z_ID");

            information = new Info(name, info, preis, data[0][0], data[0][1], allergen, zusatzstoffe);

            showData();
        }

        private void showData()
        {
            lbl_NameValue.Text = information.name;
            if (information.info == "" || information.info == null)
            {
                lbl_InfoValue.Text = "No Info";
            }
            else
            {
                lbl_InfoValue.Text = information.info;
            }
            lbl_PreisValue.Text = information.preis;
            lbl_KategorieValue.Text = information.kategorie;
            lbl_AmpelValue.Text = information.ampel;
            
            foreach (string value1 in allergen)
            {
                lBox_Allergen.Items.Add(value1);
            }
            foreach (string value2 in zusatzstoffe)
            {
                lBox_ZusatzstoffeValue.Items.Add(value2);
            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
