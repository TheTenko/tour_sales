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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = login_textBox.Text.Trim();
            string password = password_maskedTextBox.Text.Trim();
            string confirmPassword = repeatPassword_maskedTextBox.Text.Trim(); // Поле для повторного ввода пароля
            string mail = mail_textBox.Text.Trim();

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
        string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }

            // Проверка, что логин состоит только из букв
            if (!login.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Логин может содержать только буквы.");
                return;
            }

            // Проверка, что пароль состоит только из цифр
            if (!password.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Пароль может содержать только цифры.");
                return;
            }

            // Проверка, что пароли совпадают
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            User newUser = new User
            {
                Login = login_textBox.Text,
                Password = password_maskedTextBox.Text,
                Mail = mail_textBox.Text,
                Nickname = null
            };

            bool success = UserManager.RegisterUser(newUser);

            if (success)
            {
                MessageBox.Show("Регистрация прошла успешно!");
                AutoruzationForm autoruzationForm = new AutoruzationForm();
                autoruzationForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином или почтой уже существует.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_maskedTextBox.UseSystemPasswordChar = false;
                repeatPassword_maskedTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_maskedTextBox.UseSystemPasswordChar = true;
                repeatPassword_maskedTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
