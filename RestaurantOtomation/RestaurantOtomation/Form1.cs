﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Waiters_login form2 = new Waiters_login();
            form2.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier_Login am = new Cashier_Login();
            am.Show();  // form2 göster diyoruz
            this.Hide();
        }
    }
}
