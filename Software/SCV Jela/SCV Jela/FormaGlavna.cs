using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SCV_Jela.Models;
using SCV_Jela.Repositories;

namespace SCV_Jela
{
    public partial class FormaGlavna : Form
    {
        public FormaGlavna()
        {
            InitializeComponent();
        }

        //public static Zaposlenik LogiraniZaposlenik { get; set; }
        private string username = "test";
        private string password = "test";



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_prijava.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_lozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                //LogiraniZaposlenik = RepozitorijZaposlenika.GetZaposlenik(textBox_prijava.Text);

                //if (LogiraniZaposlenik != null && LogiraniZaposlenik.Lozinka == textBox_lozinka.Text)
                if(textBox_prijava.Text == username && textBox_lozinka.Text == password)
                {
                    FormaMeniji formaMeniji = new FormaMeniji();
                    Hide();
                    formaMeniji.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }


        }

        private void textBox_prijava_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_lozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormaGlavna_Load(object sender, EventArgs e)
        {

        }
    }
}
