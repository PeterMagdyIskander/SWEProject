
namespace projectswe
{
    partial class doctorform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doctornamebtn = new System.Windows.Forms.Button();
            this.doctornamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // doctornamebtn
            // 
            this.doctornamebtn.Location = new System.Drawing.Point(419, 500);
            this.doctornamebtn.Name = "doctornamebtn";
            this.doctornamebtn.Size = new System.Drawing.Size(75, 23);
            this.doctornamebtn.TabIndex = 0;
            this.doctornamebtn.Text = "enter";
            this.doctornamebtn.UseVisualStyleBackColor = true;
            this.doctornamebtn.Click += new System.EventHandler(this.doctornamebtn_Click);
            // 
            // doctornamebox
            // 
            this.doctornamebox.Location = new System.Drawing.Point(353, 472);
            this.doctornamebox.Name = "doctornamebox";
            this.doctornamebox.Size = new System.Drawing.Size(225, 22);
            this.doctornamebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(936, 454);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // doctorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 535);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctornamebox);
            this.Controls.Add(this.doctornamebtn);
            this.Name = "doctorform";
            this.Text = "doctorform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doctornamebtn;
        private System.Windows.Forms.TextBox doctornamebox;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}