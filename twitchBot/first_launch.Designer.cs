
namespace twitchBot
{
    partial class first_launch
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
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.textBox_bot_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_oauth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин на твиче:";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(29, 25);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(127, 20);
            this.textBox_user.TabIndex = 1;
            this.textBox_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_user_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(164, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(20, 20);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_info
            // 
            this.button_info.FlatAppearance.BorderSize = 0;
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_info.Location = new System.Drawing.Point(0, -1);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(20, 20);
            this.button_info.TabIndex = 5;
            this.button_info.Text = "?";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // textBox_bot_name
            // 
            this.textBox_bot_name.Location = new System.Drawing.Point(29, 66);
            this.textBox_bot_name.Name = "textBox_bot_name";
            this.textBox_bot_name.Size = new System.Drawing.Size(127, 20);
            this.textBox_bot_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите имя бота:";
            // 
            // textBox_oauth
            // 
            this.textBox_oauth.Location = new System.Drawing.Point(30, 108);
            this.textBox_oauth.Name = "textBox_oauth";
            this.textBox_oauth.Size = new System.Drawing.Size(127, 20);
            this.textBox_oauth.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите oauth бота:";
            // 
            // first_launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.textBox_oauth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_bot_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "first_launch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.TextBox textBox_bot_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_oauth;
        private System.Windows.Forms.Label label3;
    }
}