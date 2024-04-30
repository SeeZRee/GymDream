using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PassRegTextBox.Text != PassRegTextBox2.Text)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка");
                return;
            }

            PassValidation PassV = new PassValidation();
            if (PassV.Validation(PassRegTextBox.Text) == false)
            {
                return;
            }

            if (LogRegTextBox.Text == PassRegTextBox.Text)
            {
                MessageBox.Show("Пароль и логин не должны совпадать.", "Ошибка");
                return;
            }

            LoginValidation VL = new LoginValidation();
            if (VL.Validation(LogRegTextBox.Text) == false)
            {
                return;
            }
            else
            {
                Register(LogRegTextBox.Text, PassRegTextBox.Text);

                Main main = new Main();
                main.Show();
                this.Hide();
            }

             void Register(string login, string password)
            {
                string query = $"Insert into [dbo].[User](Login, Password) values('{login}', '{password}')";

                var DB = new DB();
                DB.Execute(query);
            }
        }
    }
}
