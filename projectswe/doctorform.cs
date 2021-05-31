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
    public partial class doctorform : Form
    {
        public doctorform()
        {
            InitializeComponent();
        }

        private void doctornamebtn_Click(object sender, EventArgs e)
        {
            doctorrep rep;
            rep = new doctorrep();
            rep.SetParameterValue("doctorname", doctornamebox.Text.ToString());
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
