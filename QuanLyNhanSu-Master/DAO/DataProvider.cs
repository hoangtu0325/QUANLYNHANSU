using MyINI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public string DataSource;
        public string DatabaseName;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        private DataProvider() { }
        private string connectionString = GetConnect.GetConnection();
        private bool IsHaveConnection = GetConnect.IsHaveConnect();
     
        private static string GetConnection()
        {
            IniFile iniFile = new IniFile();
            iniFile.Load("config.ini");
            string DataSource = DataProvider.Instance.GetStoreValue(iniFile.GetKeyValue("Connect", "DataSource"));
            string DatabaseName = DataProvider.Instance.GetStoreValue(iniFile.GetKeyValue("Connect", "DatabaseName"));
            string connection;
            return connection = @"Data Source=" + DataSource + ";Initial Catalog=" + DatabaseName + ";Integrated Security=True";
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            if (IsHaveConnection)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }
            }

            return data;
        }

        public string GetStoreValue(string strValue)
        {
            bool flag = strValue == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                result = strValue.Trim();
            }
            return result;
        }

        

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            if (IsHaveConnection)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    string com = command.CommandText.ToString();
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            if (IsHaveConnection)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();

                    connection.Close();
                }
            }
            

            return data;
        }
        

    }

    public static class GetConnect
    {
        private static  string DataSource;
        private static string DatabaseName;
        private static string UserName;
        private static string PassWord;
        public static string GetConnection()
        {
            IniFile iniFile = new IniFile();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\config.ini";
            iniFile.Load(path);
             DataSource = GetStoreValue(iniFile.GetKeyValue("Connect", "DataSource"));
             DatabaseName = GetStoreValue(iniFile.GetKeyValue("Connect", "DatabaseName"));
             UserName = GetStoreValue(iniFile.GetKeyValue("Connect", "UserName"));
             PassWord = GetStoreValue(iniFile.GetKeyValue("Connect", "PassWord"));
            string connection;
            if (!String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(PassWord))
            {
                connection = @"Data Source=" + DataSource + ";Initial Catalog=" + DatabaseName + ";User ID=" + UserName+ ";Password=" +PassWord+ "Integrated Security=True";
            }
            else
            {
                connection = @"Data Source=" + DataSource + ";Initial Catalog=" + DatabaseName + ";Integrated Security=True";

            }
            return connection;
        }
        public static string GetStoreValue(string strValue)
        {
            bool flag = strValue == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                result = strValue.Trim();
            }
            return result;
        }
        public static bool IsHaveConnect()
        {
            if (DataSource == "" || DatabaseName == "") { return false; }
            else { return true; }
        }
    }
}
