using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoMaterijal.Interfaces
{
    public class RadnikInterface
    {
        public static Radnik GetRadnik(string username)
        {
            string sql = $"SELECT * FROM Radnik WHERE username = '{username}'";
            return FetchRadnik(sql);
        }

        private static Radnik FetchRadnik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Radnik radnik = null;
            if(reader.HasRows) {
                reader.Read();
                radnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return radnik;
        }

        private static Radnik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();

            var radnik = new Radnik
            {
                id = id,
                username = username,
                password = password
            };
            return radnik;
        }
    }
}
