using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hau.chialop
{
    public partial class frmCheckConn2 : Form
    {
        public frmCheckConn2()
        {
            InitializeComponent();
        }

        Database data;
        private string connectionString = "server = P0328; database = test; integrated security = true";

        string err;

        private void frmCheckConn2_Load(object sender, EventArgs e)
        {
            data = new Database(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                if (data.checkconn(ref err))
                {
                    MessageBox.Show("Ok");
                }
                else
                {
                    MessageBox.Show("No \n" + err);
                }
            }
        }
    }
}
