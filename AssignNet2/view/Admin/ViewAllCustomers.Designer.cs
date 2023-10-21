namespace Booking.com
{
    partial class ViewAllCustomers
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
            this.label_title = new System.Windows.Forms.Label();
            this.lb_customers = new System.Windows.Forms.ListBox();
            this.button_viewdetails = new System.Windows.Forms.Button();
            this.button_editdeletecustomer = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(125, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(96, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "View All Customers";
            // 
            // lb_customers
            // 
            this.lb_customers.FormattingEnabled = true;
            this.lb_customers.Location = new System.Drawing.Point(55, 54);
            this.lb_customers.Name = "lb_customers";
            this.lb_customers.Size = new System.Drawing.Size(252, 316);
            this.lb_customers.TabIndex = 1;
            // 
            // button_viewdetails
            // 
            this.button_viewdetails.Location = new System.Drawing.Point(354, 54);
            this.button_viewdetails.Name = "button_viewdetails";
            this.button_viewdetails.Size = new System.Drawing.Size(128, 23);
            this.button_viewdetails.TabIndex = 2;
            this.button_viewdetails.Text = "View Details";
            this.button_viewdetails.UseVisualStyleBackColor = true;
            this.button_viewdetails.Click += new System.EventHandler(this.button_viewdetails_Click);
            // 
            // button_editdeletecustomer
            // 
            this.button_editdeletecustomer.Location = new System.Drawing.Point(354, 92);
            this.button_editdeletecustomer.Name = "button_editdeletecustomer";
            this.button_editdeletecustomer.Size = new System.Drawing.Size(128, 23);
            this.button_editdeletecustomer.TabIndex = 3;
            this.button_editdeletecustomer.Text = "Edit/Delete Customer";
            this.button_editdeletecustomer.UseVisualStyleBackColor = true;
            this.button_editdeletecustomer.Click += new System.EventHandler(this.button_editdeletecustomer_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(354, 347);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(128, 23);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // ViewAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 397);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_editdeletecustomer);
            this.Controls.Add(this.button_viewdetails);
            this.Controls.Add(this.lb_customers);
            this.Controls.Add(this.label_title);
            this.Name = "ViewAllCustomers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ListBox lb_customers;
        private System.Windows.Forms.Button button_viewdetails;
        private System.Windows.Forms.Button button_editdeletecustomer;
        private System.Windows.Forms.Button button_close;
    }
}