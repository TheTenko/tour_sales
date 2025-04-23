namespace tour_sales
{
    partial class MainForm
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
            comboBox1 = new ComboBox();
            otkuda_textBox = new TextBox();
            kuda_textBox = new TextBox();
            kogda_dateTimePicker1 = new DateTimePicker();
            obratno_dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            find_button = new Button();
            profile_button = new Button();
            social_linklabel = new LinkLabel();
            us_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 0;
            label1.Text = "Toursales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(209, 36);
            label2.Name = "label2";
            label2.Size = new Size(415, 19);
            label2.TabIndex = 1;
            label2.Text = "Самые дешевые туры тут!";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.AppWorkspace;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Авиаперелеты", "Ж/Д поездки", "Отели" });
            comboBox1.Location = new Point(209, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(415, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // otkuda_textBox
            // 
            otkuda_textBox.BackColor = SystemColors.AppWorkspace;
            otkuda_textBox.Location = new Point(90, 125);
            otkuda_textBox.Name = "otkuda_textBox";
            otkuda_textBox.Size = new Size(100, 23);
            otkuda_textBox.TabIndex = 3;
            otkuda_textBox.Text = "Откуда";
            // 
            // kuda_textBox
            // 
            kuda_textBox.BackColor = SystemColors.AppWorkspace;
            kuda_textBox.Location = new Point(196, 125);
            kuda_textBox.Name = "kuda_textBox";
            kuda_textBox.Size = new Size(100, 23);
            kuda_textBox.TabIndex = 4;
            kuda_textBox.Text = "Куда";
            // 
            // kogda_dateTimePicker1
            // 
            kogda_dateTimePicker1.Location = new Point(302, 151);
            kogda_dateTimePicker1.Name = "kogda_dateTimePicker1";
            kogda_dateTimePicker1.Size = new Size(200, 23);
            kogda_dateTimePicker1.TabIndex = 5;
            // 
            // obratno_dateTimePicker2
            // 
            obratno_dateTimePicker2.Location = new Point(508, 151);
            obratno_dateTimePicker2.Name = "obratno_dateTimePicker2";
            obratno_dateTimePicker2.Size = new Size(200, 23);
            obratno_dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(366, 129);
            label3.Name = "label3";
            label3.Size = new Size(72, 13);
            label3.TabIndex = 7;
            label3.Text = "Когда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(563, 129);
            label4.Name = "label4";
            label4.Size = new Size(98, 13);
            label4.TabIndex = 8;
            label4.Text = "Обратно";
            // 
            // find_button
            // 
            find_button.BackColor = SystemColors.AppWorkspace;
            find_button.Location = new Point(335, 202);
            find_button.Name = "find_button";
            find_button.Size = new Size(137, 23);
            find_button.TabIndex = 9;
            find_button.Text = "Найти туры";
            find_button.UseVisualStyleBackColor = false;
            find_button.Click += find_button_Click;
            // 
            // profile_button
            // 
            profile_button.BackColor = SystemColors.AppWorkspace;
            profile_button.Location = new Point(751, 12);
            profile_button.Name = "profile_button";
            profile_button.Size = new Size(75, 55);
            profile_button.TabIndex = 10;
            profile_button.Text = "Профиль";
            profile_button.UseVisualStyleBackColor = false;
            profile_button.Click += profile_button_Click;
            // 
            // social_linklabel
            // 
            social_linklabel.AutoSize = true;
            social_linklabel.LinkColor = Color.Cyan;
            social_linklabel.Location = new Point(736, 417);
            social_linklabel.Name = "social_linklabel";
            social_linklabel.Size = new Size(90, 15);
            social_linklabel.TabIndex = 11;
            social_linklabel.TabStop = true;
            social_linklabel.Text = "Мы в соцсетях!";
            social_linklabel.VisitedLinkColor = Color.Fuchsia;
            social_linklabel.LinkClicked += social_linklabel_LinkClicked;
            // 
            // us_button
            // 
            us_button.BackColor = SystemColors.AppWorkspace;
            us_button.Location = new Point(736, 391);
            us_button.Name = "us_button";
            us_button.Size = new Size(90, 23);
            us_button.TabIndex = 12;
            us_button.Text = "О нас";
            us_button.UseVisualStyleBackColor = false;
            us_button.Click += us_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(838, 441);
            Controls.Add(us_button);
            Controls.Add(social_linklabel);
            Controls.Add(profile_button);
            Controls.Add(find_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(obratno_dateTimePicker2);
            Controls.Add(kogda_dateTimePicker1);
            Controls.Add(kuda_textBox);
            Controls.Add(otkuda_textBox);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox otkuda_textBox;
        private TextBox kuda_textBox;
        private DateTimePicker kogda_dateTimePicker1;
        private DateTimePicker obratno_dateTimePicker2;
        private Label label3;
        private Label label4;
        private Button find_button;
        private Button profile_button;
        private LinkLabel social_linklabel;
        private Button us_button;
    }
}