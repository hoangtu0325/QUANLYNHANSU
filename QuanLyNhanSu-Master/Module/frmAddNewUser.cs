using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.Module.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmAddNewUser : Form
    {
        public string ReturnValue1 { get; set; }

        public frmAddNewUser()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
           
        }
        //private bool Drag;
        //private int MouseX;
        //private int MouseY;

        //private const int WM_NCHITTEST = 0x84;
        //private const int HTCLIENT = 0x1;
        //private const int HTCAPTION = 0x2;

        //private bool m_aeroEnabled;

        //private const int CS_DROPSHADOW = 0x00020000;
        //private const int WM_NCPAINT = 0x0085;
        //private const int WM_ACTIVATEAPP = 0x001C;

        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        //public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        //public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        //public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        //[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //    );

        //public struct MARGINS
        //{
        //    public int leftWidth;
        //    public int rightWidth;
        //    public int topHeight;
        //    public int bottomHeight;
        //}
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();
        //        CreateParams cp = base.CreateParams;
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW; return cp;
        //    }
        //}
        //private bool CheckAeroEnabled()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6)
        //    {
        //        int enabled = 0; DwmIsCompositionEnabled(ref enabled);
        //        return (enabled == 1) ? true : false;
        //    }
        //    return false;
        //}
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCPAINT:
        //            if (m_aeroEnabled)
        //            {
        //                var v = 2;
        //                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        //                MARGINS margins = new MARGINS()
        //                {
        //                    bottomHeight = 1,
        //                    leftWidth = 10,
        //                    rightWidth = 10,
        //                    topHeight = 10
        //                }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        //            }
        //            break;
        //        default: break;
        //    }
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        //}
        //private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Drag = true;
        //    MouseX = Cursor.Position.X - this.Left;
        //    MouseY = Cursor.Position.Y - this.Top;
        //}
        //private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (Drag)
        //    {
        //        this.Top = Cursor.Position.Y - MouseY;
        //        this.Left = Cursor.Position.X - MouseX;
        //    }
        //}
        //private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string passWord = txtPassword.Text.Trim();
            string RePassword = txtRePassword.Text.Trim();
            string Email = txtEmail.Text.Trim();

            if (userName == "" || passWord == "" || RePassword == "" || Email == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (passWord != RePassword)
                {
                    MessageBox.Show("Mật khẩu mới phải trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (AccountDAO.Instance.IsAddNewUser(userName, passWord, Email))
                    {

                        MessageBox.Show("Thêm tài khoản Admin thành công");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã khai báo hoặc không kết nối được server!!");
                    }
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(sender, e);
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox textbox = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            textbox.isPassword = true;
        }
    }
}
