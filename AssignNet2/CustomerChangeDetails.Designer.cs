namespace AssignNet2
{
    partial class CustomerChangeDetails
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_phonenumber = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label_errormessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(182, 109);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(216, 20);
            this.tb_email.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(182, 158);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(216, 20);
            this.tb_password.TabIndex = 1;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(182, 212);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(216, 20);
            this.tb_firstname.TabIndex = 2;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(182, 360);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(216, 20);
            this.tb_address.TabIndex = 5;
            // 
            // tb_phonenumber
            // 
            this.tb_phonenumber.Location = new System.Drawing.Point(182, 311);
            this.tb_phonenumber.Name = "tb_phonenumber";
            this.tb_phonenumber.Size = new System.Drawing.Size(216, 20);
            this.tb_phonenumber.TabIndex = 4;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(182, 262);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(216, 20);
            this.tb_lastname.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(101, 116);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 9;
            this.label_email.Text = "Email";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(80, 161);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(76, 212);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(57, 13);
            this.label_firstname.TabIndex = 11;
            this.label_firstname.Text = "First Name";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(75, 262);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(58, 13);
            this.label_lastname.TabIndex = 12;
            this.label_lastname.Text = "Last Name";
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Location = new System.Drawing.Point(55, 311);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(78, 13);
            this.label_phonenumber.TabIndex = 13;
            this.label_phonenumber.Text = "Phone Number";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(88, 363);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 14;
            this.label_address.Text = "Address";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(104, 429);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.cancel_click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(221, 429);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(110, 23);
            this.button_register.TabIndex = 20;
            this.button_register.Text = "Change Details";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.changedetails_click);
            // 
            // label_errormessage
            // 
            this.label_errormessage.AutoSize = true;
            this.label_errormessage.Location = new System.Drawing.Point(132, 61);
            this.label_errormessage.Name = "label_errormessage";
            this.label_errormessage.Size = new System.Drawing.Size(0, 13);
            this.label_errormessage.TabIndex = 21;
            // 
            // CustomerChangeDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 537);
            this.Controls.Add(this.label_errormessage);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_phonenumber);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_phonenumber);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Name = "CustomerChangeDetailsView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_phonenumber;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_phonenumber;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_errormessage;
    }
}