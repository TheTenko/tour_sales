namespace tour_sales
{
    partial class cardInfo
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
            button1 = new Button();
            lblTotalAmount = new Label();
            txtCardNumber = new TextBox();
            txtExpiry = new TextBox();
            maskedTextBoxCVV = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 16);
            label1.TabIndex = 0;
            label1.Text = "Оплата";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(77, 226);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 1;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(12, 165);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(95, 12);
            lblTotalAmount.TabIndex = 2;
            lblTotalAmount.Text = "К оплате:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(12, 44);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(260, 19);
            txtCardNumber.TabIndex = 3;
            txtCardNumber.Text = "Номер карты";
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(12, 98);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(144, 19);
            txtExpiry.TabIndex = 4;
            txtExpiry.Text = "Действует до";
            txtExpiry.TextChanged += txtExpiry_TextChanged;
            // 
            // maskedTextBoxCVV
            // 
            maskedTextBoxCVV.Location = new Point(172, 98);
            maskedTextBoxCVV.Mask = "000";
            maskedTextBoxCVV.Name = "maskedTextBoxCVV";
            maskedTextBoxCVV.Size = new Size(100, 19);
            maskedTextBoxCVV.TabIndex = 5;
            maskedTextBoxCVV.UseSystemPasswordChar = true;
            // 
            // cardInfo
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 261);
            Controls.Add(maskedTextBoxCVV);
            Controls.Add(txtExpiry);
            Controls.Add(txtCardNumber);
            Controls.Add(lblTotalAmount);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "cardInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cardInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label lblTotalAmount;
        private TextBox txtCardNumber;
        private TextBox txtExpiry;
        private MaskedTextBox maskedTextBoxCVV;
    }
}