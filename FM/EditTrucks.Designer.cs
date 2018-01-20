namespace FM
{
    partial class EditTrucks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrucks));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldNumTextBox = new System.Windows.Forms.TextBox();
            this.oldTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oldWhseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oldCapTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oldDutyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newCapTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.newWhseListBox = new System.Windows.Forms.ListBox();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gHBWFMDataSet = new FM.GHBWFMDataSet();
            this.newTypeListBox = new System.Windows.Forms.ListBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newDutyListBox = new System.Windows.Forms.ListBox();
            this.dutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.typeTableAdapter = new FM.GHBWFMDataSetTableAdapters.TypeTableAdapter();
            this.dutyTableAdapter = new FM.GHBWFMDataSetTableAdapters.DutyTableAdapter();
            this.warehouseTableAdapter = new FM.GHBWFMDataSetTableAdapters.WarehouseTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Truck Number and click Retrieve.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Truck Number:";
            // 
            // oldNumTextBox
            // 
            this.oldNumTextBox.Location = new System.Drawing.Point(82, 16);
            this.oldNumTextBox.Name = "oldNumTextBox";
            this.oldNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldNumTextBox.TabIndex = 2;
            // 
            // oldTypeTextBox
            // 
            this.oldTypeTextBox.Location = new System.Drawing.Point(249, 16);
            this.oldTypeTextBox.Name = "oldTypeTextBox";
            this.oldTypeTextBox.ReadOnly = true;
            this.oldTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldTypeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // oldWhseTextBox
            // 
            this.oldWhseTextBox.Location = new System.Drawing.Point(437, 43);
            this.oldWhseTextBox.Name = "oldWhseTextBox";
            this.oldWhseTextBox.ReadOnly = true;
            this.oldWhseTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldWhseTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Warehouse:";
            // 
            // oldCapTextBox
            // 
            this.oldCapTextBox.Location = new System.Drawing.Point(249, 43);
            this.oldCapTextBox.Name = "oldCapTextBox";
            this.oldCapTextBox.ReadOnly = true;
            this.oldCapTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldCapTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capacity:";
            // 
            // oldDutyTextBox
            // 
            this.oldDutyTextBox.Location = new System.Drawing.Point(437, 17);
            this.oldDutyTextBox.Name = "oldDutyTextBox";
            this.oldDutyTextBox.ReadOnly = true;
            this.oldDutyTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldDutyTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duty:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.oldDutyTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.oldCapTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.oldWhseTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.oldTypeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.oldNumTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Duty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Capacity:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Warehouse:";
            // 
            // newCapTextBox
            // 
            this.newCapTextBox.Location = new System.Drawing.Point(248, 69);
            this.newCapTextBox.Name = "newCapTextBox";
            this.newCapTextBox.Size = new System.Drawing.Size(100, 20);
            this.newCapTextBox.TabIndex = 16;
            this.newCapTextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newWhseListBox
            // 
            this.newWhseListBox.DataSource = this.warehouseBindingSource;
            this.newWhseListBox.DisplayMember = "Name";
            this.newWhseListBox.FormattingEnabled = true;
            this.newWhseListBox.Location = new System.Drawing.Point(438, 69);
            this.newWhseListBox.Name = "newWhseListBox";
            this.newWhseListBox.Size = new System.Drawing.Size(100, 43);
            this.newWhseListBox.TabIndex = 25;
            this.newWhseListBox.ValueMember = "ID";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // gHBWFMDataSet
            // 
            this.gHBWFMDataSet.DataSetName = "GHBWFMDataSet";
            this.gHBWFMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newTypeListBox
            // 
            this.newTypeListBox.DataSource = this.typeBindingSource;
            this.newTypeListBox.DisplayMember = "Description";
            this.newTypeListBox.FormattingEnabled = true;
            this.newTypeListBox.Location = new System.Drawing.Point(248, 19);
            this.newTypeListBox.Name = "newTypeListBox";
            this.newTypeListBox.Size = new System.Drawing.Size(100, 43);
            this.newTypeListBox.TabIndex = 26;
            this.newTypeListBox.ValueMember = "ID";
            this.newTypeListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // newDutyListBox
            // 
            this.newDutyListBox.DataSource = this.dutyBindingSource;
            this.newDutyListBox.DisplayMember = "Description";
            this.newDutyListBox.FormattingEnabled = true;
            this.newDutyListBox.Location = new System.Drawing.Point(438, 19);
            this.newDutyListBox.Name = "newDutyListBox";
            this.newDutyListBox.Size = new System.Drawing.Size(100, 43);
            this.newDutyListBox.TabIndex = 27;
            this.newDutyListBox.ValueMember = "ID";
            // 
            // dutyBindingSource
            // 
            this.dutyBindingSource.DataMember = "Duty";
            this.dutyBindingSource.DataSource = this.gHBWFMDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.newDutyListBox);
            this.groupBox2.Controls.Add(this.newTypeListBox);
            this.groupBox2.Controls.Add(this.newWhseListBox);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.newCapTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(9, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 126);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Make your changes and click Update.";
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
            // EditTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 278);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTrucks";
            this.Text = "Edit Trucks";
            this.Load += new System.EventHandler(this.EditTrucks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHBWFMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldNumTextBox;
        private System.Windows.Forms.TextBox oldTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldWhseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldCapTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oldDutyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newCapTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox newWhseListBox;
        private System.Windows.Forms.ListBox newTypeListBox;
        private System.Windows.Forms.ListBox newDutyListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private GHBWFMDataSet gHBWFMDataSet;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private GHBWFMDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource dutyBindingSource;
        private GHBWFMDataSetTableAdapters.DutyTableAdapter dutyTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private GHBWFMDataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter;
    }
}