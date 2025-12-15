using System;
using System.Windows.Forms;

namespace Салон
{
    public partial class Menu : Form
    {
        int userID = 0;
        public Menu(int userID_)
        {
            InitializeComponent();
            userID = userID_;
        }

        private void button_клиент_Click(object sender, EventArgs e)
        {
            Клиент клиент = new Клиент(userID);
            Hide();
            клиент.ShowDialog();
        }

        private void button_услуги_Click(object sender, EventArgs e)
        {
            Услуги услуги = new Услуги(userID);
            Hide();
            услуги.ShowDialog();
        }
        private void button_мастер_Click(object sender, EventArgs e)
        {
            Мастер мастер = new Мастер(userID);
            Hide();
            мастер.ShowDialog();
        }

        private void button_запись_Click(object sender, EventArgs e)
        {
            Занятость запись = new Занятость(userID);
            Hide();
            запись.ShowDialog();
        }

        private void button_расписание_Click(object sender, EventArgs e)
        {
            Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
            Hide();
            мастер_Расписание.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_Отчеты(object sender, EventArgs e)
        {
            Отчеты отчеты = new Отчеты(userID);
            Hide();
            отчеты.ShowDialog();
        }
    }
}
