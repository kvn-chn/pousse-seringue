//-----------------------------------------------------------------------------
//
//  Form1.cs
//
//  USB Generic HID Communications 3_0_0_0
//
//  A reference test application for the usbGenericHidCommunications library
//  Copyright (C) 2011 Simon Inns
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
//  Web:    http://www.waitingforfriday.com
//  Email:  simon.inns@gmail.com
//
//-----------------------------------------------------------------------------

//
//  Current reference class library version:
//  usbGenericHidCommunications class library version 2.0.0.0
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using System.Net;
using System.Net.Mail;

namespace USB_Generic_HID_reference_application
    {
    public partial class Form1 : Form
        {
        /// <summary>
        /// This is a reference application for testing the functionality of the 
        /// usbGenericHidCommunications class library.  It runs a series of 
        /// communication tests against a known USB reference device to determine
        /// if the class library is functioning correctly.
        /// 
        /// You can also use this application as a guide to integrating the 
        /// usbGenericHidCommunications class library into your projects.
        /// 
        /// See http://www,waitingforfriday.com for more detailed documentation.
        /// </summary>
        /// 

        private static bool usbOpen=false;

//      --------------------------------   [0]   [1]   [2]   [3]  [4]   ------------------------------------
        double[] Tab_diam = new double[] { 27.7, 47.4, 33.8, 22, 26.6 }; // Valeur des diamètres des seringues

        double Diametre=0.0;
        double vol = 0.0;
        double freq = 0.0;
        double temps = 0.0;
        double count = 0.0;

        bool isReady = false;    // Condition du débit à injecter 
        bool onGoing = false;   // Condition start moteur

        private TimeSpan remainingTime;

        // Connexion à la base de données
        static string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=mysql-kevinhaoyi.alwaysdata.net;Database=kevinhaoyi_dbpousseseringue;User=305002_admin;Password=etudiant2kevin;Option=3;";
        OdbcConnection connection = new OdbcConnection(connectionString);

        public Form1()
            {
            InitializeComponent();

            // Create the USB reference device object (passing VID and PID)
            theReferenceUsbDevice = new usbReferenceDevice(0x2DBC, 0x0001);

            // Add a listener for usb events
            theReferenceUsbDevice.usbEvent += new usbReferenceDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target device
            theReferenceUsbDevice.findTargetDevice();
            }

        // Create an instance of the USB reference device
        private usbReferenceDevice theReferenceUsbDevice;

        // Listener for USB events
        private void usbEvent_receiver(object o, EventArgs e)
        {
            // Check the status of the USB device and update the form accordingly
            if (theReferenceUsbDevice.isDeviceAttached)
            {
                deviceStatusPollTimer.Enabled = true;
            }
            else
            {
                // Device is currently unattached
                deviceStatusPollTimer.Enabled = false;
                // Update the status label
                this.usbToolStripStatusLabel.Text = "USB Device is detached";
            }
        }

// ---------------------------------------------------------- CONSTRUCTEUR ---------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise le moteur à l'arrêt 
            byte etat = 3;  // switch case 3 du Readbuff[0]
            byte action = 0; 
            theReferenceUsbDevice.StartStop(etat, action);

            // Initialise nbPas à 0 depuis Carte Velleman
            byte init = 4;  // switch case 4 du Readbuff[0]
            byte reset = 1;
            theReferenceUsbDevice.ResetIHM(init, reset);

            MessageBox.Show("1. Paramétrer diamètre seringue \n2. Choisir volume à injecter puis valider \n3. Choisir vitesse moteur pas à pas puis valider", "Démarche à suivre :", MessageBoxButtons.OK);
            Statut.Text = "A l'arrêt";
            Statut.ForeColor = Color.Tomato;

            connection.Open();
            
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    // ---------------------------- AJOUT VALEUR DANS COMBOBOX PATIENT ----------------------------
                    string queryPatient = "SELECT NumSecu FROM patient";
                    OdbcCommand cmdPatient = new OdbcCommand(queryPatient, connection);
                    OdbcDataReader readerPatient = cmdPatient.ExecuteReader();
                    while (readerPatient.Read())
                    {
                        long numSecuPatient = readerPatient.GetInt64(0);
                        comboBoxNumSecu.Items.Add(numSecuPatient);
                    }
                    readerPatient.Close();

                    string queryInfirmier = "SELECT * FROM infirmier";
                    OdbcCommand cmdInfirmier = new OdbcCommand(queryInfirmier, connection);
                    OdbcDataReader readerInfirmier = cmdInfirmier.ExecuteReader();

                    while (readerInfirmier.Read())
                    {
                        int idInfirmier = readerInfirmier.GetInt32(0);
                        string nom = readerInfirmier.GetString(1);
                        string prenom = readerInfirmier.GetString(2);
                        string infirmier = idInfirmier + " " + nom + " " + prenom;
                        comboBoxInfirmier.Items.Add(infirmier);
                    }
                    readerInfirmier.Close();
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();      
        }

// -------------------------------------------------- TIMER RECEPTION DONNEES CARTE VELLEMAN--------------------------------------------------

        private void deviceStatusPollTimer_Tick(object sender, EventArgs e)
        {
            // Update the status label
            this.usbToolStripStatusLabel.Text = "USB Device is attached";
            byte[] Inputs = theReferenceUsbDevice.Reading();
            
            textBox4.Text = Convert.ToString((Inputs[8] + (Inputs[9]<<8) + (Inputs[10]<<16) ));  // seuil_temps
            textBox5.Text = (double.Parse(textBox4.Text) * 2 / 100).ToString();  // tps_entre_pas

            nbPasInit.Text = Convert.ToString((Inputs[11] + (Inputs[12] << 8) + (Inputs[13] << 16) + (Inputs[14] << 24)));
            nbPasRestant.Text = Convert.ToString((Inputs[15] + (Inputs[16] << 8) + (Inputs[17] << 16) + (Inputs[18] << 24)));

            double DVis = 0.05 * 0.75 * (1.0 / 72.0) * 0.001; // DVis = déplacement de l'écrou pour 1 pas moteur en m 
            double section = (Diametre * Diametre * Math.Pow(10, -6)) / 4 * 3.14159; //section en m² et diametre en mm
            double volume = DVis * section * Math.Pow(10, 6); // volume en ml d'un pas 

            double nbVolRestant = (double.Parse(nbPasRestant.Text) * volume);
            double nbVolInjecté = (double)(Inputs[19] + (Inputs[20] << 8) + (Inputs[21] << 16) + (Inputs[22] << 24));

            nbVolumeInjecté.Text = Math.Round((nbVolInjecté * volume), 3).ToString(); // Arrondir valeur au millième
            nbVolumeRestant.Text = Math.Round(nbVolRestant, 3).ToString(); // Idem

            volumeInitial.Text = VolumeValue.Text;
            Console.WriteLine(nbVolInjecté);
        }

// ---------------------------------------------------- SCROLL BAR DES CHIFFRES BCD-------------------------------------------------

                              // ------------------------- VOLUME A INJECTER -------------------------

        private void vSb0_1_Scroll(object sender, ScrollEventArgs e)
        {
            txB0_1.Text = (vSb0_1.Maximum - vSb0_1.Value).ToString();
        }

        private void vSb1_Scroll(object sender, ScrollEventArgs e)
        {
            txB1.Text = (vSb1.Maximum - vSb1.Value).ToString();
        }

        private void vSb10_Scroll(object sender, ScrollEventArgs e)
        {
            txB10.Text = (vSb10.Maximum - vSb10.Value).ToString();
        }

                              // ------------------------- DEBIT VOLUMIQUE -------------------------

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textB10.Text = (vScrollBar1.Maximum - vScrollBar1.Value).ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textB01.Text = (vScrollBar2.Maximum - vScrollBar2.Value).ToString();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textB0_1.Text = (vScrollBar3.Maximum - vScrollBar3.Value).ToString();
        }

// ---------------------------------------------------- VALIDATION DEBIT VOLUMIQUE ------------------------------------------------

        private void ValiderDebit_Click(object sender, EventArgs e)
        {
            freq = 10 * Int16.Parse(txB10.Text) + Int16.Parse(txB1.Text) + 0.1 * Int16.Parse(txB0_1.Text);
            byte etat = 2; // switch case dans carte Velleman
            if (freq > 0.0 && freq <= 100)
            {
                if (onGoing == true) MessageBox.Show("Arrêter le programme avant de modifier", "", MessageBoxButtons.OK);
                else theReferenceUsbDevice.FlowControl(etat, freq, Diametre);
            }
            else MessageBox.Show("Le débit doit avoir une valeur", "", MessageBoxButtons.OK);

            if (VolumeValue.Text != "?" && freq != 0)
            {
                temps = vol / freq * 60;
                remainingTime = TimeSpan.FromMinutes(temps);
                //label_tempsRestant.Text = remainingTime.ToString(@"hh\:mm\:ss");
                label_tempsRestant.Text = remainingTime.ToString();
            }
        }

// -------------------------------------------------------- BOUTON DEMARRAGE ----------------------------------------------------

        private void BtStart_Click(object sender, EventArgs e)  
        {
            if (isReady == true) // Condition démarrage
            {
                byte etat = 3;
                byte action = 1;
                theReferenceUsbDevice.StartStop(etat, action);
                Statut.Text = "En marche";
                Statut.ForeColor = Color.ForestGreen;
                onGoing = true;
                groupBoxTraitement.Enabled = false;
                groupBoxVolume.Enabled = false;
            }
            else
            {
                MessageBox.Show("Parametrer le type deseringue et volume à injecter","", MessageBoxButtons.OK);
            }
        }

// --------------------------------------------------------- BOUTON ARRET --------------------------------------------------

        private void btStop_Click(object sender, EventArgs e)
        {
            byte etat = 3;
            byte action = 0;
            theReferenceUsbDevice.StartStop(etat, action);
            Statut.Text = "A l'arrêt";
            Statut.ForeColor = Color.Tomato;
            onGoing = false;
            groupBoxTraitement.Enabled = true;
            groupBoxVolume.Enabled = true;
        }

// ----------------------------------------------------  COMBOBOX SERINGUE  --------------------------------------------------

        private void comboBoxSeringue_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeringueValue.Text = comboBoxSeringue.Text;
            DiametreValue.Text = Tab_diam[comboBoxSeringue.SelectedIndex].ToString() + " mm ";
            Diametre = Tab_diam[comboBoxSeringue.SelectedIndex];
            byte etat = 4;
            theReferenceUsbDevice.SendnbPas(etat, vol, Diametre);
            groupBoxVolume.Enabled = true;
        }

// ------------------------------------------------- VALIDATION VOLUME A INJECTER -----------------------------------------------

        private void ValiderVolume_Click(object sender, EventArgs e) // Validation volume à injecter
        {
            vol = 10 * Int16.Parse(textB10.Text) + Int16.Parse(textB01.Text) + 0.1 * Int16.Parse(textB0_1.Text);
            byte etat = 4;
            if (vol > 0.0 && vol <= 100)
            {
                theReferenceUsbDevice.SendnbPas(etat, vol, Diametre);
                isReady = true; // Condition de démarrage
                groupBoxDebit.Enabled = true;
            }
            else MessageBox.Show("Le volume doit avoir une valeur", "", MessageBoxButtons.OK);
            label21.Text = "Volume choisi :";
            VolumeValue.Text = vol.ToString() + " mL ";
        }

// ----------------------------------------------------- TIMER MISE A JOUR BDD  -------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isReady == true && onGoing == true)
            {
                //string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=dbpousseseringue;User=root;Password=;Option=3;"; //option=3 utilise le protocole TCP/IP pour se connecter au serveur MySQL
                //OdbcConnection connection = new OdbcConnection(connectionString);
                try
                {
                    string selectedNum = comboBoxNumSecu.Text;
                    string selectedInfirmier = comboBoxInfirmier.Text;
                    string[] SplitIdInfirmier = selectedInfirmier.Split(' ');

                    connection.Open();

                    string querySelect = "SELECT * FROM traitementseringue WHERE Patient_NumSecu = ?";
                    using (OdbcCommand selectCommand = new OdbcCommand(querySelect, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Patient_NumSecu", selectedNum);
                        using (OdbcDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {    
                                string queryUpdate = "UPDATE traitementseringue SET DebitVolumique = ?, VolumeInjection = ?, TypeSeringue = ?" +
                                                                                    ", VolumeInjecte = ?, TempsRestant = ?, VolumeRestant = ?" +
                                                                                    ", Infirmier_idInfirmier = ? WHERE Patient_NumSecu = ?";
                                using (OdbcCommand updateCommand = new OdbcCommand(queryUpdate, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@debitVolumique", freq);
                                    updateCommand.Parameters.AddWithValue("@volumeInjection", vol);
                                    updateCommand.Parameters.AddWithValue("@typeSeringue", comboBoxSeringue.Text);
                                    updateCommand.Parameters.AddWithValue("@volInjecté", nbVolumeInjecté.Text.Replace(",", "."));
                                    updateCommand.Parameters.AddWithValue("@tempsRestant", label_tempsRestant.Text);
                                    updateCommand.Parameters.AddWithValue("@volRestant", nbVolumeRestant.Text.Replace(",", "."));
                                    updateCommand.Parameters.AddWithValue("@idInfirmier", SplitIdInfirmier[0]);
                                    updateCommand.Parameters.AddWithValue("@Patient_NumSecu", selectedNum);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string queryInsert = "INSERT INTO traitementseringue (DebitVolumique, VolumeInjection, DebutTraitement ,TypeSeringue " +
                                                                                        ", VolumeInjecte, VolumeRestant, TempsRestant, Patient_NumSecu" +
                                                                                        ", Infirmier_idInfirmier) VALUES (?, ? ,?, ?, ? ,?, ?, ?, ?)";
                                using (OdbcCommand insertCommand = new OdbcCommand(queryInsert, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@debitVolumique", freq);
                                    insertCommand.Parameters.AddWithValue("@volumeInjection", vol);
                                    insertCommand.Parameters.AddWithValue("@debutTraitement", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                                    insertCommand.Parameters.AddWithValue("@typeSeringue", comboBoxSeringue.Text);
                                    insertCommand.Parameters.AddWithValue("@volInjecté", nbVolumeInjecté.Text.Replace(",", "."));
                                    insertCommand.Parameters.AddWithValue("@volRestant", nbVolumeRestant.Text.Replace(",", "."));
                                    insertCommand.Parameters.AddWithValue("@tempsRestant", label_tempsRestant.Text);
                                    insertCommand.Parameters.AddWithValue("@numSecu", selectedNum);
                                    insertCommand.Parameters.AddWithValue("@idInfirmier", SplitIdInfirmier[0]);
                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                connection.Close();

                /* ------------------------------------ ANCIENNE METHODE AVEC FICHIER TEXTE ----------------------------------------
                *       string infoSeringuefile = @"F:\v02_projet_pousse_seringue_base\info_seringue.txt";
                *
                *       Ordre : TypeSeringue[0] / VolumeInjecté[1] / VolumeRestant[2] / TempsRestant[3]
                *       string text = SeringueValue.Text.Replace("System.Windows.Forms.Label, Text: ", "") + "," + nbVolumeRestant.Text + "," + freq + "," + vol + "," + nbVolumeInjecté.Text.Replace("System.Windows.Forms.Label, Text: ", "");
                *
                *       string[] values = { SeringueValue.Text.ToString(), nbVolumeRestant.Text };
                *
                *       using (StreamWriter writer = new StreamWriter(infoSeringuefile))
                *       {
                *            writer.WriteLine(SeringueValue.Text.Replace("System.Windows.Forms.Label, Text: ", "") + "," + nbVolumeInjecté.Text.Replace("System.Windows.Forms.Label, Text: ", "") + "," + nbVolumeRestant.Text + "," + 0);
                *       }
                 -------------------------------------------------------------------------------------------------------------------*/
            }
        }

// -------------------------------------------------------- COMBOBOX PATIENT  -----------------------------------------------------------
        private void comboBoxNumSecu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNum = comboBoxNumSecu.Text;
            connection.Open();
            try
            {
                string queryPatient = "SELECT Nom, Prenom, Age, NumChambre, Etage FROM patient WHERE NumSecu = " + selectedNum;
                OdbcCommand cmdPatient = new OdbcCommand(queryPatient, connection);
                OdbcDataReader readerPatient = cmdPatient.ExecuteReader();
                while (readerPatient.Read())
                {
                    string nom = readerPatient.GetString(0);
                    string prenom = readerPatient.GetString(1);
                    int age = readerPatient.GetInt16(2);
                    int numChambre = readerPatient.GetInt16(3);
                    int etage = readerPatient.GetInt16(4);

                    label_nomPatient.Text = nom;
                    label_prenomPatient.Text = prenom;
                    label_agePatient.Text = age.ToString();
                }
                readerPatient.Close();
            } 
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }

// -------------------------------------------------------- COMBOBOX INFIRMIER  -----------------------------------------------------------

        private void comboBoxInfirmier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedInfirmier = comboBoxInfirmier.Text;
            string[] SplitIdInfirmier = selectedInfirmier.Split(' ');

            connection.Open();

            string queryInfirmier = "SELECT * FROM infirmier WHERE idInfirmier = " + SplitIdInfirmier[0];
            OdbcCommand cmdInfirmier = new OdbcCommand(queryInfirmier, connection);
            OdbcDataReader readerInfirmier = cmdInfirmier.ExecuteReader();
            while (readerInfirmier.Read())
            {
                string nomInfirmier = readerInfirmier.GetString(1);
                string prenomInfirmier = readerInfirmier.GetString(2);
                string mailInfirmier = readerInfirmier.GetString(3);

                label_nomInfirmier.Text = nomInfirmier;
                label_prenomInfirmier.Text = prenomInfirmier;
                label_mailInfirmier.Text = mailInfirmier;
            }
            readerInfirmier.Close();
            if (comboBoxNumSecu.Text != "" && comboBoxInfirmier.Text != "")
            {
                groupBoxInfo.Enabled = true;
            }
            connection.Close();
        }

// -------------------------------------------------------- TIMER TEMPS RESTANT  -----------------------------------------------------------

        private void timeCountdown_Tick(object sender, EventArgs e)
        {
            if(isReady == true && onGoing == true)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                //label_tempsRestant.Text = remainingTime.ToString(@"hh\:mm\:ss");
                label_tempsRestant.Text = remainingTime.ToString();
                if (remainingTime.TotalSeconds <= 0)
                {
                    timeCountdown.Stop();
                    MessageBox.Show("Time's up!");
                }
            }
        }

// ------------------------------------------------------------ BOUTON RESET  -----------------------------------------------------------------

        private void resetIHM_Click(object sender, EventArgs e)
        {
            // Initialise le moteur à l'arrêt 
            byte etat = 3;  // switch case 3
            byte action = 0;
            theReferenceUsbDevice.StartStop(etat, action);

            // Initialise nbPas à 0 depuis Carte Velleman
            byte reset = 1;
            byte init = 4;  // switch case 4
            theReferenceUsbDevice.ResetIHM(init, reset);

            reset = 0;
            init = 4;  // switch case 4
            theReferenceUsbDevice.ResetIHM(init, reset);

            // Debit seringue
            txB0_1.Text = "0";
            txB1.Text = "0";
            txB10.Text = "0";

            // Volume injectable
            textB10.Text = "0";
            textB01.Text = "0";
            textB0_1.Text = "0";

            VolumeValue.Text = "N/A";

            // Reset ComboBox type seringue
            comboBoxSeringue.Items.Clear();
            string[] list = new string[] { "BD Plastipak 50", "Monoproject 50", "Terumo 50", "Braun Onifix 50", "BD Plastipak 20" };
            for (int i = 0; i <= 4; i++) { comboBoxSeringue.Items.Add(list[i]); }
            SeringueValue.Text = comboBoxSeringue.Text;
            DiametreValue.Text = "?";

            vol = 0;
            Diametre = 0;
            MessageBox.Show("Reset effectué", "", MessageBoxButtons.OK);
            Statut.Text = "A l'arrêt";
            Statut.ForeColor = Color.Tomato;
            isReady = false;  // Condition de démarrage 
            onGoing = false;
            label_tempsRestant.Text = "N/A";
        }

// ------------------------------------------------------ BOUTON TABLEAU INJECTION IHM --------------------------------------------------------

        private void tableauInjection_Click(object sender, EventArgs e)
        {
            TableauInjection form = new TableauInjection();
            form.Show();
        }

// ----------------------------------------------------------- BOUTON PATIENT IHM -------------------------------------------------------------

        private void listePatients_Click(object sender, EventArgs e)
        {
            ListePatient form = new ListePatient();
            form.Show();
        }

// ---------------------------------------------------------- BOUTON INFIRMIER IHM -----------------------------------------------------------

        private void listeInfirmiers_Click(object sender, EventArgs e)
        {
            ListeInfirmier form = new ListeInfirmier();
            form.Show();
        }

// ----------------------------------------------------------- BOUTON FERMER IHM  -----------------------------------------------------------

        private void fermerIHM_Click(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }
    }
}
     
