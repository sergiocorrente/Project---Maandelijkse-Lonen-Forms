using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___Maandelijkse_Lonen_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Werknemer> WerknemerList= new List<Werknemer>();
        List<Programmeur> ProgrammeurList = new List<Programmeur>();
        string geslacht;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbAvailable.Items.Clear();
            switch (cbFunctie.SelectedItem)
            {
                case "Standard": checkWagen.Visible = false;
                                    break;
                case "Programmeur": checkWagen.Visible = true; break;
                case "IT support": checkWagen.Visible = false; break;
                case "Customer Support": checkWagen.Visible = false; break;
               
                default:
                    break;
            }



        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (cbFunctie.Text=="Standaard")
            {
                if (radMan.Checked)
                {
                    geslacht = radMan.Text;
                }
                if (radiVrouw.Checked)
                {
                    geslacht = radiVrouw.Text;
                }

                WerknemerList.Add(new Werknemer(txtVoornaam.Text, txAchternaam.Text,geslacht,dateGeboorte.Value,txRijks.Text,dateGeprestreerde.Value,cbFunctie.Text,Convert.ToInt32(txAantalUren.Text)));

                int count = WerknemerList.Count -1;
                listWerknemer.Items.Add(WerknemerList[count]);


               
              
            }

            if (cbFunctie.Text == "Programmeur")
            {
                if (radMan.Checked)
                {
                    geslacht = radMan.Text;
                }
                if (radiVrouw.Checked)
                {
                    geslacht = radiVrouw.Text;
                }

                ProgrammeurList.Add(new Programmeur(txtVoornaam.Text, txAchternaam.Text, geslacht, dateGeboorte.Value, txRijks.Text, dateGeprestreerde.Value, cbFunctie.Text, Convert.ToInt32(txAantalUren.Text),checkWagen.Checked));

                int count = ProgrammeurList.Count - 1;
                MessageBox.Show(Convert.ToString(count));
                listProgrammeur.Items.Add(ProgrammeurList[count]);




            }
        }

        private void listWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {

            Werknemer WerknemerList = (Werknemer)listWerknemer.SelectedItem;
            


            //Programmeur ProgrammeurList = (Programmeur)listWerknemer.SelectedItem;
            richTextToon.Text = WerknemerList.Content();
           

        }

        private void listProgrammeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Programmeur ProgrammeurList = (Programmeur)listProgrammeur.SelectedItem;
            //Programmeur ProgrammeurList = (Programmeur)listWerknemer.SelectedItem;
            richTextToon.Text = ProgrammeurList.Content();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text files|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader read = new StreamReader(ofd.FileName))
                    {
                        while (true) ;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text files|*.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter write = new StreamWriter(sfd.FileName, true, Encoding.UTF8))
                    {
                        write.WriteLine(richTextToon.Text);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

