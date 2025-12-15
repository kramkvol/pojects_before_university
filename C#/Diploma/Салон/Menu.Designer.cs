namespace Салон
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_запись = new System.Windows.Forms.Button();
            this.button_мастер = new System.Windows.Forms.Button();
            this.button_клиент = new System.Windows.Forms.Button();
            this.button_услуги = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.button_расписание = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_запись
            // 
            this.button_запись.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_запись.Location = new System.Drawing.Point(169, 196);
            this.button_запись.Name = "button_запись";
            this.button_запись.Size = new System.Drawing.Size(369, 66);
            this.button_запись.TabIndex = 15;
            this.button_запись.Text = "Запись";
            this.button_запись.UseVisualStyleBackColor = true;
            this.button_запись.Click += new System.EventHandler(this.button_запись_Click);
            // 
            // button_мастер
            // 
            this.button_мастер.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_мастер.Location = new System.Drawing.Point(633, 196);
            this.button_мастер.Name = "button_мастер";
            this.button_мастер.Size = new System.Drawing.Size(369, 66);
            this.button_мастер.TabIndex = 16;
            this.button_мастер.Text = "Мастер";
            this.button_мастер.UseVisualStyleBackColor = true;
            this.button_мастер.Click += new System.EventHandler(this.button_мастер_Click);
            // 
            // button_клиент
            // 
            this.button_клиент.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_клиент.Location = new System.Drawing.Point(633, 331);
            this.button_клиент.Name = "button_клиент";
            this.button_клиент.Size = new System.Drawing.Size(369, 66);
            this.button_клиент.TabIndex = 18;
            this.button_клиент.Text = "Клиент";
            this.button_клиент.UseVisualStyleBackColor = true;
            this.button_клиент.Click += new System.EventHandler(this.button_клиент_Click);
            // 
            // button_услуги
            // 
            this.button_услуги.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_услуги.Location = new System.Drawing.Point(169, 466);
            this.button_услуги.Name = "button_услуги";
            this.button_услуги.Size = new System.Drawing.Size(369, 66);
            this.button_услуги.TabIndex = 21;
            this.button_услуги.Text = "Услуги";
            this.button_услуги.UseVisualStyleBackColor = true;
            this.button_услуги.Click += new System.EventHandler(this.button_услуги_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1164, 70);
            this.Title.TabIndex = 48;
            this.Title.Text = "Выбор операции";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_расписание
            // 
            this.button_расписание.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_расписание.Location = new System.Drawing.Point(633, 466);
            this.button_расписание.Name = "button_расписание";
            this.button_расписание.Size = new System.Drawing.Size(369, 66);
            this.button_расписание.TabIndex = 50;
            this.button_расписание.Text = "Расписание";
            this.button_расписание.UseVisualStyleBackColor = true;
            this.button_расписание.Click += new System.EventHandler(this.button_расписание_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 66);
            this.button1.TabIndex = 52;
            this.button1.Text = "Отчеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Отчеты);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_расписание);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button_услуги);
            this.Controls.Add(this.button_клиент);
            this.Controls.Add(this.button_мастер);
            this.Controls.Add(this.button_запись);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_запись;
        private System.Windows.Forms.Button button_мастер;
        private System.Windows.Forms.Button button_клиент;
        private System.Windows.Forms.Button button_услуги;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button_расписание;
        private System.Windows.Forms.Button button1;
    }
}