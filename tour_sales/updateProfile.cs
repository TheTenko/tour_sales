using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_sales
{
    public partial class updateProfile : Form
    {
        public updateProfile()
        {
            InitializeComponent();

            if (Session.CurrentUser != null)
            {
                txtLogin.Text = Session.CurrentUser.Login;
                txtRepeatPassword.Text = Session.CurrentUser.Password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newNickname = txtNickname.Text.Trim();
            string newLogin = txtLogin.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            string repeatPassword = txtRepeatPassword.Text.Trim();

            if (newPassword != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }
            if (newPassword == "" && repeatPassword != "")
            {
                MessageBox.Show("Вы не ввели новый пароль");
                return;
            }    
            if (newPassword == "")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            // Загружаем пользователей
            string json = File.ReadAllText("users.json");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var users = JsonSerializer.Deserialize<List<User>>(json, options);

            // Ищем текущего
            var user = users.FirstOrDefault(u => u.Login == Session.CurrentUser.Login);
            if (user != null)
            {
                user.Login = newLogin;
                user.Nickname = newNickname;
                user.Password = newPassword;

                Session.CurrentUser = user;

                string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("users.json", updatedJson);

                MessageBox.Show("Данные успешно обновлены!");

                Profile profile = new Profile();
                profile.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка: пользователь не найден.");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите выйти и не сохраниться?",
                "Выход",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Profile profile = new Profile();
                profile.Show();
                this.Hide();
            }
        }
    }
}
