namespace USB_Generic_HID_reference_application
{
    partial class ListeInfirmier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fermerIHM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailInfirmier = new System.Windows.Forms.TextBox();
            this.prenomInfirmier = new System.Windows.Forms.TextBox();
            this.nomInfirmier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.supprimerButton = new System.Windows.Forms.Button();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_idInfirmier = new System.Windows.Forms.Label();
            this.idInfirmier = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.fermerIHM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 70);
            this.panel1.TabIndex = 80;
            // 
            // fermerIHM
            // 
            this.fermerIHM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fermerIHM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fermerIHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermerIHM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fermerIHM.Image = global::USB_Generic_HID_reference_application.Properties.Resources.marque_de_croix__1_;
            this.fermerIHM.Location = new System.Drawing.Point(1001, 2);
            this.fermerIHM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fermerIHM.Name = "fermerIHM";
            this.fermerIHM.Size = new System.Drawing.Size(64, 63);
            this.fermerIHM.TabIndex = 88;
            this.fermerIHM.UseVisualStyleBackColor = false;
            this.fermerIHM.Click += new System.EventHandler(this.fermerIHM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Infirmiers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::USB_Generic_HID_reference_application.Properties.Resources.icons8_close_30;
            this.button3.Location = new System.Drawing.Point(1661, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 54);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idInfirmier);
            this.groupBox1.Controls.Add(this.label_idInfirmier);
            this.groupBox1.Controls.Add(this.mailInfirmier);
            this.groupBox1.Controls.Add(this.prenomInfirmier);
            this.groupBox1.Controls.Add(this.nomInfirmier);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(849, 340);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infirmier";
            // 
            // mailInfirmier
            // 
            this.mailInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailInfirmier.Location = new System.Drawing.Point(214, 251);
            this.mailInfirmier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mailInfirmier.Name = "mailInfirmier";
            this.mailInfirmier.Size = new System.Drawing.Size(525, 39);
            this.mailInfirmier.TabIndex = 17;
            this.mailInfirmier.TextChanged += new System.EventHandler(this.mailInfirmier_TextChanged);
            // 
            // prenomInfirmier
            // 
            this.prenomInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomInfirmier.Location = new System.Drawing.Point(214, 159);
            this.prenomInfirmier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prenomInfirmier.Name = "prenomInfirmier";
            this.prenomInfirmier.Size = new System.Drawing.Size(380, 39);
            this.prenomInfirmier.TabIndex = 16;
            this.prenomInfirmier.TextChanged += new System.EventHandler(this.prenomInfirmier_TextChanged);
            // 
            // nomInfirmier
            // 
            this.nomInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomInfirmier.Location = new System.Drawing.Point(214, 63);
            this.nomInfirmier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nomInfirmier.Name = "nomInfirmier";
            this.nomInfirmier.Size = new System.Drawing.Size(380, 39);
            this.nomInfirmier.TabIndex = 15;
            this.nomInfirmier.TextChanged += new System.EventHandler(this.nomInfirmier_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mail :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prenom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nom :";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SandyBrown;
            this.updateButton.Location = new System.Drawing.Point(874, 210);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(180, 72);
            this.updateButton.TabIndex = 86;
            this.updateButton.Text = "Modifier";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // supprimerButton
            // 
            this.supprimerButton.BackColor = System.Drawing.Color.OrangeRed;
            this.supprimerButton.Location = new System.Drawing.Point(874, 314);
            this.supprimerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.supprimerButton.Name = "supprimerButton";
            this.supprimerButton.Size = new System.Drawing.Size(178, 72);
            this.supprimerButton.TabIndex = 85;
            this.supprimerButton.Text = "Supprimer";
            this.supprimerButton.UseVisualStyleBackColor = false;
            this.supprimerButton.Click += new System.EventHandler(this.supprimerButton_Click);
            // 
            // ajouterButton
            // 
            this.ajouterButton.BackColor = System.Drawing.Color.Green;
            this.ajouterButton.Location = new System.Drawing.Point(874, 111);
            this.ajouterButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(178, 72);
            this.ajouterButton.TabIndex = 84;
            this.ajouterButton.Text = "Ajouter";
            this.ajouterButton.UseVisualStyleBackColor = false;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(15, 428);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 493);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label_idInfirmier
            // 
            this.label_idInfirmier.AutoSize = true;
            this.label_idInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idInfirmier.Location = new System.Drawing.Point(643, 66);
            this.label_idInfirmier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_idInfirmier.Name = "label_idInfirmier";
            this.label_idInfirmier.Size = new System.Drawing.Size(56, 32);
            this.label_idInfirmier.TabIndex = 88;
            this.label_idInfirmier.Text = "ID :";
            // 
            // idInfirmier
            // 
            this.idInfirmier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idInfirmier.Location = new System.Drawing.Point(711, 63);
            this.idInfirmier.Margin = new System.Windows.Forms.Padding(6);
            this.idInfirmier.Name = "idInfirmier";
            this.idInfirmier.Size = new System.Drawing.Size(109, 39);
            this.idInfirmier.TabIndex = 88;
            // 
            // ListeInfirmier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 934);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.supprimerButton);
            this.Controls.Add(this.ajouterButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListeInfirmier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeInfirmier";
            this.Load += new System.EventHandler(this.ListeInfirmier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mailInfirmier;
        private System.Windows.Forms.TextBox prenomInfirmier;
        private System.Windows.Forms.TextBox nomInfirmier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button supprimerButton;
        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fermerIHM;
        private System.Windows.Forms.TextBox idInfirmier;
        private System.Windows.Forms.Label label_idInfirmier;
    }
}