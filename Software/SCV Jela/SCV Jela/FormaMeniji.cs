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
        }
    }
}
