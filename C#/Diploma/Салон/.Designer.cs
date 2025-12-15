namespace Салон
{
    partial class Enter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.textBox_ФИО = new System.Windows.Forms.TextBox();
            this.textBox_Пароль = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.pictureBox_lock = new System.Windows.Forms.PictureBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ФИО
            // 
            this.textBox_ФИО.CausesValidation = false;
            this.textBox_ФИО.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ФИО.Location = new System.Drawing.Point(343, 254);
            this.textBox_ФИО.Multiline = true;
            this.textBox_ФИО.Name = "textBox_ФИО";
            this.textBox_ФИО.Size = new System.Drawing.Size(478, 37);
            this.textBox_ФИО.TabIndex = 43;
            // 
            // textBox_Пароль
            // 
            this.textBox_Пароль.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox_Пароль.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_Пароль.Location = new System.Drawing.Point(343, 339);
            this.textBox_Пароль.Multiline = true;
            this.textBox_Пароль.Name = "textBox_Пароль";
            this.textBox_Пароль.PasswordChar = '*';
            this.textBox_Пароль.Size = new System.Drawing.Size(478, 37);
            this.textBox_Пароль.TabIndex = 42;
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.Location = new System.Drawing.Point(423, 408);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(319, 51);
            this.button_enter.TabIndex = 41;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // pictureBox_lock
            // 
            this.pictureBox_lock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_lock.Image")));
            this.pictureBox_lock.Location = new System.Drawing.Point(248, 312);
            this.pictureBox_lock.Name = "pictureBox_lock";
            this.pictureBox_lock.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_lock.TabIndex = 46;
            this.pictureBox_lock.TabStop = false;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_user.Image")));
            this.pictureBox_user.Location = new System.Drawing.Point(248, 227);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 45;
            this.pictureBox_user.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(423, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Заполните форму";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1164, 70);
            this.Title.TabIndex = 0;
            this.Title.Text = "Вход для администратора";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 666);
            this.Controls.Add(this.textBox_ФИО);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBox_Пароль);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.pictureBox_lock);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Enter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ФИО;
        private System.Windows.Forms.TextBox textBox_Пароль;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.PictureBox pictureBox_lock;
        private System.Windows.Forms.PictureBox pictureBox_user;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
    }
}

