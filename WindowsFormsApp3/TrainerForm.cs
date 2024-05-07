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
    public partial class TrainerForm : Form
    {
        private DB db;
        public TrainerForm()
        {
            InitializeComponent();
            db = new DB();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxFioTrainer.Text != String.Empty && TextBoxOkladTrainer.Text != String.Empty)
            {
                var queryAddTrainer = $"insert into [dbo].[Trainer] (FIO_Trainer,Oklad) values ('{TextBoxFioTrainer.Text}','{TextBoxOkladTrainer.Text}')";
                db.Execute(queryAddTrainer);

                string query = "select * from [dbo].[Trainer]";
                db.SqlReturnData(query, dataGridView3);
            }
            else
            {
                MessageBox.Show("Введите ФИО и оклад тренера", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[Trainer]";
            db.SqlReturnData(query, dataGridView3);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var queryDelTrainer = $"delete [dbo].[Trainer] where Id_Trainer = {TextBoxIdTrainer.Text}";
            db.Execute(queryDelTrainer);
            string query = "select * from [dbo].[Trainer]";
            db.SqlReturnData(query, dataGridView3);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var queryEditAbonement = $"update [dbo].[Trainer] set FIO_Trainer = '{TextBoxFioTrainer.Text}', Oklad ='{TextBoxOkladTrainer.Text}' where Id_Trainer = {TextBoxIdTrainer.Text}";
            db.Execute(queryEditAbonement);
            string query = "select * from [dbo].[Trainer]";
            db.SqlReturnData(query, dataGridView3);
        }
    }
}
