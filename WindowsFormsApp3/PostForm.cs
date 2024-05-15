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
    public partial class PostForm : Form
    {
        private DB db;
        public PostForm()
        {
            InitializeComponent();
            db = new DB();
        }
        private void PostForm_Load(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[Post]";
            db.SqlReturnData(query, dataGridView4);
        }

        private void ButtonAddPost_Click(object sender, EventArgs e)
        {
            if (TextBoxNamePost.Text == String.Empty)
            {
                MessageBox.Show("Введите название должности", "Ошибка", MessageBoxButtons.OK);
            }
            else if (TextBoxNamePost.Text != String.Empty)
            {
                var queryAddPost = $"insert into [dbo].[Post] (Name_Post) values ('{TextBoxNamePost.Text}') ";
                db.Execute(queryAddPost);
                string query = "select * from [dbo].[Post]";
                db.SqlReturnData(query, dataGridView4);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var queryDelPost = $"delete [dbo].[Post] where Id_Post = {TextBoxIdPost.Text}";
            db.Execute(queryDelPost);
            string query = "select * from [dbo].[Post]";
            db.SqlReturnData(query, dataGridView4);
        }
    }
}
