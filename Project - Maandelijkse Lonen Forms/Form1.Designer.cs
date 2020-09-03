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
            this.txAantalUren = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWag1 = new System.Windows.Forms.Label();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.radiVrouw = new System.Windows.Forms.RadioButton();
            this.dateGeboorte = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateGeprestreerde = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.radWagJaa = new System.Windows.Forms.RadioButton();
            this.radWagNee = new System.Windows.Forms.RadioButton();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txRijks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listWerknemer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFunctie
            // 
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Items.AddRange(new object[] {
            "Standard",
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
            this.txtVoornaam.Location = new System.Drawing.Point(23, 82);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(146, 20);
            this.txtVoornaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer Werknemer Functie";
            // 
            // txAchternaam
            // 
            this.txAchternaam.Location = new System.Drawing.Point(175, 82);
            this.txAchternaam.Name = "txAchternaam";
            this.txAchternaam.Size = new System.Drawing.Size(160, 20);
            this.txAchternaam.TabIndex = 1;
            // 
            // txAantalUren
            // 
            this.txAantalUren.Location = new System.Drawing.Point(25, 332);
            this.txAantalUren.Name = "txAantalUren";
            this.txAantalUren.Size = new System.Drawing.Size(36, 20);
            this.txAantalUren.TabIndex = 1;
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
            // labWag1
            // 
            this.labWag1.AutoSize = true;
            this.labWag1.Location = new System.Drawing.Point(21, 365);
            this.labWag1.Name = "labWag1";
            this.labWag1.Size = new System.Drawing.Size(71, 13);
            this.labWag1.TabIndex = 3;
            this.labWag1.Text = "Bedrijf wagen";
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(121, 19);
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
            this.radiVrouw.Location = new System.Drawing.Point(6, 19);
            this.radiVrouw.Name = "radiVrouw";
            this.radiVrouw.Size = new System.Drawing.Size(55, 17);
            this.radiVrouw.TabIndex = 5;
            this.radiVrouw.TabStop = true;
            this.radiVrouw.Text = "Vrouw";
            this.radiVrouw.UseVisualStyleBackColor = true;
            // 
            // dateGeboorte
            // 
            this.dateGeboorte.Location = new System.Drawing.Point(24, 157);
            this.dateGeboorte.Name = "dateGeboorte";
            this.dateGeboorte.Size = new System.Drawing.Size(200, 20);
            this.dateGeboorte.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Selecteer Gebortedatum";
            // 
            // dateGeprestreerde
            // 
            this.dateGeprestreerde.Location = new System.Drawing.Point(25, 205);
            this.dateGeprestreerde.Name = "dateGeprestreerde";
            this.dateGeprestreerde.Size = new System.Drawing.Size(200, 20);
            this.dateGeprestreerde.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Selecteer intdizntredings  datum";
            // 
            // radWagJaa
            // 
            this.radWagJaa.AutoSize = true;
            this.radWagJaa.Location = new System.Drawing.Point(25, 382);
            this.radWagJaa.Name = "radWagJaa";
            this.radWagJaa.Size = new System.Drawing.Size(36, 17);
            this.radWagJaa.TabIndex = 7;
            this.radWagJaa.TabStop = true;
            this.radWagJaa.Text = "Ja";
            this.radWagJaa.UseVisualStyleBackColor = true;
            // 
            // radWagNee
            // 
            this.radWagNee.AutoSize = true;
            this.radWagNee.Location = new System.Drawing.Point(94, 382);
            this.radWagNee.Name = "radWagNee";
            this.radWagNee.Size = new System.Drawing.Size(45, 17);
            this.radWagNee.TabIndex = 8;
            this.radWagNee.TabStop = true;
            this.radWagNee.Text = "Nee";
            this.radWagNee.UseVisualStyleBackColor = true;
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
            this.groupBox1.Size = new System.Drawing.Size(200, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txRijks
            // 
            this.txRijks.Location = new System.Drawing.Point(23, 250);
            this.txRijks.Name = "txRijks";
            this.txRijks.Size = new System.Drawing.Size(146, 20);
            this.txRijks.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rijksregisternummer";
            // 
            // listWerknemer
            // 
            this.listWerknemer.FormattingEnabled = true;
            this.listWerknemer.Location = new System.Drawing.Point(351, 39);
            this.listWerknemer.Name = "listWerknemer";
            this.listWerknemer.Size = new System.Drawing.Size(199, 277);
            this.listWerknemer.TabIndex = 12;
            this.listWerknemer.SelectedIndexChanged += new System.EventHandler(this.listWerknemer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.listWerknemer);
            this.Controls.Add(this.txRijks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.radWagNee);
            this.Controls.Add(this.radWagJaa);
            this.Controls.Add(this.dateGeprestreerde);
            this.Controls.Add(this.dateGeboorte);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labWag1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txAantalUren);
            this.Controls.Add(this.txAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.cbFunctie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txAchternaam;
        private System.Windows.Forms.TextBox txAantalUren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWag1;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.RadioButton radiVrouw;
        private System.Windows.Forms.DateTimePicker dateGeboorte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateGeprestreerde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radWagJaa;
        private System.Windows.Forms.RadioButton radWagNee;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txRijks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listWerknemer;
    }
}

