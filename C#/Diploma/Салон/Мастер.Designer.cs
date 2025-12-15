namespace Салон
{
    partial class Мастер
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label_ФИО_add;
            System.Windows.Forms.Label label_должность_add;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label_тел_filter;
            System.Windows.Forms.Label label1;
            this.мастерпредставлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_back = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_должность_add = new System.Windows.Forms.ComboBox();
            this.мастерdataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мастер_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Мастер_представлениеTableAdapter();
            this.должностьTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.ДолжностьTableAdapter();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_ФИО_add = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox_ФИО_edit = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_newФИО_edit = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.comboBox_ФИО_del = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox_word_filter = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label_ADD = new System.Windows.Forms.Label();
            this.label_edit = new System.Windows.Forms.Label();
            this.label_del = new System.Windows.Forms.Label();
            label_ФИО_add = new System.Windows.Forms.Label();
            label_должность_add = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label_тел_filter = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.мастерпредставлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерdataGridView)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ФИО_add
            // 
            label_ФИО_add.AutoSize = true;
            label_ФИО_add.Location = new System.Drawing.Point(17, 17);
            label_ФИО_add.Name = "label_ФИО_add";
            label_ФИО_add.Size = new System.Drawing.Size(57, 20);
            label_ФИО_add.TabIndex = 94;
            label_ФИО_add.Text = "*ФИО:";
            // 
            // label_должность_add
            // 
            label_должность_add.AutoSize = true;
            label_должность_add.Location = new System.Drawing.Point(17, 73);
            label_должность_add.Name = "label_должность_add";
            label_должность_add.Size = new System.Drawing.Size(105, 20);
            label_должность_add.TabIndex = 114;
            label_должность_add.Text = "*Должность:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(17, 17);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(57, 20);
            label9.TabIndex = 117;
            label9.Text = "*ФИО:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.Location = new System.Drawing.Point(17, 17);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(57, 20);
            label12.TabIndex = 98;
            label12.Text = "*ФИО:";
            // 
            // label_тел_filter
            // 
            label_тел_filter.AutoSize = true;
            label_тел_filter.Location = new System.Drawing.Point(17, 17);
            label_тел_filter.Name = "label_тел_filter";
            label_тел_filter.Size = new System.Drawing.Size(61, 20);
            label_тел_filter.TabIndex = 119;
            label_тел_filter.Text = "Слово:";
            // 
            // мастерпредставлениеBindingSource
            // 
            this.мастерпредставлениеBindingSource.DataMember = "Мастер_представление";
            this.мастерпредставлениеBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // салон_красотыDataSet
            // 
            this.салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(1006, 614);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(146, 40);
            this.button_back.TabIndex = 116;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1164, 53);
            this.Title.TabIndex = 113;
            this.Title.Text = "Мастер";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(799, 89);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(164, 33);
            this.button_add.TabIndex = 81;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_должность_add
            // 
            this.comboBox_должность_add.DataSource = this.должностьBindingSource;
            this.comboBox_должность_add.DisplayMember = "Название";
            this.comboBox_должность_add.FormattingEnabled = true;
            this.comboBox_должность_add.Location = new System.Drawing.Point(17, 96);
            this.comboBox_должность_add.Name = "comboBox_должность_add";
            this.comboBox_должность_add.Size = new System.Drawing.Size(419, 28);
            this.comboBox_должность_add.TabIndex = 115;
            this.comboBox_должность_add.ValueMember = "ID";
            // 
            // мастерdataGridView
            // 
            this.мастерdataGridView.AllowUserToAddRows = false;
            this.мастерdataGridView.AllowUserToDeleteRows = false;
            this.мастерdataGridView.AutoGenerateColumns = false;
            this.мастерdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.мастерdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.мастерdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.мастерdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мастерdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.мастерdataGridView.DataSource = this.мастерпредставлениеBindingSource;
            this.мастерdataGridView.Location = new System.Drawing.Point(12, 55);
            this.мастерdataGridView.Name = "мастерdataGridView";
            this.мастерdataGridView.ReadOnly = true;
            this.мастерdataGridView.Size = new System.Drawing.Size(1140, 425);
            this.мастерdataGridView.TabIndex = 121;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // мастер_представлениеTableAdapter
            // 
            this.мастер_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.Location = new System.Drawing.Point(12, 486);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(988, 168);
            this.tabControl2.TabIndex = 172;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label_ADD);
            this.tabPage1.Controls.Add(this.comboBox_должность_add);
            this.tabPage1.Controls.Add(label_должность_add);
            this.tabPage1.Controls.Add(this.textBox_ФИО_add);
            this.tabPage1.Controls.Add(label_ФИО_add);
            this.tabPage1.Controls.Add(this.button_add);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(980, 135);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Добавить";
            // 
            // textBox_ФИО_add
            // 
            this.textBox_ФИО_add.Location = new System.Drawing.Point(17, 41);
            this.textBox_ФИО_add.Name = "textBox_ФИО_add";
            this.textBox_ФИО_add.Size = new System.Drawing.Size(419, 26);
            this.textBox_ФИО_add.TabIndex = 93;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage5.Controls.Add(this.label_edit);
            this.tabPage5.Controls.Add(label1);
            this.tabPage5.Controls.Add(this.comboBox_ФИО_edit);
            this.tabPage5.Controls.Add(label9);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.textBox_newФИО_edit);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(980, 135);
            this.tabPage5.TabIndex = 8;
            this.tabPage5.Text = "Изменить";
            // 
            // comboBox_ФИО_edit
            // 
            this.comboBox_ФИО_edit.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО_edit.DisplayMember = "ФИО";
            this.comboBox_ФИО_edit.FormattingEnabled = true;
            this.comboBox_ФИО_edit.Location = new System.Drawing.Point(17, 40);
            this.comboBox_ФИО_edit.Name = "comboBox_ФИО_edit";
            this.comboBox_ФИО_edit.Size = new System.Drawing.Size(419, 28);
            this.comboBox_ФИО_edit.TabIndex = 118;
            this.comboBox_ФИО_edit.ValueMember = "ID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(797, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 33);
            this.button2.TabIndex = 110;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_newФИО_edit
            // 
            this.textBox_newФИО_edit.Location = new System.Drawing.Point(441, 40);
            this.textBox_newФИО_edit.Name = "textBox_newФИО_edit";
            this.textBox_newФИО_edit.Size = new System.Drawing.Size(419, 26);
            this.textBox_newФИО_edit.TabIndex = 111;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage7.Controls.Add(this.label_del);
            this.tabPage7.Controls.Add(this.comboBox_ФИО_del);
            this.tabPage7.Controls.Add(this.button3);
            this.tabPage7.Controls.Add(label12);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(980, 135);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Удалить";
            // 
            // comboBox_ФИО_del
            // 
            this.comboBox_ФИО_del.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО_del.DisplayMember = "ФИО";
            this.comboBox_ФИО_del.FormattingEnabled = true;
            this.comboBox_ФИО_del.Location = new System.Drawing.Point(17, 40);
            this.comboBox_ФИО_del.Name = "comboBox_ФИО_del";
            this.comboBox_ФИО_del.Size = new System.Drawing.Size(419, 28);
            this.comboBox_ФИО_del.TabIndex = 100;
            this.comboBox_ФИО_del.ValueMember = "ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(797, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 33);
            this.button3.TabIndex = 81;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage8.Controls.Add(this.textBox_word_filter);
            this.tabPage8.Controls.Add(label_тел_filter);
            this.tabPage8.Controls.Add(this.button4);
            this.tabPage8.Controls.Add(this.button5);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(980, 135);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Фильтрация";
            // 
            // textBox_word_filter
            // 
            this.textBox_word_filter.Location = new System.Drawing.Point(17, 40);
            this.textBox_word_filter.Name = "textBox_word_filter";
            this.textBox_word_filter.Size = new System.Drawing.Size(419, 26);
            this.textBox_word_filter.TabIndex = 120;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(797, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 33);
            this.button4.TabIndex = 89;
            this.button4.Text = "Фильтровать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(627, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 33);
            this.button5.TabIndex = 100;
            this.button5.Text = "Показать всё";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(438, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 20);
            label1.TabIndex = 120;
            label1.Text = "*Новое ФИО:";
            // 
            // label_ADD
            // 
            this.label_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ADD.Location = new System.Drawing.Point(629, 96);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(164, 20);
            this.label_ADD.TabIndex = 135;
            this.label_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_edit
            // 
            this.label_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit.Location = new System.Drawing.Point(627, 96);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(164, 20);
            this.label_edit.TabIndex = 135;
            this.label_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_del
            // 
            this.label_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_del.Location = new System.Drawing.Point(627, 96);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(164, 20);
            this.label_del.TabIndex = 135;
            this.label_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Мастер
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 666);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.мастерdataGridView);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "Мастер";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Мастер_FormClosed);
            this.Load += new System.EventHandler(this.Мастер_Load);
            ((System.ComponentModel.ISupportInitialize)(this.мастерпредставлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерdataGridView)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_должность_add;
        private System.Windows.Forms.DataGridView мастерdataGridView;
        private Салон_красотыDataSet салон_красотыDataSet;
        private System.Windows.Forms.BindingSource мастерпредставлениеBindingSource;
        private Салон_красотыDataSetTableAdapters.Мастер_представлениеTableAdapter мастер_представлениеTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private Салон_красотыDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_ФИО_add;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBox_ФИО_edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_newФИО_edit;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ComboBox comboBox_ФИО_del;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_word_filter;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.Label label_del;
    }
}