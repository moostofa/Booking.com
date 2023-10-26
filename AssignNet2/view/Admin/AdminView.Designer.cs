namespace Booking.com
{
    partial class AdminView
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
            button_addhotel = new System.Windows.Forms.Button();
            button_editviewhotel = new System.Windows.Forms.Button();
            button_logout = new System.Windows.Forms.Button();
            button_addairline = new System.Windows.Forms.Button();
            button_vieweditairfare = new System.Windows.Forms.Button();
            button_registercustomer = new System.Windows.Forms.Button();
            button_searchcustomerbookings = new System.Windows.Forms.Button();
            button_viewallcustomers = new System.Windows.Forms.Button();
            button_searchbookings = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button_addhotel
            // 
            button_addhotel.Location = new System.Drawing.Point(259, 283);
            button_addhotel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_addhotel.Name = "button_addhotel";
            button_addhotel.Size = new System.Drawing.Size(167, 27);
            button_addhotel.TabIndex = 2;
            button_addhotel.Text = "Add Hotel";
            button_addhotel.UseVisualStyleBackColor = true;
            button_addhotel.Click += addhotel_click;
            // 
            // button_editviewhotel
            // 
            button_editviewhotel.Location = new System.Drawing.Point(259, 331);
            button_editviewhotel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_editviewhotel.Name = "button_editviewhotel";
            button_editviewhotel.Size = new System.Drawing.Size(167, 27);
            button_editviewhotel.TabIndex = 6;
            button_editviewhotel.Text = "View/Edit Hotel Details";
            button_editviewhotel.UseVisualStyleBackColor = true;
            button_editviewhotel.Click += button_viewallhotels_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new System.Drawing.Point(792, 14);
            button_logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_logout.Name = "button_logout";
            button_logout.Size = new System.Drawing.Size(88, 27);
            button_logout.TabIndex = 9;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += logout_click;
            // 
            // button_addairline
            // 
            button_addairline.Location = new System.Drawing.Point(48, 283);
            button_addairline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_addairline.Name = "button_addairline";
            button_addairline.Size = new System.Drawing.Size(167, 27);
            button_addairline.TabIndex = 1;
            button_addairline.Text = "Add Airfare";
            button_addairline.UseVisualStyleBackColor = true;
            button_addairline.Click += button_addairline_Click;
            // 
            // button_vieweditairfare
            // 
            button_vieweditairfare.Location = new System.Drawing.Point(48, 331);
            button_vieweditairfare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_vieweditairfare.Name = "button_vieweditairfare";
            button_vieweditairfare.Size = new System.Drawing.Size(167, 27);
            button_vieweditairfare.TabIndex = 5;
            button_vieweditairfare.Text = "View/Edit Airfare Details";
            button_vieweditairfare.UseVisualStyleBackColor = true;
            // 
            // button_registercustomer
            // 
            button_registercustomer.Location = new System.Drawing.Point(471, 283);
            button_registercustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_registercustomer.Name = "button_registercustomer";
            button_registercustomer.Size = new System.Drawing.Size(167, 27);
            button_registercustomer.TabIndex = 3;
            button_registercustomer.Text = "Register Customer";
            button_registercustomer.UseVisualStyleBackColor = true;
            button_registercustomer.Click += button_registercustomer_Click;
            // 
            // button_searchcustomerbookings
            // 
            button_searchcustomerbookings.Location = new System.Drawing.Point(684, 331);
            button_searchcustomerbookings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_searchcustomerbookings.Name = "button_searchcustomerbookings";
            button_searchcustomerbookings.Size = new System.Drawing.Size(167, 27);
            button_searchcustomerbookings.TabIndex = 8;
            button_searchcustomerbookings.Text = " Search Customer Bookings";
            button_searchcustomerbookings.UseVisualStyleBackColor = true;
            button_searchcustomerbookings.Click += button_searchcustomerbookings_Click;
            // 
            // button_viewallcustomers
            // 
            button_viewallcustomers.Location = new System.Drawing.Point(471, 331);
            button_viewallcustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_viewallcustomers.Name = "button_viewallcustomers";
            button_viewallcustomers.Size = new System.Drawing.Size(167, 27);
            button_viewallcustomers.TabIndex = 7;
            button_viewallcustomers.Text = "View All Customers";
            button_viewallcustomers.UseVisualStyleBackColor = true;
            button_viewallcustomers.Click += button_viewallcustomers_Click;
            // 
            // button_searchbookings
            // 
            button_searchbookings.Location = new System.Drawing.Point(684, 283);
            button_searchbookings.Name = "button_searchbookings";
            button_searchbookings.Size = new System.Drawing.Size(167, 27);
            button_searchbookings.TabIndex = 4;
            button_searchbookings.Text = "Search Bookings";
            button_searchbookings.UseVisualStyleBackColor = true;
            button_searchbookings.Click += button_searchbookings_Click;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(896, 416);
            Controls.Add(button_searchbookings);
            Controls.Add(button_viewallcustomers);
            Controls.Add(button_searchcustomerbookings);
            Controls.Add(button_registercustomer);
            Controls.Add(button_vieweditairfare);
            Controls.Add(button_addairline);
            Controls.Add(button_logout);
            Controls.Add(button_editviewhotel);
            Controls.Add(button_addhotel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AdminView";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_addhotel;
        private System.Windows.Forms.Button button_editviewhotel;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_addairline;
        private System.Windows.Forms.Button button_vieweditairfare;
        private System.Windows.Forms.Button button_registercustomer;
        private System.Windows.Forms.Button button_searchcustomerbookings;
        private System.Windows.Forms.Button button_viewallcustomers;
        private System.Windows.Forms.Button button_searchbookings;
    }
}