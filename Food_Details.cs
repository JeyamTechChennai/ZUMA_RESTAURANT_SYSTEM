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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fooddetails", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter param1 = new SqlParameter("@id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_id.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_name.Text;
                SqlParameter param3 = new SqlParameter("@food", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = comboBox_food.Text;
                SqlParameter param4 = new SqlParameter("@food1", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = comboBox_food1.Text;
                SqlParameter param5 = new SqlParameter("@price", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_price.Text;


                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Data inserted successfully");
                else
                    MessageBox.Show("Data cannot be inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_id.Text;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Data deleted successfully");
                else
                    MessageBox.Show("Data cannot be deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");


                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_id.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_name.Text;
                SqlParameter param3 = new SqlParameter("@food", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = comboBox_food.Text;
                SqlParameter param4 = new SqlParameter("@food1", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = comboBox_food1.Text;
                SqlParameter param5 = new SqlParameter("@price", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_price.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Data updated successfully");
                else
                    MessageBox.Show("Data cannot be updated");
                con.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");
            

                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[sp_fetch]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_food.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Page f = new Admin_Page();
            f.Show();
           this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    
        
            
    


