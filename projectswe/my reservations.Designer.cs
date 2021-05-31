
namespace projectswe
{
    partial class my_reservations
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
            this.myreservations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // myreservations
            // 
            this.myreservations.FormattingEnabled = true;
            this.myreservations.ItemHeight = 16;
            this.myreservations.Location = new System.Drawing.Point(12, 12);
            this.myreservations.Name = "myreservations";
            this.myreservations.Size = new System.Drawing.Size(776, 404);
            this.myreservations.TabIndex = 0;
            this.myreservations.SelectedIndexChanged += new System.EventHandler(this.myreservations_SelectedIndexChanged);
            // 
            // my_reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myreservations);
            this.Name = "my_reservations";
            this.Text = "my_reservations";
            this.Load += new System.EventHandler(this.my_reservations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox myreservations;
    }
}