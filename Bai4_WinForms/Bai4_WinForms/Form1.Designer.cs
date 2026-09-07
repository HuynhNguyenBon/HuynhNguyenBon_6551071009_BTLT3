namespace Bai4_WinForms
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
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = SystemColors.ActiveBorder;
            btnClickMe.Dock = DockStyle.Fill;
            btnClickMe.FlatAppearance.BorderColor = Color.Cyan;
            btnClickMe.FlatAppearance.BorderSize = 2;
            btnClickMe.FlatStyle = FlatStyle.Flat;
            btnClickMe.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(0, 0);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(800, 450);
            btnClickMe.TabIndex = 1;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Simple Event Example";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
    }
}
