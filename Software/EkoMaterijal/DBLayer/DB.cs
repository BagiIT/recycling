﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DBLayer
{
    public static class DB
    {
        private static string _connectionString = @"Data Source=31.147.206.65;Initial Catalog=PI2324_bkolakovi22_DB;User ID=PI2324_bkolakovi22_User;Password=O/8Lr>t9;";

        private static SqlConnection _connection;

        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }
        public static void CloseConnection()
        {
            if(_connection.State != System.Data.ConnectionState.Closed) 
            {
                _connection.Close();
            }
        }
        public static SqlDataReader GetDataReader(string query) 
        {
            SqlCommand command = new SqlCommand(query,_connection);
            return command.ExecuteReader();
        }
        public static int ExecuteCommant(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);
            return command.ExecuteNonQuery();
        }


    }
}
