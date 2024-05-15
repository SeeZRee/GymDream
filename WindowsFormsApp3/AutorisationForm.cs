using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
        }

        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            {
                var login = LogAutoTextBox.Text;
                var password = PassAutoTextBox.Text;
                if (login == string.Empty || password == string.Empty)
                {
                    MessageBox.Show("Заполните все поля", "Ошибка");
                    return;
                }

                if (AuthorizeUser(login, password))
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка");
                }
            }
            bool AuthorizeUser(string login, string password)
            {
                bool isAuthorized = false;

                var dbQeury = new DB();

                using (SqlConnection con = new SqlConnection(dbQeury.StringCon()))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM [dbo].[Worker] WHERE Login ='{login}' and Password = '{password}'", con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["Password"].ToString() == password && reader["Login"].ToString() == login)
                                {
                                    isAuthorized = true;
                                    MessageBox.Show("Вход успешно выполнен!", "Успех");
                                }
                            }
                        }
                    }
                }
                return isAuthorized;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassAutoTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassAutoTextBox.UseSystemPasswordChar = true;
            }
        }

        private void AutorisationForm_Load(object sender, EventArgs e)
        {
            PassAutoTextBox.UseSystemPasswordChar = true;
        }
    }
}
