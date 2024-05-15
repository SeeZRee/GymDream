using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
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
        string StringCon = @"Data Source=DESKTOP-3N4PR9A\SQLEXPRESS;Initial Catalog=GymDreamBD;Integrated Security=True";

        private void ClientForm_Load(object sender, EventArgs e)
        {
            var queryListRequest = "SELECT * FROM Abonement";
            GetColumnValues(queryListRequest, "Name_Abonement", ComboBoxAbonementsForClients);

            var queryListRequestTrainers = "SELECT * FROM Trainer";
            GetColumnValues(queryListRequestTrainers, "FIO_Trainer", ComboBoxTrainerForClients);

            string query = "select * from [dbo].[Client]";
            db.SqlReturnData(query, dataGridView3);

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

       
        public void AddClient(string query, string query2, string query3, string query4)
        {
            List<string> Client = new List<string>();

            SqlConnection myCon = new SqlConnection(db.StringCon());
            myCon.Open();

            using (SqlCommand command = new SqlCommand(query, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object IdTrainerr = reader.GetValue(0);
                    Client.Add(IdTrainerr.ToString());
                }
                reader.Close();
            }
            using (SqlCommand command = new SqlCommand(query2, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object IdAbonementt = reader.GetValue(0);
                    Client.Add(IdAbonementt.ToString());
                }
                reader.Close();
            }
            using (SqlCommand command = new SqlCommand(query3, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object ClientNum = reader.GetValue(0);
                    Client.Add(ClientNum.ToString());
                }
                reader.Close();
            }
            using (SqlCommand command = new SqlCommand(query4, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object ClientFio = reader.GetValue(0);
                    Client.Add(ClientFio.ToString());
                }
                reader.Close();
            }

            //textBox2.Text = Client.ToArray().ToString();

            string result = String.Join(",", Client);

            var AddClient = $"INSERT INTO [dbo].[Client] VALUES '{result}'";
            db.Execute(AddClient);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object SelectedTrainer = ComboBoxTrainerForClients.SelectedItem;
            object SelectedAbonement = ComboBoxAbonementsForClients.SelectedItem;

            var queryIdTrainer = $"SELECT Id_Trainer FROM [dbo].[Trainer] WHERE FIO_Trainer = '{SelectedTrainer}'";
            var queryIdAbonement = $"SELECT Id_Abonement From [dbo].[Abonement] WHERE Name_Abonement = '{SelectedAbonement}'";
            var ClientNum = $"SELECT Phone_Number FROM [dbo].[Client] WHERE Phone_Number = '{TextBoxNumClient.Text}'";
            var ClientFio = $"SELECT FIO_Client FROM [dbo].[Client] WHERE FIO_Client = '{TextBoxFioClient.Text}'";

            var ClientAdd = $"INSERT INTO [dbo].[Client] (Id_Trainer) VALUES ('{queryIdTrainer}')";
            db.Execute(ClientAdd);

            
            //AddClient(queryIdTrainer, queryIdAbonement, ClientNum, ClientFio);

            string query = "select * from [dbo].[Client]";
            db.SqlReturnData(query, dataGridView3);
        }
    }
}
