using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCV_Jela.Models;
using SCV_Jela.Repositories;

namespace SCV_Jela
{
    public partial class FormaMeniji : Form
    {
        public FormaMeniji()
        {
            InitializeComponent();
        }

        private void FormaMeniji_Load(object sender, EventArgs e)
        {
            PrikazMeniji();
        }

        private void dgvMeniji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrikazMeniji()
        {
            List<Meni> meni = RepozitorijMenija.GetMeni();
            dgvMeniji.DataSource = meni;

            /*
            List<Meni> meni = RepozitorijMenija.GetMeni();
            List<Meni> odabraniMeniji = new List<Meni>
            {
                meni.ElementAt(0),
                meni.ElementAt(1),
                meni.ElementAt(2)
            };
            dgvMeni1.DataSource = odabraniMeniji;
            
            List<Meni> meni2 = RepozitorijMenija.GetMeni();
            List<Meni> odabraniMeniji2 = new List<Meni>
            {
                meni.ElementAt(3),
                meni.ElementAt(4),
                meni.ElementAt(5)
            };
            dgvMeni2.DataSource = odabraniMeniji2;

            List<Meni> meni3 = RepozitorijMenija.GetMeni();
            List<Meni> odabraniMeniji3 = new List<Meni>
            {
                meni.ElementAt(6),
                meni.ElementAt(7),
                meni.ElementAt(8)
            };
            dgvMeni3.DataSource = odabraniMeniji3;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
