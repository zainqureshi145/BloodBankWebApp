using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebApplication1.Classes
{
    public class DataAccess
    {
        private string ConnectionString = @"Server=localhost;Database=blooddonor;Uid=root;Pwd=1234";
        User UO = new User();

        public int RegisterUser()
        {

            int RowUpdated = 0;
            MySqlConnection connection = new MySqlConnection();
            MySqlCommand command = new MySqlCommand();
            string QueryString = "Insert Into donor(DonorName,DonorPass,DonorEmail) values('"+UO.UserName+"','"+UO.Password+"','"+UO.Email+"')";
            connection.ConnectionString = ConnectionString;
            command.CommandText = QueryString;
            command.Connection = connection;
            connection.Open();

            RowUpdated = command.ExecuteNonQuery();

            return RowUpdated;
        }
    }
}