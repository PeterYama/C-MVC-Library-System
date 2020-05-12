using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;

namespace Data_Access_Layer
{
    public class dbManager
    {
        private string connString; //Connection String
        private SqlConnection SqlConn; //Manages the connection to SQL Server
        private SqlDataAdapter dataAdapter; //Manages the Queries
        private DataSet dataSet; //Set of Data in the memory

        public dbManager()
        {
            connString = "Data Source=SQL5045.site4now.net;Initial Catalog=DB_A57252_B20ES6518;Persist Security Info=True;User ID=DB_A57252_B20ES6518_admin;Password=Ah6tqEC8";
        }

        private void OpenConnection()
        {
            SqlConn = new SqlConnection(connString);
            SqlConn.Open();
        }
        private void CloseConnection()
        {
            SqlConn.Close();
        }

        public DataSet QueryDatabase(string queryString)
        {
            dataSet = new DataSet(); //initialize the DataSet
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn); //Create an SqlCommand
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "books"); //Fills a DataSet & gives a table name
            CloseConnection();
            return dataSet;
        }
        
        public DataSet CheckUser(string userName, string userPassword)
        {
            dataSet = new DataSet(); //initialize the DataSet
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(null, SqlConn); //Create an SqlCommand

            sqlCommand.CommandText =
            "select * from TabUser where UserName = @id AND Password = @pass";

            SqlParameter userID = new SqlParameter("@id", SqlDbType.VarChar, 100);
            SqlParameter userPass = new SqlParameter("@pass", SqlDbType.VarChar, 100);
            userID.Value = userName;
            userPass.Value = userPassword;
            sqlCommand.Parameters.Add(userID);
            sqlCommand.Parameters.Add(userPass);
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "user");
            CloseConnection();

            return dataSet;

        }

        }
    }
