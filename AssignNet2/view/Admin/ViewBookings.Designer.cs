namespace Booking.com
{
    partial class ViewBookings
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
            dtg_bookings = new System.Windows.Forms.DataGridView();
            label_title = new System.Windows.Forms.Label();
            button_view = new System.Windows.Forms.Button();
            button_edit = new System.Windows.Forms.Button();
            button_logout = new System.Windows.Forms.Button();
            button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtg_bookings).BeginInit();
            SuspendLayout();
            // 
            // dtg_bookings
            // 
            dtg_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_bookings.Location = new System.Drawing.Point(26, 82);
            dtg_bookings.Name = "dtg_bookings";
            dtg_bookings.RowTemplate.Height = 25;
            dtg_bookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtg_bookings.Size = new System.Drawing.Size(521, 343);
            dtg_bookings.TabIndex = 0;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new System.Drawing.Point(26, 54);
            label_title.Name = "label_title";
            label_title.Size = new System.Drawing.Size(105, 15);
            label_title.TabIndex = 1;
            label_title.Text = "Current Bookings :";
            // 
            // button_view
            // 
            button_view.Location = new System.Drawing.Point(580, 82);
            button_view.Name = "button_view";
            button_view.Size = new System.Drawing.Size(112, 23);
            button_view.TabIndex = 1;
            button_view.Text = "View Booking";
            button_view.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            button_edit.Location = new System.Drawing.Point(580, 111);
            button_edit.Name = "button_edit";
            button_edit.Size = new System.Drawing.Size(112, 23);
            button_edit.TabIndex = 2;
            button_edit.Text = "Edit Booking";
            button_edit.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            button_logout.Location = new System.Drawing.Point(665, 12);
            button_logout.Name = "button_logout";
            button_logout.Size = new System.Drawing.Size(75, 23);
            button_logout.TabIndex = 4;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_back
            // 
            button_back.Location = new System.Drawing.Point(617, 402);
            button_back.Name = "button_back";
            button_back.Size = new System.Drawing.Size(75, 23);
            button_back.TabIndex = 3;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // ViewBookings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(752, 438);
            Controls.Add(button_back);
            Controls.Add(button_logout);
            Controls.Add(button_edit);
            Controls.Add(button_view);
            Controls.Add(label_title);
            Controls.Add(dtg_bookings);
            Name = "ViewBookings";
            Text = "View All Bookings";
            ((System.ComponentModel.ISupportInitialize)dtg_bookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_bookings;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_back;
    }
}