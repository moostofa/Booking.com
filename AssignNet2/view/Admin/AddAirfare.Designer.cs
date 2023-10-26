﻿namespace Booking.com
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
            label_airlinename = new System.Windows.Forms.Label();
            label_location = new System.Windows.Forms.Label();
            label_destination = new System.Windows.Forms.Label();
            label_price = new System.Windows.Forms.Label();
            label_title = new System.Windows.Forms.Label();
            tb_airlinename = new System.Windows.Forms.TextBox();
            tb_location = new System.Windows.Forms.TextBox();
            tb_destination = new System.Windows.Forms.TextBox();
            tb_price = new System.Windows.Forms.TextBox();
            button_addairfare = new System.Windows.Forms.Button();
            button_cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label_airlinename
            // 
            label_airlinename.AutoSize = true;
            label_airlinename.Location = new System.Drawing.Point(115, 127);
            label_airlinename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_airlinename.Name = "label_airlinename";
            label_airlinename.Size = new System.Drawing.Size(41, 15);
            label_airlinename.TabIndex = 0;
            label_airlinename.Text = "Airline";
            // 
            // label_location
            // 
            label_location.AutoSize = true;
            label_location.Location = new System.Drawing.Point(100, 179);
            label_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_location.Name = "label_location";
            label_location.Size = new System.Drawing.Size(53, 15);
            label_location.TabIndex = 1;
            label_location.Text = "Location";
            // 
            // label_destination
            // 
            label_destination.AutoSize = true;
            label_destination.Location = new System.Drawing.Point(86, 239);
            label_destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_destination.Name = "label_destination";
            label_destination.Size = new System.Drawing.Size(67, 15);
            label_destination.TabIndex = 2;
            label_destination.Text = "Destination";
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new System.Drawing.Point(120, 294);
            label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_price.Name = "label_price";
            label_price.Size = new System.Drawing.Size(33, 15);
            label_price.TabIndex = 3;
            label_price.Text = "Price";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new System.Drawing.Point(178, 84);
            label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new System.Drawing.Size(67, 15);
            label_title.TabIndex = 4;
            label_title.Text = "Add Airfare";
            // 
            // tb_airlinename
            // 
            tb_airlinename.Location = new System.Drawing.Point(211, 127);
            tb_airlinename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_airlinename.Name = "tb_airlinename";
            tb_airlinename.Size = new System.Drawing.Size(173, 23);
            tb_airlinename.TabIndex = 1;
            // 
            // tb_location
            // 
            tb_location.Location = new System.Drawing.Point(211, 179);
            tb_location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_location.Name = "tb_location";
            tb_location.Size = new System.Drawing.Size(173, 23);
            tb_location.TabIndex = 2;
            // 
            // tb_destination
            // 
            tb_destination.Location = new System.Drawing.Point(211, 235);
            tb_destination.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_destination.Name = "tb_destination";
            tb_destination.Size = new System.Drawing.Size(173, 23);
            tb_destination.TabIndex = 3;
            // 
            // tb_price
            // 
            tb_price.Location = new System.Drawing.Point(211, 291);
            tb_price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_price.Name = "tb_price";
            tb_price.Size = new System.Drawing.Size(173, 23);
            tb_price.TabIndex = 4;
            tb_price.KeyPress += tb_price_KeyPress;
            // 
            // button_addairfare
            // 
            button_addairfare.Location = new System.Drawing.Point(232, 363);
            button_addairfare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_addairfare.Name = "button_addairfare";
            button_addairfare.Size = new System.Drawing.Size(88, 27);
            button_addairfare.TabIndex = 6;
            button_addairfare.Text = "Add Airfare";
            button_addairfare.UseVisualStyleBackColor = true;
            button_addairfare.Click += button_addairfare_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new System.Drawing.Point(124, 363);
            button_cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new System.Drawing.Size(88, 27);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // AddAirfare
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(475, 481);
            Controls.Add(button_cancel);
            Controls.Add(button_addairfare);
            Controls.Add(tb_price);
            Controls.Add(tb_destination);
            Controls.Add(tb_location);
            Controls.Add(tb_airlinename);
            Controls.Add(label_title);
            Controls.Add(label_price);
            Controls.Add(label_destination);
            Controls.Add(label_location);
            Controls.Add(label_airlinename);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddAirfare";
            Text = "BookHotel";
            ResumeLayout(false);
            PerformLayout();
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