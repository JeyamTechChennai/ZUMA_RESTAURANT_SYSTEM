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
    public partial class Purchase_details : Form
    {
        public Purchase_details()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "******************************************\n";
            txtResult.Text += "**             Fees Receipts            **\n";
            txtResult.Text += "******************************************\n";
            txtResult.Text += "Date :"+ DateTime.Now+"\n\n";

            txtResult.Text += "Name: " + txtName.Text + "\n\n";
            txtResult.Text += "Email: " + txtEmail.Text + "\n\n";
            txtResult.Text += "Mobile Number: " + txtNumber.Text + "\n\n";
            txtResult.Text += "Batch Timing: " + txtBatch.Text + "\n\n";
            txtResult.Text += "Amount: " + txtAmount.Text + "\n\n";

            txtResult.Text += "\n                     Signature";


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text =  "";
            txtEmail.Text = "";
            txtNumber.Text = "";
            txtBatch.Text = "";
            txtAmount.Text = "";
            txtResult.Text = ""; 
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Bill_Receipts_Load(object sender, EventArgs e)
        {

        }

        private void Linklbl_dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Page d1 = new Admin_Page();
            d1.Show();
            this.Hide();
        }
    }
}
