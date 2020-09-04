namespace Project___Maandelijkse_Lonen_Forms
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
            this.cbFunctie = new System.Windows.Forms.ComboBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txAchternaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.radiVrouw = new System.Windows.Forms.RadioButton();
            this.dateGeboorte = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateGeprestreerde = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txRijks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listWerknemer = new System.Windows.Forms.ListBox();
            this.richTextToon = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkWagen = new System.Windows.Forms.CheckBox();
            this.listProgrammeur = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numAantalUren = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listCustomer = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listITsupport = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAantalUren)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFunctie
            // 
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Items.AddRange(new object[] {
            "Standaard",
            "Programmeur",
            "IT support",
            "Customer Support"});
            this.cbFunctie.Location = new System.Drawing.Point(24, 29);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(121, 21);
            this.cbFunctie.TabIndex = 0;
            this.cbFunctie.Text = "Selection";
            this.cbFunctie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(8, 83);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(146, 20);
            this.txtVoornaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer werknemer functie";
            // 
            // txAchternaam
            // 
            this.txAchternaam.Location = new System.Drawing.Point(160, 83);
            this.txAchternaam.Name = "txAchternaam";
            this.txAchternaam.Size = new System.Drawing.Size(144, 20);
            this.txAchternaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voornaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aantal geprestreerde uren";
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(64, 16);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(46, 17);
            this.radMan.TabIndex = 4;
            this.radMan.TabStop = true;
            this.radMan.Text = "Man";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // radiVrouw
            // 
            this.radiVrouw.AutoSize = true;
            this.radiVrouw.Location = new System.Drawing.Point(3, 16);
            this.radiVrouw.Name = "radiVrouw";
            this.radiVrouw.Size = new System.Drawing.Size(55, 17);
            this.radiVrouw.TabIndex = 5;
            this.radiVrouw.TabStop = true;
            this.radiVrouw.Text = "Vrouw";
            this.radiVrouw.UseVisualStyleBackColor = true;
            // 
            // dateGeboorte
            // 
            this.dateGeboorte.Location = new System.Drawing.Point(27, 166);
            this.dateGeboorte.Name = "dateGeboorte";
            this.dateGeboorte.Size = new System.Drawing.Size(200, 20);
            this.dateGeboorte.TabIndex = 6;
            this.dateGeboorte.Value = new System.DateTime(2020, 9, 3, 18, 9, 8, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Selecteer geboortedatum";
            // 
            // dateGeprestreerde
            // 
            this.dateGeprestreerde.Location = new System.Drawing.Point(28, 211);
            this.dateGeprestreerde.Name = "dateGeprestreerde";
            this.dateGeprestreerde.Size = new System.Drawing.Size(200, 20);
            this.dateGeprestreerde.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Selecteer intdientredings  datum";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(17, 415);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 9;
            this.butAdd.Text = "Toevoegen";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMan);
            this.groupBox1.Controls.Add(this.radiVrouw);
            this.groupBox1.Location = new System.Drawing.Point(25, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 39);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geslacht";
            // 
            // txRijks
            // 
            this.txRijks.Location = new System.Drawing.Point(27, 250);
            this.txRijks.Name = "txRijks";
            this.txRijks.Size = new System.Drawing.Size(146, 20);
            this.txRijks.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rijksregisternummer";
            // 
            // listWerknemer
            // 
            this.listWerknemer.FormattingEnabled = true;
            this.listWerknemer.Location = new System.Drawing.Point(321, 46);
            this.listWerknemer.Name = "listWerknemer";
            this.listWerknemer.Size = new System.Drawing.Size(122, 108);
            this.listWerknemer.TabIndex = 12;
            this.listWerknemer.SelectedIndexChanged += new System.EventHandler(this.listWerknemer_SelectedIndexChanged);
            // 
            // richTextToon
            // 
            this.richTextToon.Location = new System.Drawing.Point(586, 25);
            this.richTextToon.Name = "richTextToon";
            this.richTextToon.Size = new System.Drawing.Size(354, 311);
            this.richTextToon.TabIndex = 13;
            this.richTextToon.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sla  bestand op";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkWagen
            // 
            this.checkWagen.AutoSize = true;
            this.checkWagen.Location = new System.Drawing.Point(25, 368);
            this.checkWagen.Name = "checkWagen";
            this.checkWagen.Size = new System.Drawing.Size(90, 17);
            this.checkWagen.TabIndex = 15;
            this.checkWagen.Text = "Bedrijf wagen";
            this.checkWagen.UseVisualStyleBackColor = true;
            this.checkWagen.Visible = false;
            // 
            // listProgrammeur
            // 
            this.listProgrammeur.FormattingEnabled = true;
            this.listProgrammeur.Location = new System.Drawing.Point(452, 46);
            this.listProgrammeur.Name = "listProgrammeur";
            this.listProgrammeur.Size = new System.Drawing.Size(120, 108);
            this.listProgrammeur.TabIndex = 16;
            this.listProgrammeur.SelectedIndexChanged += new System.EventHandler(this.listProgrammeur_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Standaard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Customer support";
            // 
            // numAantalUren
            // 
            this.numAantalUren.Location = new System.Drawing.Point(25, 328);
            this.numAantalUren.Name = "numAantalUren";
            this.numAantalUren.Size = new System.Drawing.Size(35, 20);
            this.numAantalUren.TabIndex = 20;
            this.numAantalUren.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(321, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 21;
            // 
            // listCustomer
            // 
            this.listCustomer.FormattingEnabled = true;
            this.listCustomer.Location = new System.Drawing.Point(452, 189);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(120, 108);
            this.listCustomer.TabIndex = 22;
            this.listCustomer.SelectedIndexChanged += new System.EventHandler(this.listCustomer_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Standaard";
            // 
            // listITsupport
            // 
            this.listITsupport.FormattingEnabled = true;
            this.listITsupport.Location = new System.Drawing.Point(321, 189);
            this.listITsupport.Name = "listITsupport";
            this.listITsupport.Size = new System.Drawing.Size(120, 108);
            this.listITsupport.TabIndex = 21;
            this.listITsupport.SelectedIndexChanged += new System.EventHandler(this.listITsupport_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "IT Support";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(449, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Programmeur ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Werknemer lijsten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listCustomer);
            this.Controls.Add(this.listITsupport);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numAantalUren);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listProgrammeur);
            this.Controls.Add(this.checkWagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextToon);
            this.Controls.Add(this.listWerknemer);
            this.Controls.Add(this.txRijks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dateGeprestreerde);
            this.Controls.Add(this.dateGeboorte);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.cbFunctie);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAantalUren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txAchternaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.RadioButton radiVrouw;
        private System.Windows.Forms.DateTimePicker dateGeboorte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateGeprestreerde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txRijks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listWerknemer;
        private System.Windows.Forms.RichTextBox richTextToon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkWagen;
        private System.Windows.Forms.ListBox listProgrammeur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAantalUren;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listITsupport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

