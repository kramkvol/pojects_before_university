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
    public partial class Печать_чека : Form
    {
        int userID = 0;
        public Печать_чека(int userID_)
        {
            InitializeComponent();
            userID = userID_;
        }

        Bitmap bitmap;
        private void Печать_чека_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Чек_представление". При необходимости она может быть перемещена или удалена.
            this.чек_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Чек_представление);
            датаTextBox.BackColor = System.Drawing.Color.White;
            итогTextBox.BackColor = System.Drawing.Color.White;
            кассирTextBox.BackColor = System.Drawing.Color.White;
            наличнымиTextBox.BackColor = System.Drawing.Color.White;
            сдачаTextBox.BackColor = System.Drawing.Color.White;
            скидкаTextBox.BackColor = System.Drawing.Color.White;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            чек_представлениеBindingNavigator.Visible = false;
            button_print.Visible = false;
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
