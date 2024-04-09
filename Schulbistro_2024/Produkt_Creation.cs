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
    public partial class Produkt_Creation : Form
    {
        Dbase DB = new Dbase("localhost", "Schulbistro", "root", "");

        public Produkt_Creation()
        {
            InitializeComponent();

            loadComboBoxen();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

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
    }
}
