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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=Госпошлины;Integrated Security=True;Encrypt=False";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            if (ValidateUser(login, password)) /*проверка логина и пароля*/
            {
                if (login == "admin" && password == "admin")
                {
                    Administrator administrator = new Administrator();
                    administrator.Show();
                    this.Hide();
                }
                else
                {
                    User user = new User();
                    user.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private bool ValidateUser(string login, string password)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Data WHERE Login = @Login AND Password = @Password", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Login", login);
                sqlCommand.Parameters.AddWithValue("@Password", password);

                int result = (int)sqlCommand.ExecuteScalar();

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(); /*переход на другую форму*/
            registration.Show();
            this.Hide();
        }
    }
    }

