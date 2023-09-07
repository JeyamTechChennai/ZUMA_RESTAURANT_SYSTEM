using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUMA_RESTAURANT
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_reg_user", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_id.Text;
                SqlParameter param2 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_name.Text;
                SqlParameter param4 = new SqlParameter("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_pass.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registered successfully");
                    LoginForm l = new LoginForm();
                    l.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Registration Failed");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txtpass_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
        }
    }
}

