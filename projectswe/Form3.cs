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
        string userid;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;
        OracleDataAdapter adapter1;
        OracleCommandBuilder commandBuilder1;
        DataSet ds1;
        public Form3(string id)
        {
            userid = id;
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
            bookbtn.Enabled = false;
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
            if (doctors.SelectedItem == null)
                return;
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

            string cmdstr1 = "select * from DOCTORRESERV";
            adapter1 = new OracleDataAdapter(cmdstr1, ordb);
            ds1 = new DataSet();
            adapter1.Fill(ds1);



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
                if(int.Parse((reader[0].ToString()))<=0)
                {
                    bookbtn.Enabled = false;
                }
                else
                {
                    bookbtn.Enabled = true;
                }


            }
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {

            try
            {
                DataColumn dc1 = ds.Tables[0].Columns[0];
                DataColumn dc2 = ds.Tables[0].Columns[1];



                object[] rowdara = new object[3];
                rowdara[0] = userid;
                rowdara[1] = doctors.SelectedItem.ToString();
                rowdara[2] = dayscombo.Text.ToString();

                ds1.Tables[0].Rows.Add(rowdara);
                commandBuilder1 = new OracleCommandBuilder(adapter1);
                adapter1.Update(ds1.Tables[0]);



                ds.Tables[0].PrimaryKey = new DataColumn[] { dc1, dc2 };
                object[] key = new object[2];
                key[0] = doctors.SelectedItem.ToString();
                key[1] = dayscombo.Text.ToString();
                DataRow r = ds.Tables[0].Rows.Find(key);
                int x = int.Parse(r["userbooked"].ToString()) + 1;
                r["userbooked"] = x;
                commandBuilder = new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);



               
                
            }
            catch
            {
                MessageBox.Show("already registerd");
            }
            updatedaysavlabel();



        }

        private void myreserv_Click(object sender, EventArgs e)
        {
            var f = new my_reservations(userid);
            f.Show();

        }
    }
}
