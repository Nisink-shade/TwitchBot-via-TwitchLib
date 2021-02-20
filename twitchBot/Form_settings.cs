using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace twitchBot
{
    public partial class Form_settings : Form
    {
        public Form_settings()
        {
            InitializeComponent();
            tlTip.SetToolTip(label2, "За эти слова бот будет блокировать человеку доступ к чату на 10 минут");
            tlTip.SetToolTip(button_clear_all, "Для сброса используйте ПКМ");
        }

        public StringCollection bad_words = new StringCollection();
        ToolTip tlTip = new ToolTip();

        private void Form_settings_Load(object sender, EventArgs e)
        {
            label_save_confirmed.Visible = false;

            textBox_hello_msg.Text = Properties.Settings.Default.hello_conn_msg;

            if (Properties.Settings.Default.first_launch == 0)
            {
                Properties.Settings.Default.bad_words = Properties.Settings.Default.bad_words_for_first_launch;
                Properties.Settings.Default.first_launch = 1;
            }

            bad_words = Properties.Settings.Default.bad_words;

            foreach (string obj in bad_words)
            {
                textBox_list_of_bad_words.AppendText(obj + Environment.NewLine);
            }

            textBox_vk.Text = Properties.Settings.Default.VK;
            textBox_twitter.Text = Properties.Settings.Default.Twitter;
            textBox_instagram.Text = Properties.Settings.Default.Instagram;
            textBox_discord.Text = Properties.Settings.Default.Discord;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.hello_conn_msg = textBox_hello_msg.Text;

            textBox_list_of_bad_words.Text = Regex.Replace(textBox_list_of_bad_words.Text, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            Properties.Settings.Default.bad_words = GetLinesCollectionFromTextBox(textBox_list_of_bad_words);

            Properties.Settings.Default.VK = textBox_vk.Text.Replace(" ", "");
            Properties.Settings.Default.Twitter = textBox_twitter.Text.Replace(" ", "");
            Properties.Settings.Default.Instagram = textBox_instagram.Text.Replace(" ", "");
            Properties.Settings.Default.Discord = textBox_discord.Text.Replace(" ", "");

            Properties.Settings.Default.Save();
            label_blink_success();
        }


        StringCollection GetLinesCollectionFromTextBox(TextBox textBox)
        {
            string lastLine = textBox.Lines.Last();
            int lineCount;

            if (lastLine == "") lineCount = textBox.Lines.Count() - 1;
            else lineCount = textBox.Lines.Count();

            bad_words.Clear();
            for (int line = 0; line < lineCount; line++) bad_words.Add(textBox.Lines[line]);
            
            return bad_words;
        }

        private async void label_blink_success()
        {
            label_save_confirmed.Visible = true;
            await Task.Delay(1500);
            label_save_confirmed.Visible = false;
        }

        private void button_clear_all_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Properties.Settings.Default.Reset();
                Application.Restart();
            }
        }

        private void Form_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).Enabled = true;
        }
    }
}
