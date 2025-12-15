namespace Салон
{
    partial class Печать_чека
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
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label скидкаLabel;
            System.Windows.Forms.Label итогLabel;
            System.Windows.Forms.Label наличнымиLabel;
            System.Windows.Forms.Label сдачаLabel;
            System.Windows.Forms.Label кассирLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Печать_чека));
            this.button_print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.чек_представлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.чек_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Чек_представлениеTableAdapter();
            this.tableAdapterManager = new Салон.Салон_красотыDataSetTableAdapters.TableAdapterManager();
            this.чек_представлениеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.скидкаTextBox = new System.Windows.Forms.TextBox();
            this.итогTextBox = new System.Windows.Forms.TextBox();
            this.наличнымиTextBox = new System.Windows.Forms.TextBox();
            this.сдачаTextBox = new System.Windows.Forms.TextBox();
            this.кассирTextBox = new System.Windows.Forms.TextBox();
            this.датаTextBox = new System.Windows.Forms.TextBox();
            датаLabel = new System.Windows.Forms.Label();
            скидкаLabel = new System.Windows.Forms.Label();
            итогLabel = new System.Windows.Forms.Label();
            наличнымиLabel = new System.Windows.Forms.Label();
            сдачаLabel = new System.Windows.Forms.Label();
            кассирLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чек_представлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чек_представлениеBindingNavigator)).BeginInit();
            this.чек_представлениеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(40, 83);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(52, 20);
            датаLabel.TabIndex = 112;
            датаLabel.Text = "Дата:";
            // 
            // скидкаLabel
            // 
            скидкаLabel.AutoSize = true;
            скидкаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            скидкаLabel.Location = new System.Drawing.Point(40, 112);
            скидкаLabel.Name = "скидкаLabel";
            скидкаLabel.Size = new System.Drawing.Size(69, 20);
            скидкаLabel.TabIndex = 114;
            скидкаLabel.Text = "Скидка:";
            // 
            // итогLabel
            // 
            итогLabel.AutoSize = true;
            итогLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            итогLabel.Location = new System.Drawing.Point(40, 142);
            итогLabel.Name = "итогLabel";
            итогLabel.Size = new System.Drawing.Size(49, 20);
            итогLabel.TabIndex = 116;
            итогLabel.Text = "Итог:";
            // 
            // наличнымиLabel
            // 
            наличнымиLabel.AutoSize = true;
            наличнымиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наличнымиLabel.Location = new System.Drawing.Point(40, 172);
            наличнымиLabel.Name = "наличнымиLabel";
            наличнымиLabel.Size = new System.Drawing.Size(102, 20);
            наличнымиLabel.TabIndex = 118;
            наличнымиLabel.Text = "Наличными:";
            // 
            // сдачаLabel
            // 
            сдачаLabel.AutoSize = true;
            сдачаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сдачаLabel.Location = new System.Drawing.Point(40, 202);
            сдачаLabel.Name = "сдачаLabel";
            сдачаLabel.Size = new System.Drawing.Size(62, 20);
            сдачаLabel.TabIndex = 120;
            сдачаLabel.Text = "Сдача:";
            // 
            // кассирLabel
            // 
            кассирLabel.AutoSize = true;
            кассирLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кассирLabel.Location = new System.Drawing.Point(40, 232);
            кассирLabel.Name = "кассирLabel";
            кассирLabel.Size = new System.Drawing.Size(66, 20);
            кассирLabel.TabIndex = 122;
            кассирLabel.Text = "Кассир:";
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.Transparent;
            this.button_print.BackgroundImage = global::Салон.Properties.Resources.print_32;
            this.button_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Location = new System.Drawing.Point(308, 13);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(32, 32);
            this.button_print.TabIndex = 111;
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // салон_красотыDataSet
            // 
            this.салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // чек_представлениеBindingSource
            // 
            this.чек_представлениеBindingSource.DataMember = "Чек_представление";
            this.чек_представлениеBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // чек_представлениеTableAdapter
            // 
            this.чек_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Салон.Салон_красотыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = null;
            this.tableAdapterManager.День_неделиTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЗанятостьTableAdapter = null;
            this.tableAdapterManager.ЗаписьTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.МастерTableAdapter = null;
            this.tableAdapterManager.НаправлениеTableAdapter = null;
            this.tableAdapterManager.РасписаниеTableAdapter = null;
            this.tableAdapterManager.УслугаTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // чек_представлениеBindingNavigator
            // 
            this.чек_представлениеBindingNavigator.AddNewItem = null;
            this.чек_представлениеBindingNavigator.BindingSource = this.чек_представлениеBindingSource;
            this.чек_представлениеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.чек_представлениеBindingNavigator.DeleteItem = null;
            this.чек_представлениеBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.чек_представлениеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.чек_представлениеBindingNavigator.Location = new System.Drawing.Point(43, 20);
            this.чек_представлениеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.чек_представлениеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.чек_представлениеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.чек_представлениеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.чек_представлениеBindingNavigator.Name = "чек_представлениеBindingNavigator";
            this.чек_представлениеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.чек_представлениеBindingNavigator.Size = new System.Drawing.Size(217, 25);
            this.чек_представлениеBindingNavigator.TabIndex = 112;
            this.чек_представлениеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // скидкаTextBox
            // 
            this.скидкаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.скидкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чек_представлениеBindingSource, "Скидка", true));
            this.скидкаTextBox.Enabled = false;
            this.скидкаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.скидкаTextBox.Location = new System.Drawing.Point(148, 113);
            this.скидкаTextBox.Name = "скидкаTextBox";
            this.скидкаTextBox.Size = new System.Drawing.Size(179, 19);
            this.скидкаTextBox.TabIndex = 115;
            // 
            // итогTextBox
            // 
            this.итогTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.итогTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чек_представлениеBindingSource, "Итог", true));
            this.итогTextBox.Enabled = false;
            this.итогTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.итогTextBox.Location = new System.Drawing.Point(148, 143);
            this.итогTextBox.Name = "итогTextBox";
            this.итогTextBox.Size = new System.Drawing.Size(179, 19);
            this.итогTextBox.TabIndex = 117;
            // 
            // наличнымиTextBox
            // 
            this.наличнымиTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.наличнымиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чек_представлениеBindingSource, "Наличными", true));
            this.наличнымиTextBox.Enabled = false;
            this.наличнымиTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наличнымиTextBox.Location = new System.Drawing.Point(148, 173);
            this.наличнымиTextBox.Name = "наличнымиTextBox";
            this.наличнымиTextBox.Size = new System.Drawing.Size(179, 19);
            this.наличнымиTextBox.TabIndex = 119;
            // 
            // сдачаTextBox
            // 
            this.сдачаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.сдачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чек_представлениеBindingSource, "Сдача", true));
            this.сдачаTextBox.Enabled = false;
            this.сдачаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сдачаTextBox.Location = new System.Drawing.Point(148, 203);
            this.сдачаTextBox.Name = "сдачаTextBox";
            this.сдачаTextBox.Size = new System.Drawing.Size(179, 19);
            this.сдачаTextBox.TabIndex = 121;
            // 
            // кассирTextBox
            // 
            this.кассирTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.кассирTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чек_представлениеBindingSource, "Кассир", true));
            this.кассирTextBox.Enabled = false;
            this.кассирTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кассирTextBox.Location = new System.Drawing.Point(148, 233);
            this.кассирTextBox.Multiline = true;
            this.кассирTextBox.Name = "кассирTextBox";
            this.кассирTextBox.Size = new System.Drawing.Size(179, 46);
            this.кассирTextBox.TabIndex = 123;
            // 
            // датаTextBox
            // 
            this.датаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.датаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чек_представлениеBindingSource, "Дата", true));
            this.датаTextBox.Enabled = false;
            this.датаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаTextBox.Location = new System.Drawing.Point(148, 83);
            this.датаTextBox.Name = "датаTextBox";
            this.датаTextBox.Size = new System.Drawing.Size(179, 19);
            this.датаTextBox.TabIndex = 124;
            // 
            // Печать_чека
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 300);
            this.Controls.Add(this.датаTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(скидкаLabel);
            this.Controls.Add(this.скидкаTextBox);
            this.Controls.Add(итогLabel);
            this.Controls.Add(this.итогTextBox);
            this.Controls.Add(наличнымиLabel);
            this.Controls.Add(this.наличнымиTextBox);
            this.Controls.Add(сдачаLabel);
            this.Controls.Add(this.сдачаTextBox);
            this.Controls.Add(кассирLabel);
            this.Controls.Add(this.кассирTextBox);
            this.Controls.Add(this.чек_представлениеBindingNavigator);
            this.Controls.Add(this.button_print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Печать_чека";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Печать_чека_Load);
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чек_представлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чек_представлениеBindingNavigator)).EndInit();
            this.чек_представлениеBindingNavigator.ResumeLayout(false);
            this.чек_представлениеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Салон_красотыDataSet салон_красотыDataSet;
        private System.Windows.Forms.BindingSource чек_представлениеBindingSource;
        private Салон_красотыDataSetTableAdapters.Чек_представлениеTableAdapter чек_представлениеTableAdapter;
        private Салон_красотыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator чек_представлениеBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox скидкаTextBox;
        private System.Windows.Forms.TextBox итогTextBox;
        private System.Windows.Forms.TextBox наличнымиTextBox;
        private System.Windows.Forms.TextBox сдачаTextBox;
        private System.Windows.Forms.TextBox кассирTextBox;
        private System.Windows.Forms.TextBox датаTextBox;
    }
}