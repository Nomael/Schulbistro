using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int pID;

        public Produkt_Edit(int pID, string name, string info, string preis)
        {
            InitializeComponent();
           
                data = DB.QueryToArrayList($"SELECT kategorie.Bezeichnung, ampelstatus.Farbe FROM prudukt, kategorie, ampelstatus WHERE prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.Kat_ID = kategorie.Kat_ID AND prudukt.Status_ID = ampelstatus.Status_ID;");
                allergen = DB.QueryToList($"SELECT allergen.Bezeichnung from allergen, allergeninprodukt, prudukt where prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.P_Nr = allergeninprodukt.P_Nr AND allergeninprodukt.A_ID = allergen.A_ID");
                zusatzstoffe = DB.QueryToList($"SELECT zusatzstoff.Bezeichnung from zusatzstoff, zusatzstoffinprodukt, prudukt where prudukt.Bezeichnung = '{name}' AND prudukt.info = '{info}' AND prudukt.P_Nr = zusatzstoffinprodukt.P_Nr AND zusatzstoffinprodukt.Z_ID = zusatzstoff.Z_ID");
                this.pID = pID;

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
        private void EditProdukt()
        {
            if (txt_Name.Text == "" || txt_Preis.Text == "")
            {
                MessageBox.Show("Name oder Preis nicht angegeben", "Fehler");
            }
            else
            {
                string edit;
                edit = $"UPDATE `prudukt` SET `Bezeichnung`= '{txt_Name.Text}',`info`= '{txt_Info.Text}',`Preis`= '{txt_Preis.Text}',`Kat_ID`= '{cBox_Kategorie.SelectedIndex + 1}',`Status_ID`= '{cBox_Ampel.SelectedIndex + 1}' WHERE `P_Nr` = '{pID}'";
                Debug.WriteLine(edit);
                DB.ExecuteQuery(edit);
                edit = $"DELETE FROM `allergeninprodukt` WHERE allergeninprodukt.P_Nr = '{pID}'";
                Debug.WriteLine(edit);
                DB.ExecuteQuery(edit);
                foreach (var j in listBox_Allergen.CheckedItems)
                {
                    edit = $"INSERT INTO `allergeninprodukt`(`P_Nr`, `A_ID`) VALUES ('{pID}',(SELECT allergen.A_ID FROM allergen WHERE allergen.Bezeichnung = '{j}'))";
                    Debug.WriteLine(edit);
                    DB.ExecuteQuery(edit);
                }
                edit = $"DELETE FROM `zusatzstoffinprodukt` WHERE zusatzstoffinprodukt.P_Nr = '{pID}'";
                Debug.WriteLine(edit);
                DB.ExecuteQuery(edit);
                foreach (var j in listBox_Zusatzstoffe.CheckedItems)
                {
                    edit = $"INSERT INTO `zusatzstoffinprodukt`(`P_Nr`, `Z_ID`) VALUES ('{pID}',(SELECT zusatzstoff.Z_ID FROM zusatzstoff WHERE zusatzstoff.Bezeichnung = '{j}'))";
                    Debug.WriteLine(edit);
                    DB.ExecuteQuery(edit);
                }
                this.Close();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProdukt();
        }
    }
}
