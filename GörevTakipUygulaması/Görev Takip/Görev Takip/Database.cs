using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görev_Takip
{
    internal class DataBase
    {
        static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={currentDirectory}tasks.accdb;";
        OleDbConnection connection = new OleDbConnection(connectionString);

       
        public void Connect()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Veri tabanına bağlanırken hata oluştu");
                }
            }
        }
       
        public void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Veri tabanına bağlantıyı keserken hata oluştu");
                }
            }
        }
       
        public OleDbDataReader ExecuteReader(string query)
        {
            if (connection.State == System.Data.ConnectionState.Closed) { MessageBox.Show("Veritabanı bağlantısı kapalı"); }
            else
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                return command.ExecuteReader();
            }
            return null;
        }

        
        public int ExecuteNonQuery(string query)
        {
            if (connection.State == System.Data.ConnectionState.Closed) { Connect(); }
            else
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                return command.ExecuteNonQuery();
            }
            return 0;

        }

    }
}
