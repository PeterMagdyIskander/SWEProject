using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectswe
{
    public partial class signupform : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;




        public signupform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into USERS values (:id,:name,:address,:password,:phonenum)";
            cmd.Parameters.Add("id", idbox.Text);
            cmd.Parameters.Add("name", namebox.Text);
            cmd.Parameters.Add("address", addressbox.Text);
            cmd.Parameters.Add("password", paswordbox.Text);
            cmd.Parameters.Add("phonenum", phonebox.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                
                MessageBox.Show("registered");
            }


        }

        private void signupform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            
            conn.Open();
        }
    }
}
