
namespace projectswe
{
    partial class signinform
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
            this.signinbtn = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinbtn
            // 
            this.signinbtn.Location = new System.Drawing.Point(211, 232);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(111, 33);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "sign in";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(211, 122);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(202, 22);
            this.idbox.TabIndex = 1;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(211, 174);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(202, 22);
            this.passwordbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(211, 294);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(111, 33);
            this.signupbtn.TabIndex = 5;
            this.signupbtn.Text = "sign up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // signinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 404);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.signinbtn);
            this.Name = "signinform";
            this.Text = "health insurance system";
            this.Load += new System.EventHandler(this.signinform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signupbtn;
    }
}

