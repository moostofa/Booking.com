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
            this.button_edithotel = new System.Windows.Forms.Button();
            this.button_searchhotel = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addhotel
            // 
            this.button_addhotel.Location = new System.Drawing.Point(57, 274);
            this.button_addhotel.Name = "button_addhotel";
            this.button_addhotel.Size = new System.Drawing.Size(108, 23);
            this.button_addhotel.TabIndex = 2;
            this.button_addhotel.Text = "Add Hotel";
            this.button_addhotel.UseVisualStyleBackColor = true;
            this.button_addhotel.Click += new System.EventHandler(this.addhotel_click);
            // 
            // button_edithotel
            // 
            this.button_edithotel.Location = new System.Drawing.Point(57, 318);
            this.button_edithotel.Name = "button_edithotel";
            this.button_edithotel.Size = new System.Drawing.Size(108, 23);
            this.button_edithotel.TabIndex = 3;
            this.button_edithotel.Text = "Edit Hotel Details";
            this.button_edithotel.UseVisualStyleBackColor = true;
            // 
            // button_searchhotel
            // 
            this.button_searchhotel.Location = new System.Drawing.Point(57, 364);
            this.button_searchhotel.Name = "button_searchhotel";
            this.button_searchhotel.Size = new System.Drawing.Size(108, 23);
            this.button_searchhotel.TabIndex = 4;
            this.button_searchhotel.Text = "Search Hotel";
            this.button_searchhotel.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button_searchhotel);
            this.Controls.Add(this.button_edithotel);
            this.Controls.Add(this.button_addhotel);
            this.Name = "AdminView";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_addhotel;
        private System.Windows.Forms.Button button_edithotel;
        private System.Windows.Forms.Button button_searchhotel;
        private System.Windows.Forms.Button button_logout;
    }
}