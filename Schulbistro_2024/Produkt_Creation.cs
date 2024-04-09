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
    public partial class Produkt_Creation : Form
    {
        Dbase DB = new Dbase("localhost", "Schulbistro", "root", "");

        public Produkt_Creation()
        {
            InitializeComponent();

            loadComboBoxen();
            loadListBoxen();
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateProdukt();
            this.Close();
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
            foreach(string i in liste)
            {
                listBox_Zusatzstoffe.Items.Add(i);
            }
        }
        //INSERT INTO `prudukt`(`P_Nr`, `Bezeichnung`, `info`, `Preis`, `Kat_ID`, `Status_ID`) VALUES(24,'Test','Test','1.50','1','1')
        private void CreateProdukt()
        {
            int i = Convert.ToInt32(DB.QueryString($"SELECT MAX(prudukt.P_Nr)+1 FROM prudukt"));
            string hinzufügen;
            hinzufügen = $"INSERT INTO `prudukt`(`P_Nr`, `Bezeichnung`, `info`, `Preis`, `Kat_ID`, `Status_ID`) VALUES('{i}', '{txt_Name.Text}', '{txt_Info.Text}', '{txt_Preis.Text}', '{cBox_Kategorie.SelectedIndex +1}', '{cBox_Ampel.SelectedIndex +1}')";
            Debug.WriteLine(hinzufügen);
            DB.ExecuteQuery(hinzufügen);
            hinzufügen = $"INSERT INTO `allergeninprodukt`(`P_Nr`, `A_ID`) VALUES ('{i}','{listBox_Allergen.SelectedIndex +1}')";
            Debug.WriteLine(hinzufügen);
            DB.ExecuteQuery(hinzufügen);
            hinzufügen = $"INSERT INTO `zusatzstoffinprodukt`(`P_Nr`, `Z_ID`) VALUES ('{i}','{listBox_Zusatzstoffe.SelectedIndex + 1}')";
            Debug.WriteLine(hinzufügen);
            DB.ExecuteQuery(hinzufügen);
        }
    }
}
