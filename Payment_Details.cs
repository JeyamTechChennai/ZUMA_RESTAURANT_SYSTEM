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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_StockUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_id.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_name.Text;
                SqlParameter param3 = new SqlParameter("@food", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = comboBox_stock.Text;
                SqlParameter param4 = new SqlParameter("@food1", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = comboBox3.Text;
                SqlParameter param5 = new SqlParameter("@Payment_method", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = comboBox_stock1.Text;
                SqlParameter param6 = new SqlParameter("@total", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_total.Text;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_id.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_name.Text;
                SqlParameter param3 = new SqlParameter("@food", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = comboBox_stock.Text;
                SqlParameter param4 = new SqlParameter("@food1", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = comboBox3.Text;
                SqlParameter param5 = new SqlParameter("@PaymentMethod", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = comboBox_stock1.Text;
                SqlParameter param6 = new SqlParameter("@total", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_total.Text;
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
                SqlCommand cmd = new SqlCommand("sp_StockDelete", con);
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

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=Zuma_Restaurant;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Stockfetch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Page f1 = new Admin_Page();
            f1.Show();
            this.Hide();

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

