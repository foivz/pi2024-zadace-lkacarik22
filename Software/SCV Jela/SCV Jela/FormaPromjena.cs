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

        private void FormaPromjena_Load(object sender, EventArgs e)
        {
            DB.OpenConnection();
            string sql = "SELECT ID_meni FROM Meni";
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                comboBox_odabir.Items.Add(reader["ID_meni"].ToString());
            }
            reader.Close();
            DB.CloseConnection();
        }

        private void comboBox_odabir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_odabir.SelectedItem.ToString());
            PronadiMeni(id);
        }

        public void PronadiMeni(int id)
        {
            string sql = $"SELECT * FROM Meni WHERE ID_meni = {id}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader != null && reader.Read())
            {
                textBox_ID.Text = reader["ID_meni"].ToString();
                textBox_juha.Text = reader["juha_meni"].ToString();
                textBox_glavno.Text = reader["glavno_meni"].ToString();
                textBox_prilog.Text = reader["prilog_meni"].ToString();
                textBox_desert.Text = reader["desert_meni"].ToString();
            }
            reader.Close();
            DB.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_ID.Text.Trim());
            string glavno = textBox_glavno.Text.Trim();
            string juha = textBox_juha.Text.Trim();
            string prilog = textBox_prilog.Text.Trim();
            string desert = textBox_desert.Text.Trim();

            string sql = $"UPDATE Meni SET juha_meni = '{juha}', glavno_meni = '{glavno}', prilog_meni = '{prilog}', desert_meni = '{desert}' WHERE ID_meni = {id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            MessageBox.Show("Podaci su uspješno spremljeni");
        }
    }
}
