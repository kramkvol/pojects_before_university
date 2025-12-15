using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Салон
{
    public partial class Отчеты : Form
    {
        int userID = 0;
        public Отчеты(int userID_)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Отчеты_Load(object sender, EventArgs e)
        {
             // TODO: данная строка кода позволяет загрузить данные в таблицу "Салон_красотыDataSet.Отчет_по_работе_мастеров". При необходимости она может быть перемещена или удалена.
            this.Отчет_по_работе_мастеровTableAdapter.Fill(this.Салон_красотыDataSet.Отчет_по_работе_мастеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Салон_красотыDataSet.Рейтинг_востребованных_услуг". При необходимости она может быть перемещена или удалена.
            this.Рейтинг_востребованных_услугTableAdapter.Fill(this.Салон_красотыDataSet.Рейтинг_востребованных_услуг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Салон_красотыDataSet.Услуга_представление". При необходимости она может быть перемещена или удалена.
            this.Услуга_представлениеTableAdapter.Fill(this.Салон_красотыDataSet.Услуга_представление);
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
