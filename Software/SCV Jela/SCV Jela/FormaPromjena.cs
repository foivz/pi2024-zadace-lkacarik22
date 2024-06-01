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
    public partial class FormaPromjena : Form
    {
        public FormaPromjena()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaMeniji formaMeniji = new FormaMeniji();
            Hide();
            formaMeniji.ShowDialog();
            Close();
        }
    }
}
