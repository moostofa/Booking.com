namespace Booking.com
{
    partial class CustomerView
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
            this.button_changecustomerdetails = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_changecustomerdetails
            // 
            this.button_changecustomerdetails.Location = new System.Drawing.Point(648, 12);
            this.button_changecustomerdetails.Name = "button_changecustomerdetails";
            this.button_changecustomerdetails.Size = new System.Drawing.Size(129, 31);
            this.button_changecustomerdetails.TabIndex = 0;
            this.button_changecustomerdetails.Text = "Change My Details";
            this.button_changecustomerdetails.UseVisualStyleBackColor = true;
            this.button_changecustomerdetails.Click += new System.EventHandler(this.changedetails_click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(783, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(86, 31);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.logout_click);
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 676);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_changecustomerdetails);
            this.Name = "UserWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_changecustomerdetails;
        private System.Windows.Forms.Button button_logout;
    }
}