namespace tour_sales
{
    partial class Profile
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
            lblNickname = new Label();
            label2 = new Label();
            lblLogin = new Label();
            lblEmail = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Location = new Point(24, 84);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(95, 12);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "Ваше имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(82, 19);
            label2.Name = "label2";
            label2.Size = new Size(126, 16);
            label2.TabIndex = 1;
            label2.Text = "Профиль";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(12, 116);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(107, 12);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Ваш логин:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(52, 147);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 12);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Почта:";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(56, 226);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 4;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 261);
            Controls.Add(button1);
            Controls.Add(lblEmail);
            Controls.Add(lblLogin);
            Controls.Add(label2);
            Controls.Add(lblNickname);
            Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNickname;
        private Label label2;
        private Label lblLogin;
        private Label lblEmail;
        private Button button1;
    }
}