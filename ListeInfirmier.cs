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
    public partial class ListeInfirmier : Form
    {
        public ListeInfirmier()
        {
            InitializeComponent();
        }

        static string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};" +
                                         "Server=mysql-kevinhaoyi.alwaysdata.net;" +
                                         "Database=kevinhaoyi_dbpousseseringue;" +
                                         "User=305002_admin;" +
                                         "Password=etudiant2kevin;" +
                                         "Option=3;";

        OdbcConnection connection = new OdbcConnection(connectionString);

        private void ListeInfirmier_Load(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM infirmier", connection);
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

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            nomInfirmier.BackColor = Color.White;
            prenomInfirmier.BackColor = Color.White;
            mailInfirmier.BackColor = Color.White;
            int countFill = 0;

            if (nomInfirmier.Text == "")
            {
                nomInfirmier.BackColor = Color.Red;
                countFill++;
            }
            if (prenomInfirmier.Text == "")
            {
                prenomInfirmier.BackColor = Color.Red;
                countFill++;
            }
            if (mailInfirmier.Text == "")
            {
                mailInfirmier.BackColor = Color.Red;
                countFill++;
            }

            if (countFill == 0)
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    try
                    {
                        string querySelect = "SELECT * FROM infirmier WHERE Nom = ?";
                        using (OdbcCommand selectCommand = new OdbcCommand(querySelect, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@nom", nomInfirmier.Text);
                            //selectCommand.Parameters.AddWithValue("@prenom", prenomInfirmier.Text);
                            using (OdbcDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Infirmier déjà ajouté", "", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    string insertInfirmier = "INSERT INTO infirmier (Nom,Prenom,Mail) VALUES (?,?,?)";
                                    using (OdbcCommand connect = new OdbcCommand(insertInfirmier, connection))
                                    {
                                        connect.Parameters.AddWithValue("@nom", nomInfirmier.Text);
                                        connect.Parameters.AddWithValue("@prenom", prenomInfirmier.Text);
                                        connect.Parameters.AddWithValue("@mail", mailInfirmier.Text);
                                        connect.ExecuteNonQuery();
                                        MessageBox.Show("Infirmier ajouté", "", MessageBoxButtons.OK);
                                    }
                                } 
                            }
                        }
                       
                        nomInfirmier.Text = "";
                        prenomInfirmier.Text = "";
                        mailInfirmier.Text = "";
                        nomInfirmier.BackColor = Color.White;
                        prenomInfirmier.BackColor = Color.White;
                        mailInfirmier.BackColor = Color.White;
                        OdbcCommand cmd = new OdbcCommand("SELECT * FROM infirmier", connection);
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

            while (countFill != 0)
            {
                MessageBox.Show("Veuillez remplir les cases incomplètes", "", MessageBoxButtons.OK);
                countFill = 0;
            }
        }

        private void nomInfirmier_TextChanged(object sender, EventArgs e)
        {
            if (nomInfirmier.Text.Length > 0) { nomInfirmier.BackColor = Color.White; }
        }

        private void prenomInfirmier_TextChanged(object sender, EventArgs e)
        {
            if (prenomInfirmier.Text.Length > 0) { prenomInfirmier.BackColor = Color.White; }
        }

        private void mailInfirmier_TextChanged(object sender, EventArgs e)
        {
            if (mailInfirmier.Text.Length > 0) { mailInfirmier.BackColor = Color.White; }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nomInfirmier.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            prenomInfirmier.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mailInfirmier.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void fermerIHM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    string queryDelete = "DELETE FROM infirmier WHERE idInfirmier = ?";
                    using (OdbcCommand deleteCommand = new OdbcCommand(queryDelete, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@ID", label_idInfirmier.Text);
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Infirmier supprimé", "", MessageBoxButtons.OK);
                    }
                    label_idInfirmier.Text = "";
                    nomInfirmier.Text = "";
                    prenomInfirmier.Text = "";
                    mailInfirmier.Text = "";
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM infirmier", connection);
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    connection.Close();
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
