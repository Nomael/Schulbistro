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

            loadKategorie();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void loadKategorie()
        {
            cBox_Kategorie.Items.Add(DB.QueryString($"SELECT kategorie.Bezeichnung FROM `kategorie`"));
        }
    }
}
