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
        List<IT_Support> ITsupportList = new List<IT_Support>();
        List<IT_Support> CustomerSupportList = new List<IT_Support>();
        string geslacht;
        string wagen;



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbAvailable.Items.Clear();
            switch (cbFunctie.SelectedItem)
            {
                case "Standaard": checkWagen.Visible = false;
                                    break;
                case "Programmeur": checkWagen.Visible = true;
                                    break;
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

               
                if (txtVoornaam.Text==null || txAchternaam==null || geslacht==null || dateGeboorte==null || txRijks==null || numAantalUren==null)
                {
                    MessageBox.Show("Je moet alles invullen");
                }
                else {
                WerknemerList.Add(new Werknemer(txtVoornaam.Text, txAchternaam.Text,geslacht,dateGeboorte.Value,txRijks.Text,dateGeprestreerde.Value,cbFunctie.Text,Convert.ToInt32(numAantalUren.Text)));
                int count = WerknemerList.Count -1;
                listWerknemer.Items.Add(WerknemerList[count]);
                }





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



                if (checkWagen.Checked)
                {
                     wagen = "Ja";
                }else {  wagen = "nee"; }
                


                if (txtVoornaam.Text == null || txAchternaam == null || geslacht == null || dateGeboorte == null || txRijks == null || numAantalUren == null)
                {
                    MessageBox.Show("Je moet alles invullen");
                }
                else
                {
                    ProgrammeurList.Add(new Programmeur(txtVoornaam.Text, txAchternaam.Text, geslacht, dateGeboorte.Value, txRijks.Text, dateGeprestreerde.Value, cbFunctie.Text, Convert.ToInt32(numAantalUren.Text), wagen));

                    int count = ProgrammeurList.Count - 1;
                    //MessageBox.Show(Convert.ToString(count));
                    listProgrammeur.Items.Add(ProgrammeurList[count]);
                }

            }


            if (cbFunctie.Text == "IT support")
            {
                if (radMan.Checked)
                {
                    geslacht = radMan.Text;
                }
                if (radiVrouw.Checked)
                {
                    geslacht = radiVrouw.Text;
                }

                if (txtVoornaam.Text == null || txAchternaam == null || geslacht == null || dateGeboorte == null || txRijks == null || numAantalUren == null)
                {
                    MessageBox.Show("Je moet alles invullen");
                }
                else
                {
                     ITsupportList.Add(new IT_Support(txtVoornaam.Text, txAchternaam.Text, geslacht, dateGeboorte.Value, txRijks.Text, dateGeprestreerde.Value, cbFunctie.Text, Convert.ToInt32(numAantalUren.Text)));

                    int count = ITsupportList.Count - 1;
                    //MessageBox.Show(Convert.ToString(count));
                    listITsupport.Items.Add(ITsupportList[count]);
                }

            }
            if (cbFunctie.Text == "Customer Support")
            {
                MessageBox.Show("Probleem met the Customer-Support class Error CS1503 - Cannot convert from");
                if (radMan.Checked)
                {
                    geslacht = radMan.Text;
                }
                if (radiVrouw.Checked)
                {
                    geslacht = radiVrouw.Text;
                }

                if (txtVoornaam.Text == null || txAchternaam == null || geslacht == null || dateGeboorte == null || txRijks == null || numAantalUren == null)
                {
                    MessageBox.Show("Je moet alles invullen");
                }
                else
                {
                    //Error CS1503 - Cannot convert from
                    //CustomerSupportList.Add(new Customer_Support(txtVoornaam.Text, txAchternaam.Text, geslacht, dateGeboorte.Value, txRijks.Text, dateGeprestreerde.Value, cbFunctie.Text, Convert.ToInt32(numAantalUren.Text)));

                    int count = CustomerSupportList.Count - 1;

                    //MessageBox.Show(Convert.ToString(count));
                   // listCustomer.Items.Add(CustomerSupportList[count]); //  probleeem met de Customer-Suport klasse
                }

            }
        }   
        


               
        
        private void listWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {

            Werknemer WerknemerList = (Werknemer)listWerknemer.SelectedItem;
       
               richTextToon.Text = WerknemerList.Content();        
            //Programmeur ProgrammeurList = (Programmeur)listWerknemer.SelectedIte 
        }

        private void listProgrammeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Programmeur ProgrammeurList = (Programmeur)listProgrammeur.SelectedItem;
            //Programmeur ProgrammeurList = (Programmeur)listWerknemer.SelectedItem;
            richTextToon.Text = ProgrammeurList.Content();

        }


        private void listITsupport_SelectedIndexChanged(object sender, EventArgs e)
        {
            IT_Support ITsupportList = (IT_Support)listITsupport .SelectedItem;
            //Programmeur ProgrammeurList = (Programmeur)listWerknemer.SelectedItem;
            richTextToon.Text = ITsupportList.Content();
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

        private void butWerkDel_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices =listWerknemer.SelectedIndices;
            int selected = indices.Count;
            if (indices.Count > 0)
            {
                for (int n = selected - 1; n >= 0; n--)
                {
                    int index = indices[n];
                    listWerknemer .Items.RemoveAt(index);
                }
            }




        }

  

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

