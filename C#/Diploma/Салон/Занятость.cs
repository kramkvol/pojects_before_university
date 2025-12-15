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

namespace Салон
{
    public partial class Занятость : Form
    {
        int userID = 0;
        string data = "";
        int ID_Услуга = 0;
        public Занятость(int userID_)
        {
            InitializeComponent();
            userID = userID_;
        }
        public Занятость(int userID_, string dt_, int ID_Услуга_)
        {
            InitializeComponent();
            userID = userID_;
            data = dt_;
            ID_Услуга = ID_Услуга_;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(userID);
            Hide();
            menu.ShowDialog();

        }
        private void Enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Метод для загрузки страницы
        private void Занятость_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Клиент_представление". При необходимости она может быть перемещена или удалена.
            this.клиент_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Клиент_представление);
            try
            {

                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    for (int j = 0; j <= 6; j++)
                    {
                        connection.Open();
                        string sqlExpression = " DECLARE @counter INT SET @counter = (SELECT COUNT(Мастер.ID) FROM dbo.Расписание INNER JOIN dbo.Мастер ON dbo.Расписание.ID_Мастера = dbo.Мастер.ID INNER JOIN dbo.[День недели] ON dbo.Расписание.ID_День_недели = dbo.[День недели].ID Where  (dbo.Расписание.ID_День_недели = DATEPART(w, convert(varchar, DATEADD(day,DATEDIFF(day,0,GETDATE())," + j + "), 23))))  select @counter";
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        int counter = reader.GetInt32(0);
                        reader.Close();
                        connection.Close();
                        connection.Open();
                        sqlExpression =
                            "SELECT Мастер.ID FROM dbo.Расписание INNER JOIN dbo.Мастер ON dbo.Расписание.ID_Мастера = dbo.Мастер.ID INNER JOIN dbo.[День недели] ON dbo.Расписание.ID_День_недели = dbo.[День недели].ID Where  (dbo.Расписание.ID_День_недели = DATEPART(w, convert(varchar, DATEADD(day,DATEDIFF(day,0,GETDATE()), "+ j +"), 23)))";
                        command = new SqlCommand(sqlExpression, connection);
                        reader = command.ExecuteReader();
                        int[] arr = new int[counter];
                        for (int i = 0; i <= arr.Length - 1; i++)
                        {
                            reader.Read();
                            arr[i] = reader.GetInt32(0);
                        }
                        reader.Close();
                        connection.Close();
                        for (int i = 0; i <= arr.Length - 1; i++)
                        {
                            connection.Open();
                            sqlExpression = "if not exists ( select * from Занятость where (dbo.Занятость.Дата = convert(varchar, DATEADD(day,DATEDIFF(day,0,GETDATE())," + j + "), 23)) AND (Занятость.ID_Мастер = " + arr[i] + "))" +
                                " begin INSERT INTO [Занятость] ([ID_Мастер],[Дата]) VALUES(" + arr[i] + ", convert(varchar, DATEADD(day,DATEDIFF(day,0,GETDATE())," + j + "), 23) ) end";
                            command = new SqlCommand(sqlExpression, connection);
                            reader = command.ExecuteReader();
                            reader.Read();
                            reader.Close();
                            connection.Close();
                        }
                    }
                }
            }
            catch { }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Направление". При необходимости она может быть перемещена или удалена.
            this.направлениеTableAdapter.Fill(this.салон_красотыDataSet.Направление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Запись_представление". При необходимости она может быть перемещена или удалена.
            this.запись_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Запись_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Занятость_представление". При необходимости она может быть перемещена или удалена.
            this.занятость_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Занятость_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер_представление". При необходимости она может быть перемещена или удалена.
            this.мастер_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Мастер_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Услуга_представление". При необходимости она может быть перемещена или удалена.
            this.услуга_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Услуга_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            for (int j = 0; j < записьпредставлениеDataGridView.RowCount; j++)
            {
                for (int i = 2; i < записьпредставлениеDataGridView.ColumnCount; i++)
                {
                    if (записьпредставлениеDataGridView[i, j].Value.ToString() == "занято")
                    {
                        записьпредставлениеDataGridView[i, j].Style.BackColor = Color.OrangeRed;
                    }
                    if (записьпредставлениеDataGridView[i, j].Value.ToString() == "доп время")
                    {
                        записьпредставлениеDataGridView[i, j].Style.BackColor = Color.Orange;
                    }
                    if (записьпредставлениеDataGridView[i, j].Value.ToString() == "не работает")
                    {
                        записьпредставлениеDataGridView[i, j].Style.BackColor = Color.Blue;
                    }
                }
            }
        }
        // Метод для добавления записи
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "EXEC [Добавить запись] '" + comboBox_расписание_add.Text + "', " + comboBox_услуга_add.SelectedValue.ToString() + ", " + comboBox_клиент_ФИО.SelectedValue.ToString() + ", '" + dateTimePicker_дата_add.Value.Year.ToString() + "-" + Value(dateTimePicker_дата_add.Value.Month.ToString()) + "-" + Value(dateTimePicker_дата_add.Value.Day.ToString()) + "', '" + textBox_начало_add.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                }
                Hide();
                Занятость запись = new Занятость(userID);
                запись.ShowDialog();

            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }
        private string Value(string dt)
        {
            string value_ = dt;
            if (dt.Length == 1)
            {
                value_ = "0" + dt;
            }
            return value_;
        }
        private void записьпредставлениеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            услугапредставлениеBindingSource.Filter = "";
            мастерпредставлениеBindingSource.Filter = "";
            направлениеBindingSource1.Filter = "";
            string time = "";
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 2) { time = "10:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 3) { time = "10:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 4) { time = "11:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 5) { time = "11:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 6) { time = "12:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 7) { time = "12:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 8) { time = "13:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 9) { time = "13:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 10) { time = "14:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 11) { time = "14:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 12) { time = "15:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 13) { time = "15:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 14) { time = "16:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 15) { time = "16:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 16) { time = "17:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 17) { time = "17:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 18) { time = "18:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 19) { time = "18:30"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 20) { time = "19:00"; }
            if (записьпредставлениеDataGridView.CurrentCell.ColumnIndex == 21) { time = "19:30"; }
            int Мастер = 0;
            int Клиент = 0;
            int Направление = 0;
            int Услуга = 0;
            try
            {
                if (записьпредставлениеDataGridView[записьпредставлениеDataGridView.CurrentCell.ColumnIndex, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString() == "занято")
                {
                    string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string sqlExpression = "SELECT     dbo.Услуга.Название, dbo.Услуга.Стоимость, dbo.Направление.Название, dbo.Клиент.ФИО, dbo.Клиент.[Номер телефона] FROM dbo.Запись INNER JOIN dbo.Услуга ON dbo.Запись.ID_Услуга = dbo.Услуга.ID INNER JOIN dbo.Направление ON dbo.Услуга.ID_Направление = dbo.Направление.ID INNER JOIN dbo.Клиент ON dbo.Запись.ID_Клиент = dbo.Клиент.ID where Дата  = '" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Year + "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Month +
                           "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Day + "' and ID_Расписание = " +
                           "(SELECT Расписание.ID FROM dbo.Расписание INNER JOIN dbo.Мастер ON dbo.Расписание.ID_Мастера = dbo.Мастер.ID INNER JOIN dbo.[День недели] ON dbo.Расписание.ID_День_недели = dbo.[День недели].ID " +
                           "Where dbo.Расписание.ID_День_недели = DATEPART(w, '" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Year + "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Month +
                            "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Day + "')" +
                            " and Мастер.ФИО = '" + записьпредставлениеDataGridView[0, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString() + "' and Запись.Начало = '" + time + "')";
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        string фио = reader.GetValue(3).ToString();
                        string услуга_str = reader.GetValue(0).ToString();
                        string стоимость_str = reader.GetValue(1).ToString();
                        услугаLabel.Text = "Услуга: " + reader.GetValue(0).ToString();
                        стоимостьLabel.Text = "Стоимость: " + reader.GetValue(1).ToString();
                        направлениеLabel.Text = "Направление: " + reader.GetValue(2).ToString();
                        клиент_ФИОLabel.Text = "Клиент ФИО: " + reader.GetValue(3).ToString();
                        номер_телефонаLabel.Text = "Номер телефона " + reader.GetValue(4).ToString();
                        reader.Close();
                        connection.Close();

                        connection.Open();
                        sqlExpression = " DECLARE @Клиент INT SET @Клиент = (SELECT ID FROM  dbo.Клиент where ФИО = '" + фио + "') select @Клиент ";
                        command = new SqlCommand(sqlExpression, connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        Клиент = reader.GetInt32(0);
                        connection.Close();

                        connection.Open();
                        sqlExpression = " DECLARE @Услуга INT SET @Услуга = (SELECT ID_Направление FROM  dbo.Услуга where Название = '" + услуга_str + "') select @Услуга ";
                        command = new SqlCommand(sqlExpression, connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        Направление = reader.GetInt32(0);
                        connection.Close();
                        combobox_ФИО_edit.SelectedValue = Клиент;
                        comboBox_направление_edit.SelectedValue = Направление;
                        dateTimePicker_дата_edit.Value = Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString()).Date;
                        textBox_начало_edit.Text = time;

                        combobox_ФИО_del.SelectedValue = Клиент;
                        dateTimePicker_дата_del.Value = Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString()).Date;
                        textBox_начало_del.Text = time;
                        comboBox_клиент_ФИО_чек.SelectedValue = Клиент;        
                        dateTimePicker_дата_чек.Value = Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString()).Date;
                        //textBox_начало_чек.Text = time;
                        connection.Open();
                        sqlExpression = " SELECT SUM (dbo.Услуга.Стоимость) FROM dbo.Запись INNER JOIN dbo.Услуга ON dbo.Запись.ID_Услуга = dbo.Услуга.ID group by ID_Клиент, Запись.Дата Having  Запись.ID_Клиент = " + Клиент + " and Запись.Дата = '" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Year + "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Month +
            "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Day  + "'";
                        command = new SqlCommand(sqlExpression, connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        string сумма  = reader.GetValue(0).ToString();
                        connection.Close();
                        textBox_наличными_чек.Text = ">=" + сумма;
                        connection.Open();
                        sqlExpression = " DECLARE @Услуга INT SET @Услуга = (SELECT ID FROM  dbo.Услуга where Название = '" + услуга_str + "') select @Услуга ";
                        command = new SqlCommand(sqlExpression, connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        Услуга = reader.GetInt32(0);
                        connection.Close();
                        comboBox_услуга_чек.SelectedValue = Услуга;
                    }
                }
                else if (записьпредставлениеDataGridView[записьпредставлениеDataGridView.CurrentCell.ColumnIndex, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString() == "не занято")
                {
                    string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlExpression = " DECLARE @Мастер INT SET @Мастер = (SELECT ID FROM  dbo.Мастер where ФИО = '" + записьпредставлениеDataGridView[0, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString() + "') select @Мастер ";
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        Мастер = reader.GetInt32(0);
                        connection.Close();
                    }
                    comboBox_расписание_add.SelectedValue = Мастер;
                    dateTimePicker_дата_add.Value = Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value.ToString()).Date;
                    textBox_начало_add.Text = time;
                    textBox_newначало_edit.Text = time;
                }
                else
                {
                    услугаLabel.Text = "Услуга: ";
                    стоимостьLabel.Text = "Стоимость: ";
                    направлениеLabel.Text = "Направление: ";
                    клиент_ФИОLabel.Text = "Клиент ФИО: ";
                    номер_телефонаLabel.Text = "Номер телефона ";
                }
            }
            catch (Exception)
            {

            }
        }
        // Метод для изменения записи
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = " EXEC [Обновить услугу записи]" + comboBox_newуслуга_edit.SelectedValue.ToString() + ", " + combobox_ФИО_edit.SelectedValue.ToString() + ", '" + dateTimePicker_дата_edit.Value.Year.ToString() + "-" + Value(dateTimePicker_дата_edit.Value.Month.ToString()) + "-" + Value(dateTimePicker_дата_edit.Value.Day.ToString()) + "', '" + textBox_начало_edit.Text + "'";
                string sqlExpression1 = " EXEC [Обновить начало записи] " + combobox_ФИО_edit.SelectedValue.ToString() + ", '" + dateTimePicker_дата_edit.Value.Year.ToString() + "-" + Value(dateTimePicker_дата_edit.Value.Month.ToString()) + "-" + Value(dateTimePicker_дата_edit.Value.Day.ToString()) + "', '" + textBox_начало_edit.Text + "', '" + textBox_newначало_edit.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (radioButton_услуга_edit.Checked == true)
                    {
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    else if (radioButton_начало_edit.Checked == true)
                    {
                        SqlCommand command2 = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    Hide();
                    Занятость запись = new Занятость(userID);
                    запись.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }
        // Метод для удаления записи
        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "EXEC  [Удалить запись] " + combobox_ФИО_del.SelectedValue.ToString() + ", '" + dateTimePicker_дата_del.Value.Year.ToString() + "-" + dateTimePicker_дата_del.Value.Month.ToString() + "-" + dateTimePicker_дата_del.Value.Day.ToString() + "', '" + textBox_начало_del.Text + "'";
                string sqlExpression1 = "select * from Запись where ID_Клиент = " + combobox_ФИО_del.SelectedValue.ToString() + " and Дата = '" + dateTimePicker_дата_del.Value.Year.ToString() + "-" + Value(dateTimePicker_дата_del.Value.Month.ToString()) + "-" + Value(dateTimePicker_дата_del.Value.Day.ToString()) + "' and Начало = '" + textBox_начало_del.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression1, connection);
                    SqlDataReader reader1 = command.ExecuteReader();
                    if (!reader1.HasRows)
                    {
                        throw new Exception();
                    }
                    reader1.Close();
                    connection.Close();

                    connection.Open();
                    command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();

                    connection.Open();
                    command = new SqlCommand(sqlExpression1, connection);
                    SqlDataReader reader2 = command.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        throw new Exception();
                    }
                    reader2.Close();
                    connection.Close();
                    Hide();
                    Занятость запись = new Занятость(userID);
                    запись.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }

        private void comboBox_расписание_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Направление = 0;
            string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string sqlExpression = " DECLARE @Направление INT SET @Направление = (SELECT ID_Должность FROM  dbo.Мастер where ID = " + comboBox_расписание_add.SelectedValue + ") select @Направление ";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Направление = reader.GetInt32(0);
                connection.Close();
            }
            услугапредставлениеBindingSource.Filter = "Направление_ID = " + Направление;
        }

        private void comboBox_направление_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            услугапредставлениеBindingSource.Filter = "Направление_ID = " + comboBox_направление_add.SelectedValue;
            мастерпредставлениеBindingSource.Filter = "Должность_ID = " + comboBox_направление_add.SelectedValue;
        }

        private void comboBox_направление_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            услугапредставлениеBindingSource1.Filter = "Направление_ID = " + comboBox_направление_edit.SelectedValue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_дата_filter.Checked) { занятостьпредставлениеBindingSource.Filter = "Дата = '" + dateTimePicker_дата_filter.Value.Year.ToString() + "-" + dateTimePicker_дата_filter.Value.Month.ToString() + "-" + dateTimePicker_дата_filter.Value.Day.ToString() + "'"; }
                if (radioButton_услуга_filter.Checked) { занятостьпредставлениеBindingSource.Filter = " ID_Должность = " + comboBox_направление_filter.SelectedValue; }
                if (radioButton_мастер_filter.Checked) { занятостьпредставлениеBindingSource.Filter = " ID_Мастер = " + comboBox_мастер_filter.SelectedValue; }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            занятостьпредставлениеBindingSource.Filter = "";
            for (int j = 0; j < записьпредставлениеDataGridView.RowCount; j++)
            {
                for (int i = 2; i < записьпредставлениеDataGridView.ColumnCount; i++)
                {
                    if (записьпредставлениеDataGridView[i, j].Value.ToString() == "занято")
                    {
                        записьпредставлениеDataGridView[i, j].Style.BackColor = Color.OrangeRed;
                    }
                    if (записьпредставлениеDataGridView[i, j].Value.ToString() == "доп время")
                    {
                        записьпредставлениеDataGridView[i, j].Style.BackColor = Color.Orange;
                    }
                    if (записьпредставлениеDataGridView[i, j].Value.ToString() == "не работает")
                    {
                        записьпредставлениеDataGridView[i, j].Style.BackColor = Color.Blue;
                    }
                }
            }
        }

        private void dateTimePicker_дата_add_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_дата_add.Value.Date > DateTime.Now.Date.AddDays(6) | dateTimePicker_дата_add.Value.Date < DateTime.Now.Date)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Недопустимая дата.";
                label_ADD.Visible = true;
            }
            else
                label_ADD.Visible = false;
        }

        private void dateTimePicker_дата_edit_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_дата_edit.Value.Date > DateTime.Now.Date.AddDays(6) | dateTimePicker_дата_edit.Value.Date < DateTime.Now.Date)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Недопустимая дата.";
                label_edit.Visible = true;
            }
            else
                label_edit.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Печать_чека печать_Чека = new Печать_чека(userID);
            печать_Чека.ShowDialog();
        }
        // Метод для добавления квитанции
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = " EXEC [Добавить чек] " + comboBox_клиент_ФИО_чек.SelectedValue.ToString() + ", " + comboBox_услуга_чек.SelectedValue.ToString() + ", " + userID + ", '" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Year + "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Month +
                            "-" + Convert.ToDateTime(записьпредставлениеDataGridView[1, записьпредставлениеDataGridView.CurrentCell.RowIndex].Value).Day + "', '" + textBox_наличными_чек.Text.Replace(',', '.') + "', '" + DateTime.Now.Year.ToString() + "-" + Value(DateTime.Now.Month.ToString()) + "-" + Value(DateTime.Now.Day.ToString()) + " " + Value(DateTime.Now.Hour.ToString()) + ":" + Value(DateTime.Now.Minute.ToString()) + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    Hide();
                    Занятость запись = new Занятость(userID);
                    запись.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_ADD2.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD2.Text = "Ошибка";
                label_ADD2.Visible = true;
            }
        }

        private void radioButton_услуга_edit_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_newуслуга_edit.Enabled = true;
            textBox_newначало_edit.Enabled = false;
        }

        private void radioButton_начало_edit_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_направление_edit.Enabled = false;
            comboBox_newуслуга_edit.Enabled = false;
            textBox_newначало_edit.Enabled = true;
        }

        private void radioButton_дата_filter_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_направление_filter.Enabled = false;
            dateTimePicker_дата_filter.Enabled = true;
            comboBox_мастер_filter.Enabled = false;
        }

        private void radioButton_услуга_filter_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_направление_filter.Enabled = true;
            dateTimePicker_дата_filter.Enabled = false;
            comboBox_мастер_filter.Enabled = false;
        }

        private void radioButton_мастер_filter_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_направление_filter.Enabled = false;
            dateTimePicker_дата_filter.Enabled = false;
            comboBox_мастер_filter.Enabled = true;
        }

        private void dateTimePicker_дата_del_ValueChanged(object sender, EventArgs e)
        {
                if (dateTimePicker_дата_del.Value.Date > DateTime.Now.Date.AddDays(6) | dateTimePicker_дата_del.Value.Date < DateTime.Now.Date)
                {
                    label_del.BackColor = System.Drawing.Color.OrangeRed;
                    label_del.Text = "Недопустимая дата.";
                    label_del.Visible = true;
                }
                else
                    label_del.Visible = false;
        }

        private void dateTimePicker_дата_чек_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_дата_чек.Value.Date > DateTime.Now.Date.AddDays(6) | dateTimePicker_дата_чек.Value.Date < DateTime.Now.Date)
            {
                label_ADD2.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD2.Text = "Недопустимая дата.";
                label_ADD2.Visible = true;
            }
            else
                label_ADD2.Visible = false;
        }
    }
}
