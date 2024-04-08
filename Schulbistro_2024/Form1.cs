using MySqlConnector;
using Schulbistro_2024;
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
    public partial class Form1 : Form
    {
        Dbase DB = new Dbase("localhost", "Schulbistro", "root", ""); 
        Produkt_Information PInfo;
        Produkt_Creation PCrea;

        string pepper = "YouAreAPepper";

        public Form1()
        {
            InitializeComponent();

            setup();
            produktsuche();
        }


        public void setup()
        {
            lbl_Error.Text = "";
            tControl_Content.TabPages.Remove(tPage_Info);
            tControl_Content.TabPages.Remove(tPage_PVerwaltung);
            tControl_Content.TabPages.Remove(tPage_Stats);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            var connection = new MySqlConnection("server=localhost;database=schulbistro;user=root;password=");
            connection.Open();

            // SQL-Anweisung vorbereiten
            var sql = "select * from login where user = @AccountName and passwort = sha2(@passwort + Salt, 256);";
            var cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@AccountName", tBox_Account.Text);
            cmd.Parameters.AddWithValue("@passwort", tBox_Passwort.Text + pepper);

            // SQL-Anweisung ausführen
            //cmd.Prepare();

            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                tControl_Content.TabPages.Add(tPage_Info);
                tControl_Content.TabPages.Add(tPage_PVerwaltung);
                tControl_Content.TabPages.Add(tPage_Stats);
                tControl_Content.TabPages.Remove(tPage_Login);
                lbl_InfoAccountName.Text = $"{reader["user"]}";
            }
            else
            {
                lbl_Error.Text = "Error: Password or Kürzel wrong";
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PInfo = new Produkt_Information();
            PInfo.Show();
        }

        private void btn_PNew_Click(object sender, EventArgs e)
        {
            PCrea = new Produkt_Creation();
            PCrea.Show();
        }
        private void produktsuche()
        {
            dGView_Produkte.DataSource = DB.QueryToDataTable($"SELECT DISTINCT prudukt.Bezeichnung, prudukt.Preis FROM `prudukt` WHERE prudukt.Bezeichnung LIKE '%{tBox_Search.Text}%'");
        }

        private void tBox_Search_TextChanged(object sender, EventArgs e)
        {
            produktsuche();
        }
    }
}
