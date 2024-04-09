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
        private readonly DataGridViewButtonColumn btnInfo = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

        string pepper = "YouAreAPepper";

        public Form1()
        {
            InitializeComponent();

            setup();

            tBox_Account.Text = "admin";
            tBox_Passwort.Text = "Manna!2024";


            dGView_Produkte.Columns.Add(btnInfo);
            dGView_PVerwaltung.Columns.Add(btnEdit);
            dGView_PVerwaltung.Columns.Add(btnDelete);

            produktsuche(dGView_Produkte, tBox_Search.Text);
            produktsuche(dGView_PVerwaltung, tBox_PVSuche.Text);
        }


        public void setup()
        {
            lbl_Error.Text = "";
            tControl_Content.TabPages.Remove(tPage_PVerwaltung);
            tControl_Content.TabPages.Remove(tPage_Stats);

            btnInfo.HeaderText = "";
            btnInfo.Name = "btn_Info";
            btnInfo.Text = "Info";
            btnInfo.UseColumnTextForButtonValue = true;

            btnEdit.HeaderText = "";
            btnEdit.Name = "btn_Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            btnDelete.HeaderText = "";
            btnDelete.Name = "btn_Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
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
            string query = $"SELECT prudukt.Bezeichnung, prudukt.Preis, prudukt.info FROM `prudukt` WHERE prudukt.Bezeichnung LIKE '%{search}%'";
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
                MessageBox.Show($"{dGView_Produkte.Rows[e.RowIndex].Cells[1].Value}, {dGView_Produkte.Rows[e.RowIndex].Cells[2].Value}, {dGView_Produkte.Rows[e.RowIndex].Cells[3].Value}");
            }
        }

        private void dGView_PVerwaltung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < dGView_Produkte.RowCount) // Edit
            {

            }
            else if (e.ColumnIndex == 1 && e.RowIndex < dGView_Produkte.RowCount) // Delete
            {

            }
        }
    }
}
