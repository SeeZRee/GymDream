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
        public partial class WorkerForm : Form
        {
        private DB db;
        public WorkerForm()
        {
            InitializeComponent();
            db = new DB();
        }
        private void ButtonAddUser_Click(object sender, EventArgs e)
        { 
            if (TextBoxLoginWorker.Text == String.Empty)
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK);
            }
            else if (TextBoxLoginWorker.Text != String.Empty)
            {
                var queryAddLogin = $"insert into [dbo].[Worker] (Login) values ('{TextBoxLoginWorker.Text}') ";
                db.Execute(queryAddLogin);
                string query = "select * from [dbo].[Worker]";
                db.SqlReturnData(query, dataGridView1);
            }
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            var queryDelLogin = $"delete [dbo].[Worker] where Id_Worker = {TextBoxIdWorker.Text}";
            db.Execute(queryDelLogin);
            string query = "select * from [dbo].[Worker]";
            db.SqlReturnData(query, dataGridView1);
        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            var queryEditLogin = $"update [dbo].[Worker] set Login = '{TextBoxLoginWorker.Text}' where Id_Worker = {TextBoxIdWorker.Text}";
            db.Execute(queryEditLogin);
            string query = "select * from [dbo].[Worker]";
            db.SqlReturnData(query, dataGridView1);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var queryListRequestPost = "SELECT * FROM Post";
            GetColumnValues(queryListRequestPost, "Name_Post", ComboBoxPostForWorker);

            string query = "select * from [dbo].[Worker]";
            db.SqlReturnData(query, dataGridView1);
        }
        public List<string> GetColumnValues(string query, string columnName, System.Windows.Forms.ComboBox comboBox)
        {
            List<string> ColumnValues = new List<string>();

            SqlConnection myCon = new SqlConnection(db.StringCon());
            myCon.Open();
            using (SqlCommand command = new SqlCommand(query, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object ColumnValueObject = reader.GetValue(reader.GetOrdinal(columnName));
                    string ColumnValue = ColumnValueObject != DBNull.Value ? ColumnValueObject.ToString() : "";
                    ColumnValues.Add(ColumnValue);
                }
                comboBox.Items.AddRange(ColumnValues.ToArray());
                return ColumnValues;
            }
        }
    }
}
