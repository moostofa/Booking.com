namespace Booking.com
{
    partial class EditDeleteHotelDetails
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_pricepernight = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(91, 144);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(78, 188);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(48, 13);
            this.label_location.TabIndex = 1;
            this.label_location.Text = "Location";
            // 
            // label_pricepernight
            // 
            this.label_pricepernight.AutoSize = true;
            this.label_pricepernight.Location = new System.Drawing.Point(48, 232);
            this.label_pricepernight.Name = "label_pricepernight";
            this.label_pricepernight.Size = new System.Drawing.Size(78, 13);
            this.label_pricepernight.TabIndex = 2;
            this.label_pricepernight.Text = "Price Per Night";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(158, 141);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(130, 20);
            this.tb_name.TabIndex = 3;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(158, 188);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(130, 20);
            this.tb_location.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(158, 232);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(130, 20);
            this.tb_price.TabIndex = 5;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(81, 295);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(12, 392);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete Hotel";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(175, 295);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save Details";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(141, 81);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(53, 13);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Edit Hotel";
            // 
            // EditDeleteHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 427);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_pricepernight);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_name);
            this.Name = "EditDeleteHotel";
            this.Text = "BookHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_pricepernight;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_title;
    }
}