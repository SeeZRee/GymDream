using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class ClientForm : Form
    {
        private DB db;
        public ClientForm()
        {
            InitializeComponent();
            db = new DB();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            var queryListRequest = "SELECT * FROM Abonement";
            GetColumnValues(queryListRequest, "Name_Abonement", ComboBoxAbonementsForClients);

            var queryListRequestTrainers = "SELECT * FROM Trainer";
            GetColumnValues(queryListRequestTrainers, "FIO_Trainer", ComboBoxTrainerForClients);


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

        /*private void button1_Click(object sender, EventArgs e)
        {
            object SelectedItem = ComboBoxTrainerForClients.SelectedItem;
            var queryFindIdTrainer = $"insert into [dbo].[Client] (Id_Trainer) values Id_Trainer where FIO_Trainer = '{SelectedItem}'";
            db.Execute(queryFindIdTrainer);
            TextBoxIdTrainerForSql.Text = queryFindIdTrainer;
            *///select * from [dbo].[Trainer] where FIO_Trainer = '{SelectedItem}'  /* SELECT SCOPE_IDENTITY()*/
        
       /* private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var queryEditAbonement = $"update [dbo].[Trainer] set FIO_Trainer = '{TextBoxFioTrainer.Text}', Oklad ='{TextBoxOkladTrainer.Text}' where Id_Trainer = {TextBoxIdTrainer.Text}";
            db.Execute(queryEditAbonement);
            string query = "select * from [dbo].[Trainer]";
            db.SqlReturnData(query, dataGridView3);
        }*/

       /* private void button1_Click_1(object sender, EventArgs e)
        {
            object SelectedItem = ComboBoxTrainerForClients.SelectedItem;
            var queryEdittAbonement = $"INSERT INTO [dbo].[Client] (Id_Trainer) SELECT Id_Trainer From [dbo].[Trainer] WHERE FIO_Trainer = '{SelectedItem}'";
            db.Execute(queryEdittAbonement);
            string query = "select * from [dbo].[Trainer]";
            db.SqlReturnData(query, dataGridView3);
        }*/
    }
}
