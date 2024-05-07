using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp3
{
    internal class DB
    {
        public string StringCon()
        {
            return @"Data Source=DESKTOP-3N4PR9A\SQLEXPRESS;Initial Catalog=GymDreamBD;Integrated Security=True";
        }
        public SqlDataAdapter Execute(string query)
        {
            try
            {
                using (SqlConnection myCon = new SqlConnection(StringCon()))
                {
                    myCon.Open();
                    if (myCon.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Не удалось установить подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(query, myCon);
                    sda.SelectCommand.ExecuteNonQuery();
                    return sda;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Возникла ошибка при выполнении запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable SqlReturnData(string query, DataGridView grid)
        {
            try
            {
                using (SqlConnection myCon = new SqlConnection(StringCon()))
                {
                    myCon.Open();
                    if (myCon.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Не удалось установить подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(query, myCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    grid.DataSource = dt;
                    return dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Возникла ошибка при выполнении запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
