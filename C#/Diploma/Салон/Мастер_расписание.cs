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
    public partial class Мастер_расписание : Form
    {
        int userID = 0;
        public Мастер_расписание(int userID_)
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

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            расписаниепредставлениеBindingSource.Filter = "";
        }

        private void button_filer_Click(object sender, EventArgs e)
        {
            try
            {
                расписаниепредставлениеBindingSource.Filter = "ФИО = '" + textBox_word_filter.Text + "'" +
                    " or Должность = '" + textBox_word_filter.Text + "'" +
                    " or [День недели] = '" + textBox_word_filter.Text + "'" +
                " or [Начало рабочего дня] = '" + textBox_word_filter.Text + "'" +
                " or [Конец рабочего дня] = '" + textBox_word_filter.Text + "'";
            }
            catch { }
        }

        private void Мастер_расписание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер_представление". При необходимости она может быть перемещена или удалена.
            this.мастер_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Мастер_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.День_недели". При необходимости она может быть перемещена или удалена.
            this.день_неделиTableAdapter.Fill(this.салон_красотыDataSet.День_недели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Расписание_представление". При необходимости она может быть перемещена или удалена.
            this.расписание_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Расписание_представление);
        }

        private void Мастер_расписание_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression2 = "DELETE FROM [Салон красоты].[dbo].[Расписание]  WHERE ID_Мастера =" + comboBox_ФИО_del.SelectedValue.ToString() + " and ID_День_недели = " + comboBox_деньнедели_del.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    connection.Close();
                }
                Hide();
                Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
                мастер_Расписание.ShowDialog();
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (String.IsNullOrEmpty(textBox_от_add.Text) | String.IsNullOrEmpty(textBox_до_add.Text))
                    {
                        throw new Exception();
                    }
                    string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Расписание]([ID_День_недели],[ID_Мастера],[Начало рабочего дня],[Конец рабочего дня])" + "VALUES(" + comboBox_деньнедели_add.SelectedValue.ToString() + ", " + comboBox_ФИО_add.SelectedValue.ToString() + ", '" + textBox_от_add.Text + "', '" + textBox_до_add.Text + "')";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
                Hide();
                Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
                мастер_Расписание.ShowDialog();
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlExpression = "UPDATE [Салон красоты].[dbo].[Расписание] SET [Начало рабочего дня] = '" + textBox_newот_edit.Text + "', [Конец рабочего дня] = '" + textBox_newдо_edit.Text + "' WHERE [ID_День_недели] = " + comboBox_деньнедели_edit.SelectedValue.ToString() + " and [ID_Мастера] = " + comboBox_ФИО_edit.SelectedValue.ToString();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
                Hide();
                Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
                мастер_Расписание.ShowDialog();
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }
    }
    
}
