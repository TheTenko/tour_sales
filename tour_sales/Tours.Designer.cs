namespace tour_sales
{
    partial class Tours
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
            listBox1 = new ListBox();
            label2 = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            lblDays = new Label();
            lblPrice = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(218, 24);
            label1.TabIndex = 0;
            label1.Text = "Наши туры";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 169);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(365, 79);
            label2.Name = "label2";
            label2.Size = new Size(161, 16);
            label2.TabIndex = 2;
            label2.Text = "Инфо о туре";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFrom.ForeColor = SystemColors.Control;
            lblFrom.Location = new Point(303, 104);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(88, 13);
            lblFrom.TabIndex = 3;
            lblFrom.Text = "Откуда:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTo.ForeColor = SystemColors.Control;
            lblTo.Location = new Point(303, 135);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(62, 13);
            lblTo.TabIndex = 4;
            lblTo.Text = "Куда:";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDays.ForeColor = SystemColors.Control;
            lblDays.Location = new Point(303, 167);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(138, 13);
            lblDays.TabIndex = 5;
            lblDays.Text = "Кол-во дней:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPrice.ForeColor = SystemColors.Control;
            lblPrice.Location = new Point(303, 225);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(127, 13);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Стоимость:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(365, 283);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 7;
            button1.Text = "Забронировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(303, 195);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 17);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Бизнес";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Tours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(624, 337);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(lblPrice);
            Controls.Add(lblDays);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Tours";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tours";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label lblFrom;
        private Label lblTo;
        private Label lblDays;
        private Label lblPrice;
        private Button button1;
        private CheckBox checkBox1;
    }
}