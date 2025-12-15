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
    public partial class Услуги : Form
    {
        int userID = 0;
        public Услуги(int userID_)
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

        private void Услуги_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Направление". При необходимости она может быть перемещена или удалена.
            this.направлениеTableAdapter.Fill(this.салон_красотыDataSet.Направление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Услуга_представление". При необходимости она может быть перемещена или удалена.
            this.услуга_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Услуга_представление);

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_услуга.Checked) { услугапредставлениеBindingSource1.Filter = "Услуга = '" + comboBox_услуга_filter.Text + "'"; }
                if (radioButton_направление.Checked) { услугапредставлениеBindingSource1.Filter = "Направление = '" + comboBox_направление_filter.Text + "'"; }
                if (radioButton_длительность.Checked) { услугапредставлениеBindingSource1.Filter = " Длительность >= " + textBox_длительностьОТ_filter.Text + " and Длительность <= " + textBox_длительностьДО_filter.Text; }
                if (radioButton_стоимость.Checked) { услугапредставлениеBindingSource1.Filter = " Стоимость >= " + textBox_стоимостьОТ_filter.Text.Replace(',', '.') + " and Стоимость <= " + textBox_стоимостьДО_filter.Text.Replace(',', '.'); }
            }
            catch { }
        }
        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            услугапредставлениеBindingSource1.Filter = "";
        }


        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression1 = "SELECT * FROM [Салон красоты].[dbo].[Услуга] WHERE Название = '" + comboBox_услуга_del.Text + "'";
                string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Статус] = 'не актуально' WHERE Название = '" + comboBox_услуга_del.Text + "'";
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
                    SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    connection.Close();
                    Hide();
                    Услуги услуги = new Услуги(userID);
                    услуги.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
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
                    if (radioButton_newдлительность.Checked == true)
                    {
                        string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Длительность] =" + textBox_newдлительность_edit.Text + " WHERE Название = '" + comboBox_услуга_edit.Text + "'";
                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else if (radioButton_newназвание.Checked == true)
                    {
                        string sqlExpression3 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Название] = '" + textBox_newназвание_edit.Text + "' WHERE Название = '" + comboBox_услуга_edit.Text + "'";
                        SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        reader3.Close();
                    }
                    else if (radioButton_newстоимость.Checked == true)
                    {
                        string sqlExpression4 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Стоимость] = " + textBox_newстоимость_edit.Text.Replace(',', '.') + " WHERE Название = '" + comboBox_услуга_edit.Text + "'";
                        SqlCommand command4 = new SqlCommand(sqlExpression4, connection);
                        SqlDataReader reader4 = command4.ExecuteReader();
                        reader4.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    Hide();
                    Услуги услуги = new Услуги(userID);
                    услуги.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
            string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Услуга]([ID_Направление],[Название],[Стоимость],[Длительность],[Статус])VALUES (" + comboBox_направление_add.SelectedValue.ToString() + ", '" + textBox_название_add.Text + "' ," + textBox_длительность_add.Text + "," + textBox_стоимость_add.Text.Replace(',', '.') + ", 'актуально')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    Hide();
                    Услуги услуги = new Услуги(userID);
                    услуги.ShowDialog();
                    connection.Close();
                }
                catch (Exception)
                {
                    label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                    label_ADD.Text = "Ошибка";
                    label_ADD.Visible = true;
                }
            }
        }
        private void Услуги_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_направление_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            услугапредставлениеBindingSource.Filter = "Направление_ID = " + comboBox_направление_edit.SelectedValue;
        }

        private void comboBox_направление_del_SelectedIndexChanged(object sender, EventArgs e)
        {
            услугапредставлениеBindingSource2.Filter = "Направление_ID = " + comboBox_направление_del.SelectedValue;
        }

        private void услуга_представлениеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                услугапредставлениеBindingSource1.Filter = "";
                услугапредставлениеBindingSource2.Filter = "";
                int Услуга = 0;
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlExpression = " DECLARE @Услуга INT SET @Услуга = (SELECT ID FROM  dbo.Услуга where Название = '" + услуга_представлениеDataGridView[1, услуга_представлениеDataGridView.CurrentCell.RowIndex].Value.ToString() + "') select @Услуга ";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    Услуга = reader.GetInt32(0);
                    connection.Close();
                    comboBox_услуга_edit.SelectedValue = Услуга;
                    comboBox_услуга_del.SelectedValue = Услуга;
                }
            }
            catch { }
        }

        private void radioButton_newназвание_CheckedChanged(object sender, EventArgs e)
        {
            textBox_newдлительность_edit.Enabled = false;
            textBox_newстоимость_edit.Enabled = false;
            textBox_newназвание_edit.Enabled = true;
        }

        private void radioButton_newстоимость_CheckedChanged(object sender, EventArgs e)
        {
            textBox_newдлительность_edit.Enabled = false;
            textBox_newстоимость_edit.Enabled = true;
            textBox_newназвание_edit.Enabled = false;
        }

        private void radioButton_newдлительность_CheckedChanged(object sender, EventArgs e)
        {
            textBox_newдлительность_edit.Enabled = true;
            textBox_newстоимость_edit.Enabled = false;
            textBox_newназвание_edit.Enabled = false;
        }

        private void radioButton_услуга_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_услуга_filter.Enabled = true;
            comboBox_направление_filter.Enabled = false;
            textBox_длительностьДО_filter.Enabled = false;
            textBox_длительностьОТ_filter.Enabled = false;
            textBox_стоимостьДО_filter.Enabled = false;
            textBox_стоимостьОТ_filter.Enabled = false;
        }

        private void radioButton_направление_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_услуга_filter.Enabled = false;
            comboBox_направление_filter.Enabled = true;
            textBox_длительностьДО_filter.Enabled = false;
            textBox_длительностьОТ_filter.Enabled = false;
            textBox_стоимостьДО_filter.Enabled = false;
            textBox_стоимостьОТ_filter.Enabled = false;
        }

        private void radioButton_длительность_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_услуга_filter.Enabled = false;
            comboBox_направление_filter.Enabled = false;
            textBox_длительностьДО_filter.Enabled = true;
            textBox_длительностьОТ_filter.Enabled = true;
            textBox_стоимостьДО_filter.Enabled = false;
            textBox_стоимостьОТ_filter.Enabled = false;
        }

        private void radioButton_стоимость_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_услуга_filter.Enabled = false;
            comboBox_направление_filter.Enabled = false;
            textBox_длительностьДО_filter.Enabled = false;
            textBox_длительностьОТ_filter.Enabled = false;
            textBox_стоимостьДО_filter.Enabled = true;
            textBox_стоимостьОТ_filter.Enabled = true;
        }
    }
}
