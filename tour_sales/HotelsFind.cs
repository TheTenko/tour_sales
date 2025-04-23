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
    public partial class HotelsFind : Form
    {
        private bool businessRoom = false;
        private bool extraFood = false;
        public HotelsFind(List<Hotel> hotels)
        {
            InitializeComponent();

            listBox1.Items.Clear();
            foreach (var hotel in hotels)
                listBox1.Items.Add(hotel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Hotel selectedHotel)
            {
                int total = selectedHotel.Price;

                if (chkBusinessRoom.Checked)
                    total += 200;

                if (chkExtraFood.Checked)
                    total += 50;

                var paymentForm = new cardInfo(total);
                paymentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите отель для бронирования.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Hotel selectedHotel)
            {
                int total = selectedHotel.Price;


                lblCity.Text = $"Город: {selectedHotel.City}";
                lblHotelName.Text = $"Название: {selectedHotel.Name} ({selectedHotel.Type}, ★{selectedHotel.Stars})";
                lblNights.Text = $"Ночей: {selectedHotel.Nights}";
                
                if (extraFood && businessRoom) lblPrice.Text = $"Стоимость: {selectedHotel.Price + 250}$";
                else if (businessRoom) lblPrice.Text = $"Стоимость: {selectedHotel.Price + 200}$";
                else if (extraFood) lblPrice.Text = $"Стоимость: {selectedHotel.Price + 50}$";
                else lblPrice.Text = $"Стоимость: {selectedHotel.Price}$";
            }
        }

        private void chkBusinessRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBusinessRoom.Checked) businessRoom = true;
            else businessRoom = false;
        }

        private void chkExtraFood_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraFood.Checked) extraFood = true;
            else extraFood = false;
        }
    }
}
