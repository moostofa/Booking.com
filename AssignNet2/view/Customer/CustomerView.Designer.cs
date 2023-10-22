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
            button_changecustomerdetails = new System.Windows.Forms.Button();
            button_logout = new System.Windows.Forms.Button();
            button_bookHotel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button_changecustomerdetails
            // 
            button_changecustomerdetails.Location = new System.Drawing.Point(482, 12);
            button_changecustomerdetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_changecustomerdetails.Name = "button_changecustomerdetails";
            button_changecustomerdetails.Size = new System.Drawing.Size(150, 36);
            button_changecustomerdetails.TabIndex = 0;
            button_changecustomerdetails.Text = "Change My Details";
            button_changecustomerdetails.UseVisualStyleBackColor = true;
            button_changecustomerdetails.Click += changedetails_click;
            // 
            // button_logout
            // 
            button_logout.Location = new System.Drawing.Point(649, 12);
            button_logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_logout.Name = "button_logout";
            button_logout.Size = new System.Drawing.Size(100, 36);
            button_logout.TabIndex = 1;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += logout_click;
            // 
            // button_bookHotel
            // 
            button_bookHotel.Location = new System.Drawing.Point(41, 415);
            button_bookHotel.Name = "button_bookHotel";
            button_bookHotel.Size = new System.Drawing.Size(150, 35);
            button_bookHotel.TabIndex = 2;
            button_bookHotel.Text = "Book Hotel";
            button_bookHotel.UseVisualStyleBackColor = true;
            button_bookHotel.Click += button_bookHotel_Click;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(762, 486);
            Controls.Add(button_bookHotel);
            Controls.Add(button_logout);
            Controls.Add(button_changecustomerdetails);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CustomerView";
            Text = "BookHotel";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_changecustomerdetails;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_bookHotel;
    }
}