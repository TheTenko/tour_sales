namespace tour_sales
{
    partial class us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us));
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 0;
            label1.Text = "О нас";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(506, 143);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // us
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(553, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            Margin = new Padding(3, 2, 3, 2);
            Name = "us";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "us";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}