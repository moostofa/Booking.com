namespace Booking.com
{
    partial class EditViewHotel
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
            this.lb_hotellist = new System.Windows.Forms.ListBox();
            this.button_view = new System.Windows.Forms.Button();
            this.button_editdetails = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_hotellist
            // 
            this.lb_hotellist.ColumnWidth = 2;
            this.lb_hotellist.FormattingEnabled = true;
            this.lb_hotellist.Location = new System.Drawing.Point(33, 74);
            this.lb_hotellist.Name = "lb_hotellist";
            this.lb_hotellist.Size = new System.Drawing.Size(200, 420);
            this.lb_hotellist.TabIndex = 0;
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(271, 74);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(75, 23);
            this.button_view.TabIndex = 1;
            this.button_view.Text = "View Details";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_editdetails
            // 
            this.button_editdetails.Location = new System.Drawing.Point(271, 103);
            this.button_editdetails.Name = "button_editdetails";
            this.button_editdetails.Size = new System.Drawing.Size(75, 23);
            this.button_editdetails.TabIndex = 2;
            this.button_editdetails.Text = "Edit Hotel";
            this.button_editdetails.UseVisualStyleBackColor = true;
            this.button_editdetails.Click += new System.EventHandler(this.button_editdetails_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(271, 471);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(33, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(37, 13);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Hotels";
            // 
            // EditHotelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 562);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_editdetails);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.lb_hotellist);
            this.Name = "EditHotelView";
            this.Text = "BookHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_hotellist;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_editdetails;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_title;
    }
}