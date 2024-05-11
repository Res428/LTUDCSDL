using qlbh.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh
{
    public partial class Frm_SaoluuPhuchoi : Form
    {
        public Frm_SaoluuPhuchoi()
        {
            InitializeComponent();
        }
        Bll_HeThong bd;
        string err = string.Empty;

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "bak";
            saveFileDialog.Title = "Noi chua file bakup";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"D:\";
            saveFileDialog.FileName = string.Format("fileBackup_{0}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSaoluu.Text = saveFileDialog.FileName;
            }
        }

        private void btnSaoluu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSaoluu.Text))
            {
                if (bd.SaoLuuDatabase(ref err, txtSaoluu.Text))
                {
                    MessageBox.Show("Thanh cong");
                }
                else
	            {
                    MessageBox.Show("k thanh cong \n" + err);
	            }
            }
        }

        private void btnPhuchoi_Click(object sender, EventArgs e)
        {
            //bd = new Bll_HeThong(ClsMain.path);
            if (string.IsNullOrEmpty(txtPhuchoi.Text))
            {
                if (bd.PhucHoiDatabase(ref err, txtPhuchoi.Text))
                {
                    MessageBox.Show("Thanh cong");
                }
                else
                {
                    MessageBox.Show("k thanh cong \n" + err);
                }
            }
        }

        private void btnPathRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "backup files (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Title = "Noi chua file backup";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPhuchoi.Text = openFileDialog.FileName;
            }
        }

        private void Frm_SaoluuPhuchoi_Load(object sender, EventArgs e)
        {
            bd = new Bll_HeThong(ClsMain.path);
        }
    }
}
