namespace FM
{
    partial class AddTrucks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrucks));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.typeListBox = new System.Windows.Forms.ListBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gHBWFMDataSet = new FM.GHBWFMDataSet();
            this.whseListBox = new System.Windows.Forms.ListBox();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dutyListBox = new System.Windows.Forms.ListBox();
            this.dutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.typeTableAdapter = new FM.GHBWFMDataSetTableAdapters.TypeTableAdapter();
            this.dutyTableAdapter = new FM.GHBWFMDataSetTableAdapters.DutyTableAdapter();
            this.warehouseTableAdapter = new FM.GHBWFMDataSetTableAdapters.WarehouseTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.truckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckTableAdapter = new FM.GHBWFMDataSetTableAdapters.TruckTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Odometer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truck Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Warehouse assigned to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fill in or select all fields and press OK. (Truck number cannot already be in use" +
    ")";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeListBox
            // 
            this.typeListBox.DataSource = this.typeBindingSource;
            this.typeListBox.DisplayMember = "Description";
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.IntegralHeight = false;
            this.typeListBox.Location = new System.Drawing.Point(244, 52);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(90, 36);
            this.typeListBox.TabIndex = 8;
            this.typeListBox.ValueMember = "ID";
            this.typeListBox.SelectedIndexChanged += new System.EventHandler(this.typeListBox_SelectedIndexChanged);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // gHBWFMDataSet
            // 
            this.gHBWFMDataSet.DataSetName = "GHBWFMDataSet";
            this.gHBWFMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // whseListBox
            // 
            this.whseListBox.DataSource = this.warehouseBindingSource;
            this.whseListBox.DisplayMember = "Name";
            this.whseListBox.FormattingEnabled = true;
            this.whseListBox.IntegralHeight = false;
            this.whseListBox.Location = new System.Drawing.Point(391, 99);
            this.whseListBox.Name = "whseListBox";
            this.whseListBox.Size = new System.Drawing.Size(122, 36);
            this.whseListBox.TabIndex = 9;
            this.whseListBox.ValueMember = "ID";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // dutyListBox
            // 
            this.dutyListBox.DataSource = this.dutyBindingSource;
            this.dutyListBox.DisplayMember = "Description";
            this.dutyListBox.FormattingEnabled = true;
            this.dutyListBox.IntegralHeight = false;
            this.dutyListBox.Location = new System.Drawing.Point(418, 52);
            this.dutyListBox.Name = "dutyListBox";
            this.dutyListBox.Size = new System.Drawing.Size(95, 36);
            this.dutyListBox.TabIndex = 10;
            this.dutyListBox.ValueMember = "ID";
            // 
            // dutyBindingSource
            // 
            this.dutyBindingSource.DataMember = "Duty";
            this.dutyBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(104, 52);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(77, 20);
            this.numTextBox.TabIndex = 11;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(104, 99);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(75, 20);
            this.capacityTextBox.TabIndex = 12;
            this.capacityTextBox.Text = "n/a";
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // dutyTableAdapter
            // 
            this.dutyTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.truckBindingSource, "Rental", true));
            this.checkBox1.Location = new System.Drawing.Point(334, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Rental";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // truckBindingSource
            // 
            this.truckBindingSource.DataMember = "Truck";
            this.truckBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // truckTableAdapter
            // 
            this.truckTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gHBWFMDataSet, "Truck.Odometer", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox1.Location = new System.Drawing.Point(155, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Odometer
            // 
            this.Odometer.AutoSize = true;
            this.Odometer.Location = new System.Drawing.Point(53, 155);
            this.Odometer.Name = "Odometer";
            this.Odometer.Size = new System.Drawing.Size(96, 13);
            this.Odometer.TabIndex = 15;
            this.Odometer.Text = "Odometer Reading";
            // 
            // AddTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 239);
            this.Controls.Add(this.Odometer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.dutyListBox);
            this.Controls.Add(this.whseListBox);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTrucks";
            this.Text = "Add Trucks";
            this.Load += new System.EventHandler(this.AddTrucks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox typeListBox;
        private System.Windows.Forms.ListBox whseListBox;
        private System.Windows.Forms.ListBox dutyListBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private GHBWFMDataSet gHBWFMDataSet;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private GHBWFMDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource dutyBindingSource;
        private GHBWFMDataSetTableAdapters.DutyTableAdapter dutyTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private GHBWFMDataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource truckBindingSource;
        private GHBWFMDataSetTableAdapters.TruckTableAdapter truckTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Odometer;
    }
}