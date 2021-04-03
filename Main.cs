using System;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Client
{
    public partial class Main : Form
    {
        static Socket server;
        AutoResetEvent code = new AutoResetEvent(false);
        public Main()
        {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                server.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Disconnect();
            }
        }
        void GetMessage(Socket server)
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int length = server.Receive(buffer);
                    string m = Encoding.Unicode.GetString(buffer, 0, length);
                    richTextBox1.Text += Environment.NewLine + Encoding.Unicode.GetString(buffer, 0, length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Подключение прервано!"); //соединение было прервано
                    Disconnect();
                }
            }
        }
        void Disconnect()
        {
            if (server != null)
                server.Close();//отключение потока
            Environment.Exit(0); //завершение процесса
        }

        //  3 - отправлять другим сообщения
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            server.Send(Encoding.Unicode.GetBytes(message));
            richTextBox1.Text += Environment.NewLine + message;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && maskedTextBox1.Text != "")
            {
                string message = textBox2.Text + "$" + maskedTextBox1.Text;
                server.Send(Encoding.Unicode.GetBytes(message));

                byte[] buffer = new byte[1024];
                int length = server.Receive(buffer);
                string m = Encoding.Unicode.GetString(buffer, 0, length);
                if (m == "1")
                {

                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox2.Visible = false;
                    maskedTextBox1.Visible = false;
                    registerButton2.Visible = false;
                    loginButton.Visible = false;

                    richTextBox1.Visible = true;
                    messageTextBox.Visible = true;
                    sendMessageButton.Visible = true;
                    label1.Visible = true;

                    Task.Run(() => GetMessage(server));
                }
                else
                {
                    Disconnect();
                }
            }
        }

        private void registerButton2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            maskedTextBox1.Visible = false;
            registerButton2.Visible = false;
            loginButton.Visible = false;

            nickTextBox.Visible = true;
            emailTextBox.Visible = true;
            passwordTextBox.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            registerButton.Visible = true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
     
        void Work() 
        {
            byte[] buffer = new byte[1024];
            int length = server.Receive(buffer);
            string m = Encoding.Unicode.GetString(buffer, 0, length);

            if (m == "1")
            {

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox2.Visible = false;
                maskedTextBox1.Visible = false;
                registerButton2.Visible = false;
                loginButton.Visible = false;

                richTextBox1.Visible = true;
                messageTextBox.Visible = true;
                sendMessageButton.Visible = true;
                label1.Visible = true;

                Task.Run(() => GetMessage(server));
            }
            else
            {
                Disconnect();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (nickTextBox.Text != "" && emailTextBox.Text != "" && passwordTextBox.Text != "" && IsValidEmail(emailTextBox.Text))
            {
                string message = emailTextBox.Text + "$" + passwordTextBox.Text + "$" + nickTextBox.Text;
                server.Send(Encoding.Unicode.GetBytes(message));

                label8.Visible = true;
                sendButton.Visible = true;
                checkTextBox.Visible = true;

                Task.Run(() => code.WaitOne());
                //Task.WaitAll();
                //ждем от сервера 1 или 0
               
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            server.Send(Encoding.Unicode.GetBytes(checkTextBox.Text));
            code.Set();
            Task.Run(() => Work());
        }

    }
}