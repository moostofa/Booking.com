namespace Booking.com
{
    partial class AddHotel
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_pricepernight = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(139, 114);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 0;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(139, 171);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(100, 20);
            this.tb_location.TabIndex = 1;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(139, 233);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 2;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_keypress);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(41, 114);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(75, 13);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name of Hotel";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(68, 171);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(48, 13);
            this.label_location.TabIndex = 4;
            this.label_location.Text = "Location";
            // 
            // label_pricepernight
            // 
            this.label_pricepernight.AutoSize = true;
            this.label_pricepernight.Location = new System.Drawing.Point(38, 240);
            this.label_pricepernight.Name = "label_pricepernight";
            this.label_pricepernight.Size = new System.Drawing.Size(78, 13);
            this.label_pricepernight.TabIndex = 5;
            this.label_pricepernight.Text = "Price Per Night";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(101, 54);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(54, 13);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "Add Hotel";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(44, 298);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(150, 298);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // AddHotelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 351);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_pricepernight);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_name);
            this.Name = "AddHotelView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_pricepernight;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
    }
}