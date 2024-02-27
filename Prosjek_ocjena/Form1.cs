using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosjek_ocjena
{
    public partial class Form1 : Form
    {
        int ocjena, brojOcjena = 0, zbroj;
        double prosjek;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(txtunosOcjene.Text);
            brojOcjena++;
            zbroj += ocjena;
            DialogResult odgovor = MessageBox.Show("zelis li upisati jos ocjena?", "upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           switch(odgovor)
            {
                case DialogResult.Yes:
                    txtunosOcjene.Clear();
                    break;
                    case DialogResult.No:
                    prosjek = (double)zbroj / brojOcjena; 
                    txtProsjekOcjene.Text = prosjek.ToString();
                    break;
            }
        }
    }
}
