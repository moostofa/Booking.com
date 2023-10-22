namespace Booking.com
{
    partial class ViewHotelDetails
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
            this.text_name = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.text_location = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.text_pricepernight = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(62, 66);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // text_name
            // 
            this.text_name.AutoSize = true;
            this.text_name.Location = new System.Drawing.Point(127, 66);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(0, 13);
            this.text_name.TabIndex = 1;
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(49, 100);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(48, 13);
            this.label_location.TabIndex = 2;
            this.label_location.Text = "Location";
            // 
            // text_location
            // 
            this.text_location.AutoSize = true;
            this.text_location.Location = new System.Drawing.Point(127, 100);
            this.text_location.Name = "text_location";
            this.text_location.Size = new System.Drawing.Size(0, 13);
            this.text_location.TabIndex = 3;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(19, 133);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(78, 13);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "Price Per Night";
            // 
            // text_pricepernight
            // 
            this.text_pricepernight.AutoSize = true;
            this.text_pricepernight.Location = new System.Drawing.Point(127, 133);
            this.text_pricepernight.Name = "text_pricepernight";
            this.text_pricepernight.Size = new System.Drawing.Size(0, 13);
            this.text_pricepernight.TabIndex = 5;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(79, 173);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "ID";
            // 
            // text_id
            // 
            this.text_id.AutoSize = true;
            this.text_id.Location = new System.Drawing.Point(127, 173);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(0, 13);
            this.text_id.TabIndex = 7;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(87, 224);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // ViewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 309);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.text_pricepernight);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.text_location);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label_name);
            this.Name = "ViewHotel";
            this.Text = "BookHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}