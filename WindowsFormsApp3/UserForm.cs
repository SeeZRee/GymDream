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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var queryAddLogin = $"insert into [dbo].[User] (Login) values ('{TextBoxLogin.Text}') ";
            db.Execute(queryAddLogin);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var queryAddLogin = $"delete [dbo].[User] where Id_User = {TextBoxDelete.Text}";
            db.Execute(queryAddLogin);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var queryAddLogin = $"update [dbo].[User] set Login = '{TextBoxEditLog.Text}' where Id_User = {TextBoxEditId.Text}";
            db.Execute(queryAddLogin);
        }
    }
}
