using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCV_Jela
{
    public partial class FormaTrazi : Form
    {
        public FormaTrazi()
        {
            InitializeComponent();
        }

        private void FormaTrazi_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_pretragaID.Text.Trim(), out int id));
            PronadiMeni_ID(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMeniji formaMeniji = new FormaMeniji();
            Hide();
            formaMeniji.ShowDialog();
            Close();
        }

        public void PronadiMeni_ID(int id)
        {
            string sql = $"SELECT * FROM Meni WHERE ID_meni = {id}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader != null && reader.Read())
            {
                textBox_ID.Text = reader["ID_meni"].ToString();
                textBox_glavno.Text = reader["juha_meni"].ToString();
                textBox_juha.Text = reader["glavno_meni"].ToString();
                textBox_prilog.Text = reader["prilog_meni"].ToString();
                textBox_desert.Text = reader["desert_meni"].ToString();
            }
            else
            {
                MessageBox.Show("Unesite validan ID");
            }
            reader.Close();
            DB.CloseConnection();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_pretragaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_desert_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_prilog_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_glavno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_juha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
