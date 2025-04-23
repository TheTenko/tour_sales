namespace tour_sales
{
    partial class HotelsFind
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
            button1 = new Button();
            lblPrice = new Label();
            lblNights = new Label();
            lblCity = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            chkBusinessRoom = new CheckBox();
            chkExtraFood = new CheckBox();
            lblHotelName = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(379, 234);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 15;
            button1.Text = "Забронировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPrice.ForeColor = SystemColors.Control;
            lblPrice.Location = new Point(292, 155);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(127, 13);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Стоимость:";
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNights.ForeColor = SystemColors.Control;
            lblNights.Location = new Point(292, 133);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(75, 13);
            lblNights.TabIndex = 13;
            lblNights.Text = "Ночей:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCity.ForeColor = SystemColors.Control;
            lblCity.Location = new Point(292, 85);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(72, 13);
            lblCity.TabIndex = 11;
            lblCity.Text = "Город";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(379, 58);
            label2.Name = "label2";
            label2.Size = new Size(193, 16);
            label2.TabIndex = 10;
            label2.Text = "Инфо об отеле";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(57, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 169);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(57, 51);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 8;
            label1.Text = "Наши отели";
            // 
            // chkBusinessRoom
            // 
            chkBusinessRoom.AutoSize = true;
            chkBusinessRoom.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkBusinessRoom.ForeColor = SystemColors.Control;
            chkBusinessRoom.Location = new Point(294, 192);
            chkBusinessRoom.Name = "chkBusinessRoom";
            chkBusinessRoom.Size = new Size(104, 17);
            chkBusinessRoom.TabIndex = 16;
            chkBusinessRoom.Text = "Бизнес";
            chkBusinessRoom.UseVisualStyleBackColor = true;
            chkBusinessRoom.CheckedChanged += chkBusinessRoom_CheckedChanged;
            // 
            // chkExtraFood
            // 
            chkExtraFood.AutoSize = true;
            chkExtraFood.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkExtraFood.ForeColor = SystemColors.Control;
            chkExtraFood.Location = new Point(404, 185);
            chkExtraFood.Name = "chkExtraFood";
            chkExtraFood.Size = new Size(208, 30);
            chkExtraFood.TabIndex = 17;
            chkExtraFood.Text = "Дополнительное\r\nпитание\r\n";
            chkExtraFood.UseVisualStyleBackColor = true;
            chkExtraFood.CheckedChanged += chkExtraFood_CheckedChanged;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHotelName.ForeColor = SystemColors.Control;
            lblHotelName.Location = new Point(292, 109);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(114, 13);
            lblHotelName.TabIndex = 18;
            lblHotelName.Text = "Название:";
            // 
            // HotelsFind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(624, 337);
            Controls.Add(lblHotelName);
            Controls.Add(chkExtraFood);
            Controls.Add(chkBusinessRoom);
            Controls.Add(button1);
            Controls.Add(lblPrice);
            Controls.Add(lblNights);
            Controls.Add(lblCity);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HotelsFind";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelsFind";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblPrice;
        private Label lblNights;
        private Label lblCity;
        private Label label2;
        private ListBox listBox1;
        private Label label1;
        private CheckBox chkBusinessRoom;
        private CheckBox chkExtraFood;
        private Label lblHotelName;
    }
}