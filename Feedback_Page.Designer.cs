namespace ZUMA_RESTAURANT
{
    partial class Feedback_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_emailid = new System.Windows.Forms.TextBox();
            this.txt_feedback = new System.Windows.Forms.TextBox();
            this.comboBox_about = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.btn_showfeedback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.dataGridView_feedback = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your Name?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is your Email id?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "What is you Writng About?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type Your Feedback";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(284, 107);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(165, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_emailid
            // 
            this.txt_emailid.Location = new System.Drawing.Point(284, 160);
            this.txt_emailid.Name = "txt_emailid";
            this.txt_emailid.Size = new System.Drawing.Size(165, 20);
            this.txt_emailid.TabIndex = 5;
            // 
            // txt_feedback
            // 
            this.txt_feedback.Location = new System.Drawing.Point(284, 288);
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.Size = new System.Drawing.Size(165, 20);
            this.txt_feedback.TabIndex = 6;
            // 
            // comboBox_about
            // 
            this.comboBox_about.FormattingEnabled = true;
            this.comboBox_about.Items.AddRange(new object[] {
            "Exception Details Feedback",
            "Design Feedback"});
            this.comboBox_about.Location = new System.Drawing.Point(284, 217);
            this.comboBox_about.Name = "comboBox_about";
            this.comboBox_about.Size = new System.Drawing.Size(165, 21);
            this.comboBox_about.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(106, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Feedback Page";
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(22, 338);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(92, 31);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_showfeedback
            // 
            this.btn_showfeedback.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showfeedback.Location = new System.Drawing.Point(158, 337);
            this.btn_showfeedback.Name = "btn_showfeedback";
            this.btn_showfeedback.Size = new System.Drawing.Size(216, 31);
            this.btn_showfeedback.TabIndex = 10;
            this.btn_showfeedback.Text = "Show FeedBack";
            this.btn_showfeedback.UseVisualStyleBackColor = true;
            this.btn_showfeedback.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "What is your User id?";
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(284, 62);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(165, 20);
            this.txt_userid.TabIndex = 13;
            // 
            // dataGridView_feedback
            // 
            this.dataGridView_feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_feedback.Location = new System.Drawing.Point(12, 387);
            this.dataGridView_feedback.Name = "dataGridView_feedback";
            this.dataGridView_feedback.Size = new System.Drawing.Size(832, 150);
            this.dataGridView_feedback.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(427, 342);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 26);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Dashboard";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Feedback_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(907, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView_feedback);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_showfeedback);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_about);
            this.Controls.Add(this.txt_feedback);
            this.Controls.Add(this.txt_emailid);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Feedback_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Feedback_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_emailid;
        private System.Windows.Forms.TextBox txt_feedback;
        private System.Windows.Forms.ComboBox comboBox_about;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button btn_showfeedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.DataGridView dataGridView_feedback;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}