using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isinglass
{
    class DatabaseController
    {
        private SqlConnection connection;
        private string serverAddress;
        private string serverPort;
        private string serverNetworkLibrary;
        private string serverDatabaseName;
        private string serverUserID;
        private string serverUserPassword;
        private string connectionString;

        public string generateConnectionString()
        {
            connectionString = "Data Source=" + serverAddress + "," + serverPort + ";Network Library=" + 
                serverNetworkLibrary + ";Initial Catalog=" + serverDatabaseName + ";User ID=" + 
                serverUserID + ";Password=" + serverUserPassword;
            return connectionString;
        }

        public void setDefault()
        {
            serverAddress = "127.0.0.1";
            serverPort = "3002";
            serverNetworkLibrary = "DBMSSOCN";
            serverDatabaseName = "isinglass";
            serverUserID = "chef";
            serverUserPassword = "rachelray";
            generateConnectionString();
        }
    }
}
