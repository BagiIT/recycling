using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoMaterijal.Interfaces
{
    public class MaterijalInterface
    {
        #region Get
        public static Materijal GetMaterijal(int id)
        {
            Materijal mat = null;
            string sql = $"SELECT * FROM Materijal WHERE ID_mat = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                mat = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return mat;
        }

        

        public static List<Materijal> GetMaterijals()
        {
            List<Materijal> matList = new List<Materijal>();
            string sql = "SELECT * FROM Materijal";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Materijal materijal = CreateObject(reader);
                matList.Add(materijal);
            }

            reader.Close();
            DB.CloseConnection();
            return matList;
        }

        private static Materijal CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_mat"].ToString());
            string name = reader["Naziv"].ToString();
            int maxKol = int.Parse(reader["MaxKol"].ToString());
            float kritKol = maxKol * float.Parse(reader["KriticnaKol"].ToString());
            int kol = int.Parse(reader["Kolicina"].ToString());
            string mjJedinica = reader["mjJedinica"].ToString();
            int Rezervirano = int.Parse(reader["Rezervirano"].ToString());

            var materijal = new Materijal
            {
                id = id,
                name = name,
                maxKol = maxKol,
                kritKol = kritKol,
                kol = kol,
                mjJedinica = mjJedinica,
                Rezervirano = Rezervirano,
                kolicinaSlobodno = kol - Rezervirano
            };
            return materijal;
        }
        #endregion
        
        public static void UpdateAddedSelectedMaterijal(Materijal mat)
        {
            Debug.Write(mat.kol);
            string sql = $"UPDATE Materijal SET Kolicina = {mat.kol} WHERE ID_mat = {mat.id}";
            DB.OpenConnection();
            DB.ExecuteCommant(sql);
            DB.CloseConnection();
        }
        public static void UpdateRezerviranoMaterijal(Materijal mat)
        {
            Debug.Write(mat.kol);
            string sql = $"UPDATE Materijal SET Rezervirano = {mat.Rezervirano} WHERE ID_mat = {mat.id}";
            DB.OpenConnection();
            DB.ExecuteCommant(sql);
            DB.CloseConnection();
        }
        public static void UpdateObradeniMaterijal(Materijal mat)
        {
            Debug.Write(mat.kol);
            string sql = $"UPDATE Materijal SET Rezervirano = {mat.Rezervirano}, Kolicina = {mat.kol} WHERE ID_mat = {mat.id}";
            DB.OpenConnection();
            DB.ExecuteCommant(sql);
            DB.CloseConnection();
        }
    }
}
