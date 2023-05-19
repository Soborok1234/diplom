using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class Registration : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Taxi;");

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void registr_button_Click(object sender, EventArgs e)
        {
            //string login = login_textBox.Text;
            //connection.Open();
            //NpgsqlCommand command1 = new NpgsqlCommand($"SELECT login FROM users WHERE login = '{login_textBox.Text}'", connection);


            string symb = "ABCDEFGHIJKLMNOPRSTUVWXYZ123456789!\"#$%&'()*+,-./::<=>?@[\\]:_{|}";
            if (password_textBox.Text.IndexOfAny(symb.ToCharArray()) == -1 || password_textBox.Text.Length < 8)
            {
                MessageBox.Show("Придумайте новый пароль", "Ошибка");
            }
            else
            {

                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users", connection);
                    int max_id = 0;
                    using (NpgsqlDataReader rd = command.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            max_id = Convert.ToInt32(rd["id_user"]);
                        }
                    }
                    max_id += 1;
                    NpgsqlCommand command_2 = new NpgsqlCommand(string.Format(@"INSERT INTO users VALUES({0}, '{1}', '{2}')", max_id, login_textBox.Text, password_textBox.Text), connection);
                    command_2.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                    MessageBox.Show("Пользователь успешно создан");
                }
                catch
                {
                    MessageBox.Show("Пользователь не может быть добавлен", "Ошибка");
                }
            }
        }
    }
}
