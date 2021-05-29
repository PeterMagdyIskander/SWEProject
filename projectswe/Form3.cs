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
    public partial class Form3 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            putdoctordatainlist();
            disconnectedmodeinit();
        }

        private void doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayscombo.Text="";
            busylabel.Text = "avelable places : ";
            getdoctordatainlabel();
            putworkingdaysandav();
        }
        private void putdoctordatainlist()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getdoctorsname";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("doctors", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                doctors.Items.Add(reader[0]);
            }
        }
        private void getdoctordatainlabel()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getdoctorsdata";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("nam", doctors.SelectedItem.ToString());
            cmd.Parameters.Add("doctors", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                namelabel.Text = "Name : " + reader[0].ToString();
                phonelabel.Text = "phone : " + reader[2].ToString();
                locationlabel.Text = "location : " + reader[1].ToString();

            }
        }
        private void putworkingdaysandav()
        {
            dayscombo.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getdoctorworkingdays";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("nam", doctors.SelectedItem.ToString());
            cmd.Parameters.Add("days", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dayscombo.Items.Add(reader[0].ToString());
                

            }
        }

        private void dayscombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            updatedaysavlabel();
        }
        private void disconnectedmodeinit()
        {
            string cmdstr = "select * from doctortime";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);

            

        }
        private void updatedaysavlabel()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getavelable";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("nam", doctors.SelectedItem.ToString());
            cmd.Parameters.Add("da", dayscombo.Text.ToString());
            cmd.Parameters.Add("av", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                busylabel.Text = "avelable places : " + reader[0].ToString();


            }
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {

            DataColumn dc1 = ds.Tables[0].Columns[0];
            DataColumn dc2 = ds.Tables[0].Columns[1];

            ds.Tables[0].PrimaryKey = new DataColumn[] { dc1, dc2 };
            object[] key = new object[2];
            key[0] = doctors.SelectedItem.ToString();
            key[1] = dayscombo.Text.ToString();
            DataRow r = ds.Tables[0].Rows.Find(key);
           
            
            int x=int.Parse(r["userbooked"].ToString())+1;
            r["userbooked"] = x;
            commandBuilder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            updatedaysavlabel();
            

        }
    }
}
