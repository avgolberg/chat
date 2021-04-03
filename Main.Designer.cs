
namespace Chat_Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton2 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(22, 60);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(387, 22);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите сообщение:";
            this.label1.Visible = false;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.AutoSize = true;
            this.sendMessageButton.Location = new System.Drawing.Point(430, 56);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(89, 27);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "Отправить";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Visible = false;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(766, 334);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(255, 174);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(255, 22);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Еще нет аккаунта?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email:";
            // 
            // registerButton2
            // 
            this.registerButton2.AutoSize = true;
            this.registerButton2.Location = new System.Drawing.Point(313, 334);
            this.registerButton2.Name = "registerButton2";
            this.registerButton2.Size = new System.Drawing.Size(164, 27);
            this.registerButton2.TabIndex = 10;
            this.registerButton2.Text = "Зарегистироваться";
            this.registerButton2.UseVisualStyleBackColor = true;
            this.registerButton2.Click += new System.EventHandler(this.registerButton2_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Location = new System.Drawing.Point(348, 233);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 27);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // nickTextBox
            // 
            this.nickTextBox.Location = new System.Drawing.Point(255, 238);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(255, 22);
            this.nickTextBox.TabIndex = 24;
            this.nickTextBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ник:";
            this.label5.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(255, 175);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(255, 22);
            this.passwordTextBox.TabIndex = 22;
            this.passwordTextBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Пароль";
            this.label6.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(255, 103);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(255, 22);
            this.emailTextBox.TabIndex = 20;
            this.emailTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email:";
            this.label7.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Location = new System.Drawing.Point(299, 294);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(164, 27);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Зарегистироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Visible = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(255, 363);
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(255, 22);
            this.checkTextBox.TabIndex = 25;
            this.checkTextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Проверочный код:";
            this.label8.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = true;
            this.sendButton.Location = new System.Drawing.Point(526, 358);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(89, 27);
            this.sendButton.TabIndex = 27;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Visible = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkTextBox);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox nickTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendButton;
    }
}

