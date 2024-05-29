using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Administrator : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=Госпошлины;Integrated Security=True;Encrypt=False";
        public Administrator()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, EventArgs e)
        {
            string idPoshlina = IDPoshlina.Text;

            // Подключение к базе данных
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // SQL-запрос для обновления статуса записей
                string query = "UPDATE Госпошлина SET Статус = 'Принято' WHERE IDПошлины = @IDPoshlina";

                // Выполнение SQL-запроса
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDPoshlina", idPoshlina);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Принято: " + rowsAffected + " записей");
                }
            }

            // Обновление данных в DataGridView
            UpdateDataGridView();
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            string idPoshlina = IDPoshlina.Text;

            // Подключение к базе данных
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // SQL-запрос для обновления статуса записей
                string query = "UPDATE Госпошлина SET Статус = 'Отклонено' WHERE IDПошлины = @IDPoshlina";

                // Выполнение SQL-запроса
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDPoshlina", idPoshlina);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Отклонено: " + rowsAffected + " записей");
                }
            }

            // Обновление данных в DataGridView
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Госпошлина"; // ваш запрос для получения данных

                // Создаем новый SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Создаем новый DataSet
                DataSet dataSet = new DataSet();

                // Заполняем DataSet
                adapter.Fill(dataSet, "Госпошлина");

                // Устанавливаем источник данных для DataGridView
                dataGridViewStatus.DataSource = dataSet.Tables["Госпошлина"];
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // SQL-запрос для получения всех записей из таблицы Госпошлина
                string query = "SELECT * FROM Госпошлина";

                // Выполнение SQL-запроса и заполнение DataGridView
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewStatus.DataSource = dataTable;
                }
            }
        }
    }
}
