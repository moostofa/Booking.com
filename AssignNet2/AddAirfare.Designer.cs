namespace Booking.com
{
    partial class AddAirfare
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
            this.label_airlinename = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.tb_airlinename = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.button_addairfare = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_airlinename
            // 
            this.label_airlinename.AutoSize = true;
            this.label_airlinename.Location = new System.Drawing.Point(99, 110);
            this.label_airlinename.Name = "label_airlinename";
            this.label_airlinename.Size = new System.Drawing.Size(35, 13);
            this.label_airlinename.TabIndex = 0;
            this.label_airlinename.Text = "Airline";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(86, 155);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(48, 13);
            this.label_location.TabIndex = 1;
            this.label_location.Text = "Location";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(74, 207);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(60, 13);
            this.label_destination.TabIndex = 2;
            this.label_destination.Text = "Destination";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(103, 255);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(31, 13);
            this.label_price.TabIndex = 3;
            this.label_price.Text = "Price";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(153, 73);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(59, 13);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Add Airfare";
            // 
            // tb_airlinename
            // 
            this.tb_airlinename.Location = new System.Drawing.Point(181, 110);
            this.tb_airlinename.Name = "tb_airlinename";
            this.tb_airlinename.Size = new System.Drawing.Size(149, 20);
            this.tb_airlinename.TabIndex = 5;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(181, 155);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(149, 20);
            this.tb_location.TabIndex = 6;
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(181, 204);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(149, 20);
            this.tb_destination.TabIndex = 7;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(181, 252);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(149, 20);
            this.tb_price.TabIndex = 8;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // button_addairfare
            // 
            this.button_addairfare.Location = new System.Drawing.Point(199, 315);
            this.button_addairfare.Name = "button_addairfare";
            this.button_addairfare.Size = new System.Drawing.Size(75, 23);
            this.button_addairfare.TabIndex = 9;
            this.button_addairfare.Text = "Add Airfare";
            this.button_addairfare.UseVisualStyleBackColor = true;
            this.button_addairfare.Click += new System.EventHandler(this.button_addairfare_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(106, 315);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddAirfare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 417);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_addairfare);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_airlinename);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_airlinename);
            this.Name = "AddAirfare";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_airlinename;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox tb_airlinename;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button button_addairfare;
        private System.Windows.Forms.Button button_cancel;
    }
}