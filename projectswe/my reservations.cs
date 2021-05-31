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
    public partial class my_reservations : Form
    {
        string userid;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public my_reservations(string id)
        {
            userid = id;
            InitializeComponent();
        }

        private void my_reservations_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            putreservationlist();

        }
        private void putreservationlist()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select doctorname,reservday from doctorreserv where USERID=:id";
            cmd.Parameters.Add("id",userid);
            OracleDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                
                myreservations.Items.Add("Dr "+dr[0].ToString()+" at "+dr[1].ToString());

              
            }
            
            dr.Close();
        }

        private void myreservations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
