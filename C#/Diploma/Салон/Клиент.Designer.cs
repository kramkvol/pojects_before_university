namespace Салон
{
    partial class Клиент
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
            System.Windows.Forms.Label label_тел_filter;
            System.Windows.Forms.Label label_тел_add;
            System.Windows.Forms.Label label_ФИО_add;
            System.Windows.Forms.Label label3;
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_filter = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_newтел = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_newФИО = new System.Windows.Forms.TextBox();
            this.radioButton_ФИО = new System.Windows.Forms.RadioButton();
            this.radioButton_тел = new System.Windows.Forms.RadioButton();
            this.textBox_тел_add = new System.Windows.Forms.TextBox();
            this.textBox_ФИО_add = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клинетdataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_ADD = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label_edit = new System.Windows.Forms.Label();
            this.comboBox_тел_edit = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox_word_filter = new System.Windows.Forms.TextBox();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.клиентпредставлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиент_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Клиент_представлениеTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посещенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label_тел_filter = new System.Windows.Forms.Label();
            label_тел_add = new System.Windows.Forms.Label();
            label_ФИО_add = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.клинетdataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентпредставлениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_тел_filter
            // 
            label_тел_filter.AutoSize = true;
            label_тел_filter.Location = new System.Drawing.Point(17, 17);
            label_тел_filter.Name = "label_тел_filter";
            label_тел_filter.Size = new System.Drawing.Size(61, 20);
            label_тел_filter.TabIndex = 97;
            label_тел_filter.Text = "Слово:";
            // 
            // label_тел_add
            // 
            label_тел_add.AutoSize = true;
            label_тел_add.Location = new System.Drawing.Point(17, 73);
            label_тел_add.Name = "label_тел_add";
            label_тел_add.Size = new System.Drawing.Size(152, 20);
            label_тел_add.TabIndex = 95;
            label_тел_add.Text = "*Номер телефона:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 20);
            label3.TabIndex = 120;
            label3.Text = "*Номер телефона:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер телефона";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filter.ForeColor = System.Drawing.Color.Black;
            this.button_filter.Location = new System.Drawing.Point(797, 89);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(164, 33);
            this.button_filter.TabIndex = 89;
            this.button_filter.Text = "Фильтровать";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.Black;
            this.buttonShowAll.Location = new System.Drawing.Point(627, 89);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(164, 33);
            this.buttonShowAll.TabIndex = 100;
            this.buttonShowAll.Text = "Показать всё";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(1006, 614);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(146, 40);
            this.button_back.TabIndex = 114;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_newтел
            // 
            this.textBox_newтел.Enabled = false;
            this.textBox_newтел.Location = new System.Drawing.Point(17, 96);
            this.textBox_newтел.Name = "textBox_newтел";
            this.textBox_newтел.Size = new System.Drawing.Size(419, 26);
            this.textBox_newтел.TabIndex = 98;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.ForeColor = System.Drawing.Color.Black;
            this.button_edit.Location = new System.Drawing.Point(797, 89);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(164, 33);
            this.button_edit.TabIndex = 110;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_newФИО
            // 
            this.textBox_newФИО.Enabled = false;
            this.textBox_newФИО.Location = new System.Drawing.Point(441, 40);
            this.textBox_newФИО.Name = "textBox_newФИО";
            this.textBox_newФИО.Size = new System.Drawing.Size(419, 26);
            this.textBox_newФИО.TabIndex = 111;
            // 
            // radioButton_ФИО
            // 
            this.radioButton_ФИО.AutoSize = true;
            this.radioButton_ФИО.Location = new System.Drawing.Point(444, 15);
            this.radioButton_ФИО.Name = "radioButton_ФИО";
            this.radioButton_ФИО.Size = new System.Drawing.Size(117, 24);
            this.radioButton_ФИО.TabIndex = 116;
            this.radioButton_ФИО.TabStop = true;
            this.radioButton_ФИО.Text = "Новое ФИО";
            this.radioButton_ФИО.UseVisualStyleBackColor = true;
            this.radioButton_ФИО.CheckedChanged += new System.EventHandler(this.radioButton_ФИО_CheckedChanged);
            // 
            // radioButton_тел
            // 
            this.radioButton_тел.AutoSize = true;
            this.radioButton_тел.Location = new System.Drawing.Point(19, 70);
            this.radioButton_тел.Name = "radioButton_тел";
            this.radioButton_тел.Size = new System.Drawing.Size(224, 24);
            this.radioButton_тел.TabIndex = 115;
            this.radioButton_тел.TabStop = true;
            this.radioButton_тел.Text = "Новый нормер телефона:";
            this.radioButton_тел.UseVisualStyleBackColor = true;
            this.radioButton_тел.CheckedChanged += new System.EventHandler(this.radioButton_тел_CheckedChanged);
            // 
            // textBox_тел_add
            // 
            this.textBox_тел_add.Location = new System.Drawing.Point(17, 96);
            this.textBox_тел_add.Name = "textBox_тел_add";
            this.textBox_тел_add.Size = new System.Drawing.Size(419, 26);
            this.textBox_тел_add.TabIndex = 96;
            // 
            // textBox_ФИО_add
            // 
            this.textBox_ФИО_add.Location = new System.Drawing.Point(17, 41);
            this.textBox_ФИО_add.Name = "textBox_ФИО_add";
            this.textBox_ФИО_add.Size = new System.Drawing.Size(419, 26);
            this.textBox_ФИО_add.TabIndex = 93;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(797, 89);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(164, 33);
            this.button_add.TabIndex = 81;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1164, 53);
            this.Title.TabIndex = 112;
            this.Title.Text = "Клиент";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // клинетdataGridView
            // 
            this.клинетdataGridView.AllowUserToAddRows = false;
            this.клинетdataGridView.AllowUserToDeleteRows = false;
            this.клинетdataGridView.AutoGenerateColumns = false;
            this.клинетdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.клинетdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.клинетdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.клинетdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клинетdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.посещенийDataGridViewTextBoxColumn});
            this.клинетdataGridView.DataSource = this.клиентпредставлениеBindingSource;
            this.клинетdataGridView.Location = new System.Drawing.Point(12, 56);
            this.клинетdataGridView.Name = "клинетdataGridView";
            this.клинетdataGridView.ReadOnly = true;
            this.клинетdataGridView.Size = new System.Drawing.Size(1140, 424);
            this.клинетdataGridView.TabIndex = 118;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 486);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 168);
            this.tabControl1.TabIndex = 170;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label_ADD);
            this.tabPage2.Controls.Add(this.textBox_тел_add);
            this.tabPage2.Controls.Add(this.button_add);
            this.tabPage2.Controls.Add(this.textBox_ФИО_add);
            this.tabPage2.Controls.Add(label_тел_add);
            this.tabPage2.Controls.Add(label_ФИО_add);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(980, 135);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Добавить";
            // 
            // label_ADD
            // 
            this.label_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ADD.Location = new System.Drawing.Point(627, 96);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(164, 20);
            this.label_ADD.TabIndex = 135;
            this.label_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage6.Controls.Add(this.label_edit);
            this.tabPage6.Controls.Add(label3);
            this.tabPage6.Controls.Add(this.comboBox_тел_edit);
            this.tabPage6.Controls.Add(this.radioButton_ФИО);
            this.tabPage6.Controls.Add(this.button_edit);
            this.tabPage6.Controls.Add(this.textBox_newФИО);
            this.tabPage6.Controls.Add(this.textBox_newтел);
            this.tabPage6.Controls.Add(this.radioButton_тел);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(980, 135);
            this.tabPage6.TabIndex = 8;
            this.tabPage6.Text = "Изменить";
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
            // comboBox_тел_edit
            // 
            this.comboBox_тел_edit.DataSource = this.клиентпредставлениеBindingSource;
            this.comboBox_тел_edit.DisplayMember = "Список";
            this.comboBox_тел_edit.FormattingEnabled = true;
            this.comboBox_тел_edit.Location = new System.Drawing.Point(17, 40);
            this.comboBox_тел_edit.Name = "comboBox_тел_edit";
            this.comboBox_тел_edit.Size = new System.Drawing.Size(419, 28);
            this.comboBox_тел_edit.TabIndex = 121;
            this.comboBox_тел_edit.ValueMember = "ID";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.textBox_word_filter);
            this.tabPage4.Controls.Add(label_тел_filter);
            this.tabPage4.Controls.Add(this.button_filter);
            this.tabPage4.Controls.Add(this.buttonShowAll);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(980, 135);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Фильтрация";
            // 
            // textBox_word_filter
            // 
            this.textBox_word_filter.Location = new System.Drawing.Point(17, 40);
            this.textBox_word_filter.Name = "textBox_word_filter";
            this.textBox_word_filter.Size = new System.Drawing.Size(419, 26);
            this.textBox_word_filter.TabIndex = 112;
            // 
            // ФИО
            // 
            this.ФИО.DataPropertyName = "ФИО";
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // салон_красотыDataSet
            // 
            this.салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентпредставлениеBindingSource
            // 
            this.клиентпредставлениеBindingSource.DataMember = "Клиент_представление";
            this.клиентпредставлениеBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // клиент_представлениеTableAdapter
            // 
            this.клиент_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // посещенийDataGridViewTextBoxColumn
            // 
            this.посещенийDataGridViewTextBoxColumn.DataPropertyName = "Посещений";
            this.посещенийDataGridViewTextBoxColumn.HeaderText = "Посещений";
            this.посещенийDataGridViewTextBoxColumn.Name = "посещенийDataGridViewTextBoxColumn";
            this.посещенийDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Клиент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.клинетdataGridView);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "Клиент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Клиент_FormClosed);
            this.Load += new System.EventHandler(this.Клиент_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клинетdataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентпредставлениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_newтел;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_newФИО;
        private System.Windows.Forms.TextBox textBox_тел_add;
        private System.Windows.Forms.TextBox textBox_ФИО_add;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView клинетdataGridView;
        private Салон_красотыDataSet салон_красоты_11_1DataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton radioButton_ФИО;
        private System.Windows.Forms.RadioButton radioButton_тел;
        private System.Windows.Forms.DataGridViewTextBoxColumn процедурDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBox_тел_edit;
        private System.Windows.Forms.TextBox textBox_word_filter;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private Салон_красотыDataSet салон_красотыDataSet;
        private System.Windows.Forms.BindingSource клиентпредставлениеBindingSource;
        private Салон_красотыDataSetTableAdapters.Клиент_представлениеTableAdapter клиент_представлениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn посещенийDataGridViewTextBoxColumn;
    }
}