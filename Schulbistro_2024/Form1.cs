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
using System.Xml.Linq;

namespace Schulbistro_2024
{
    public partial class Form1 : Form
    {
        Dbase DB = new Dbase("localhost", "Schulbistro", "root", "");
        List<string[]> chart = new List<string[]>();
        List<string> produkte = new List<string>();
        Produkt_Information PInfo;
        Produkt_Creation PCrea;
        Produkt_Edit PEdit;
        private readonly DataGridViewButtonColumn btnInfo = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();

        string pepper = "YouAreAPepper";

        public Form1()
        {
            InitializeComponent();

            setup();

            tBox_Account.Text = "admin";
            tBox_Passwort.Text = "Manna!2024";
        }


        public void setup()
        {
            lbl_Error.Text = "";
            tControl_Content.TabPages.Remove(tPage_PVerwaltung);
            tControl_Content.TabPages.Remove(tPage_Stats);

            btnInfo.HeaderText = "";
            btnInfo.Name = "btn_Info";
            btnInfo.Text = "More Info";
            btnInfo.UseColumnTextForButtonValue = true;

            btnEdit.HeaderText = "";
            btnEdit.Name = "btn_Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;


            dGView_Produkte.Columns.Add(btnInfo);
            dGView_PVerwaltung.Columns.Add(btnEdit);

            produktsuche(dGView_Produkte, tBox_Search.Text);
            produktsuche(dGView_PVerwaltung, tBox_PVSuche.Text);

            produkte = DB.QueryToList($"SELECT DISTINCT prudukt.Bezeichnung FROM `prudukt`");
            cBox_SProdukte.DataSource = produkte;
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
                tControl_Content.TabPages.Add(tPage_PVerwaltung);
                tControl_Content.TabPages.Add(tPage_Stats);
                tControl_Content.TabPages.Remove(tPage_Login);
            }
            else
            {
                lbl_Error.Text = "Error: Password or Kürzel wrong";
            }

            connection.Close();
        }

        private void btn_PNew_Click(object sender, EventArgs e)
        {
            PCrea = new Produkt_Creation();
            PCrea.Show();
        }
        private void produktsuche(DataGridView dGV, string search)
        {
            string query = $"SELECT prudukt.Bezeichnung, prudukt.info AS Info, prudukt.Preis, ampelstatus.Farbe AS 'Nutri-Score' FROM prudukt, ampelstatus WHERE prudukt.Bezeichnung LIKE '%{search}%' and prudukt.Status_ID = ampelstatus.Status_ID; ";
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV.DataSource = DB.QueryToDataTable(query);
        }

        private void tBox_Search_TextChanged(object sender, EventArgs e)
        {
            produktsuche(dGView_Produkte, tBox_Search.Text);
        }

        private void tBox_PVSuche_TextChanged(object sender, EventArgs e)
        {
            produktsuche(dGView_PVerwaltung, tBox_PVSuche.Text);
        }

        private void dGView_Produkte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < dGView_Produkte.RowCount) // Info
            {
                //MessageBox.Show($"{dGView_Produkte.Rows[e.RowIndex].Cells[1].Value}, {dGView_Produkte.Rows[e.RowIndex].Cells[2].Value}, {dGView_Produkte.Rows[e.RowIndex].Cells[3].Value}");
                PInfo = new Produkt_Information(dGView_Produkte.Rows[e.RowIndex].Cells[1].Value.ToString(), dGView_Produkte.Rows[e.RowIndex].Cells[2].Value.ToString(), dGView_Produkte.Rows[e.RowIndex].Cells[3].Value.ToString());
                PInfo.Show();
            }
        }

        private void dGView_PVerwaltung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < dGView_Produkte.RowCount) // Edit
            {
                //MessageBox.Show((e.RowIndex + 1).ToString());
                PEdit = new Produkt_Edit((e.RowIndex + 1), dGView_Produkte.Rows[e.RowIndex].Cells[1].Value.ToString(), dGView_Produkte.Rows[e.RowIndex].Cells[2].Value.ToString(), dGView_Produkte.Rows[e.RowIndex].Cells[3].Value.ToString());
                PEdit.Show();
            }
        }

        private void cBox_SProdukte_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_Stats.Series[0].Points.Clear();
            string[] chartZerlegt;
            chart = DB.QueryToArrayList($"SELECT verkaufsstatistik.Datum, verkaufsstatistik.Verkaufsmenge FROM verkaufsstatistik, prudukt WHERE prudukt.P_Nr = '{cBox_SProdukte.SelectedIndex + 1}' AND prudukt.P_Nr = verkaufsstatistik.P_Nr;");
            //MessageBox.Show(chart[0][0] + "|" + chart[0][1]);
            
            for (int i = 0; i < chart.Count; i++)
            {
                chartZerlegt = chart[i][0].Split(' ');
                chart_Stats.Series[0].Points.AddXY(chartZerlegt[0], chart[i][1]);
            }
        }
    }
}
