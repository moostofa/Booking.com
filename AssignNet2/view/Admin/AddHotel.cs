﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.com
{
    public partial class AddHotel : Form
    {
        Admin admin;
        public AddHotel(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        private void back()
        {
            this.Close();
            AdminView adminView = new AdminView(admin);
            adminView.Show();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string location = tb_location.Text;
            string price = tb_price.Text;
            string[] properties = new string[] { name, location, price };
            bool validForm = CheckForm.addEditHotel(properties);
            if (validForm)
            {
                HotelFileManager.addHotel(name, location, price);
                MessageBox.Show("Hotel Added Successfully");
                back();
            }
        }  

        private void tb_price_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            back();
        }


    }
}