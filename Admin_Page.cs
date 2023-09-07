using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUMA_RESTAURANT
{
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Food f = new Food();
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = Screen.PrimaryScreen.Bounds.Width;
            int b = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(a, b);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Waiter w = new Waiter();
            w.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Purchase_details f = new Purchase_details();
            f.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int col1 = r.Next(0, 200);
            int col2 = r.Next(0, 200);
            int col3 = r.Next(0, 200);
            int col4 = r.Next(0, 200);

            label1.ForeColor = Color.FromArgb(col1, col2, col3, col4);
            OrderFood_details_button.ForeColor = Color.FromArgb(col1, col2, col3, col4);
            stock_Details_button.ForeColor = Color.FromArgb(col1, col2, col3, col4);
            Customer_Details_button.ForeColor = Color.FromArgb(col1, col2, col3, col4);
            Logout_button_adminpage.ForeColor = Color.FromArgb(col1, col2, col3, col4);
            purchase_details_button.ForeColor = Color.FromArgb(col1, col2, col3, col4);
            feedback_page_button.ForeColor = Color.FromArgb(col1, col2, col3, col4);

        }

        private void Btn_feedback_Click(object sender, EventArgs e)
        {
            Feedback_Page feedback = new Feedback_Page();
            this.Hide();
            feedback.Show();

            //Feedback_Page f1 = new Feedback_Page();
            //f1.Show();
            ////this.Hide();

        }
    }
}
