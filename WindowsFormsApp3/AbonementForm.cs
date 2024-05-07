using System;
using System.Collections;
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
    public partial class AbonementForm : Form
    {
        private DB db;
        public AbonementForm()
        {
            InitializeComponent();
            db = new DB();
        }

        private void AbonementForm_Load(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[Abonement]";
            db.SqlReturnData(query, dataGridView2);
        }

        private void ButtonAddAbonement_Click(object sender, EventArgs e)
        {

            if (TextBoxAbonementName.Text != String.Empty && TextBoxPriceAbonement.Text != String.Empty)
            {
                var queryAddAbonement = $"insert into [dbo].[Abonement] (Name_Abonement,Price) values ('{TextBoxAbonementName.Text}','{TextBoxPriceAbonement.Text}')";
                db.Execute(queryAddAbonement);

                string query = "select * from [dbo].[Abonement]";
                db.SqlReturnData(query, dataGridView2);
            }
            else
            {
                MessageBox.Show("Введите название абонемента и цену", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ButtonDeleteAbonement_Click(object sender, EventArgs e)
        {
            var queryDelAbonement = $"delete [dbo].[Abonement] where Id_Abonement = {TextBoxIdAbonement.Text}";
            db.Execute(queryDelAbonement);
            string query = "select * from [dbo].[Abonement]";
            db.SqlReturnData(query, dataGridView2);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var queryEditAbonement = $"update [dbo].[Abonement] set Name_Abonement = '{TextBoxAbonementName.Text}', Price ='{TextBoxPriceAbonement.Text}' where Id_Abonement = {TextBoxIdAbonement.Text}";
            db.Execute(queryEditAbonement);
            string query = "select * from [dbo].[Abonement]";
            db.SqlReturnData(query, dataGridView2);
        }
    }
}
