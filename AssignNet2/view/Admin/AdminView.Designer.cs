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
            this.button_addhotel = new System.Windows.Forms.Button();
            this.button_editviewhotel = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_addairline = new System.Windows.Forms.Button();
            this.button_vieweditairfare = new System.Windows.Forms.Button();
            this.button_registercustomer = new System.Windows.Forms.Button();
            this.button_searchcustomer = new System.Windows.Forms.Button();
            this.button_viewallcustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addhotel
            // 
            this.button_addhotel.Location = new System.Drawing.Point(222, 245);
            this.button_addhotel.Name = "button_addhotel";
            this.button_addhotel.Size = new System.Drawing.Size(143, 23);
            this.button_addhotel.TabIndex = 2;
            this.button_addhotel.Text = "Add Hotel";
            this.button_addhotel.UseVisualStyleBackColor = true;
            this.button_addhotel.Click += new System.EventHandler(this.addhotel_click);
            // 
            // button_editviewhotel
            // 
            this.button_editviewhotel.Location = new System.Drawing.Point(222, 287);
            this.button_editviewhotel.Name = "button_editviewhotel";
            this.button_editviewhotel.Size = new System.Drawing.Size(143, 23);
            this.button_editviewhotel.TabIndex = 3;
            this.button_editviewhotel.Text = "View/Edit Hotel Details";
            this.button_editviewhotel.UseVisualStyleBackColor = true;
            this.button_editviewhotel.Click += new System.EventHandler(this.button_editviewhotel_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(679, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.logout_click);
            // 
            // button_addairline
            // 
            this.button_addairline.Location = new System.Drawing.Point(41, 245);
            this.button_addairline.Name = "button_addairline";
            this.button_addairline.Size = new System.Drawing.Size(143, 23);
            this.button_addairline.TabIndex = 6;
            this.button_addairline.Text = "Add Airfare";
            this.button_addairline.UseVisualStyleBackColor = true;
            this.button_addairline.Click += new System.EventHandler(this.button_addairline_Click);
            // 
            // button_vieweditairfare
            // 
            this.button_vieweditairfare.Location = new System.Drawing.Point(41, 287);
            this.button_vieweditairfare.Name = "button_vieweditairfare";
            this.button_vieweditairfare.Size = new System.Drawing.Size(143, 23);
            this.button_vieweditairfare.TabIndex = 7;
            this.button_vieweditairfare.Text = "View/Edit Airfare Details";
            this.button_vieweditairfare.UseVisualStyleBackColor = true;
            // 
            // button_registercustomer
            // 
            this.button_registercustomer.Location = new System.Drawing.Point(404, 245);
            this.button_registercustomer.Name = "button_registercustomer";
            this.button_registercustomer.Size = new System.Drawing.Size(143, 23);
            this.button_registercustomer.TabIndex = 8;
            this.button_registercustomer.Text = "Register Customer";
            this.button_registercustomer.UseVisualStyleBackColor = true;
            this.button_registercustomer.Click += new System.EventHandler(this.button_registercustomer_Click);
            // 
            // button_searchcustomer
            // 
            this.button_searchcustomer.Location = new System.Drawing.Point(404, 287);
            this.button_searchcustomer.Name = "button_searchcustomer";
            this.button_searchcustomer.Size = new System.Drawing.Size(143, 23);
            this.button_searchcustomer.TabIndex = 9;
            this.button_searchcustomer.Text = "Search Customer";
            this.button_searchcustomer.UseVisualStyleBackColor = true;
            this.button_searchcustomer.Click += new System.EventHandler(this.button_searchcustomer_Click);
            // 
            // button_viewallcustomers
            // 
            this.button_viewallcustomers.Location = new System.Drawing.Point(404, 331);
            this.button_viewallcustomers.Name = "button_viewallcustomers";
            this.button_viewallcustomers.Size = new System.Drawing.Size(143, 23);
            this.button_viewallcustomers.TabIndex = 10;
            this.button_viewallcustomers.Text = "View All Customers";
            this.button_viewallcustomers.UseVisualStyleBackColor = true;
            this.button_viewallcustomers.Click += new System.EventHandler(this.button_viewallcustomers_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 431);
            this.Controls.Add(this.button_viewallcustomers);
            this.Controls.Add(this.button_searchcustomer);
            this.Controls.Add(this.button_registercustomer);
            this.Controls.Add(this.button_vieweditairfare);
            this.Controls.Add(this.button_addairline);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_editviewhotel);
            this.Controls.Add(this.button_addhotel);
            this.Name = "AdminView";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_addhotel;
        private System.Windows.Forms.Button button_editviewhotel;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_addairline;
        private System.Windows.Forms.Button button_vieweditairfare;
        private System.Windows.Forms.Button button_registercustomer;
        private System.Windows.Forms.Button button_searchcustomer;
        private System.Windows.Forms.Button button_viewallcustomers;
    }
}