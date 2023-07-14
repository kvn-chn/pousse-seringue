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
    public partial class ListePatient : Form
    {

        public ListePatient()
        {
            InitializeComponent();
        }

        static string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=mysql-kevinhaoyi.alwaysdata.net;Database=kevinhaoyi_dbpousseseringue;User=305002_admin;Password=etudiant2kevin;Option=3;";
        OdbcConnection connection = new OdbcConnection(connectionString);

        private void Form_Load(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM patient", connection);

                    // create an OdbcDataAdapter object with the OdbcCommand object
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);

                    // create a DataTable object
                    DataTable table = new DataTable();

                    // fill the DataTable object with the data from the database using the OdbcDataAdapter object
                    adapter.Fill(table);

                    // set the DataSource property of the DataGridView control to the DataTable object
                    dataGridView1.DataSource = table;
                    connection.Close();
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            nomPatient.BackColor = Color.White;
            prenomPatient.BackColor = Color.White;
            agePatient.BackColor = Color.White;
            numChambre.BackColor = Color.White;
            etagePatient.BackColor = Color.White;
            numSecuPatient.BackColor = Color.White;

            int countFill = 0;

            if (numSecuPatient.Text.Length != 13)
            {
                numSecuPatient.BackColor = Color.Red;
                countFill++;
            }
            if (nomPatient.Text == "")
            {
                nomPatient.BackColor = Color.Red;
                countFill++;
            }
            if (prenomPatient.Text == "")
            {
                prenomPatient.BackColor = Color.Red;
                countFill++;
            }
            if (agePatient.Text == "")
            {
                agePatient.BackColor = Color.Red;
                countFill++;
            }
            if (numChambre.Text == "")
            {
                numChambre.BackColor = Color.Red;
                countFill++;
            }
            if (etagePatient.Text == "")
            {
                etagePatient.BackColor = Color.Red;
                countFill++;
            }

            if (countFill == 0)
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    try
                    {
                        string querySelect = "SELECT * FROM patient WHERE NumSecu = ?";
                        using (OdbcCommand selectCommand = new OdbcCommand(querySelect, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@numSecu", numSecuPatient.Text);
                            using (OdbcDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Patient déjà ajouté", "", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    string insertPatient = "INSERT INTO patient (NumSecu,Nom,Prenom,Age,NumChambre,Etage) VALUES (?,?,?,?,?,?)";
                                    using (OdbcCommand connect = new OdbcCommand(insertPatient, connection))
                                    {
                                        connect.Parameters.AddWithValue("@numSecu", numSecuPatient.Text);
                                        connect.Parameters.AddWithValue("@nom", nomPatient.Text);
                                        connect.Parameters.AddWithValue("@prenom", prenomPatient.Text);
                                        connect.Parameters.AddWithValue("@age", agePatient.Text);
                                        connect.Parameters.AddWithValue("@numChambre", numChambre.Text);
                                        connect.Parameters.AddWithValue("@etage", etagePatient.Text);
                                        connect.ExecuteNonQuery();
                                        MessageBox.Show("Patient ajouté", "", MessageBoxButtons.OK);
                                    }
                                }
                            }
                        }
                        numSecuPatient.Text = "";
                        nomPatient.Text = "";
                        prenomPatient.Text = "";
                        agePatient.Text = "";
                        numChambre.Text = "";
                        etagePatient.Text = "";
                        nomPatient.BackColor = Color.White;
                        prenomPatient.BackColor = Color.White;
                        agePatient.BackColor = Color.White;
                        numChambre.BackColor = Color.White;
                        etagePatient.BackColor = Color.White;
                        OdbcCommand cmd = new OdbcCommand("SELECT * FROM patient", connection);
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

            if (countFill != 0)
            {
                MessageBox.Show("Veuillez remplir les cases incomplètes", "", MessageBoxButtons.OK);
                countFill = 0;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numSecuPatient.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomPatient.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            prenomPatient.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            agePatient.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            numChambre.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            etagePatient.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    string queryUpdate = "UPDATE patient SET Nom = ?, Prenom = ?, Age = ?, NumChambre = ?, Etage = ? WHERE NumSecu = ?";
                    using (OdbcCommand updateCommand = new OdbcCommand(queryUpdate, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nom", nomPatient.Text);
                        updateCommand.Parameters.AddWithValue("@prenom", prenomPatient.Text);
                        updateCommand.Parameters.AddWithValue("@age", agePatient.Text);
                        updateCommand.Parameters.AddWithValue("@numChambre", numChambre.Text);
                        updateCommand.Parameters.AddWithValue("@etage", etagePatient.Text);
                        updateCommand.Parameters.AddWithValue("@Patient_NumSecu", numSecuPatient.Text);
                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("Patient mis à jour", "", MessageBoxButtons.OK);
                    }
                    numSecuPatient.Text = "";
                    nomPatient.Text = "";
                    prenomPatient.Text = "";
                    agePatient.Text = "";
                    numChambre.Text = "";
                    etagePatient.Text = "";
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM patient", connection);
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

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    string queryDelete = "DELETE FROM patient WHERE NumSecu = ?";
                    using (OdbcCommand deleteCommand = new OdbcCommand(queryDelete, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@numSecu", numSecuPatient.Text);
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Patient supprimé", "", MessageBoxButtons.OK);
                    }
                    numSecuPatient.Text = "";
                    nomPatient.Text = "";
                    prenomPatient.Text = "";
                    agePatient.Text = "";
                    numChambre.Text = "";
                    etagePatient.Text = "";
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM patient", connection);
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

        private void nomPatient_TextChanged(object sender, EventArgs e)
        {
            if (nomPatient.Text.Length > 0) { nomPatient.BackColor = Color.White; }
        }

        private void prenomPatient_TextChanged(object sender, EventArgs e)
        {
            if (prenomPatient.Text.Length > 0) { prenomPatient.BackColor = Color.White; }
        }

        private void numSecuPatient_TextChanged(object sender, EventArgs e)
        {
            if (numSecuPatient.Text.Length > 0) { numSecuPatient.BackColor = Color.White; }
        }

        private void agePatient_TextChanged(object sender, EventArgs e)
        {
            if (agePatient.Text.Length > 0) { agePatient.BackColor = Color.White; }
        }

        private void numChambre_TextChanged(object sender, EventArgs e)
        {
            if (numChambre.Text.Length > 0) { numChambre.BackColor = Color.White; }
        }

        private void etagePatient_TextChanged(object sender, EventArgs e)
        {
            if (etagePatient.Text.Length > 0) { etagePatient.BackColor = Color.White; }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            OdbcCommand search = new OdbcCommand("SELECT * FROM patient WHERE NumSecu like '%" + textBoxRechercher.Text + "%' ", connection);
            OdbcDataAdapter adapter = new OdbcDataAdapter(search);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void fermerIHM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
