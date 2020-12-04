using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module.Popup
{
    public partial class frmFilterExportExcel : Form
    {
        public frmFilterExportExcel()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAllPhongBan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                    ChangeAllCheckBoxValues(true);
                else
                    ChangeAllCheckBoxValues( false);
            }
        }
        private void ChangeAllCheckBoxValues(bool value)
        {
            for (int i = 1; i < cbAllPhongBan.Items.Count; i++)
            {
                cbAllPhongBan.SetItemChecked(i, value);
            }
        }
    }
}
