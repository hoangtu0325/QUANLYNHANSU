using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QUANLYNHANSU
{
    public class DataService : DataTable
    {
       
        static String strCon = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=QuanLyNhanSu1;Integrated Security=True";
        static SqlConnection connection = new SqlConnection();
        SqlDataAdapter dataAdapter;

        public static bool OpenConnection()
        {
            connection.ConnectionString = strCon;
            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();
                    //System.Windows.Forms.MessageBox.Show("ket noi duoc!!!");
                    return true;
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Không kết nối được!!!");
                    return false;
                }
            }
            else return true;
        }
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
        public DataTable Load(SqlCommand cmd)
        {
            cmd.Connection = connection;
            dataAdapter = new SqlDataAdapter(cmd);
            this.Clear();
            this.dataAdapter.Fill(this);
            return this;
        }
        
        public void Update()
        {
            SqlCommandBuilder buider = new SqlCommandBuilder(this.dataAdapter);
            this.dataAdapter.Update(this);
        }
    }
}
