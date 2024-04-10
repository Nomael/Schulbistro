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
           
                data = DB.QueryToArrayList($"SELECT kategorie.Bezeichnung, ampelstatus.Farbe FROM prudukt, kategorie, ampelstatus WHERE prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.Kat_ID = kategorie.Kat_ID AND prudukt.Status_ID = ampelstatus.Status_ID;");
                allergen = DB.QueryToList($"SELECT allergen.Bezeichnung from allergen, allergeninprodukt, prudukt where prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.P_Nr = allergeninprodukt.P_Nr AND allergeninprodukt.A_ID = allergen.A_ID");
                zusatzstoffe = DB.QueryToList($"SELECT zusatzstoff.Bezeichnung from zusatzstoff, zusatzstoffinprodukt, prudukt where prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.P_Nr = zusatzstoffinprodukt.P_Nr AND zusatzstoffinprodukt.Z_ID = zusatzstoff.Z_ID");

                information = new Info(name, info, preis, data[0][0], data[0][1], allergen, zusatzstoffe);

            loadComboBoxen();
            loadListBoxen();

            showData();
            
        }
        private void showData()
        {
            txt_Name.Text = information.name;
            if (information.info == "" || information.info == null)
            {
                txt_Info.Text = "No Info";
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
                int index = listBox_Allergen.FindString(value1);    
                    listBox_Allergen.SetItemChecked(index, true);   
            }
            foreach (string value2 in zusatzstoffe)
            {
                int index = listBox_Zusatzstoffe.FindString(value2);
                listBox_Zusatzstoffe.SetItemChecked(index, true);
            }


        }
        private void loadComboBoxen()
        {
            List<string> liste = DB.QueryToList($"SELECT kategorie.Bezeichnung FROM `kategorie` ");
            foreach (string i in liste)
            {
                cBox_Kategorie.Items.Add(i);
            }
            liste = DB.QueryToList($"SELECT ampelstatus.Farbe FROM `ampelstatus`");
            foreach (string i in liste)
            {
                cBox_Ampel.Items.Add(i);
            }
        }

        private void loadListBoxen()
        {
            List<string> liste = DB.QueryToList($"SELECT allergen.Bezeichnung FROM `allergen` ");
            foreach (string i in liste)
            {
                listBox_Allergen.Items.Add(i);
            }
            liste = DB.QueryToList($"SELECT zusatzstoff.Bezeichnung FROM `zusatzstoff`");
            foreach (string i in liste)
            {
                listBox_Zusatzstoffe.Items.Add(i);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
