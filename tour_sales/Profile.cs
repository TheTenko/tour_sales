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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            if (Session.CurrentUser != null)
            {
                lblLogin.Text = $"Ваш логин: {Session.CurrentUser.Login}";
                lblEmail.Text = $"Почта: {Session.CurrentUser.Mail}";
                lblNickname.Text = $"Ваше имя: {Session.CurrentUser.Nickname}";
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateProfile updateProfile = new updateProfile();
            updateProfile.Show();
            this.Hide();
        }
    }
}
