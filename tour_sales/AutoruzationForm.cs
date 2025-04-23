using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;

namespace tour_sales
{
    public partial class AutoruzationForm : Form
    {
        public AutoruzationForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string login = login_textbox.Text; // Получаем логин из поля ввода
            string password = password_maskedTextBox.Text; // Получаем пароль из поля ввода

            bool isAuthenticated = UserManager.Authenticate(login, password);

            if (isAuthenticated)
            {
                // Загружаем всех пользователей из JSON
                string json = File.ReadAllText("users.json");
                var users = JsonSerializer.Deserialize<List<User>>(json);

                // Ищем текущего пользователя
                var currentUser = users.FirstOrDefault(u => u.Login == login);

                // Сохраняем в сессию
                Session.CurrentUser = currentUser;

                MessageBox.Show("Вход выполнен успешно!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void reg_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_maskedTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_maskedTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
