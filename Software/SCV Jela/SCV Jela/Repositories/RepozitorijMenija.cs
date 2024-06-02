using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCV_Jela.Models;
using System.Data.SqlClient;
using System.Data.Common;

namespace SCV_Jela.Repositories
{
    internal class RepozitorijMenija
    {
        public static Meni GetMeni(int id)
        {
            Meni meni = null;
            string sql = $"SELECT * WHERE Id = {id}";
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

        public static List<Meni> GetMeni()
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
            int id = int.Parse(reader["ID_meni"].ToString());
            string juha = reader["juha_meni"].ToString();
            string glavno = reader["glavno_meni"].ToString();
            string prilog = reader["prilog_meni"].ToString();
            string desert = reader["desert_meni"].ToString();

            var meni = new Meni
            {
                ID = id,
                Juha = juha,
                Glavno = glavno,
                Prilog = prilog,
                Desert = desert
            };
            return meni;
        }

        public void ObrisiMeni(int id)
        {
            string sql = $"DELETE FROM Meni WHERE ID_meni = {id}";

                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
        }
    }
}
