using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_sales
{
    public partial class Tours : Form
    {
        private bool business = false;
        public Tours(List<Tour> tours)
        {
            InitializeComponent();

            // Очистка и заполнение ListBox
            listBox1.Items.Clear();
            foreach (var tour in tours)
            {
                listBox1.Items.Add(tour);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Tour selectedTour)
            {
                lblFrom.Text = "Откуда: " + selectedTour.From;
                lblTo.Text = "Куда: " + selectedTour.To;

                int days = (selectedTour.EndDate - selectedTour.StartDate).Days;
                lblDays.Text = $"Кол-во дней: {days} дней";

                if (business)
                {
                    lblPrice.Text = $"Стоимость: {selectedTour.Price + 500}$";
                }
                else
                {
                    lblPrice.Text = $"Стоимость: {selectedTour.Price}$";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) business = true;
            else business = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Tour selectedTour)
            {
                int finalPrice = selectedTour.Price;

                if (checkBox1.Checked) finalPrice += 500;

                DialogResult result = MessageBox.Show("Сейчас вы попадете на форму оплаты\nНажмите Да, если согласны",
                "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cardInfo cardInfo = new cardInfo(finalPrice);
                    cardInfo.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тур.");
            }
        }
    }
}
