
namespace projectswe
{
    partial class Form3
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
            this.doctors = new System.Windows.Forms.ListBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.locationlabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.busylabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dayscombo = new System.Windows.Forms.ComboBox();
            this.bookbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctors
            // 
            this.doctors.FormattingEnabled = true;
            this.doctors.ItemHeight = 16;
            this.doctors.Location = new System.Drawing.Point(27, 37);
            this.doctors.Name = "doctors";
            this.doctors.Size = new System.Drawing.Size(259, 388);
            this.doctors.TabIndex = 0;
            this.doctors.SelectedIndexChanged += new System.EventHandler(this.doctors_SelectedIndexChanged);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(292, 77);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 20);
            this.namelabel.TabIndex = 1;
            // 
            // locationlabel
            // 
            this.locationlabel.AutoSize = true;
            this.locationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationlabel.Location = new System.Drawing.Point(292, 110);
            this.locationlabel.Name = "locationlabel";
            this.locationlabel.Size = new System.Drawing.Size(0, 20);
            this.locationlabel.TabIndex = 2;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.Location = new System.Drawing.Point(292, 141);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(0, 20);
            this.phonelabel.TabIndex = 3;
            // 
            // busylabel
            // 
            this.busylabel.AutoSize = true;
            this.busylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busylabel.Location = new System.Drawing.Point(292, 175);
            this.busylabel.Name = "busylabel";
            this.busylabel.Size = new System.Drawing.Size(0, 20);
            this.busylabel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "working days";
            // 
            // dayscombo
            // 
            this.dayscombo.FormattingEnabled = true;
            this.dayscombo.Location = new System.Drawing.Point(427, 214);
            this.dayscombo.Name = "dayscombo";
            this.dayscombo.Size = new System.Drawing.Size(121, 24);
            this.dayscombo.TabIndex = 6;
            this.dayscombo.SelectedIndexChanged += new System.EventHandler(this.dayscombo_SelectedIndexChanged);
            // 
            // bookbtn
            // 
            this.bookbtn.Location = new System.Drawing.Point(340, 260);
            this.bookbtn.Name = "bookbtn";
            this.bookbtn.Size = new System.Drawing.Size(80, 31);
            this.bookbtn.TabIndex = 7;
            this.bookbtn.Text = "book";
            this.bookbtn.UseVisualStyleBackColor = true;
            this.bookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookbtn);
            this.Controls.Add(this.dayscombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.busylabel);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.locationlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.doctors);
            this.Name = "Form3";
            this.Text = "health assurance system";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox doctors;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label locationlabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label busylabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dayscombo;
        private System.Windows.Forms.Button bookbtn;
    }
}