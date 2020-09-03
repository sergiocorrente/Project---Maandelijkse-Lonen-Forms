using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        string geslacht;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbAvailable.Items.Clear();
            switch (cbFunctie.SelectedItem)
            {
                case "Standard":  radWagJaa.Hide();
                                  radWagNee.Hide();
                                    break;
                case "Programmeur":radWagJaa.Show(); 
                                   radWagNee.Show(); break;
                case "IT support": radWagJaa.Hide(); 
                                   radWagNee.Hide(); break;
                case "Customer Support":
                                  radWagJaa.Hide(); radWagNee.Hide(); MessageBox.Show(cbFunctie.Text);
                                   break;
                           


                default:
                    break;
            }



        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (cbFunctie.Text=="Standard")
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
                MessageBox.Show(Convert.ToString(count));
                listWerknemer.Items.Add(WerknemerList[count]);


               
              
            }
        }

        private void listWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Werknemer werknemer = (Werknemer)listWerknemer.SelectedItem;
           

        }
    }
}

