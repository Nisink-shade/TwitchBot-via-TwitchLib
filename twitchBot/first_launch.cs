using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitchBot
{
    public partial class first_launch : Form
    {
        public first_launch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_user.Text == "" || textBox_bot_name.Text == "" || textBox_oauth.Text == "")
            {
                MessageBox.Show("Остались пустые поля!");
            }
            else
            {
                Properties.Settings.Default.channel = textBox_user.Text;
                Properties.Settings.Default.username = textBox_bot_name.Text;
                Properties.Settings.Default.oauth = textBox_oauth.Text;
                ((Form1)this.Owner).Enabled = true;
                this.Close();
            }
        }

        private void textBox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(sender, e);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Логин берётся из строки браузера twitch.tv/user, где user - ваш логин."
                 + Environment.NewLine + "Имя бота - никнейм аккаунта, который вы зарегестрировали для бота."
                 + Environment.NewLine + "oauth - токен авторизации бота, получить можно тут - https://twitchapps.com/tmi/."
                  + Environment.NewLine + "Если ввели неверные данные - откройте настройки и сделайте сброс.");
        }
    }
}
