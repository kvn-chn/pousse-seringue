using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Generic_HID_reference_application
{
    public partial class TableauInjection : Form
    {
        public TableauInjection()
        {
            InitializeComponent();
        }

        static string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=mysql-kevinhaoyi.alwaysdata.net;Database=kevinhaoyi_dbpousseseringue;User=305002_admin;Password=etudiant2kevin;Option=3;";
        OdbcConnection connection = new OdbcConnection(connectionString);

        private void TableauInjection_Load(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM traitementseringue", connection);
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            connection.Close();
            }
        }

        private void fermerIHM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            OdbcCommand search = new OdbcCommand("SELECT * FROM traitementseringue WHERE Patient_NumSecu like '%" + textBoxRechercher.Text + "%' ", connection);
            OdbcDataAdapter adapter = new OdbcDataAdapter(search);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void updateTable_Tick(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM traitementseringue", connection);
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label_debitVolumique.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label_volume.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            label_debutTraitement.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label_volumeInjecte.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label_volumeRestant.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            label_tempsRestant.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            label_numSecu.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            label_infirmier.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
