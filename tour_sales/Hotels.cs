using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_sales
{
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void findHotels_button_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();

            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Введите город для поиска.");
                return;
            }

            var hotels = HotelGenerator.Generate(city);
            var findForm = new HotelsFind(hotels);
            findForm.Show();
        }
    }
}
