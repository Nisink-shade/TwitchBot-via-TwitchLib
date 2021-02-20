namespace twitchBot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_connection_status = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_show_log = new System.Windows.Forms.Button();
            this.textBox_output_info = new System.Windows.Forms.TextBox();
            this.textBox_message_like_bot = new System.Windows.Forms.TextBox();
            this.button_message_like_bot = new System.Windows.Forms.Button();
            this.checkBox_allow_voice = new System.Windows.Forms.CheckBox();
            this.button_open_settings = new System.Windows.Forms.Button();
            this.button_stop_speech = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_speech_volume = new System.Windows.Forms.Label();
            this.groupBox_speech = new System.Windows.Forms.GroupBox();
            this.radioButton_say = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.groupBox_speech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список команд:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 85);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "!commands || !команды\r\n!rules || !правила\r\n!iq || !IQ\r\n!social || !ссылки\r\n!joke " +
    "|| !анекдот\r\n!ball || !шар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус подключения:";
            // 
            // label_connection_status
            // 
            this.label_connection_status.AutoSize = true;
            this.label_connection_status.Location = new System.Drawing.Point(129, 122);
            this.label_connection_status.Name = "label_connection_status";
            this.label_connection_status.Size = new System.Drawing.Size(71, 13);
            this.label_connection_status.TabIndex = 5;
            this.label_connection_status.Text = "disconnected";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(140, 25);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(132, 31);
            this.button_connect.TabIndex = 6;
            this.button_connect.Text = "Подключиться к twitch";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(140, 79);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(132, 31);
            this.button_disconnect.TabIndex = 7;
            this.button_disconnect.Text = "Отключиться";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_show_log
            // 
            this.button_show_log.Location = new System.Drawing.Point(242, 112);
            this.button_show_log.Name = "button_show_log";
            this.button_show_log.Size = new System.Drawing.Size(30, 23);
            this.button_show_log.TabIndex = 8;
            this.button_show_log.Text = ">";
            this.button_show_log.UseVisualStyleBackColor = true;
            this.button_show_log.Click += new System.EventHandler(this.button_show_log_Click);
            // 
            // textBox_output_info
            // 
            this.textBox_output_info.Location = new System.Drawing.Point(286, 6);
            this.textBox_output_info.Multiline = true;
            this.textBox_output_info.Name = "textBox_output_info";
            this.textBox_output_info.ReadOnly = true;
            this.textBox_output_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output_info.Size = new System.Drawing.Size(220, 193);
            this.textBox_output_info.TabIndex = 9;
            // 
            // textBox_message_like_bot
            // 
            this.textBox_message_like_bot.Location = new System.Drawing.Point(286, 207);
            this.textBox_message_like_bot.Name = "textBox_message_like_bot";
            this.textBox_message_like_bot.Size = new System.Drawing.Size(139, 20);
            this.textBox_message_like_bot.TabIndex = 10;
            this.textBox_message_like_bot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_message_like_bot_KeyDown);
            // 
            // button_message_like_bot
            // 
            this.button_message_like_bot.Location = new System.Drawing.Point(431, 205);
            this.button_message_like_bot.Name = "button_message_like_bot";
            this.button_message_like_bot.Size = new System.Drawing.Size(75, 23);
            this.button_message_like_bot.TabIndex = 11;
            this.button_message_like_bot.Text = "Отправить";
            this.button_message_like_bot.UseVisualStyleBackColor = true;
            this.button_message_like_bot.Click += new System.EventHandler(this.button_message_like_bot_Click);
            // 
            // checkBox_allow_voice
            // 
            this.checkBox_allow_voice.AutoSize = true;
            this.checkBox_allow_voice.Location = new System.Drawing.Point(12, 45);
            this.checkBox_allow_voice.Name = "checkBox_allow_voice";
            this.checkBox_allow_voice.Size = new System.Drawing.Size(68, 17);
            this.checkBox_allow_voice.TabIndex = 13;
            this.checkBox_allow_voice.Text = "Озвучка";
            this.checkBox_allow_voice.UseVisualStyleBackColor = true;
            this.checkBox_allow_voice.CheckedChanged += new System.EventHandler(this.checkBox_allow_voice_CheckedChanged);
            // 
            // button_open_settings
            // 
            this.button_open_settings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_open_settings.BackgroundImage = global::twitchBot.Properties.Resources.ios_8_Settings_icon_43812;
            this.button_open_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_open_settings.FlatAppearance.BorderSize = 0;
            this.button_open_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_settings.Location = new System.Drawing.Point(242, 197);
            this.button_open_settings.Name = "button_open_settings";
            this.button_open_settings.Size = new System.Drawing.Size(30, 30);
            this.button_open_settings.TabIndex = 14;
            this.button_open_settings.UseVisualStyleBackColor = false;
            this.button_open_settings.Click += new System.EventHandler(this.button_open_settings_Click);
            // 
            // button_stop_speech
            // 
            this.button_stop_speech.Location = new System.Drawing.Point(12, 16);
            this.button_stop_speech.Name = "button_stop_speech";
            this.button_stop_speech.Size = new System.Drawing.Size(75, 23);
            this.button_stop_speech.TabIndex = 15;
            this.button_stop_speech.Text = "Остановить";
            this.button_stop_speech.UseVisualStyleBackColor = true;
            this.button_stop_speech.Click += new System.EventHandler(this.button_stop_speech_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Volume:";
            // 
            // label_speech_volume
            // 
            this.label_speech_volume.AutoSize = true;
            this.label_speech_volume.Location = new System.Drawing.Point(130, 21);
            this.label_speech_volume.Name = "label_speech_volume";
            this.label_speech_volume.Size = new System.Drawing.Size(25, 13);
            this.label_speech_volume.TabIndex = 17;
            this.label_speech_volume.Text = "100";
            // 
            // groupBox_speech
            // 
            this.groupBox_speech.Controls.Add(this.radioButton_say);
            this.groupBox_speech.Controls.Add(this.radioButton_all);
            this.groupBox_speech.Controls.Add(this.trackBar_volume);
            this.groupBox_speech.Controls.Add(this.button_stop_speech);
            this.groupBox_speech.Controls.Add(this.checkBox_allow_voice);
            this.groupBox_speech.Controls.Add(this.label1);
            this.groupBox_speech.Controls.Add(this.label_speech_volume);
            this.groupBox_speech.Location = new System.Drawing.Point(2, 160);
            this.groupBox_speech.Name = "groupBox_speech";
            this.groupBox_speech.Size = new System.Drawing.Size(222, 68);
            this.groupBox_speech.TabIndex = 20;
            this.groupBox_speech.TabStop = false;
            this.groupBox_speech.Text = "Озвучка сообщений";
            // 
            // radioButton_say
            // 
            this.radioButton_say.AutoSize = true;
            this.radioButton_say.Location = new System.Drawing.Point(175, 44);
            this.radioButton_say.Name = "radioButton_say";
            this.radioButton_say.Size = new System.Drawing.Size(44, 17);
            this.radioButton_say.TabIndex = 23;
            this.radioButton_say.TabStop = true;
            this.radioButton_say.Text = "!say";
            this.radioButton_say.UseVisualStyleBackColor = true;
            this.radioButton_say.CheckedChanged += new System.EventHandler(this.radioButton_say_CheckedChanged);
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Location = new System.Drawing.Point(175, 19);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(35, 17);
            this.radioButton_all.TabIndex = 22;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "all";
            this.radioButton_all.UseVisualStyleBackColor = true;
            this.radioButton_all.CheckedChanged += new System.EventHandler(this.radioButton_all_CheckedChanged);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.AutoSize = false;
            this.trackBar_volume.Location = new System.Drawing.Point(86, 45);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(80, 20);
            this.trackBar_volume.TabIndex = 21;
            this.trackBar_volume.TabStop = false;
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_volume.Value = 100;
            this.trackBar_volume.ValueChanged += new System.EventHandler(this.trackBar_volume_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.groupBox_speech);
            this.Controls.Add(this.button_open_settings);
            this.Controls.Add(this.button_message_like_bot);
            this.Controls.Add(this.textBox_message_like_bot);
            this.Controls.Add(this.textBox_output_info);
            this.Controls.Add(this.button_show_log);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_connection_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(531, 270);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox_speech.ResumeLayout(false);
            this.groupBox_speech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_connection_status;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_show_log;
        private System.Windows.Forms.TextBox textBox_output_info;
        private System.Windows.Forms.TextBox textBox_message_like_bot;
        private System.Windows.Forms.Button button_message_like_bot;
        private System.Windows.Forms.CheckBox checkBox_allow_voice;
        private System.Windows.Forms.Button button_open_settings;
        private System.Windows.Forms.Button button_stop_speech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_speech_volume;
        private System.Windows.Forms.GroupBox groupBox_speech;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.RadioButton radioButton_say;
        private System.Windows.Forms.RadioButton radioButton_all;
    }
}

