namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNhapPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtHienThi = new TextBox();
            btnHienThi = new Button();
            btnTiep = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.Location = new Point(214, 69);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(230, 27);
            txtNhapPassword.TabIndex = 0;
            txtNhapPassword.TextChanged += txtNhapPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 68);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập password";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 149);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Hiễn thị";
            label2.Click += label2_Click;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(214, 147);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(230, 27);
            txtHienThi.TabIndex = 3;
            txtHienThi.TextChanged += txtHienThi_TextChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.BackColor = SystemColors.ActiveBorder;
            btnHienThi.Location = new Point(65, 237);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(91, 35);
            btnHienThi.TabIndex = 4;
            btnHienThi.Text = "Hiễn Thị";
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnTiep
            // 
            btnTiep.BackColor = SystemColors.ActiveBorder;
            btnTiep.Location = new Point(233, 237);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 35);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = false;
            btnTiep.Click += button2_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = SystemColors.ActiveBorder;
            btnDong.Location = new Point(410, 237);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 35);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 351);
            Controls.Add(btnDong);
            Controls.Add(btnTiep);
            Controls.Add(btnHienThi);
            Controls.Add(txtHienThi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNhapPassword);
            Name = "Form1";
            Text = "Sử Dụng Lable & Texbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhapPassword;
        private Label label1;
        private Label label2;
        private TextBox txtHienThi;
        private Button btnHienThi;
        private Button btnTiep;
        private Button btnDong;
    }
}
