using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace library
{
    class Query
    {
        //server=localhost;user=root;database=calculatordb;SslMode=none;charset=utf8"
        string serverName;
        string userName;
        string dbName;
        string sslMode;
        string charset;      
        public Query()
        {
            LoadSetupFromFile();
           
            
        }
        public void LoadSetupFromFile()
        {
            try
            {
                var config = System.IO.File.ReadAllLines("config.txt");
                serverName = config[0].Split(' ')[1];
                userName = config[1].Split(' ')[1];
                dbName = config[2].Split(' ')[1];
                sslMode = config[3].Split(' ')[1];
                charset = config[4].Split(' ')[1];
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Config file no exist.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /*
        public string[] SendQuery(string query)
        {
            string[] result = null;
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection = new MySqlConnection("server=" + serverName + ";user=" +
                    userName + ";database=" + dbName + ";SslMode=" + sslMode + ";charset=" + charset);
                connection.Open();
                MySqlCommand command;
                MySqlDataReader reader;
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();               
                while (reader.HasRows)
                {
                    result = new string[reader.FieldCount];
                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)
                        result[i] = reader[i].ToString();
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1042:
                        MessageBox.Show("Can't get hostname address");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        */

        public List<string[]> SendQuery(string query)
        {
            List<string[]> result = new List<string[]>();
            //string[,] result = null;
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection = new MySqlConnection("server=" + serverName + ";user=" +
                    userName + ";database=" + dbName + ";SslMode=" + sslMode + ";charset=" + charset);
                connection.Open();
                MySqlCommand command;
                MySqlDataReader reader;
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
               
                while (reader.HasRows)
                {
                    for (int j = 0; reader.Read(); j++)
                    {
                        string[] buff = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                            buff[i] = reader[i].ToString();
                        result.Add(buff);
                    }
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1042:
                        MessageBox.Show("Can't get hostname address");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password");
                        break;
                    default:
                        MessageBox.Show(ex.ToString());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

    }
     
}
