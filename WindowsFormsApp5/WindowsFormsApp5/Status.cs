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
    public partial class Status : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=Госпошлины;Integrated Security=True;Encrypt=False";
        public Status()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }

        private void CheckStatus_Click(object sender, EventArgs e)
        {
            string familiya = Familiya.Text;
            string imya = Imya.Text;
            string otchestvo = Otchestvo.Text;

            // Поиск записей в базе данных
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Госпошлина WHERE Фамилия = @Familiya AND Имя = @Imya AND Отчество = @Otchestvo", connection))
                {
                    command.Parameters.AddWithValue("@Familiya", familiya);
                    command.Parameters.AddWithValue("@Imya", imya);
                    command.Parameters.AddWithValue("@Otchestvo", otchestvo);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Вывод результатов в dataGridViewStatus
                    dataGridViewStatus.DataSource = dataTable;

                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Найдено записей: " + dataTable.Rows.Count);
                    }
                    else
                    {
                        MessageBox.Show("Записей не найдено.");
                    }
                }
            }
        }

        private void Clearfields_Click(object sender, EventArgs e)
        {
            Familiya.Clear();
            Imya.Clear();
            Otchestvo.Clear();
        }
    }
}
