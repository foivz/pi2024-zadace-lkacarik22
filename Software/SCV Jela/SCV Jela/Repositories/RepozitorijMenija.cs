using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCV_Jela.Models;
using System.Data.SqlClient;

namespace SCV_Jela.Repositories
{
    internal class RepozitorijMenija
    {
        public static Meni GetMeni(int id)
        {
            Meni meni = null;
            string sql = $"SELECT * FROM Meni WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                meni = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return meni;
        }

        public static List<Meni> GetStudents()
        {
            List<Meni> meniji = new List<Meni>();
            string sql = "SELECT * FROM Meni";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Meni meni = CreateObject(reader);
                meniji.Add(meni);
            }
            reader.Close();
            DB.CloseConnection();
            return meniji;
        }

        private static Meni CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string juha = reader["Juha"].ToString();
            string glavno = reader["Glavno"].ToString();
            string prilog = reader["Prilog"].ToString();
            string desert = reader["Desert"].ToString();
            var meni = new Meni
            {
                Id = id,
                Juha = juha,
                Glavno = glavno,
                Prilog = prilog,
                Desert = desert
            };
            return meni;
        }


    }
}
