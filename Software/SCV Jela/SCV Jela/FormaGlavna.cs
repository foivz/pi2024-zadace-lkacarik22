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
using DBLayer;
using System.Collections;
using System.Data.SqlClient;

namespace SCV_Jela
{
    public partial class FormaGlavna : Form
    {
        public FormaGlavna()
        {
            InitializeComponent();
        }

        public static Zaposlenik LogiraniZaposlenik { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMeniji formaMeniji = new FormaMeniji();
            Hide();
            formaMeniji.ShowDialog();
            Close();
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
