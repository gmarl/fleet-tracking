namespace FM
{
    partial class Records
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
            System.Windows.Forms.Label warehouseLabel;
            System.Windows.Forms.Label truckLabel;
            System.Windows.Forms.Label oOSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gHBWFMDataSet = new FM.GHBWFMDataSet();
            this.recordsTableAdapter = new FM.GHBWFMDataSetTableAdapters.RecordsTableAdapter();
            this.tableAdapterManager = new FM.GHBWFMDataSetTableAdapters.TableAdapterManager();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new FM.GHBWFMDataSetTableAdapters.StatusTableAdapter();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeTableAdapter = new FM.GHBWFMDataSetTableAdapters.TypeTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.warehouseTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mileTextBox = new System.Windows.Forms.TextBox();
            this.galsTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.dutyTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oOSListBox = new System.Windows.Forms.ListBox();
            this.oOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oOSTableAdapter = new FM.GHBWFMDataSetTableAdapters.OOSTableAdapter();
            this.fueltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.drivenLabel = new System.Windows.Forms.Label();
            this.LastOdomTextBox = new System.Windows.Forms.TextBox();
            this.truckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.truckTableAdapter = new FM.GHBWFMDataSetTableAdapters.TruckTableAdapter();
            this.rentalCheckBox = new System.Windows.Forms.CheckBox();
            this.drivenTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            warehouseLabel = new System.Windows.Forms.Label();
            truckLabel = new System.Windows.Forms.Label();
            oOSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // warehouseLabel
            // 
            warehouseLabel.AutoSize = true;
            warehouseLabel.Location = new System.Drawing.Point(201, 16);
            warehouseLabel.Name = "warehouseLabel";
            warehouseLabel.Size = new System.Drawing.Size(65, 13);
            warehouseLabel.TabIndex = 4;
            warehouseLabel.Text = "Warehouse:";
            // 
            // truckLabel
            // 
            truckLabel.AutoSize = true;
            truckLabel.Location = new System.Drawing.Point(25, 53);
            truckLabel.Name = "truckLabel";
            truckLabel.Size = new System.Drawing.Size(38, 13);
            truckLabel.TabIndex = 6;
            truckLabel.Text = "Truck:";
            // 
            // oOSLabel
            // 
            oOSLabel.AutoSize = true;
            oOSLabel.Location = new System.Drawing.Point(42, 231);
            oOSLabel.Name = "oOSLabel";
            oOSLabel.Size = new System.Drawing.Size(52, 13);
            oOSLabel.TabIndex = 41;
            oOSLabel.Text = "Not Used";
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "Records";
            this.recordsBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // gHBWFMDataSet
            // 
            this.gHBWFMDataSet.DataSetName = "GHBWFMDataSet";
            this.gHBWFMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DatesTableAdapter = null;
            this.tableAdapterManager.DutyTableAdapter = null;
            this.tableAdapterManager.OOSTableAdapter = null;
            this.tableAdapterManager.RecordsTableAdapter = this.recordsTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TruckTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FM.GHBWFMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Records_Status";
            this.statusBindingSource.DataSource = this.recordsBindingSource;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Record Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // warehouseTextBox
            // 
            this.warehouseTextBox.Location = new System.Drawing.Point(272, 16);
            this.warehouseTextBox.Name = "warehouseTextBox";
            this.warehouseTextBox.ReadOnly = true;
            this.warehouseTextBox.Size = new System.Drawing.Size(200, 20);
            this.warehouseTextBox.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(68, 56);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.gHBWFMDataSet;
            // 
            // statusListBox
            // 
            this.statusListBox.DataSource = this.statusBindingSource1;
            this.statusListBox.DisplayMember = "Desscription";
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.Location = new System.Drawing.Point(69, 147);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(101, 43);
            this.statusListBox.TabIndex = 1;
            this.statusListBox.ValueMember = "ID";
            this.statusListBox.SelectedIndexChanged += new System.EventHandler(this.statusListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Odometer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Gallons Delivered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Duty";
            // 
            // mileTextBox
            // 
            this.mileTextBox.Location = new System.Drawing.Point(459, 145);
            this.mileTextBox.Name = "mileTextBox";
            this.mileTextBox.Size = new System.Drawing.Size(81, 20);
            this.mileTextBox.TabIndex = 3;
            this.mileTextBox.Text = "0";
            this.mileTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.mileTextBox_Validating);
            // 
            // galsTextBox
            // 
            this.galsTextBox.Location = new System.Drawing.Point(289, 145);
            this.galsTextBox.Name = "galsTextBox";
            this.galsTextBox.Size = new System.Drawing.Size(71, 20);
            this.galsTextBox.TabIndex = 2;
            this.galsTextBox.Text = "0";
            this.galsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.galsTextBox_Validating);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(457, 63);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(83, 20);
            this.typeTextBox.TabIndex = 37;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(506, 16);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(34, 20);
            this.userTextBox.TabIndex = 38;
            // 
            // dutyTextBox
            // 
            this.dutyTextBox.Location = new System.Drawing.Point(321, 63);
            this.dutyTextBox.Name = "dutyTextBox";
            this.dutyTextBox.ReadOnly = true;
            this.dutyTextBox.Size = new System.Drawing.Size(84, 20);
            this.dutyTextBox.TabIndex = 39;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(204, 63);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.ReadOnly = true;
            this.capacityTextBox.Size = new System.Drawing.Size(67, 20);
            this.capacityTextBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Capacity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK/Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oOSListBox
            // 
            this.oOSListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recordsBindingSource, "OOS", true));
            this.oOSListBox.DataSource = this.oOSBindingSource;
            this.oOSListBox.DisplayMember = "Description";
            this.oOSListBox.FormattingEnabled = true;
            this.oOSListBox.Location = new System.Drawing.Point(100, 231);
            this.oOSListBox.Name = "oOSListBox";
            this.oOSListBox.Size = new System.Drawing.Size(180, 43);
            this.oOSListBox.TabIndex = 42;
            this.oOSListBox.ValueMember = "ID";
            // 
            // oOSBindingSource
            // 
            this.oOSBindingSource.DataMember = "OOS";
            this.oOSBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // oOSTableAdapter
            // 
            this.oOSTableAdapter.ClearBeforeFill = true;
            // 
            // fueltextBox
            // 
            this.fueltextBox.Location = new System.Drawing.Point(289, 172);
            this.fueltextBox.Name = "fueltextBox";
            this.fueltextBox.Size = new System.Drawing.Size(71, 20);
            this.fueltextBox.TabIndex = 43;
            this.fueltextBox.Text = "0";
            this.fueltextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fueltextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Fuel Gallons Used";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Reason:";
            // 
            // drivenLabel
            // 
            this.drivenLabel.AutoSize = true;
            this.drivenLabel.ForeColor = System.Drawing.Color.Red;
            this.drivenLabel.Location = new System.Drawing.Point(371, 206);
            this.drivenLabel.Name = "drivenLabel";
            this.drivenLabel.Size = new System.Drawing.Size(183, 13);
            this.drivenLabel.TabIndex = 46;
            this.drivenLabel.Text = "**Enter miles driven instead if rental.**";
            // 
            // LastOdomTextBox
            // 
            this.LastOdomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.truckBindingSource, "Odometer", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.LastOdomTextBox.Location = new System.Drawing.Point(460, 103);
            this.LastOdomTextBox.Name = "LastOdomTextBox";
            this.LastOdomTextBox.ReadOnly = true;
            this.LastOdomTextBox.Size = new System.Drawing.Size(80, 20);
            this.LastOdomTextBox.TabIndex = 47;
            // 
            // truckBindingSource
            // 
            this.truckBindingSource.DataMember = "Truck";
            this.truckBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Last Odometer Reading";
            // 
            // truckTableAdapter
            // 
            this.truckTableAdapter.ClearBeforeFill = true;
            // 
            // rentalCheckBox
            // 
            this.rentalCheckBox.AutoSize = true;
            this.rentalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.truckBindingSource, "Rental", true));
            this.rentalCheckBox.Enabled = false;
            this.rentalCheckBox.Location = new System.Drawing.Point(220, 102);
            this.rentalCheckBox.Name = "rentalCheckBox";
            this.rentalCheckBox.Size = new System.Drawing.Size(57, 17);
            this.rentalCheckBox.TabIndex = 50;
            this.rentalCheckBox.Text = "Rental";
            this.rentalCheckBox.UseVisualStyleBackColor = true;
            // 
            // drivenTextBox
            // 
            this.drivenTextBox.Location = new System.Drawing.Point(460, 172);
            this.drivenTextBox.Name = "drivenTextBox";
            this.drivenTextBox.Size = new System.Drawing.Size(81, 20);
            this.drivenTextBox.TabIndex = 51;
            this.drivenTextBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Miles Driven:";
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 304);
            this.Controls.Add(this.drivenTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rentalCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LastOdomTextBox);
            this.Controls.Add(this.drivenLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fueltextBox);
            this.Controls.Add(oOSLabel);
            this.Controls.Add(this.oOSListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.dutyTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.galsTextBox);
            this.Controls.Add(this.mileTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.warehouseTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(warehouseLabel);
            this.Controls.Add(truckLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Records";
            this.Text = "Enter Daily Records";
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GHBWFMDataSet gHBWFMDataSet;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private GHBWFMDataSetTableAdapters.RecordsTableAdapter recordsTableAdapter;
        private GHBWFMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private GHBWFMDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private GHBWFMDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox warehouseTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private System.Windows.Forms.ListBox statusListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mileTextBox;
        private System.Windows.Forms.TextBox galsTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox dutyTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox oOSListBox;
        private System.Windows.Forms.BindingSource oOSBindingSource;
        private GHBWFMDataSetTableAdapters.OOSTableAdapter oOSTableAdapter;
        private System.Windows.Forms.TextBox fueltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label drivenLabel;
        private System.Windows.Forms.TextBox LastOdomTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource truckBindingSource;
        private GHBWFMDataSetTableAdapters.TruckTableAdapter truckTableAdapter;
        private System.Windows.Forms.CheckBox rentalCheckBox;
        private System.Windows.Forms.TextBox drivenTextBox;
        private System.Windows.Forms.Label label12;
    }
}