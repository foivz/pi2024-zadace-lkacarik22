using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCV_Jela
{
    public partial class FormaDodaj : Form
    {
        public FormaDodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMeniji formaMeniji = new FormaMeniji();
            Hide();
            formaMeniji.ShowDialog();
            Close();
        }

        private void FormaDodaj_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_ID.Text);
            string glavno = textBox_glavno.Text;
            string juha = textBox_juha.Text;
            string prilog = textBox_prilog.Text;
            string desert = textBox_desert.Text;

            if (IDExists(id))
            {
                MessageBox.Show("ID već postoji. Unesite drugi ID.");
            }
            else
            {

                if (string.IsNullOrWhiteSpace(textBox_ID.Text) ||
                    string.IsNullOrWhiteSpace(textBox_juha.Text) ||
                    string.IsNullOrWhiteSpace(textBox_glavno.Text) ||
                    string.IsNullOrWhiteSpace(textBox_desert.Text))
                {
                    MessageBox.Show("Molim popunite sva obavezna polja: ID, Juha, Glavno, Desert");
                    return;
                }

                string sql = $"INSERT INTO Meni (ID_meni, juha_meni, glavno_meni, prilog_meni, desert_meni) VALUES ('{id}', '{glavno}', '{juha}', '{prilog}', '{desert}')";

                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();

                MessageBox.Show("Novi meni je uspješno dodan");
            }
        }

        private bool IDExists(int id)
        {
            DB.OpenConnection();
            string sql = $"SELECT COUNT(*) FROM meni WHERE ID_meni = {id}";
            int count = (int)DB.GetScalar(sql);
            return count > 0;
        }

    }
}
