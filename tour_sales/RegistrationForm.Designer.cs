namespace tour_sales
{
    partial class RegistrationForm
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
            label5 = new Label();
            password_maskedTextBox = new MaskedTextBox();
            repeatPassword_maskedTextBox = new MaskedTextBox();
            login_textBox = new TextBox();
            mail_textBox = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(154, 45);
            label1.Name = "label1";
            label1.Size = new Size(320, 27);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 9.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(151, 157);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 9.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(151, 186);
            label3.Name = "label3";
            label3.Size = new Size(72, 13);
            label3.TabIndex = 2;
            label3.Text = "Почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS PGothic", 9.75F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(138, 215);
            label4.Name = "label4";
            label4.Size = new Size(85, 13);
            label4.TabIndex = 3;
            label4.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS PGothic", 9.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(17, 244);
            label5.Name = "label5";
            label5.Size = new Size(206, 13);
            label5.TabIndex = 4;
            label5.Text = "Повторите пароль";
            // 
            // password_maskedTextBox
            // 
            password_maskedTextBox.BackColor = SystemColors.AppWorkspace;
            password_maskedTextBox.Location = new Point(229, 211);
            password_maskedTextBox.Name = "password_maskedTextBox";
            password_maskedTextBox.PromptChar = '*';
            password_maskedTextBox.Size = new Size(296, 23);
            password_maskedTextBox.TabIndex = 5;
            password_maskedTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPassword_maskedTextBox
            // 
            repeatPassword_maskedTextBox.BackColor = SystemColors.AppWorkspace;
            repeatPassword_maskedTextBox.Location = new Point(229, 240);
            repeatPassword_maskedTextBox.Name = "repeatPassword_maskedTextBox";
            repeatPassword_maskedTextBox.PromptChar = '*';
            repeatPassword_maskedTextBox.Size = new Size(296, 23);
            repeatPassword_maskedTextBox.TabIndex = 6;
            repeatPassword_maskedTextBox.UseSystemPasswordChar = true;
            // 
            // login_textBox
            // 
            login_textBox.BackColor = SystemColors.AppWorkspace;
            login_textBox.Location = new Point(229, 153);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(296, 23);
            login_textBox.TabIndex = 7;
            // 
            // mail_textBox
            // 
            mail_textBox.BackColor = SystemColors.AppWorkspace;
            mail_textBox.Location = new Point(229, 182);
            mail_textBox.Name = "mail_textBox";
            mail_textBox.Size = new Size(296, 23);
            mail_textBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(189, 323);
            button1.Name = "button1";
            button1.Size = new Size(242, 23);
            button1.TabIndex = 9;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(312, 269);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(624, 441);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(mail_textBox);
            Controls.Add(login_textBox);
            Controls.Add(repeatPassword_maskedTextBox);
            Controls.Add(password_maskedTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox password_maskedTextBox;
        private MaskedTextBox repeatPassword_maskedTextBox;
        private TextBox login_textBox;
        private TextBox mail_textBox;
        private Button button1;
        private CheckBox checkBox1;
    }
}