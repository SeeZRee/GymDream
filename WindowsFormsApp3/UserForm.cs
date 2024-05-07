using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
        public partial class UserForm : Form
        {
        private DB db;
        public UserForm()
        {
            InitializeComponent();
            db = new DB();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        { 
            if (TextBoxLoginUser.Text != null)
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK);
            }
            else if (TextBoxLoginUser == null)
            {
                var queryAddLogin = $"insert into [dbo].[User] (Login) values ('{TextBoxLoginUser.Text}') ";
                db.Execute(queryAddLogin);
                string query = "select * from [dbo].[User]";
                db.SqlReturnData(query, dataGridView1);
            }
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            var queryDelLogin = $"delete [dbo].[User] where Id_User = {TextBoxDeleteUser.Text}";
            db.Execute(queryDelLogin);
            string query = "select * from [dbo].[User]";
            db.SqlReturnData(query, dataGridView1);
        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            var queryEditLogin = $"update [dbo].[User] set Login = '{TextBoxEditLogUser.Text}' where Id_User = {TextBoxEditIdUser.Text}";
            db.Execute(queryEditLogin);
            string query = "select * from [dbo].[User]";
            db.SqlReturnData(query, dataGridView1);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[User]";
            db.SqlReturnData(query, dataGridView1);
        }
    }
}
