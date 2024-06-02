using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCV_Jela.Models;

namespace SCV_Jela.Repositories
{
    internal class RepozitorijZaposlenika
    {
        public static Zaposlenik GetZaposlenik(string username)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE korime_zaposlenik = '{username}'";
            return FetchZaposlenik(sql);
        }
        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE ID_zaposlenik = {id}";
            return FetchZaposlenik(sql);
        }
        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }
        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_zaposlenik"].ToString());
            string ime = reader["ime_zaposlenik"].ToString();
            string prezime = reader["prezime_zaposlenik"].ToString();
            string korime = reader["korime_zaposlenik"].ToString();
            string lozinka = reader["lozinka_zaposlenik"].ToString();
            var zaposlenik = new Zaposlenik
            {
                ID = id,
                Ime = ime,
                Prezime = prezime,
                Korime = korime,
                Lozinka = lozinka
            };
            return zaposlenik;
        }

    }
}
