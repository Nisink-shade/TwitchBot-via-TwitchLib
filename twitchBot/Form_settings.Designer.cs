
namespace twitchBot
{
    partial class Form_settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_hello_msg = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label_save_confirmed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_list_of_bad_words = new System.Windows.Forms.TextBox();
            this.button_clear_all = new System.Windows.Forms.Button();
            this.label_social = new System.Windows.Forms.Label();
            this.label_vk = new System.Windows.Forms.Label();
            this.label_twitter = new System.Windows.Forms.Label();
            this.label_insta = new System.Windows.Forms.Label();
            this.label_discord = new System.Windows.Forms.Label();
            this.textBox_vk = new System.Windows.Forms.TextBox();
            this.textBox_twitter = new System.Windows.Forms.TextBox();
            this.textBox_instagram = new System.Windows.Forms.TextBox();
            this.textBox_discord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приветственное сообщение\r\nпри включении бота:";
            // 
            // textBox_hello_msg
            // 
            this.textBox_hello_msg.Location = new System.Drawing.Point(12, 38);
            this.textBox_hello_msg.Name = "textBox_hello_msg";
            this.textBox_hello_msg.Size = new System.Drawing.Size(148, 20);
            this.textBox_hello_msg.TabIndex = 1;
            this.textBox_hello_msg.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(185, 183);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 37);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Сохранить изменения";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_save_confirmed
            // 
            this.label_save_confirmed.AutoSize = true;
            this.label_save_confirmed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_save_confirmed.Location = new System.Drawing.Point(182, 167);
            this.label_save_confirmed.Name = "label_save_confirmed";
            this.label_save_confirmed.Size = new System.Drawing.Size(126, 13);
            this.label_save_confirmed.TabIndex = 3;
            this.label_save_confirmed.Text = "Изменения сохранены!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список запрещённых слов:";
            // 
            // textBox_list_of_bad_words
            // 
            this.textBox_list_of_bad_words.Location = new System.Drawing.Point(12, 88);
            this.textBox_list_of_bad_words.Multiline = true;
            this.textBox_list_of_bad_words.Name = "textBox_list_of_bad_words";
            this.textBox_list_of_bad_words.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_list_of_bad_words.Size = new System.Drawing.Size(148, 132);
            this.textBox_list_of_bad_words.TabIndex = 5;
            // 
            // button_clear_all
            // 
            this.button_clear_all.Location = new System.Drawing.Point(303, 183);
            this.button_clear_all.Name = "button_clear_all";
            this.button_clear_all.Size = new System.Drawing.Size(94, 37);
            this.button_clear_all.TabIndex = 6;
            this.button_clear_all.Text = "Сброс настроек";
            this.button_clear_all.UseVisualStyleBackColor = true;
            this.button_clear_all.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_clear_all_MouseUp);
            // 
            // label_social
            // 
            this.label_social.AutoSize = true;
            this.label_social.Location = new System.Drawing.Point(182, 9);
            this.label_social.Name = "label_social";
            this.label_social.Size = new System.Drawing.Size(114, 13);
            this.label_social.TabIndex = 7;
            this.label_social.Text = "Ссылки на соц. сети:";
            // 
            // label_vk
            // 
            this.label_vk.AutoSize = true;
            this.label_vk.Location = new System.Drawing.Point(182, 41);
            this.label_vk.Name = "label_vk";
            this.label_vk.Size = new System.Drawing.Size(24, 13);
            this.label_vk.TabIndex = 8;
            this.label_vk.Text = "VK:";
            // 
            // label_twitter
            // 
            this.label_twitter.AutoSize = true;
            this.label_twitter.Location = new System.Drawing.Point(182, 72);
            this.label_twitter.Name = "label_twitter";
            this.label_twitter.Size = new System.Drawing.Size(42, 13);
            this.label_twitter.TabIndex = 9;
            this.label_twitter.Text = "Twitter:";
            // 
            // label_insta
            // 
            this.label_insta.AutoSize = true;
            this.label_insta.Location = new System.Drawing.Point(182, 104);
            this.label_insta.Name = "label_insta";
            this.label_insta.Size = new System.Drawing.Size(56, 13);
            this.label_insta.TabIndex = 10;
            this.label_insta.Text = "Instagram:";
            // 
            // label_discord
            // 
            this.label_discord.AutoSize = true;
            this.label_discord.Location = new System.Drawing.Point(182, 138);
            this.label_discord.Name = "label_discord";
            this.label_discord.Size = new System.Drawing.Size(46, 13);
            this.label_discord.TabIndex = 11;
            this.label_discord.Text = "Discord:";
            // 
            // textBox_vk
            // 
            this.textBox_vk.Location = new System.Drawing.Point(244, 38);
            this.textBox_vk.Name = "textBox_vk";
            this.textBox_vk.Size = new System.Drawing.Size(153, 20);
            this.textBox_vk.TabIndex = 12;
            // 
            // textBox_twitter
            // 
            this.textBox_twitter.Location = new System.Drawing.Point(244, 69);
            this.textBox_twitter.Name = "textBox_twitter";
            this.textBox_twitter.Size = new System.Drawing.Size(153, 20);
            this.textBox_twitter.TabIndex = 13;
            // 
            // textBox_instagram
            // 
            this.textBox_instagram.Location = new System.Drawing.Point(244, 101);
            this.textBox_instagram.Name = "textBox_instagram";
            this.textBox_instagram.Size = new System.Drawing.Size(153, 20);
            this.textBox_instagram.TabIndex = 14;
            // 
            // textBox_discord
            // 
            this.textBox_discord.Location = new System.Drawing.Point(244, 135);
            this.textBox_discord.Name = "textBox_discord";
            this.textBox_discord.Size = new System.Drawing.Size(153, 20);
            this.textBox_discord.TabIndex = 15;
            // 
            // Form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 226);
            this.Controls.Add(this.textBox_discord);
            this.Controls.Add(this.textBox_instagram);
            this.Controls.Add(this.textBox_twitter);
            this.Controls.Add(this.textBox_vk);
            this.Controls.Add(this.label_discord);
            this.Controls.Add(this.label_insta);
            this.Controls.Add(this.label_twitter);
            this.Controls.Add(this.label_vk);
            this.Controls.Add(this.label_social);
            this.Controls.Add(this.button_clear_all);
            this.Controls.Add(this.textBox_list_of_bad_words);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_save_confirmed);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_hello_msg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_settings_FormClosed);
            this.Load += new System.EventHandler(this.Form_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_hello_msg;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_save_confirmed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_list_of_bad_words;
        private System.Windows.Forms.Button button_clear_all;
        private System.Windows.Forms.Label label_social;
        private System.Windows.Forms.Label label_vk;
        private System.Windows.Forms.Label label_twitter;
        private System.Windows.Forms.Label label_insta;
        private System.Windows.Forms.Label label_discord;
        private System.Windows.Forms.TextBox textBox_vk;
        private System.Windows.Forms.TextBox textBox_twitter;
        private System.Windows.Forms.TextBox textBox_instagram;
        private System.Windows.Forms.TextBox textBox_discord;
    }
}