namespace Bai3_WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHoTen = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.Blue;
            lblHoTen.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(-5, -3);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(628, 117);
            lblHoTen.TabIndex = 0;
            lblHoTen.UseVisualStyleBackColor = false;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(121, 120);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(400, 27);
            txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 192, 192);
            txtTen.Location = new Point(121, 170);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(400, 27);
            txtTen.TabIndex = 2;
            // 
            // btnHo
            // 
            btnHo.BackColor = SystemColors.ActiveBorder;
            btnHo.Location = new Point(72, 220);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(90, 40);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = false;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.BackColor = SystemColors.ActiveBorder;
            btnTen.Location = new Point(268, 220);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(90, 40);
            btnTen.TabIndex = 4;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = false;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.BackColor = SystemColors.ActiveBorder;
            btnHoTen.Location = new Point(437, 220);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(120, 40);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = false;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = SystemColors.ActiveBorder;
            btnKetThuc.Location = new Point(121, 292);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(400, 40);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 127);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Họ Lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 177);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 438);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHoTen);
            Controls.Add(txtHo);
            Controls.Add(txtTen);
            Controls.Add(btnHo);
            Controls.Add(btnTen);
            Controls.Add(btnHoTen);
            Controls.Add(btnKetThuc);
            Name = "Form1";
            Text = "Bài 3 - Nhap Ho Ten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lblHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label label1;
        private Label label2;
    }
}