using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
//using TwitchLib.PubSub;
//using TwitchLib.PubSub.Events;
using TwitchLib.Communication.Events;
using System.Speech.Synthesis;

namespace twitchBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tlTip.SetToolTip(button_show_log, "Показать/скрыть логи");
            tlTip.SetToolTip(button_message_like_bot, "Отправить сообщение от имени бота");
            tlTip.SetToolTip(textBox_message_like_bot, "Отправить сообщение от имени бота");
            tlTip.SetToolTip(checkBox_allow_voice, "Включить озвучку сообщений");
            tlTip.SetToolTip(radioButton_all, "Озвучка всех сообщений");
            tlTip.SetToolTip(radioButton_say, "Озвучка сообщений с командой !say");
            tlTip.SetToolTip(button_open_settings, "Настройка приветственного сообщения и мат фильтра");
            tlTip.SetToolTip(button_stop_speech, "Остановить озвучку текущего сообщения");
            tlTip.SetToolTip(label2, "!commands - список команд" + Environment.NewLine + "!rules - список правил"
                + Environment.NewLine + "!iq - выводит iq зрителя" + Environment.NewLine + "!social - ссылки на соц. сети"
                + Environment.NewLine + "!joke - шутеечка" + Environment.NewLine + "!ball - магический шар");

            speech.SetOutputToDefaultAudioDevice();
            speech.Volume = Properties.Settings.Default.volume_value;
            trackBar_volume.Value = speech.Volume;
            label_speech_volume.Text = speech.Volume.ToString();

            if (Properties.Settings.Default.type_of_saying == "!say") radioButton_say.Checked = true;
            else radioButton_all.Checked = true;
        }

        public bool connection_status = false;
        public string form_size = "min";
        TwitchClient client = new TwitchClient();
        ToolTip tlTip = new ToolTip();
        public string[] jokesArray = new string[] {"Разыскивается кот Шредингера. Живым или мертвым!",
                  "На улице замерзли лужи и теперь можно похрустеть не только своими коленями!",
                  "Потекло говно по трубам - подумал Маугли, подсыпав слабительное мудрому Каа.",
                  "Я умею хранить секреты! А вот люди, которым я их рассказываю, не умеют!",
                  "Дятел - это не птица, а состояние души.",
                  "Фальшивого дрессировщика в цирке быстро раскусили.",
                  "Вращение Земли сделало мой день."};
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public string[] bad_words;
        public string sound_voice_status = "Озвучка сообщений выключена";


        private void button_connect_Click(object sender, EventArgs e)
        {
            if (connection_status == false)
            {
                Cursor.Current = Cursors.WaitCursor;

                client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(onMessageReceived);
                client.OnConnected += new EventHandler<OnConnectedArgs>(onConnected);
                client.OnNewSubscriber += new EventHandler<OnNewSubscriberArgs>(onNewSubscriber);
                client.Connect();
                textBox_output_info.AppendText("Connecting..." + Environment.NewLine);

                bad_words = new string[Properties.Settings.Default.bad_words.Count];
                Properties.Settings.Default.bad_words.CopyTo(bad_words, 0);

                Cursor.Current = Cursors.Default;
            }
            else MessageBox.Show("Подключение уже активно!");
        }

        private void onConnected(object sender, OnConnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox_output_info.AppendText("Connected!" + Environment.NewLine);
            connection_status = true;
            label_connection_status.Text = "connected";
            client.SendMessage(Properties.Settings.Default.channel, Properties.Settings.Default.hello_conn_msg);
        }

        private void onNewSubscriber(object sender, OnNewSubscriberArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox_output_info.AppendText("Ей, у тебя новый подписчик: " + e.Subscriber.DisplayName + Environment.NewLine);
            client.SendMessage(Properties.Settings.Default.channel, "Спасибо за подписку, " + e.Subscriber.DisplayName + "!");
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                Cursor.Current = Cursors.WaitCursor;

                textBox_output_info.AppendText(Environment.NewLine + "Disconnecting...");
                client.OnDisconnected += new EventHandler<OnDisconnectedEventArgs>(onDisconnected);
                client.Disconnect();

                client.OnDisconnected -= new EventHandler<OnDisconnectedEventArgs>(onDisconnected);

                Cursor.Current = Cursors.Default;
            }
            else MessageBox.Show("Подключение и так не активно");
        }

        private void onDisconnected(object sender, OnDisconnectedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox_output_info.AppendText(Environment.NewLine + "Disconnected!" + Environment.NewLine);
            connection_status = false;
            label_connection_status.Text = "disconnected";

            client.OnNewSubscriber -= new EventHandler<OnNewSubscriberArgs>(onNewSubscriber);
            client.OnMessageReceived -= new EventHandler<OnMessageReceivedArgs>(onMessageReceived);
            client.OnConnected -= new EventHandler<OnConnectedArgs>(onConnected);
        }

        //пригодится в процедуре ниже
        string phrase_to_sound;
        private void onMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox_output_info.AppendText(e.ChatMessage.Username + ": " + e.ChatMessage.Message + Environment.NewLine);

            //реакция на команды
            if (e.ChatMessage.Message.Substring(0,1) == "!")
            {
                if (e.ChatMessage.Message == "!iq") client.SendMessage(Properties.Settings.Default.channel, RollIQ(e.ChatMessage.Username));
                if (e.ChatMessage.Message == "!commands") client.SendMessage(Properties.Settings.Default.channel, "!rules, !social, !iq, !joke, !ball");
                if (e.ChatMessage.Message == "!команды") client.SendMessage(Properties.Settings.Default.channel, "!правила, !ссылки, !iq, !анекдот, !шар");
                if (e.ChatMessage.Message == "!rules" || e.ChatMessage.Message == "!правила") client.SendMessage(Properties.Settings.Default.channel, "Правила чата: без оскорблений и политоты.");
                if (e.ChatMessage.Message == "!social" || e.ChatMessage.Message == "!ссылки") client.SendMessage(Properties.Settings.Default.channel, socialLinks());
                if (e.ChatMessage.Message == "!joke" || e.ChatMessage.Message == "!анекдот") client.SendMessage(Properties.Settings.Default.channel, randomJoke(jokesArray));
                if (e.ChatMessage.Message.Contains("!шар") || e.ChatMessage.Message.Contains("!ball")) client.SendMessage(Properties.Settings.Default.channel, magicBall(e.ChatMessage.Username));

                if (e.ChatMessage.Message == "!озвучка") client.SendMessage(Properties.Settings.Default.channel, sound_voice_status);
            }

            if (checkBox_allow_voice.Checked)
            {
                try
                {
                    if (radioButton_say.Checked == true && e.ChatMessage.Message.Contains("!say"))
                    {
                        phrase_to_sound = e.ChatMessage.Message.Substring(4);
                        speech.Speak(phrase_to_sound);
                    }
                    if (radioButton_all.Checked == true)
                    {
                        /*phrase_to_sound = e.ChatMessage.Message;
                        speech.Speak(phrase_to_sound);*/
                        speech.Speak(e.ChatMessage.Message);
                    }
                }
                catch (InvalidCastException err)
                {
                    textBox_output_info.AppendText("Ошибка в озвучке текста: " + err.Message + Environment.NewLine);
                }
                catch (OperationCanceledException err)
                {
                    textBox_output_info.AppendText("Озвучка текста отменена:" + Environment.NewLine + err.Message + Environment.NewLine);
                }
            }
            
            

            //реакция на слова
            if (e.ChatMessage.Message.ToLower().Contains("привет")) client.SendMessage(Properties.Settings.Default.channel, "Привет, " + e.ChatMessage.Username + "!");
            if (e.ChatMessage.Message.ToLower().Contains("как дела")) client.SendMessage(e.ChatMessage.Channel, "Какие дела? CoolStoryBob");
            if (e.ChatMessage.Message.ToLower().Contains("я думаю")) client.SendMessage(e.ChatMessage.Channel, "А я не думаю OhMyDog");
            if (e.ChatMessage.Message.ToLower().Contains("почему")) client.SendMessage(e.ChatMessage.Channel, "патамушта Kappa");

            //реакция на плохие слова
            if (bad_words.Any(e.ChatMessage.Message.Contains)) client.TimeoutUser(e.ChatMessage.Channel, e.ChatMessage.Username, TimeSpan.FromMinutes(10), "Нецензурная брань");
            //client.SendMessage(Properties.Settings.Default.channel, "проверка мат фильтра");
        }

        static string RollIQ(string user)
        {
            Random rnd = new Random();
            int iq_int = rnd.Next(159) + 1;
            string iq_str = Convert.ToString(iq_int);
            string msg = user + ", ваш iq равен " + iq_str + ".";
            return msg;
        }

        static string randomJoke(string[] jokes)
        {
            Random rnd = new Random();
            int joke_number = rnd.Next(0, jokes.Length);
            string msg = jokes[joke_number];
            return msg;
        }

        static string magicBall(string user)
        {
            Random rnd = new Random();
            int ball_msg_number = rnd.Next(0, 3);
            string ball_msg = "";
            if (ball_msg_number == 0) ball_msg = "да.";
            if (ball_msg_number == 1) ball_msg = "нет.";
            if (ball_msg_number == 2) ball_msg = "скорее всего.";
            if (ball_msg_number == 3) ball_msg = "маловероятно.";
            string msg = user + ", " + ball_msg;
            return msg;
        }

        static string socialLinks()
        {
            string vk = Properties.Settings.Default.VK;
            string twi = Properties.Settings.Default.Twitter;
            string insta = Properties.Settings.Default.Instagram;
            string discord = Properties.Settings.Default.Discord;
            string msg = "";
            if (vk == "" &&  twi == "" && insta == "" && discord == "") msg = "Стример не сидит в соц. сетях :(";
            else
            {
                if (vk != "") msg += "VK: " + vk + "   ";
                if (twi != "") msg += "Twitter: " + twi + "   ";
                if (insta != "") msg += "Instagram: " + insta + "   ";
                if (discord != "") msg += "Discord: " + discord + "   ";
            }
            return msg;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection_status == true)
            {
                e.Cancel = true;
                MessageBox.Show("Закройте подключение!");
            }
            else
            {
                Properties.Settings.Default.volume_value = speech.Volume;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }


        private void button_show_log_Click(object sender, EventArgs e)
        {
            if (form_size == "min")
            {
                form_size = "max";
                button_show_log.Text = "<";
                Width += 231;
                Height += 90;
            }
            else
            {
                form_size = "min";
                button_show_log.Text = ">";
                Width -= 231;
                Height -= 90;
            }
        }

        private void button_message_like_bot_Click(object sender, EventArgs e)
        {
            if (client.IsConnected && textBox_message_like_bot.Text != "")
            {
                textBox_output_info.AppendText("Бот: " + textBox_message_like_bot.Text + Environment.NewLine);
                client.SendMessage(Properties.Settings.Default.channel, textBox_message_like_bot.Text);
                textBox_message_like_bot.Text = "";
            }
        }

        private void textBox_message_like_bot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_message_like_bot_Click(sender, e);
            }
        }

        private void button_open_settings_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                MessageBox.Show("Для начала закройте подключение!");
            }
            else
            {
                this.Enabled = false;
                Form_settings fs = new Form_settings();
                fs.Show(this);
            }
        }

        private void button_stop_speech_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }


        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            speech.Volume = trackBar_volume.Value;
            label_speech_volume.Text = speech.Volume.ToString();
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.type_of_saying = "all";
        }

        private void radioButton_say_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.type_of_saying = "!say";
        }

        private void checkBox_allow_voice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_allow_voice.Checked == true) sound_voice_status = "Озвучка сообщений включена";
            else sound_voice_status = "Озвучка сообщений выключена";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.first_start == 0)
            {
                this.Enabled = false;
                first_launch f1 = new first_launch();
                f1.ShowDialog(this);
                Properties.Settings.Default.bad_words = Properties.Settings.Default.bad_words_for_first_launch;
                Properties.Settings.Default.first_start = 1;
            }
            try
            {
                ConnectionCredentials cnntCrdnt = new ConnectionCredentials(Properties.Settings.Default.username, Properties.Settings.Default.oauth);
                client.Initialize(cnntCrdnt, Properties.Settings.Default.channel);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message);
            }
        }
    }
}
