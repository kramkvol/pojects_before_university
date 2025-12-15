using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Салон
{
    public partial class Мастер : Form
    {
        int userID = 0;

        public Мастер(int userID_)
        {
            InitializeComponent();
            userID = userID_;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(userID);
            Hide();
            menu.ShowDialog();
        }

        private void button_расписание_Click(object sender, EventArgs e)
        {
            Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
            мастер_Расписание.ShowDialog();
        }

        private void Мастер_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.салон_красотыDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер_представление". При необходимости она может быть перемещена или удалена.
            this.мастер_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Мастер_представление);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Мастер]([ФИО],[ID_Должность],[Статус]) VALUES ('" + textBox_ФИО_add.Text + "', " + comboBox_должность_add.SelectedValue.ToString() +  ", 'работает')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (String.IsNullOrEmpty(textBox_ФИО_add.Text))
                    {
                        throw new Exception();
                    }
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    Hide();
                    Мастер мастер = new Мастер(userID);
                    мастер.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }
        private void button_filter_Click(object sender, EventArgs e)
        {
            try
            {
                мастерпредставлениеBindingSource.Filter = "Статус = '" + textBox_word_filter.Text + "'" +
                    " or Должность = '" + textBox_word_filter.Text + "'" +
                    " or ФИО = '" + textBox_word_filter.Text + "'";
            }
            catch { }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            мастерпредставлениеBindingSource.Filter = "";
        }

        private void Мастер_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    if (!String.IsNullOrEmpty(textBox_newФИО_edit.Text))
                    {
                        string sqlExpression1 = "UPDATE [Салон красоты].[dbo].[Мастер] SET [ФИО] = '" + textBox_newФИО_edit.Text + "' WHERE ФИО = '" + comboBox_ФИО_edit.Text + "'";
                        SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        reader1.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    Hide();
                    Мастер мастер = new Мастер(userID);
                    мастер.ShowDialog();

                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression1 = "SELECT * FROM [Салон красоты].[dbo].[Мастер] WHERE ФИО  = '" + comboBox_ФИО_del.Text + "'";
                string sqlExpression = "UPDATE [Салон красоты].[dbo].[Мастер] SET[Статус] = 'не работает' WHERE ФИО  = '" + comboBox_ФИО_del.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (!reader1.HasRows)
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    connection.Open();
                    SqlCommand command2 = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    reader2.Close();
                    connection.Close();
                    this.Close();
                    Hide();
                    Мастер мастер = new Мастер(userID);
                    мастер.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }
    }
}
