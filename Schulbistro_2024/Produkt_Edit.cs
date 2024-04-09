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
    public partial class Produkt_Edit : Form
    {
        Info information;
        Dbase DB = new Dbase("localhost", "schulbistro", "root", "");
        List<string[]> data = new List<string[]>();
        List<string> allergen = new List<string>();
        List<string> zusatzstoffe = new List<string>();

        public Produkt_Edit(string name, string info, string preis)
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
            txt_Name.Text = information.name;
            if (information.info == "" || information.info == null)
            {
                txt_Name.Text = "No Info";
            }
            else
            {
                txt_Info.Text = information.info;
            }
            txt_Preis.Text = information.preis;
            cBox_Kategorie.Text = information.kategorie;
            cBox_Ampel.Text = information.ampel;

            foreach (string value1 in allergen)
            {
                listBox_Allergen.Items.Add(value1);
            }
            foreach (string value2 in zusatzstoffe)
            {
                listBox_Zusatzstoffe.Items.Add(value2);
            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
