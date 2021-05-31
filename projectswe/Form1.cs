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
    public partial class signinform : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
       
        public signinform()
        {

           
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            var f = new signupform();
            f.Show();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            checklogininfo();

        }

        private void signinform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }
        private void checklogininfo()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select USERPASSWORD from USERS where USERID=:id";
            cmd.Parameters.Add("id", idbox.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            string message = "ID is not registered sign up first";
            bool wrongpass = false;
            while (dr.Read())
            {
                message = "wrong password";
                if (dr[0].Equals(passwordbox.Text))
                {

                    var f = new Form3(idbox.Text.ToString());
                    f.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(message);
                    wrongpass = true;
                }
            }
            if (!wrongpass && message != "wrong password")
                MessageBox.Show(message);
            dr.Close();
        }

        private void doctorsignin_Click(object sender, EventArgs e)
        {
            var f = new doctorform();
            f.Show();
        }
    }
}
