using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_sales
{
    public partial class cardInfo : Form
    {
        private int amount;
        public cardInfo(int amountToPay)
        {
            InitializeComponent();
            amount = amountToPay;
            lblTotalAmount.Text = $"К оплате: {amount}$";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
        string.IsNullOrWhiteSpace(txtExpiry.Text) ||
        string.IsNullOrWhiteSpace(maskedTextBoxCVV.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Валидация формата
            if (!Regex.IsMatch(txtCardNumber.Text, @"^\d{4} \d{4} \d{4} \d{4}$"))
            {
                MessageBox.Show("Неверный формат номера карты. Пример: 1234 5678 9012 3456");
                return;
            }

            if (!Regex.IsMatch(txtExpiry.Text, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                MessageBox.Show("Неверный формат срока действия. Пример: 05/27");
                return;
            }

            if (!Regex.IsMatch(maskedTextBoxCVV.Text, @"^\d{3}$"))
            {
                MessageBox.Show("CVV код должен состоять из 3 цифр.");
                return;
            }
            MessageBox.Show("Оплата успешно завершена!\nСпасибо за покупку.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string digits = Regex.Replace(txtCardNumber.Text, @"[^\d]", "");
            if (digits.Length > 16)
                digits = digits.Substring(0, 16);

            txtCardNumber.Text = string.Join(" ", Regex.Matches(digits, @"\d{1,4}").Cast<Match>().Select(m => m.Value));
            txtCardNumber.SelectionStart = txtCardNumber.Text.Length;
        }

        private void txtExpiry_TextChanged(object sender, EventArgs e)
        {
            string digits = Regex.Replace(txtExpiry.Text, @"[^\d]", "");
            if (digits.Length > 4)
                digits = digits.Substring(0, 4);

            if (digits.Length >= 3)
                txtExpiry.Text = $"{digits.Substring(0, 2)}/{digits.Substring(2)}";
            else
                txtExpiry.Text = digits;

            txtExpiry.SelectionStart = txtExpiry.Text.Length;
        }
    }
}
