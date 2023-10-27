namespace Booking.com
{
    partial class ViewHotel
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
            text_name = new System.Windows.Forms.Label();
            label_location = new System.Windows.Forms.Label();
            text_location = new System.Windows.Forms.Label();
            label_price = new System.Windows.Forms.Label();
            text_pricepernight = new System.Windows.Forms.Label();
            label_id = new System.Windows.Forms.Label();
            text_id = new System.Windows.Forms.Label();
            button_close = new System.Windows.Forms.Button();
            label_floors = new System.Windows.Forms.Label();
            label_amenities = new System.Windows.Forms.Label();
            text_floors = new System.Windows.Forms.Label();
            text_amenities = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new System.Drawing.Point(81, 76);
            label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_name.Name = "label_name";
            label_name.Size = new System.Drawing.Size(42, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Name:";
            // 
            // text_name
            // 
            text_name.AutoSize = true;
            text_name.Location = new System.Drawing.Point(144, 76);
            text_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text_name.Name = "text_name";
            text_name.Size = new System.Drawing.Size(0, 15);
            text_name.TabIndex = 1;
            // 
            // label_location
            // 
            label_location.AutoSize = true;
            label_location.Location = new System.Drawing.Point(66, 115);
            label_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_location.Name = "label_location";
            label_location.Size = new System.Drawing.Size(56, 15);
            label_location.TabIndex = 2;
            label_location.Text = "Location:";
            // 
            // text_location
            // 
            text_location.AutoSize = true;
            text_location.Location = new System.Drawing.Point(144, 115);
            text_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text_location.Name = "text_location";
            text_location.Size = new System.Drawing.Size(0, 15);
            text_location.TabIndex = 3;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new System.Drawing.Point(31, 153);
            label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_price.Name = "label_price";
            label_price.Size = new System.Drawing.Size(89, 15);
            label_price.TabIndex = 4;
            label_price.Text = "Price Per Night:";
            // 
            // text_pricepernight
            // 
            text_pricepernight.AutoSize = true;
            text_pricepernight.Location = new System.Drawing.Point(144, 153);
            text_pricepernight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text_pricepernight.Name = "text_pricepernight";
            text_pricepernight.Size = new System.Drawing.Size(0, 15);
            text_pricepernight.TabIndex = 5;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new System.Drawing.Point(102, 267);
            label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_id.Name = "label_id";
            label_id.Size = new System.Drawing.Size(21, 15);
            label_id.TabIndex = 6;
            label_id.Text = "ID:";
            // 
            // text_id
            // 
            text_id.AutoSize = true;
            text_id.Location = new System.Drawing.Point(147, 267);
            text_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text_id.Name = "text_id";
            text_id.Size = new System.Drawing.Size(0, 15);
            text_id.TabIndex = 7;
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(112, 315);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(88, 27);
            button_close.TabIndex = 8;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // label_floors
            // 
            label_floors.AutoSize = true;
            label_floors.Location = new System.Drawing.Point(18, 192);
            label_floors.Name = "label_floors";
            label_floors.Size = new System.Drawing.Size(105, 15);
            label_floors.TabIndex = 9;
            label_floors.Text = "Number Of Floors:";
            // 
            // label_amenities
            // 
            label_amenities.AutoSize = true;
            label_amenities.Location = new System.Drawing.Point(60, 231);
            label_amenities.Name = "label_amenities";
            label_amenities.Size = new System.Drawing.Size(63, 15);
            label_amenities.TabIndex = 10;
            label_amenities.Text = "Amenities:";
            // 
            // text_floors
            // 
            text_floors.AutoSize = true;
            text_floors.Location = new System.Drawing.Point(144, 192);
            text_floors.Name = "text_floors";
            text_floors.Size = new System.Drawing.Size(0, 15);
            text_floors.TabIndex = 11;
            // 
            // text_amenities
            // 
            text_amenities.AutoSize = true;
            text_amenities.Location = new System.Drawing.Point(144, 231);
            text_amenities.Name = "text_amenities";
            text_amenities.Size = new System.Drawing.Size(0, 15);
            text_amenities.TabIndex = 12;
            // 
            // ViewHotel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1189, 771);
            Controls.Add(text_amenities);
            Controls.Add(text_floors);
            Controls.Add(label_amenities);
            Controls.Add(label_floors);
            Controls.Add(button_close);
            Controls.Add(text_id);
            Controls.Add(label_id);
            Controls.Add(text_pricepernight);
            Controls.Add(label_price);
            Controls.Add(text_location);
            Controls.Add(label_location);
            Controls.Add(text_name);
            Controls.Add(label_name);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ViewHotel";
            Text = "View Hotel Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label text_name;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label text_location;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label text_pricepernight;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label text_id;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_floors;
        private System.Windows.Forms.Label label_amenities;
        private System.Windows.Forms.Label text_floors;
        private System.Windows.Forms.Label text_amenities;
    }
}