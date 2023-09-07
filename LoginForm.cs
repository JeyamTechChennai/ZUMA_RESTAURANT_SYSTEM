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
    public partial class LoginForm : Form
    {
        private object value;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");
                if (txtName.Text != "" && txtpass.Text != "")
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter param1 = new SqlParameter("@Username", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = txtName.Text;
                    SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = txtpass.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    if (a > 0)
                    {
                        MessageBox.Show("InValid User");
                        
                    }
                    else
                    {
                        MessageBox.Show("Valid User");
                        Admin_Page crud = new Admin_Page();
                        crud.Show();
                        this.Hide();
                    }


                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RegisterForm obj = new RegisterForm();
        obj.Show();
        this.Hide();
          }   
        }
    }



    
    

