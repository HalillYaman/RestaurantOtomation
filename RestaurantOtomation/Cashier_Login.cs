using System;
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
    public partial class Cashier_Login : Form
    {
        public Cashier_Login()
        {
            InitializeComponent();
            for (int i = 0; i < 24; i++)
            {
                Button button = new Button();
                button.Text = "Masa"+" "+(i+1).ToString();
                button.Width = flowLayoutPanel1.Width*1/5;
                button.Height = flowLayoutPanel1.Height*1/7;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += new EventHandler(this.GreetingBtn_Click);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void Cashier_Login_Load(object sender, EventArgs e)
        {

        }
        void GreetingBtn_Click(Object sender, EventArgs e)
        {
            

        }
    }
}
