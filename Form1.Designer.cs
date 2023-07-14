using System;

namespace USB_Generic_HID_reference_application
    {
    partial class Form1
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.usbToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugCollectionTimer = new System.Windows.Forms.Timer(this.components);
            this.deviceStatusPollTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDebit = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtStart = new System.Windows.Forms.Button();
            this.ValiderDebit = new System.Windows.Forms.Button();
            this.vSb10 = new System.Windows.Forms.VScrollBar();
            this.txB10 = new System.Windows.Forms.TextBox();
            this.vSb1 = new System.Windows.Forms.VScrollBar();
            this.txB1 = new System.Windows.Forms.TextBox();
            this.vSb0_1 = new System.Windows.Forms.VScrollBar();
            this.label12 = new System.Windows.Forms.Label();
            this.txB0_1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxNumSecu = new System.Windows.Forms.ComboBox();
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            this.VolumeValue = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ValiderVolume = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.textB10 = new System.Windows.Forms.TextBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.textB01 = new System.Windows.Forms.TextBox();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.textB0_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendToBDDTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxTraitement = new System.Windows.Forms.GroupBox();
            this.label_mailInfirmier = new System.Windows.Forms.Label();
            this.label_prenomInfirmier = new System.Windows.Forms.Label();
            this.label_nomInfirmier = new System.Windows.Forms.Label();
            this.mailInfirmier = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label_agePatient = new System.Windows.Forms.Label();
            this.label_prenomPatient = new System.Windows.Forms.Label();
            this.label_nomPatient = new System.Windows.Forms.Label();
            this.agePatient = new System.Windows.Forms.Label();
            this.prenomPatient = new System.Windows.Forms.Label();
            this.nomPatient = new System.Windows.Forms.Label();
            this.comboBoxInfirmier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label_tempsRestant = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.volumeInitial = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.nbVolumeRestant = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.nbVolumeInjecté = new System.Windows.Forms.Label();
            this.Statut = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nbPasRestant = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nbPasInit = new System.Windows.Forms.Label();
            this.DiametreValue = new System.Windows.Forms.Label();
            this.SeringueValue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxSeringue = new System.Windows.Forms.ComboBox();
            this.timeCountdown = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.fermerIHM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listeInfirmiers = new System.Windows.Forms.Button();
            this.listePatients = new System.Windows.Forms.Button();
            this.tableauInjection = new System.Windows.Forms.Button();
            this.ResetIHM = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.groupBoxDebit.SuspendLayout();
            this.groupBoxVolume.SuspendLayout();
            this.groupBoxTraitement.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usbToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // usbToolStripStatusLabel
            // 
            this.usbToolStripStatusLabel.Name = "usbToolStripStatusLabel";
            this.usbToolStripStatusLabel.Size = new System.Drawing.Size(155, 17);
            this.usbToolStripStatusLabel.Text = "USB Device Status Unknown";
            // 
            // debugCollectionTimer
            // 
            this.debugCollectionTimer.Enabled = true;
            this.debugCollectionTimer.Interval = 50;
            // 
            // deviceStatusPollTimer
            // 
            this.deviceStatusPollTimer.Tick += new System.EventHandler(this.deviceStatusPollTimer_Tick);
            // 
            // groupBoxDebit
            // 
            this.groupBoxDebit.Controls.Add(this.label16);
            this.groupBoxDebit.Controls.Add(this.label30);
            this.groupBoxDebit.Controls.Add(this.textBox5);
            this.groupBoxDebit.Controls.Add(this.label18);
            this.groupBoxDebit.Controls.Add(this.label17);
            this.groupBoxDebit.Controls.Add(this.btStop);
            this.groupBoxDebit.Controls.Add(this.textBox4);
            this.groupBoxDebit.Controls.Add(this.BtStart);
            this.groupBoxDebit.Controls.Add(this.ValiderDebit);
            this.groupBoxDebit.Controls.Add(this.vSb10);
            this.groupBoxDebit.Controls.Add(this.txB10);
            this.groupBoxDebit.Controls.Add(this.vSb1);
            this.groupBoxDebit.Controls.Add(this.txB1);
            this.groupBoxDebit.Controls.Add(this.vSb0_1);
            this.groupBoxDebit.Controls.Add(this.label12);
            this.groupBoxDebit.Controls.Add(this.txB0_1);
            this.groupBoxDebit.Controls.Add(this.label13);
            this.groupBoxDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDebit.Location = new System.Drawing.Point(224, 405);
            this.groupBoxDebit.Name = "groupBoxDebit";
            this.groupBoxDebit.Size = new System.Drawing.Size(712, 147);
            this.groupBoxDebit.TabIndex = 29;
            this.groupBoxDebit.TabStop = false;
            this.groupBoxDebit.Text = "Débit volumique";
            this.groupBoxDebit.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(401, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 71;
            this.label16.Text = "Seuil_temps";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(562, 86);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(109, 16);
            this.label30.TabIndex = 70;
            this.label30.Text = "Temps entre pas";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(574, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(81, 21);
            this.textBox5.TabIndex = 69;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(660, 105);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 24);
            this.label18.TabIndex = 68;
            this.label18.Text = "ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(488, 104);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 24);
            this.label17.TabIndex = 67;
            this.label17.Text = "* 20 µs =";
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Red;
            this.btStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.Location = new System.Drawing.Point(590, 31);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(97, 36);
            this.btStop.TabIndex = 66;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(402, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(81, 21);
            this.textBox4.TabIndex = 64;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtStart
            // 
            this.BtStart.BackColor = System.Drawing.Color.LimeGreen;
            this.BtStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtStart.Location = new System.Drawing.Point(489, 31);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(97, 36);
            this.BtStart.TabIndex = 62;
            this.BtStart.Text = "Start";
            this.BtStart.UseVisualStyleBackColor = false;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // ValiderDebit
            // 
            this.ValiderDebit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ValiderDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValiderDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValiderDebit.Location = new System.Drawing.Point(388, 31);
            this.ValiderDebit.Name = "ValiderDebit";
            this.ValiderDebit.Size = new System.Drawing.Size(97, 36);
            this.ValiderDebit.TabIndex = 61;
            this.ValiderDebit.Text = "Validation ";
            this.ValiderDebit.UseVisualStyleBackColor = false;
            this.ValiderDebit.Click += new System.EventHandler(this.ValiderDebit_Click);
            // 
            // vSb10
            // 
            this.vSb10.LargeChange = 1;
            this.vSb10.Location = new System.Drawing.Point(38, 50);
            this.vSb10.Maximum = 9;
            this.vSb10.Name = "vSb10";
            this.vSb10.Size = new System.Drawing.Size(26, 78);
            this.vSb10.TabIndex = 60;
            this.vSb10.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSb10_Scroll);
            // 
            // txB10
            // 
            this.txB10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB10.Location = new System.Drawing.Point(66, 50);
            this.txB10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txB10.Name = "txB10";
            this.txB10.ReadOnly = true;
            this.txB10.Size = new System.Drawing.Size(52, 80);
            this.txB10.TabIndex = 59;
            this.txB10.Text = "0";
            this.txB10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txB10.TextChanged += new System.EventHandler(this.txB10_TextChanged);
            // 
            // vSb1
            // 
            this.vSb1.LargeChange = 1;
            this.vSb1.Location = new System.Drawing.Point(120, 50);
            this.vSb1.Maximum = 9;
            this.vSb1.Name = "vSb1";
            this.vSb1.Size = new System.Drawing.Size(26, 78);
            this.vSb1.TabIndex = 58;
            this.vSb1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSb1_Scroll);
            // 
            // txB1
            // 
            this.txB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB1.Location = new System.Drawing.Point(147, 50);
            this.txB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txB1.Name = "txB1";
            this.txB1.ReadOnly = true;
            this.txB1.Size = new System.Drawing.Size(52, 80);
            this.txB1.TabIndex = 57;
            this.txB1.Text = "0";
            this.txB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vSb0_1
            // 
            this.vSb0_1.LargeChange = 1;
            this.vSb0_1.Location = new System.Drawing.Point(274, 52);
            this.vSb0_1.Maximum = 9;
            this.vSb0_1.Name = "vSb0_1";
            this.vSb0_1.Size = new System.Drawing.Size(26, 78);
            this.vSb0_1.TabIndex = 55;
            this.vSb0_1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSb0_1_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(299, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 44);
            this.label12.TabIndex = 54;
            this.label12.Text = "mL/h";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txB0_1
            // 
            this.txB0_1.BackColor = System.Drawing.Color.Red;
            this.txB0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB0_1.ForeColor = System.Drawing.Color.Black;
            this.txB0_1.Location = new System.Drawing.Point(220, 50);
            this.txB0_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txB0_1.Name = "txB0_1";
            this.txB0_1.ReadOnly = true;
            this.txB0_1.Size = new System.Drawing.Size(52, 80);
            this.txB0_1.TabIndex = 53;
            this.txB0_1.Text = "0";
            this.txB0_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txB0_1.TextChanged += new System.EventHandler(this.txB0_1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(192, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 55);
            this.label13.TabIndex = 56;
            this.label13.Text = ".";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // comboBoxNumSecu
            // 
            this.comboBoxNumSecu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNumSecu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumSecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumSecu.FormattingEnabled = true;
            this.comboBoxNumSecu.Location = new System.Drawing.Point(38, 68);
            this.comboBoxNumSecu.Name = "comboBoxNumSecu";
            this.comboBoxNumSecu.Size = new System.Drawing.Size(140, 24);
            this.comboBoxNumSecu.TabIndex = 87;
            this.comboBoxNumSecu.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumSecu_SelectedIndexChanged);
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.Controls.Add(this.VolumeValue);
            this.groupBoxVolume.Controls.Add(this.label21);
            this.groupBoxVolume.Controls.Add(this.ValiderVolume);
            this.groupBoxVolume.Controls.Add(this.label5);
            this.groupBoxVolume.Controls.Add(this.vScrollBar1);
            this.groupBoxVolume.Controls.Add(this.textB10);
            this.groupBoxVolume.Controls.Add(this.vScrollBar2);
            this.groupBoxVolume.Controls.Add(this.textB01);
            this.groupBoxVolume.Controls.Add(this.vScrollBar3);
            this.groupBoxVolume.Controls.Add(this.textB0_1);
            this.groupBoxVolume.Controls.Add(this.label4);
            this.groupBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVolume.Location = new System.Drawing.Point(224, 249);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(712, 152);
            this.groupBoxVolume.TabIndex = 39;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "Volume à injecter";
            // 
            // VolumeValue
            // 
            this.VolumeValue.AutoSize = true;
            this.VolumeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeValue.Location = new System.Drawing.Point(624, 78);
            this.VolumeValue.Name = "VolumeValue";
            this.VolumeValue.Size = new System.Drawing.Size(30, 16);
            this.VolumeValue.TabIndex = 72;
            this.VolumeValue.Text = "N/A";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(524, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 16);
            this.label21.TabIndex = 71;
            this.label21.Text = "Volume choisi :";
            // 
            // ValiderVolume
            // 
            this.ValiderVolume.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ValiderVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ValiderVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValiderVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValiderVolume.Location = new System.Drawing.Point(392, 67);
            this.ValiderVolume.Name = "ValiderVolume";
            this.ValiderVolume.Size = new System.Drawing.Size(97, 36);
            this.ValiderVolume.TabIndex = 69;
            this.ValiderVolume.Text = "Validation ";
            this.ValiderVolume.UseVisualStyleBackColor = false;
            this.ValiderVolume.Click += new System.EventHandler(this.ValiderVolume_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 44);
            this.label5.TabIndex = 68;
            this.label5.Text = "mL";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(39, 44);
            this.vScrollBar1.Maximum = 9;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 78);
            this.vScrollBar1.TabIndex = 67;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // textB10
            // 
            this.textB10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB10.Location = new System.Drawing.Point(67, 44);
            this.textB10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textB10.Name = "textB10";
            this.textB10.ReadOnly = true;
            this.textB10.Size = new System.Drawing.Size(52, 80);
            this.textB10.TabIndex = 66;
            this.textB10.Text = "0";
            this.textB10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.LargeChange = 1;
            this.vScrollBar2.Location = new System.Drawing.Point(121, 44);
            this.vScrollBar2.Maximum = 9;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(26, 78);
            this.vScrollBar2.TabIndex = 65;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // textB01
            // 
            this.textB01.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB01.Location = new System.Drawing.Point(148, 44);
            this.textB01.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textB01.Name = "textB01";
            this.textB01.ReadOnly = true;
            this.textB01.Size = new System.Drawing.Size(52, 80);
            this.textB01.TabIndex = 64;
            this.textB01.Text = "0";
            this.textB01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.LargeChange = 1;
            this.vScrollBar3.Location = new System.Drawing.Point(275, 46);
            this.vScrollBar3.Maximum = 9;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(26, 78);
            this.vScrollBar3.TabIndex = 62;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar3_Scroll);
            // 
            // textB0_1
            // 
            this.textB0_1.BackColor = System.Drawing.Color.Red;
            this.textB0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB0_1.ForeColor = System.Drawing.Color.Black;
            this.textB0_1.Location = new System.Drawing.Point(221, 44);
            this.textB0_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textB0_1.Name = "textB0_1";
            this.textB0_1.ReadOnly = true;
            this.textB0_1.Size = new System.Drawing.Size(52, 80);
            this.textB0_1.TabIndex = 61;
            this.textB0_1.Text = "0";
            this.textB0_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 55);
            this.label4.TabIndex = 63;
            this.label4.Text = ".";
            // 
            // sendToBDDTimer
            // 
            this.sendToBDDTimer.Enabled = true;
            this.sendToBDDTimer.Interval = 5000;
            this.sendToBDDTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxTraitement
            // 
            this.groupBoxTraitement.Controls.Add(this.label_mailInfirmier);
            this.groupBoxTraitement.Controls.Add(this.label_prenomInfirmier);
            this.groupBoxTraitement.Controls.Add(this.label_nomInfirmier);
            this.groupBoxTraitement.Controls.Add(this.mailInfirmier);
            this.groupBoxTraitement.Controls.Add(this.label31);
            this.groupBoxTraitement.Controls.Add(this.label32);
            this.groupBoxTraitement.Controls.Add(this.label_agePatient);
            this.groupBoxTraitement.Controls.Add(this.label_prenomPatient);
            this.groupBoxTraitement.Controls.Add(this.label_nomPatient);
            this.groupBoxTraitement.Controls.Add(this.agePatient);
            this.groupBoxTraitement.Controls.Add(this.prenomPatient);
            this.groupBoxTraitement.Controls.Add(this.nomPatient);
            this.groupBoxTraitement.Controls.Add(this.comboBoxInfirmier);
            this.groupBoxTraitement.Controls.Add(this.label2);
            this.groupBoxTraitement.Controls.Add(this.label1);
            this.groupBoxTraitement.Controls.Add(this.comboBoxNumSecu);
            this.groupBoxTraitement.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxTraitement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraitement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxTraitement.Location = new System.Drawing.Point(5, 8);
            this.groupBoxTraitement.Name = "groupBoxTraitement";
            this.groupBoxTraitement.Size = new System.Drawing.Size(210, 493);
            this.groupBoxTraitement.TabIndex = 76;
            this.groupBoxTraitement.TabStop = false;
            this.groupBoxTraitement.Text = "Traitement";
            // 
            // label_mailInfirmier
            // 
            this.label_mailInfirmier.AutoSize = true;
            this.label_mailInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mailInfirmier.Location = new System.Drawing.Point(59, 403);
            this.label_mailInfirmier.Name = "label_mailInfirmier";
            this.label_mailInfirmier.Size = new System.Drawing.Size(13, 13);
            this.label_mailInfirmier.TabIndex = 103;
            this.label_mailInfirmier.Text = "?";
            // 
            // label_prenomInfirmier
            // 
            this.label_prenomInfirmier.AutoSize = true;
            this.label_prenomInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenomInfirmier.Location = new System.Drawing.Point(80, 368);
            this.label_prenomInfirmier.Name = "label_prenomInfirmier";
            this.label_prenomInfirmier.Size = new System.Drawing.Size(14, 16);
            this.label_prenomInfirmier.TabIndex = 102;
            this.label_prenomInfirmier.Text = "?";
            // 
            // label_nomInfirmier
            // 
            this.label_nomInfirmier.AutoSize = true;
            this.label_nomInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomInfirmier.Location = new System.Drawing.Point(62, 335);
            this.label_nomInfirmier.Name = "label_nomInfirmier";
            this.label_nomInfirmier.Size = new System.Drawing.Size(14, 16);
            this.label_nomInfirmier.TabIndex = 101;
            this.label_nomInfirmier.Text = "?";
            // 
            // mailInfirmier
            // 
            this.mailInfirmier.AutoSize = true;
            this.mailInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailInfirmier.Location = new System.Drawing.Point(14, 401);
            this.mailInfirmier.Name = "mailInfirmier";
            this.mailInfirmier.Size = new System.Drawing.Size(38, 16);
            this.mailInfirmier.TabIndex = 100;
            this.mailInfirmier.Text = "Mail :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(14, 368);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 16);
            this.label31.TabIndex = 99;
            this.label31.Text = "Prenom :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(14, 335);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 16);
            this.label32.TabIndex = 98;
            this.label32.Text = "Nom :";
            // 
            // label_agePatient
            // 
            this.label_agePatient.AutoSize = true;
            this.label_agePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_agePatient.Location = new System.Drawing.Point(67, 177);
            this.label_agePatient.Name = "label_agePatient";
            this.label_agePatient.Size = new System.Drawing.Size(14, 16);
            this.label_agePatient.TabIndex = 97;
            this.label_agePatient.Text = "?";
            // 
            // label_prenomPatient
            // 
            this.label_prenomPatient.AutoSize = true;
            this.label_prenomPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenomPatient.Location = new System.Drawing.Point(87, 143);
            this.label_prenomPatient.Name = "label_prenomPatient";
            this.label_prenomPatient.Size = new System.Drawing.Size(14, 16);
            this.label_prenomPatient.TabIndex = 96;
            this.label_prenomPatient.Text = "?";
            // 
            // label_nomPatient
            // 
            this.label_nomPatient.AutoSize = true;
            this.label_nomPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomPatient.Location = new System.Drawing.Point(69, 110);
            this.label_nomPatient.Name = "label_nomPatient";
            this.label_nomPatient.Size = new System.Drawing.Size(14, 16);
            this.label_nomPatient.TabIndex = 95;
            this.label_nomPatient.Text = "?";
            // 
            // agePatient
            // 
            this.agePatient.AutoSize = true;
            this.agePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agePatient.Location = new System.Drawing.Point(21, 177);
            this.agePatient.Name = "agePatient";
            this.agePatient.Size = new System.Drawing.Size(38, 16);
            this.agePatient.TabIndex = 94;
            this.agePatient.Text = "Age :";
            // 
            // prenomPatient
            // 
            this.prenomPatient.AutoSize = true;
            this.prenomPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomPatient.Location = new System.Drawing.Point(21, 143);
            this.prenomPatient.Name = "prenomPatient";
            this.prenomPatient.Size = new System.Drawing.Size(60, 16);
            this.prenomPatient.TabIndex = 93;
            this.prenomPatient.Text = "Prenom :";
            // 
            // nomPatient
            // 
            this.nomPatient.AutoSize = true;
            this.nomPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomPatient.Location = new System.Drawing.Point(21, 110);
            this.nomPatient.Name = "nomPatient";
            this.nomPatient.Size = new System.Drawing.Size(42, 16);
            this.nomPatient.TabIndex = 92;
            this.nomPatient.Text = "Nom :";
            // 
            // comboBoxInfirmier
            // 
            this.comboBoxInfirmier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxInfirmier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInfirmier.FormattingEnabled = true;
            this.comboBoxInfirmier.Location = new System.Drawing.Point(27, 282);
            this.comboBoxInfirmier.Name = "comboBoxInfirmier";
            this.comboBoxInfirmier.Size = new System.Drawing.Size(158, 24);
            this.comboBoxInfirmier.TabIndex = 90;
            this.comboBoxInfirmier.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfirmier_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Administré par l\'infirmier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "N° Secu du patient :";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInfo.Controls.Add(this.label_tempsRestant);
            this.groupBoxInfo.Controls.Add(this.label27);
            this.groupBoxInfo.Controls.Add(this.volumeInitial);
            this.groupBoxInfo.Controls.Add(this.label25);
            this.groupBoxInfo.Controls.Add(this.nbVolumeRestant);
            this.groupBoxInfo.Controls.Add(this.label28);
            this.groupBoxInfo.Controls.Add(this.nbVolumeInjecté);
            this.groupBoxInfo.Controls.Add(this.Statut);
            this.groupBoxInfo.Controls.Add(this.label26);
            this.groupBoxInfo.Controls.Add(this.label24);
            this.groupBoxInfo.Controls.Add(this.nbPasRestant);
            this.groupBoxInfo.Controls.Add(this.label23);
            this.groupBoxInfo.Controls.Add(this.label22);
            this.groupBoxInfo.Controls.Add(this.nbPasInit);
            this.groupBoxInfo.Controls.Add(this.DiametreValue);
            this.groupBoxInfo.Controls.Add(this.SeringueValue);
            this.groupBoxInfo.Controls.Add(this.label15);
            this.groupBoxInfo.Controls.Add(this.label20);
            this.groupBoxInfo.Controls.Add(this.label14);
            this.groupBoxInfo.Controls.Add(this.label19);
            this.groupBoxInfo.Controls.Add(this.comboBoxSeringue);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(224, 76);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(712, 172);
            this.groupBoxInfo.TabIndex = 77;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Seringue information";
            // 
            // label_tempsRestant
            // 
            this.label_tempsRestant.AutoSize = true;
            this.label_tempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tempsRestant.Location = new System.Drawing.Point(587, 58);
            this.label_tempsRestant.Name = "label_tempsRestant";
            this.label_tempsRestant.Size = new System.Drawing.Size(32, 18);
            this.label_tempsRestant.TabIndex = 86;
            this.label_tempsRestant.Text = "N/A";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(538, 99);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 16);
            this.label27.TabIndex = 85;
            this.label27.Text = "Volume initial :";
            // 
            // volumeInitial
            // 
            this.volumeInitial.AutoSize = true;
            this.volumeInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeInitial.Location = new System.Drawing.Point(641, 99);
            this.volumeInitial.Name = "volumeInitial";
            this.volumeInitial.Size = new System.Drawing.Size(30, 16);
            this.volumeInitial.TabIndex = 84;
            this.volumeInitial.Text = "N/A";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(538, 139);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 16);
            this.label25.TabIndex = 83;
            this.label25.Text = "Volume restant :";
            // 
            // nbVolumeRestant
            // 
            this.nbVolumeRestant.AutoSize = true;
            this.nbVolumeRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbVolumeRestant.Location = new System.Drawing.Point(641, 139);
            this.nbVolumeRestant.Name = "nbVolumeRestant";
            this.nbVolumeRestant.Size = new System.Drawing.Size(30, 16);
            this.nbVolumeRestant.TabIndex = 82;
            this.nbVolumeRestant.Text = "N/A";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(538, 119);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 16);
            this.label28.TabIndex = 81;
            this.label28.Text = "Volume injecté :";
            // 
            // nbVolumeInjecté
            // 
            this.nbVolumeInjecté.AutoSize = true;
            this.nbVolumeInjecté.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbVolumeInjecté.Location = new System.Drawing.Point(641, 119);
            this.nbVolumeInjecté.Name = "nbVolumeInjecté";
            this.nbVolumeInjecté.Size = new System.Drawing.Size(30, 16);
            this.nbVolumeInjecté.TabIndex = 80;
            this.nbVolumeInjecté.Text = "N/A";
            // 
            // Statut
            // 
            this.Statut.AutoSize = true;
            this.Statut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statut.Location = new System.Drawing.Point(413, 58);
            this.Statut.Name = "Statut";
            this.Statut.Size = new System.Drawing.Size(16, 18);
            this.Statut.TabIndex = 79;
            this.Statut.Text = "?";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(412, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 20);
            this.label26.TabIndex = 78;
            this.label26.Text = "Statut ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(359, 131);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 16);
            this.label24.TabIndex = 77;
            this.label24.Text = "nbPas restant :";
            // 
            // nbPasRestant
            // 
            this.nbPasRestant.AutoSize = true;
            this.nbPasRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPasRestant.Location = new System.Drawing.Point(456, 131);
            this.nbPasRestant.Name = "nbPasRestant";
            this.nbPasRestant.Size = new System.Drawing.Size(30, 16);
            this.nbPasRestant.TabIndex = 76;
            this.nbPasRestant.Text = "N/A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(295, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 18);
            this.label23.TabIndex = 76;
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(359, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 16);
            this.label22.TabIndex = 75;
            this.label22.Text = "nbPas initial :";
            // 
            // nbPasInit
            // 
            this.nbPasInit.AutoSize = true;
            this.nbPasInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPasInit.Location = new System.Drawing.Point(456, 111);
            this.nbPasInit.Name = "nbPasInit";
            this.nbPasInit.Size = new System.Drawing.Size(30, 16);
            this.nbPasInit.TabIndex = 74;
            this.nbPasInit.Text = "N/A";
            // 
            // DiametreValue
            // 
            this.DiametreValue.AutoSize = true;
            this.DiametreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiametreValue.Location = new System.Drawing.Point(264, 58);
            this.DiametreValue.Name = "DiametreValue";
            this.DiametreValue.Size = new System.Drawing.Size(16, 18);
            this.DiametreValue.TabIndex = 73;
            this.DiametreValue.Text = "?";
            this.DiametreValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SeringueValue
            // 
            this.SeringueValue.AutoSize = true;
            this.SeringueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeringueValue.Location = new System.Drawing.Point(180, 129);
            this.SeringueValue.Name = "SeringueValue";
            this.SeringueValue.Size = new System.Drawing.Size(14, 16);
            this.SeringueValue.TabIndex = 37;
            this.SeringueValue.Text = "?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(544, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Temps restant ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 16);
            this.label20.TabIndex = 36;
            this.label20.Text = "Seringue sélectionnée :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(212, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Diamètre seringue";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(52, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "Choix seringue";
            // 
            // comboBoxSeringue
            // 
            this.comboBoxSeringue.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSeringue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSeringue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeringue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeringue.FormattingEnabled = true;
            this.comboBoxSeringue.Items.AddRange(new object[] {
            "BD Plastipak 50",
            "Monoproject 50 ",
            "Terumo 50 ",
            "Braun Onifix 50",
            "BD Plastipak 20"});
            this.comboBoxSeringue.Location = new System.Drawing.Point(46, 57);
            this.comboBoxSeringue.Name = "comboBoxSeringue";
            this.comboBoxSeringue.Size = new System.Drawing.Size(122, 24);
            this.comboBoxSeringue.TabIndex = 34;
            this.comboBoxSeringue.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeringue_SelectedIndexChanged);
            // 
            // timeCountdown
            // 
            this.timeCountdown.Enabled = true;
            this.timeCountdown.Interval = 1000;
            this.timeCountdown.Tick += new System.EventHandler(this.timeCountdown_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.fermerIHM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 38);
            this.panel1.TabIndex = 78;
            // 
            // fermerIHM
            // 
            this.fermerIHM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fermerIHM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fermerIHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermerIHM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fermerIHM.Image = global::USB_Generic_HID_reference_application.Properties.Resources.marque_de_croix__1_;
            this.fermerIHM.Location = new System.Drawing.Point(901, 2);
            this.fermerIHM.Name = "fermerIHM";
            this.fermerIHM.Size = new System.Drawing.Size(35, 34);
            this.fermerIHM.TabIndex = 87;
            this.fermerIHM.UseVisualStyleBackColor = false;
            this.fermerIHM.Click += new System.EventHandler(this.fermerIHM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(370, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interface Pousse-Seringue";
            // 
            // listeInfirmiers
            // 
            this.listeInfirmiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listeInfirmiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listeInfirmiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeInfirmiers.Image = global::USB_Generic_HID_reference_application.Properties.Resources.infirmiere;
            this.listeInfirmiers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listeInfirmiers.Location = new System.Drawing.Point(539, 42);
            this.listeInfirmiers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeInfirmiers.Name = "listeInfirmiers";
            this.listeInfirmiers.Size = new System.Drawing.Size(147, 31);
            this.listeInfirmiers.TabIndex = 82;
            this.listeInfirmiers.Text = "            Liste infirmiers";
            this.listeInfirmiers.UseVisualStyleBackColor = true;
            this.listeInfirmiers.Click += new System.EventHandler(this.listeInfirmiers_Click);
            // 
            // listePatients
            // 
            this.listePatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listePatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listePatients.Image = global::USB_Generic_HID_reference_application.Properties.Resources.patient1;
            this.listePatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listePatients.Location = new System.Drawing.Point(387, 42);
            this.listePatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listePatients.Name = "listePatients";
            this.listePatients.Size = new System.Drawing.Size(147, 31);
            this.listePatients.TabIndex = 81;
            this.listePatients.Text = "            Liste patients";
            this.listePatients.UseVisualStyleBackColor = true;
            this.listePatients.Click += new System.EventHandler(this.listePatients_Click);
            // 
            // tableauInjection
            // 
            this.tableauInjection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableauInjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableauInjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauInjection.ForeColor = System.Drawing.Color.Black;
            this.tableauInjection.Image = global::USB_Generic_HID_reference_application.Properties.Resources.exceller;
            this.tableauInjection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tableauInjection.Location = new System.Drawing.Point(232, 42);
            this.tableauInjection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableauInjection.Name = "tableauInjection";
            this.tableauInjection.Size = new System.Drawing.Size(151, 31);
            this.tableauInjection.TabIndex = 83;
            this.tableauInjection.Text = "            Tableau injection";
            this.tableauInjection.UseVisualStyleBackColor = true;
            this.tableauInjection.Click += new System.EventHandler(this.tableauInjection_Click);
            // 
            // ResetIHM
            // 
            this.ResetIHM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetIHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetIHM.Image = global::USB_Generic_HID_reference_application.Properties.Resources.cercle__1_;
            this.ResetIHM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetIHM.Location = new System.Drawing.Point(834, 42);
            this.ResetIHM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetIHM.Name = "ResetIHM";
            this.ResetIHM.Size = new System.Drawing.Size(102, 31);
            this.ResetIHM.TabIndex = 85;
            this.ResetIHM.Text = "           Reset IHM";
            this.ResetIHM.UseVisualStyleBackColor = true;
            this.ResetIHM.Click += new System.EventHandler(this.resetIHM_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.groupBoxTraitement);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 514);
            this.panel2.TabIndex = 86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(941, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ResetIHM);
            this.Controls.Add(this.tableauInjection);
            this.Controls.Add(this.listeInfirmiers);
            this.Controls.Add(this.listePatients);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxVolume);
            this.Controls.Add(this.groupBoxDebit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface Humain Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxDebit.ResumeLayout(false);
            this.groupBoxDebit.PerformLayout();
            this.groupBoxVolume.ResumeLayout(false);
            this.groupBoxVolume.PerformLayout();
            this.groupBoxTraitement.ResumeLayout(false);
            this.groupBoxTraitement.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }


        private void label14_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void txB10_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void txB0_1_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel usbToolStripStatusLabel;
        private System.Windows.Forms.Timer debugCollectionTimer;
        private System.Windows.Forms.Timer deviceStatusPollTimer;
        private System.Windows.Forms.GroupBox groupBoxDebit;
        private System.Windows.Forms.TextBox txB0_1;
        private System.Windows.Forms.VScrollBar vSb0_1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.VScrollBar vSb1;
        private System.Windows.Forms.TextBox txB1;
        private System.Windows.Forms.VScrollBar vSb10;
        private System.Windows.Forms.TextBox txB10;
        private System.Windows.Forms.Button ValiderDebit;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBoxVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textB10;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.TextBox textB01;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.TextBox textB0_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ValiderVolume;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label VolumeValue;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Timer sendToBDDTimer;
        private System.Windows.Forms.GroupBox groupBoxTraitement;
        private System.Windows.Forms.ComboBox comboBoxNumSecu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_agePatient;
        private System.Windows.Forms.Label label_prenomPatient;
        private System.Windows.Forms.Label label_nomPatient;
        private System.Windows.Forms.Label agePatient;
        private System.Windows.Forms.Label prenomPatient;
        private System.Windows.Forms.Label nomPatient;
        private System.Windows.Forms.ComboBox comboBoxInfirmier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mailInfirmier;
        private System.Windows.Forms.Label label_prenomInfirmier;
        private System.Windows.Forms.Label label_nomInfirmier;
        private System.Windows.Forms.Label mailInfirmier;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label volumeInitial;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label nbVolumeRestant;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label nbVolumeInjecté;
        private System.Windows.Forms.Label Statut;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label nbPasRestant;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label nbPasInit;
        private System.Windows.Forms.Label DiametreValue;
        private System.Windows.Forms.Label SeringueValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxSeringue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_tempsRestant;
        private System.Windows.Forms.Timer timeCountdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listePatients;
        private System.Windows.Forms.Button listeInfirmiers;
        private System.Windows.Forms.Button tableauInjection;
        private System.Windows.Forms.Button ResetIHM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button fermerIHM;
    }
    }

