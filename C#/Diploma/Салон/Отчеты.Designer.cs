
namespace Салон
{
    partial class Отчеты
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Услуга_представлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.Отчет_по_работе_мастеровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Рейтинг_востребованных_услугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_back = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Услуга_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Услуга_представлениеTableAdapter();
            this.Рейтинг_востребованных_услугTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Рейтинг_востребованных_услугTableAdapter();
            this.Отчет_по_работе_мастеровTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Отчет_по_работе_мастеровTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Услуга_представлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Салон_красотыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_по_работе_мастеровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Рейтинг_востребованных_услугBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Услуга_представлениеBindingSource
            // 
            this.Услуга_представлениеBindingSource.DataMember = "Услуга_представление";
            this.Услуга_представлениеBindingSource.DataSource = this.Салон_красотыDataSet;
            // 
            // Салон_красотыDataSet
            // 
            this.Салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.Салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Отчет_по_работе_мастеровBindingSource
            // 
            this.Отчет_по_работе_мастеровBindingSource.DataMember = "Отчет_по_работе_мастеров";
            this.Отчет_по_работе_мастеровBindingSource.DataSource = this.Салон_красотыDataSet;
            // 
            // Рейтинг_востребованных_услугBindingSource
            // 
            this.Рейтинг_востребованных_услугBindingSource.DataMember = "Рейтинг_востребованных_услуг";
            this.Рейтинг_востребованных_услугBindingSource.DataSource = this.Салон_красотыDataSet;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(1006, 614);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(146, 40);
            this.button_back.TabIndex = 117;
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
            this.Title.TabIndex = 118;
            this.Title.Text = "Отчеты";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по соотношению услуг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Услуга_представлениеBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Салон.Прайс-лист услуг.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.ShowToolBar = false;
            this.reportViewer3.Size = new System.Drawing.Size(1126, 513);
            this.reportViewer3.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчет по работе мастеров";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Отчет_по_работе_мастеровBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Салон.Отчет по работе мастеров.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1126, 513);
            this.reportViewer2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 552);
            this.tabControl1.TabIndex = 119;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1132, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Рейстинг востребованных услуг";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Рейтинг_востребованных_услугBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Салон.Рейтинг востребованных услуг.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1126, 513);
            this.reportViewer4.TabIndex = 2;
            // 
            // Услуга_представлениеTableAdapter
            // 
            this.Услуга_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // Рейтинг_востребованных_услугTableAdapter
            // 
            this.Рейтинг_востребованных_услугTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_по_работе_мастеровTableAdapter
            // 
            this.Отчет_по_работе_мастеровTableAdapter.ClearBeforeFill = true;
            // 
            // Отчеты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "Отчеты";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Отчеты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Услуга_представлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Салон_красотыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_по_работе_мастеровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Рейтинг_востребованных_услугBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label Title;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource Услуга_представлениеBindingSource;
        private Салон_красотыDataSet Салон_красотыDataSet;
        private Салон_красотыDataSetTableAdapters.Услуга_представлениеTableAdapter Услуга_представлениеTableAdapter;
        private System.Windows.Forms.BindingSource Рейтинг_востребованных_услугBindingSource;
        private Салон_красотыDataSetTableAdapters.Рейтинг_востребованных_услугTableAdapter Рейтинг_востребованных_услугTableAdapter;
        private System.Windows.Forms.BindingSource Отчет_по_работе_мастеровBindingSource;
        private Салон_красотыDataSetTableAdapters.Отчет_по_работе_мастеровTableAdapter Отчет_по_работе_мастеровTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}