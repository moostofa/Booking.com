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
            this.SuspendLayout();
            // 
            // button_addhotel
            // 
            this.button_addhotel.Location = new System.Drawing.Point(57, 274);
            this.button_addhotel.Name = "button_addhotel";
            this.button_addhotel.Size = new System.Drawing.Size(127, 23);
            this.button_addhotel.TabIndex = 2;
            this.button_addhotel.Text = "Add Hotel";
            this.button_addhotel.UseVisualStyleBackColor = true;
            this.button_addhotel.Click += new System.EventHandler(this.addhotel_click);
            // 
            // button_editviewhotel
            // 
            this.button_editviewhotel.Location = new System.Drawing.Point(57, 317);
            this.button_editviewhotel.Name = "button_editviewhotel";
            this.button_editviewhotel.Size = new System.Drawing.Size(127, 23);
            this.button_editviewhotel.TabIndex = 3;
            this.button_editviewhotel.Text = "View/Edit Hotel Details";
            this.button_editviewhotel.UseVisualStyleBackColor = true;
            this.button_editviewhotel.Click += new System.EventHandler(this.button_editviewhotel_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(472, 23);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.logout_click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 758);
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
    }
}