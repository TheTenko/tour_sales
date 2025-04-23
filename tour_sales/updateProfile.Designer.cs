namespace tour_sales
{
    partial class updateProfile
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRepeatPassword = new MaskedTextBox();
            txtEmail = new MaskedTextBox();
            txtLogin = new TextBox();
            button1 = new Button();
            label5 = new Label();
            txtNickname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(120, 20);
            label1.Name = "label1";
            label1.Size = new Size(353, 16);
            label1.TabIndex = 0;
            label1.Text = "Редактировать профиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(217, 12);
            label2.TabIndex = 1;
            label2.Text = "Введите новый логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 149);
            label3.Name = "label3";
            label3.Size = new Size(229, 12);
            label3.TabIndex = 2;
            label3.Text = "Введите новый пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 184);
            label4.Name = "label4";
            label4.Size = new Size(189, 12);
            label4.TabIndex = 3;
            label4.Text = "Повторите пароль";
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(272, 181);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(203, 19);
            txtRepeatPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(272, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 19);
            txtEmail.TabIndex = 5;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(272, 108);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(203, 19);
            txtLogin.TabIndex = 6;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(171, 221);
            button1.Name = "button1";
            button1.Size = new Size(248, 23);
            button1.TabIndex = 7;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 79);
            label5.Name = "label5";
            label5.Size = new Size(177, 12);
            label5.TabIndex = 8;
            label5.Text = "Задайте никнейм";
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(272, 76);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(203, 19);
            txtNickname.TabIndex = 9;
            // 
            // updateProfile
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(584, 288);
            Controls.Add(txtNickname);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtRepeatPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MS PGothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            Margin = new Padding(3, 2, 3, 2);
            Name = "updateProfile";
            Text = "updateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtRepeatPassword;
        private MaskedTextBox txtEmail;
        private TextBox txtLogin;
        private Button button1;
        private Label label5;
        private TextBox txtNickname;
    }
}