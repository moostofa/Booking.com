namespace Booking.com
{
    partial class Register
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
            this.tb_streetaddress = new System.Windows.Forms.TextBox();
            this.tb_phonenumber = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.label_streetaddress = new System.Windows.Forms.Label();
            this.tb_suburb = new System.Windows.Forms.TextBox();
            this.label_suburb = new System.Windows.Forms.Label();
            this.tb_postcode = new System.Windows.Forms.TextBox();
            this.label_postcode = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.ComboBox();
            this.label_state = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_errormessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(180, 161);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(231, 20);
            this.tb_email.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(180, 209);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(231, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(180, 264);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(231, 20);
            this.tb_firstname.TabIndex = 2;
            // 
            // tb_streetaddress
            // 
            this.tb_streetaddress.Location = new System.Drawing.Point(180, 420);
            this.tb_streetaddress.Name = "tb_streetaddress";
            this.tb_streetaddress.Size = new System.Drawing.Size(231, 20);
            this.tb_streetaddress.TabIndex = 5;
            // 
            // tb_phonenumber
            // 
            this.tb_phonenumber.Location = new System.Drawing.Point(180, 368);
            this.tb_phonenumber.Name = "tb_phonenumber";
            this.tb_phonenumber.Size = new System.Drawing.Size(231, 20);
            this.tb_phonenumber.TabIndex = 4;
            this.tb_phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_keypress);
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(180, 314);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(231, 20);
            this.tb_lastname.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(112, 164);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(91, 216);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(87, 264);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(57, 13);
            this.label_firstname.TabIndex = 8;
            this.label_firstname.Text = "First Name";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(86, 314);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(58, 13);
            this.label_lastname.TabIndex = 9;
            this.label_lastname.Text = "Last Name";
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Location = new System.Drawing.Point(66, 368);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(78, 13);
            this.label_phonenumber.TabIndex = 10;
            this.label_phonenumber.Text = "Phone Number";
            // 
            // label_streetaddress
            // 
            this.label_streetaddress.AutoSize = true;
            this.label_streetaddress.Location = new System.Drawing.Point(68, 423);
            this.label_streetaddress.Name = "label_streetaddress";
            this.label_streetaddress.Size = new System.Drawing.Size(76, 13);
            this.label_streetaddress.TabIndex = 11;
            this.label_streetaddress.Text = "Street Address";
            // 
            // tb_suburb
            // 
            this.tb_suburb.Location = new System.Drawing.Point(180, 476);
            this.tb_suburb.Name = "tb_suburb";
            this.tb_suburb.Size = new System.Drawing.Size(231, 20);
            this.tb_suburb.TabIndex = 12;
            // 
            // label_suburb
            // 
            this.label_suburb.AutoSize = true;
            this.label_suburb.Location = new System.Drawing.Point(103, 476);
            this.label_suburb.Name = "label_suburb";
            this.label_suburb.Size = new System.Drawing.Size(41, 13);
            this.label_suburb.TabIndex = 13;
            this.label_suburb.Text = "Suburb";
            // 
            // tb_postcode
            // 
            this.tb_postcode.Location = new System.Drawing.Point(180, 523);
            this.tb_postcode.Name = "tb_postcode";
            this.tb_postcode.Size = new System.Drawing.Size(121, 20);
            this.tb_postcode.TabIndex = 14;
            this.tb_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postcode_keypress);
            // 
            // label_postcode
            // 
            this.label_postcode.AutoSize = true;
            this.label_postcode.Location = new System.Drawing.Point(92, 523);
            this.label_postcode.Name = "label_postcode";
            this.label_postcode.Size = new System.Drawing.Size(52, 13);
            this.label_postcode.TabIndex = 15;
            this.label_postcode.Text = "Postcode";
            // 
            // cb_state
            // 
            this.cb_state.FormattingEnabled = true;
            this.cb_state.Location = new System.Drawing.Point(180, 574);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(121, 21);
            this.cb_state.TabIndex = 16;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(112, 574);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(32, 13);
            this.label_state.TabIndex = 17;
            this.label_state.Text = "State";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(272, 668);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 18;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.register_click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(161, 668);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.cancel_click);
            // 
            // label_errormessage
            // 
            this.label_errormessage.AutoSize = true;
            this.label_errormessage.Location = new System.Drawing.Point(144, 119);
            this.label_errormessage.Name = "label_errormessage";
            this.label_errormessage.Size = new System.Drawing.Size(0, 13);
            this.label_errormessage.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 763);
            this.Controls.Add(this.label_errormessage);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.cb_state);
            this.Controls.Add(this.label_postcode);
            this.Controls.Add(this.tb_postcode);
            this.Controls.Add(this.label_suburb);
            this.Controls.Add(this.tb_suburb);
            this.Controls.Add(this.label_streetaddress);
            this.Controls.Add(this.label_phonenumber);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tb_streetaddress);
            this.Controls.Add(this.tb_phonenumber);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_streetaddress;
        private System.Windows.Forms.TextBox tb_phonenumber;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_phonenumber;
        private System.Windows.Forms.Label label_streetaddress;
        private System.Windows.Forms.TextBox tb_suburb;
        private System.Windows.Forms.Label label_suburb;
        private System.Windows.Forms.TextBox tb_postcode;
        private System.Windows.Forms.Label label_postcode;
        private System.Windows.Forms.ComboBox cb_state;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_errormessage;
    }
}