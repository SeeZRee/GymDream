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
            var queryAddLogin = $"insert into [dbo].[User] (Login) values ('{TextBoxLoginUser.Text}') ";
            db.Execute(queryAddLogin);
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            var queryAddLogin = $"delete [dbo].[User] where Id_User = {TextBoxDeleteUser.Text}";
            db.Execute(queryAddLogin);
        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            var queryAddLogin = $"update [dbo].[User] set Login = '{TextBoxEditLogUser.Text}' where Id_User = {TextBoxEditIdUser.Text}";
            db.Execute(queryAddLogin);
        }
    }
}
