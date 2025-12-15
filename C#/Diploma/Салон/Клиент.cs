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
    public partial class Клиент : Form
    {
        int userID = 0;

        public Клиент(int userID_)
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

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Клиент]([ФИО],[Номер телефона],[Посещений]) VALUES('" + textBox_ФИО_add.Text + "', '" + textBox_тел_add.Text + "', 0)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (String.IsNullOrEmpty(textBox_ФИО_add.Text) | String.IsNullOrEmpty(textBox_тел_add.Text))
                    {
                        throw new Exception();
                    }
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    this.Close();
                    Hide();
                    Клиент клиент = new Клиент(userID);
                    клиент.ShowDialog();
                }
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
                    if (radioButton_ФИО.Checked == true && !String.IsNullOrEmpty(textBox_newФИО.Text))
                    {
                        string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Клиент] SET [ФИО] = '" + textBox_newФИО.Text + "' WHERE [Номер телефона] = '" + comboBox_тел_edit.Text + "'";
                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else if (radioButton_тел.Checked == true && !String.IsNullOrEmpty(textBox_newтел.Text))
                    {
                        string sqlExpression3 = "UPDATE [Салон красоты].[dbo].[Клиент] SET [Номер телефона] = '" + textBox_newтел.Text + "' WHERE [Номер телефона] = '" + comboBox_тел_edit.Text + "'";
                        SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        reader3.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    this.Close();
                    Hide();
                    Клиент клиент = new Клиент(userID);
                    клиент.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }

        private void Клиент_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Клиент_представление". При необходимости она может быть перемещена или удалена.
            this.клиент_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Клиент_представление);

        }
        bool StringIsDigits(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            return true;
        }
        private void button_filter_Click(object sender, EventArgs e)
        {
            try
            {
                if (StringIsDigits(textBox_word_filter.Text))
                {
                    клиентпредставлениеBindingSource.Filter = "[Посещений] = " + textBox_word_filter.Text;
                }
                else
                {
                    клиентпредставлениеBindingSource.Filter = "[Номер телефона] = '" + textBox_word_filter.Text + "'" + " or [ФИО] = '" + textBox_word_filter.Text + "'";
                }
            }
            catch { }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            клиентпредставлениеBindingSource.Filter = "";
        }

        private void Клиент_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton_ФИО_CheckedChanged(object sender, EventArgs e)
        {
            textBox_newФИО.Enabled = true;
            textBox_newтел.Enabled = false;
        }

        private void radioButton_тел_CheckedChanged(object sender, EventArgs e)
        {
            textBox_newФИО.Enabled = false;
            textBox_newтел.Enabled = true;
        }
    }
}
