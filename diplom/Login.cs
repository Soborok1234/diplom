using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class Login : Form
    {

        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Taxi;");

        int counter = 3;

        Form1 form = new Form1();
        public Login(Form1 form1)
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 20000;

            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl == num)
                        break;
                    {

                    }
                }
            } while (true);
            captcha_label.Text = captcha;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void autor_button_Click(object sender, EventArgs e)
        {
            counter--;
            label4.Text = "Осталось попыток: " + counter.ToString();
            if (captcha_label.Text == captcha_textBox.Text)
            {

                try
                {
                    string login = "qqqqqq#%@@##@&@&&@&@qqqqqqqqq";
                    string password = "@#^@#*^@U^(@(^*@#^*&@#^";
                    connection.Open();
                    NpgsqlCommand command1 = new NpgsqlCommand($"SELECT login FROM users WHERE login = '{login_textBox.Text}'", connection);
                    NpgsqlCommand command2 = new NpgsqlCommand($"SELECT password FROM users WHERE password = '{password_textBox.Text}'", connection);
                    using (var reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            login = reader["login"].ToString();
                        }
                    }
                    using (var reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            password = reader["password"].ToString();
                        }
                    }

                    if (login == login_textBox.Text)
                    {
                        if (password == password_textBox.Text)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователя не существует", "Ошибка");
                    }
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось пройти авторизацию", "Ошибка");
                }
            }

            else if (counter == 2)
            {


                MessageBox.Show("Капча не верная", "Повторите попытку");
                this.OnLoad(e);

            }

            else if (counter == 1)
            {


                MessageBox.Show("Капча не верная", "Повторите попытку");
                this.OnLoad(e);

            }


            else if (counter == 0)
            {
                MessageBox.Show("Повторите попытку через 20 секунд");
                timer1.Start();
                this.Enabled = false;
            }
        }

            private void registr_button_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Enabled = true;
            timer1.Interval = 20000;
            timer1.Stop();
        }
    }
}
