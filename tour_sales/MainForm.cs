using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tour_sales
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Закрытие формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                Hotels hotels = new Hotels();
                hotels.Show();
                this.Hide();
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            string from = otkuda_textBox.Text.Trim();
            string kuda = kuda_textBox.Text.Trim();
            DateTime start = kogda_dateTimePicker1.Value.Date;
            DateTime end = obratno_dateTimePicker2.Value.Date;

            var tours = TourGenerator.Generate(from, kuda, start, end);

            if (tours.Any())
            {
                var toursForm = new Tours(tours);
                toursForm.Show(); // или ShowDialog(), если хочешь модальное окно
            }
            else
            {
                MessageBox.Show("Нет подходящих туров.");
            }
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void us_button_Click(object sender, EventArgs e)
        {
            us us = new us();
            us.ShowDialog();
        }

        private void social_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://t.me/akutenkoo";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
