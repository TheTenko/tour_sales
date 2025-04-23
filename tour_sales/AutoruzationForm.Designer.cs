namespace tour_sales
{
    partial class AutoruzationForm
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
            label1 = new Label();
            label2 = new Label();
            password_maskedTextBox = new MaskedTextBox();
            login_textbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            reg_linklabel = new LinkLabel();
            enter_button = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(570, 24);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать на Toursales!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(46, 417);
            label2.Name = "label2";
            label2.Size = new Size(532, 15);
            label2.TabIndex = 1;
            label2.Text = "Для продолжения требуется авторизация";
            // 
            // password_maskedTextBox
            // 
            password_maskedTextBox.BackColor = SystemColors.AppWorkspace;
            password_maskedTextBox.Location = new Point(269, 193);
            password_maskedTextBox.Name = "password_maskedTextBox";
            password_maskedTextBox.PromptChar = '*';
            password_maskedTextBox.Size = new Size(173, 23);
            password_maskedTextBox.TabIndex = 2;
            password_maskedTextBox.UseSystemPasswordChar = true;
            // 
            // login_textbox
            // 
            login_textbox.BackColor = SystemColors.AppWorkspace;
            login_textbox.Location = new Point(269, 152);
            login_textbox.Name = "login_textbox";
            login_textbox.Size = new Size(173, 23);
            login_textbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(177, 156);
            label3.Name = "label3";
            label3.Size = new Size(72, 13);
            label3.TabIndex = 4;
            label3.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(177, 197);
            label4.Name = "label4";
            label4.Size = new Size(85, 13);
            label4.TabIndex = 5;
            label4.Text = "Пароль";
            // 
            // reg_linklabel
            // 
            reg_linklabel.AutoSize = true;
            reg_linklabel.LinkColor = Color.Cyan;
            reg_linklabel.Location = new Point(232, 273);
            reg_linklabel.Name = "reg_linklabel";
            reg_linklabel.Size = new Size(157, 15);
            reg_linklabel.TabIndex = 6;
            reg_linklabel.TabStop = true;
            reg_linklabel.Text = "Еще не зарегистрированы?";
            reg_linklabel.VisitedLinkColor = Color.Fuchsia;
            reg_linklabel.LinkClicked += reg_linklabel_LinkClicked;
            // 
            // enter_button
            // 
            enter_button.BackColor = SystemColors.AppWorkspace;
            enter_button.Location = new Point(177, 234);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(265, 23);
            enter_button.TabIndex = 7;
            enter_button.Text = "Войти";
            enter_button.UseVisualStyleBackColor = false;
            enter_button.Click += enter_button_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(454, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AutoruzationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(624, 441);
            Controls.Add(checkBox1);
            Controls.Add(enter_button);
            Controls.Add(reg_linklabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(login_textbox);
            Controls.Add(password_maskedTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AutoruzationForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox password_maskedTextBox;
        private TextBox login_textbox;
        private Label label3;
        private Label label4;
        private LinkLabel reg_linklabel;
        private Button enter_button;
        private CheckBox checkBox1;
    }
}
