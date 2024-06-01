using DBLayer;
using SCV_Jela.Models;
using SCV_Jela.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCV_Jela
{
    public partial class FormaBrisanje : Form
    {
        private RepozitorijMenija repozitorijMenija;
        public FormaBrisanje()
        {
            InitializeComponent();
            repozitorijMenija = new RepozitorijMenija();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_brisanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void gumb_brisanje_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_brisanje.Text, out int idMenija))
            {
                repozitorijMenija.ObrisiMeni(idMenija);
                MessageBox.Show("Meni uspješno obrisan.");
            }
        }

        private void FormaBrisanje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMeniji formaMeniji = new FormaMeniji();
            Hide();
            formaMeniji.ShowDialog();
            Close();
        }
    }
}
