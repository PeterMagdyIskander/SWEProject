
namespace projectswe
{
    partial class signupform
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.paswordbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(287, 133);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(176, 22);
            this.namebox.TabIndex = 0;
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(287, 172);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(176, 22);
            this.phonebox.TabIndex = 1;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(287, 204);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(176, 22);
            this.addressbox.TabIndex = 2;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(287, 246);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(176, 22);
            this.idbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "id";
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(306, 322);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(112, 48);
            this.signupbtn.TabIndex = 8;
            this.signupbtn.Text = "sign up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // paswordbox
            // 
            this.paswordbox.Location = new System.Drawing.Point(287, 287);
            this.paswordbox.Name = "paswordbox";
            this.paswordbox.PasswordChar = '*';
            this.paswordbox.Size = new System.Drawing.Size(176, 22);
            this.paswordbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "password";
            // 
            // signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paswordbox);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.namebox);
            this.Name = "signupform";
            this.Text = "health insurance system";
            this.Load += new System.EventHandler(this.signupform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox phonebox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.TextBox paswordbox;
        private System.Windows.Forms.Label label5;
    }
}