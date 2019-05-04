using FM.DataSet1TableAdapters;

namespace FM
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.warehouse1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FM.DataSet1();
            this.Warehouse2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.queriesTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gHBWFMDataSet = new FM.GHBWFMDataSet();
            this.tableAdapterManager = new FM.GHBWFMDataSetTableAdapters.TableAdapterManager();
            this.gHBWFMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecordsTableAdapter = new FM.GHBWFMDataSetTableAdapters.RecordsTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.warehouse1TableAdapter = new FM.DataSet1TableAdapters.Warehouse1TableAdapter();
            this.Warehouse2TableAdapter = new FM.DataSet1TableAdapters.Warehouse2TableAdapter();
            this.FuelMileageTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MissingEntriesNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MissingEntriesNewTableAdapter = new FM.DataSet1TableAdapters.MissingEntriesNewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelMileageTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissingEntriesNewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // warehouse1BindingSource
            // 
            this.warehouse1BindingSource.DataMember = "Warehouse1";
            this.warehouse1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Warehouse2BindingSource
            // 
            this.Warehouse2BindingSource.DataMember = "Warehouse2";
            this.Warehouse2BindingSource.DataSource = this.dataSet1;
            // 
            // warehouse1BindingSource1
            // 
            this.warehouse1BindingSource1.DataMember = "Warehouse1";
            this.warehouse1BindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "All Mileage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(313, 44);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bulk Gallons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.warehouse1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.Reports.Mileage.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(21, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(615, 405);
            this.reportViewer1.TabIndex = 10;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Before Date:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Stats";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Fuel MPG";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(471, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Missing";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // queriesTableAdapterBindingSource
            // 
            this.queriesTableAdapterBindingSource.DataSource = typeof(FM.GHBWFMDataSetTableAdapters.QueriesTableAdapter);
            // 
            // RecordsBindingSource
            // 
            this.RecordsBindingSource.DataMember = "Records";
            this.RecordsBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // gHBWFMDataSet
            // 
            this.gHBWFMDataSet.DataSetName = "GHBWFMDataSet";
            this.gHBWFMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DatesTableAdapter = null;
            this.tableAdapterManager.DutyTableAdapter = null;
            this.tableAdapterManager.OOSTableAdapter = null;
            this.tableAdapterManager.RecordsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TruckTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FM.GHBWFMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // gHBWFMDataSetBindingSource
            // 
            this.gHBWFMDataSetBindingSource.DataSource = this.gHBWFMDataSet;
            this.gHBWFMDataSetBindingSource.Position = 0;
            // 
            // RecordsTableAdapter
            // 
            this.RecordsTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(292, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Not Used";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // warehouse1TableAdapter
            // 
            this.warehouse1TableAdapter.ClearBeforeFill = true;
            // 
            // Warehouse2TableAdapter
            // 
            this.Warehouse2TableAdapter.ClearBeforeFill = true;
            // 
            // FuelMileageTableAdapterBindingSource
            // 
            this.FuelMileageTableAdapterBindingSource.DataMember = "FuelMileageTableAdapter";
            this.FuelMileageTableAdapterBindingSource.DataSource = this.dataSet1;
            // 
            // MissingEntriesNewBindingSource
            // 
            this.MissingEntriesNewBindingSource.DataMember = "MissingEntriesNew";
            this.MissingEntriesNewBindingSource.DataSource = this.dataSet1;
            // 
            // MissingEntriesNewTableAdapter
            // 
            this.MissingEntriesNewTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 558);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissingEntriesNewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private GHBWFMDataSet gHBWFMDataSet;
        private GHBWFMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource gHBWFMDataSetBindingSource;
        private System.Windows.Forms.BindingSource RecordsBindingSource;
        private GHBWFMDataSetTableAdapters.RecordsTableAdapter RecordsTableAdapter;
        private System.Windows.Forms.BindingSource queriesTableAdapterBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource warehouse1BindingSource;
        private DataSet1TableAdapters.Warehouse1TableAdapter warehouse1TableAdapter;
        private System.Windows.Forms.BindingSource warehouse1BindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource Warehouse2BindingSource;
        private DataSet1TableAdapters.Warehouse2TableAdapter Warehouse2TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource FuelMileageTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource MissingEntriesNewBindingSource;
        private DataSet1TableAdapters.MissingEntriesNewTableAdapter MissingEntriesNewTableAdapter;

        public FuelMileageTableAdapter FuelMileageTableAdapter { get; private set; }
    }
}