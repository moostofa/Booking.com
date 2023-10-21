namespace Booking.com
{
    partial class ViewCustomer
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
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.text_name = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_bookings = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(75, 90);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(78, 123);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(72, 154);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(38, 13);
            this.label_phone.TabIndex = 2;
            this.label_phone.Text = "Phone";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(65, 186);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Address";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 186);
            this.listBox1.TabIndex = 4;
            // 
            // text_name
            // 
            this.text_name.AutoSize = true;
            this.text_name.Location = new System.Drawing.Point(180, 90);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(0, 13);
            this.text_name.TabIndex = 5;
            // 
            // text_email
            // 
            this.text_email.AutoSize = true;
            this.text_email.Location = new System.Drawing.Point(180, 123);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(0, 13);
            this.text_email.TabIndex = 6;
            // 
            // text_phone
            // 
            this.text_phone.AutoSize = true;
            this.text_phone.Location = new System.Drawing.Point(180, 154);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(0, 13);
            this.text_phone.TabIndex = 7;
            // 
            // text_address
            // 
            this.text_address.AutoSize = true;
            this.text_address.Location = new System.Drawing.Point(180, 186);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(0, 13);
            this.text_address.TabIndex = 8;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(109, 46);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(86, 13);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Customer Details";
            // 
            // label_bookings
            // 
            this.label_bookings.AutoSize = true;
            this.label_bookings.Location = new System.Drawing.Point(40, 255);
            this.label_bookings.Name = "label_bookings";
            this.label_bookings.Size = new System.Drawing.Size(54, 13);
            this.label_bookings.TabIndex = 10;
            this.label_bookings.Text = "Bookings:";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(112, 483);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 513);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_bookings);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Name = "ViewCustomer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label text_name;
        private System.Windows.Forms.Label text_email;
        private System.Windows.Forms.Label text_phone;
        private System.Windows.Forms.Label text_address;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_bookings;
        private System.Windows.Forms.Button button_close;
    }
}