using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql provider
using System.Data;
using System.Data.SqlClient;

namespace hau
{
    public partial class checkconnect : Form
    {
        public checkconnect()
        {
            InitializeComponent();
        }

        private SqlConnection scn;
        private string connectionString = "server = P0328; database = test; integrated security = true";

        private string ChoiceconString(bool winNT)
        {
            string connectionString = string.Empty;
            if (winNT)
            {
                connectionString = "server = P0328; database = test; integrated security = true";
            }
            else
            {
                connectionString = "server = P0328; database = test; uid = res; pwd = 10091001;";
            } return connectionString;
        }

        private void checkconnect_Load(object sender, EventArgs e)
        {
            scn = new SqlConnection(ChoiceconString(true));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkconn())
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private bool checkconn()
        {
            try
            {
                scn.Open();
                return true;
            }
            catch (SystemException ex)
            {
                return false;
                throw;
            }
            finally
            {
                scn.Close();
            }
        }
    }
}
