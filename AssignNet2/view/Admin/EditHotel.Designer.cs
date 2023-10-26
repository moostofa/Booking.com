namespace Booking.com
{
    partial class EditHotel
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
            label_name = new System.Windows.Forms.Label();
            label_location = new System.Windows.Forms.Label();
            label_pricepernight = new System.Windows.Forms.Label();
            tb_name = new System.Windows.Forms.TextBox();
            tb_location = new System.Windows.Forms.TextBox();
            tb_price = new System.Windows.Forms.TextBox();
            button_back = new System.Windows.Forms.Button();
            button_delete = new System.Windows.Forms.Button();
            button_save = new System.Windows.Forms.Button();
            label_title = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new System.Drawing.Point(106, 166);
            label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_name.Name = "label_name";
            label_name.Size = new System.Drawing.Size(39, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Name";
            // 
            // label_location
            // 
            label_location.AutoSize = true;
            label_location.Location = new System.Drawing.Point(91, 217);
            label_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_location.Name = "label_location";
            label_location.Size = new System.Drawing.Size(53, 15);
            label_location.TabIndex = 1;
            label_location.Text = "Location";
            // 
            // label_pricepernight
            // 
            label_pricepernight.AutoSize = true;
            label_pricepernight.Location = new System.Drawing.Point(56, 268);
            label_pricepernight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_pricepernight.Name = "label_pricepernight";
            label_pricepernight.Size = new System.Drawing.Size(86, 15);
            label_pricepernight.TabIndex = 2;
            label_pricepernight.Text = "Price Per Night";
            // 
            // tb_name
            // 
            tb_name.Location = new System.Drawing.Point(184, 163);
            tb_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(151, 23);
            tb_name.TabIndex = 1;
            // 
            // tb_location
            // 
            tb_location.Location = new System.Drawing.Point(184, 217);
            tb_location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_location.Name = "tb_location";
            tb_location.Size = new System.Drawing.Size(151, 23);
            tb_location.TabIndex = 2;
            // 
            // tb_price
            // 
            tb_price.Location = new System.Drawing.Point(184, 268);
            tb_price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb_price.Name = "tb_price";
            tb_price.Size = new System.Drawing.Size(151, 23);
            tb_price.TabIndex = 3;
            // 
            // button_back
            // 
            button_back.Location = new System.Drawing.Point(94, 340);
            button_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_back.Name = "button_back";
            button_back.Size = new System.Drawing.Size(88, 27);
            button_back.TabIndex = 4;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new System.Drawing.Point(14, 452);
            button_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_delete.Name = "button_delete";
            button_delete.Size = new System.Drawing.Size(88, 27);
            button_delete.TabIndex = 6;
            button_delete.Text = "Delete Hotel";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_save
            // 
            button_save.Location = new System.Drawing.Point(204, 340);
            button_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_save.Name = "button_save";
            button_save.Size = new System.Drawing.Size(88, 27);
            button_save.TabIndex = 5;
            button_save.Text = "Save Details";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new System.Drawing.Point(164, 93);
            label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new System.Drawing.Size(59, 15);
            label_title.TabIndex = 9;
            label_title.Text = "Edit Hotel";
            // 
            // EditHotel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(411, 493);
            Controls.Add(label_title);
            Controls.Add(button_save);
            Controls.Add(button_delete);
            Controls.Add(button_back);
            Controls.Add(tb_price);
            Controls.Add(tb_location);
            Controls.Add(tb_name);
            Controls.Add(label_pricepernight);
            Controls.Add(label_location);
            Controls.Add(label_name);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditHotel";
            Text = "Edit Hotel Details";
            ResumeLayout(false);
            PerformLayout();
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