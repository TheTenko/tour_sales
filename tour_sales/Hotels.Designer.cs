namespace tour_sales
{
    partial class Hotels
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
            label4 = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            findHotels_button = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(528, 107);
            label4.Name = "label4";
            label4.Size = new Size(141, 13);
            label4.TabIndex = 10;
            label4.Text = "Дата выезда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(320, 107);
            label3.Name = "label3";
            label3.Size = new Size(141, 13);
            label3.TabIndex = 9;
            label3.Text = "Дата заезда";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.AppWorkspace;
            txtCity.Location = new Point(58, 103);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(210, 23);
            txtCity.TabIndex = 11;
            txtCity.Text = "Город";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(164, 47);
            label2.Name = "label2";
            label2.Size = new Size(462, 19);
            label2.TabIndex = 13;
            label2.Text = "Лучшие отели только у нас!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 12;
            label1.Text = "Toursales";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(496, 134);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 15;
            // 
            // findHotels_button
            // 
            findHotels_button.BackColor = SystemColors.AppWorkspace;
            findHotels_button.Location = new Point(320, 203);
            findHotels_button.Name = "findHotels_button";
            findHotels_button.Size = new Size(137, 23);
            findHotels_button.TabIndex = 16;
            findHotels_button.Text = "Найти отели";
            findHotels_button.UseVisualStyleBackColor = false;
            findHotels_button.Click += findHotels_button_Click;
            // 
            // Hotels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(findHotels_button);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Hotels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotels";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox txtCity;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button findHotels_button;
    }
}