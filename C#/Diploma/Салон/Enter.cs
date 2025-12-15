using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Салон
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        int userID = 0;
        // Создание метода для авторизации администратора
        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "SELECT * FROM Администратор where ФИО='" + textBox_ФИО.Text + "'" + "and Пароль = '" + textBox_Пароль.Text + "' and Статус= 'работает'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    userID = reader.GetInt32(0);
                    if (reader.HasRows)
                    {
                        label1.Text = "Загрузка...";
                    }
                    else
                    {
                        throw new Exception();
                    }
                    reader.Close();
                    connection.Close();
                    Menu menu = new Menu(userID);
                    Hide();
                    menu.ShowDialog();
                }
            }
            catch (Exception)
            {
                label1.Text = "Ошибка авторизации";
            }
        }
        private void Enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
