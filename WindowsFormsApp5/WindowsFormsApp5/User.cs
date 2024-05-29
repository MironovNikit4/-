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
    public partial class User : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=Госпошлины;Integrated Security=True;Encrypt=False";
        public User()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void CheckStatus_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
            this.Close();
        }

        private void CreateTicket_Click(object sender, EventArgs e)
        {
            string familiya = Familiya.Text;
            string imya = Imya.Text;
            string otchestvo = Otchestvo.Text;
            string creditCard = CreditCart.Text;
            string target = Target.Text;
            string sum = SummaryPay.Text;
            // Вставка данных в базу данных
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Госпошлина (Фамилия, Имя, Отчество, Назначение, Номеркарты, Сумма) VALUES (@Familiya, @Imya, @Otchestvo, @Target, @CreditCard, @Sum)", connection))
                {
                    command.Parameters.AddWithValue("@Familiya", familiya);
                    command.Parameters.AddWithValue("@Imya", imya);
                    command.Parameters.AddWithValue("@Otchestvo", otchestvo);
                    command.Parameters.AddWithValue("@Target", target);
                    command.Parameters.AddWithValue("@CreditCard", creditCard);
                    command.Parameters.AddWithValue("@Sum", sum);
                    command.ExecuteNonQuery();
                }
            }
            // Очистка полей после вставки данных
            ClearFields();

            MessageBox.Show("Запись добавлена успешно!");
        }
        private void ClearFields()
        {
            Familiya.Clear();
            Imya.Clear();
            Otchestvo.Clear();
            CreditCart.Clear();
            SummaryPay.Clear();
            Target.SelectedIndex = -1;
        }

        private void Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Target.SelectedIndex)
            {
                case 0:
                    SummaryPay.Text = "15000";
                    break;
                case 1:
                    SummaryPay.Text = "20000";
                    break;
                case 2:
                    SummaryPay.Text = "3000";
                    break;
                case 3:
                    SummaryPay.Text = "4000";
                    break;
                case 4:
                    SummaryPay.Text = "4500"; 
                    break;
                case 5:
                    SummaryPay.Text = "1600"; 
                    break;
                case 6:
                    SummaryPay.Text = "19500"; 
                    break;
                case 7:
                    SummaryPay.Text = "2000"; 
                    break;
            }
        }
     }
    }

    

