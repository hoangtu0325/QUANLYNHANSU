using Microsoft.Win32;
using MyINI;
using QuanLyNhanSu_Master.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module.Popup
{
    public partial class frmConfigDatabase : Form
    {
        private string storeConfig = "config.ini";
        private string init = "Connect";

        public frmConfigDatabase()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
            LoadSaveData();
            
        }

        public void Load()
        {
            if (txtDataSource.Text != "")
            {
                List<string> list =  GetDatabaseList();
            }
        }

        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();
            string DataSource = txtDataSource.Text;
            string UserName = txtUserName.Text;
            string PassWord = txtPassWord.Text;
            string connectionString = "Data Source=" + txtDataSource.Text + "; Integrated Security=True;";

            if (!String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(PassWord))
            {
                connectionString = @"Data Source=" + DataSource + ";User ID=" + UserName + ";Password=" + PassWord + "Integrated Security=True";
            }
            else
            {
                connectionString = @"Data Source=" + DataSource + ";Integrated Security=True";

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;
        }

        private void cbListDatabaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void txtDataSource_Leave(object sender, EventArgs e)
        {
            if (txtDataSource.Text != "")
            {
                bool HaveDatabase = false;
                List<string> list = GetDatabaseList();
                foreach (string item in list)
                {
                    if (item == "QuanLyNhanSu")
                    {
                        HaveDatabase = true;
                    }
                    cbListDatabaseName.Items.Add(item.ToString());
                }

     
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        
        private void SaveData()
        {
            if (txtDataSource.Text != "")
            {
                bool flag = !File.Exists(this.storeConfig);
                if (flag)
                {
                    File.Create(this.storeConfig).Close();
                }
                IniFile iniFile = new IniFile();
                iniFile.Load(this.storeConfig);
                iniFile.SetKeyValue(this.init, "DataSource", this.txtDataSource.Text);
                iniFile.SetKeyValue(this.init, "UserName", this.txtUserName.Text);
                iniFile.SetKeyValue(this.init, "PassWord", AccountDAO.Instance.EnCrypt(txtPassWord.Text, "%4oPNbxNwO3Z15CoNCbi").ToString());
                iniFile.SetKeyValue(this.init, "DatabaseName", this.cbListDatabaseName.SelectedItem.ToString());
                iniFile.Save(this.storeConfig);
                
                if (Application.OpenForms.OfType<frmLogin>().Any())
                {
                    this.Close();
                }else
                {
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                }
                
            }
        }

        private void LoadSaveData()
        {
            bool flag = File.Exists(this.storeConfig);
            if (flag)
            {
                IniFile iniFile = new IniFile();
                iniFile.Load(this.storeConfig);
                string pass = this.GetStoreValue(iniFile.GetKeyValue(this.init, "PassWord"));
                this.txtDataSource.Text = this.GetStoreValue(iniFile.GetKeyValue(this.init, "DataSource"));
                this.txtPassWord.Text = AccountDAO.Instance.DeCrypt(pass, "%4oPNbxNwO3Z15CoNCbi").ToString();
                string DatabaseName = this.GetStoreValue(iniFile.GetKeyValue(this.init, "DatabaseName"));
                if (!String.IsNullOrEmpty(DatabaseName))
                {
                    cbListDatabaseName.Items.Add(DatabaseName);
                    cbListDatabaseName.SelectedIndex = 0;
                }
            }
        }

        private string GetStoreValue(string strValue)
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
    }
}
