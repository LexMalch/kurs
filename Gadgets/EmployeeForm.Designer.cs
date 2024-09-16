namespace Gadgets
{
    partial class EmployeeForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnSortByStatus = new System.Windows.Forms.Button();
            this.btnResetSort = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.gadgetsDataSet = new Gadgets.GadgetsDataSet();
            this.repairstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repair_statusTableAdapter = new Gadgets.GadgetsDataSetTableAdapters.repair_statusTableAdapter();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.comboBoxStatusChange = new System.Windows.Forms.ComboBox();
            this.repairstatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSearchStatus = new System.Windows.Forms.ComboBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repairstatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gadgetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairstatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairstatusBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(575, 337);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // btnSortByStatus
            // 
            this.btnSortByStatus.Location = new System.Drawing.Point(16, 377);
            this.btnSortByStatus.Name = "btnSortByStatus";
            this.btnSortByStatus.Size = new System.Drawing.Size(111, 31);
            this.btnSortByStatus.TabIndex = 1;
            this.btnSortByStatus.Text = "Сортировать";
            this.btnSortByStatus.UseVisualStyleBackColor = true;
            this.btnSortByStatus.Click += new System.EventHandler(this.btnSortByStatus_Click);
            // 
            // btnResetSort
            // 
            this.btnResetSort.Location = new System.Drawing.Point(25, 414);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(93, 27);
            this.btnResetSort.TabIndex = 2;
            this.btnResetSort.Text = "Сбросить";
            this.btnResetSort.UseVisualStyleBackColor = true;
            this.btnResetSort.Click += new System.EventHandler(this.btnResetSort_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.repairstatusBindingSource;
            this.comboBoxStatus.DisplayMember = "status_name";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 347);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.ValueMember = "status_name";
            // 
            // gadgetsDataSet
            // 
            this.gadgetsDataSet.DataSetName = "GadgetsDataSet";
            this.gadgetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repairstatusBindingSource
            // 
            this.repairstatusBindingSource.DataMember = "repair_status";
            this.repairstatusBindingSource.DataSource = this.gadgetsDataSet;
            // 
            // repair_statusTableAdapter
            // 
            this.repair_statusTableAdapter.ClearBeforeFill = true;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(601, 56);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(170, 32);
            this.btnChangeStatus.TabIndex = 4;
            this.btnChangeStatus.Text = "Изменить статус";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // comboBoxStatusChange
            // 
            this.comboBoxStatusChange.DataSource = this.repairstatusBindingSource1;
            this.comboBoxStatusChange.DisplayMember = "status_name";
            this.comboBoxStatusChange.FormattingEnabled = true;
            this.comboBoxStatusChange.Location = new System.Drawing.Point(617, 26);
            this.comboBoxStatusChange.Name = "comboBoxStatusChange";
            this.comboBoxStatusChange.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatusChange.TabIndex = 5;
            this.comboBoxStatusChange.ValueMember = "status_name";
            // 
            // repairstatusBindingSource1
            // 
            this.repairstatusBindingSource1.DataMember = "repair_status";
            this.repairstatusBindingSource1.DataSource = this.gadgetsDataSet;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Location = new System.Drawing.Point(601, 184);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(170, 32);
            this.btnChangePrice.TabIndex = 6;
            this.btnChangePrice.Text = "Назначить цену";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(601, 156);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(170, 22);
            this.textBoxPrice.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Поиск WORD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSearchStatus
            // 
            this.comboBoxSearchStatus.DataSource = this.repairstatusBindingSource2;
            this.comboBoxSearchStatus.DisplayMember = "status_name";
            this.comboBoxSearchStatus.FormattingEnabled = true;
            this.comboBoxSearchStatus.Location = new System.Drawing.Point(601, 319);
            this.comboBoxSearchStatus.Name = "comboBoxSearchStatus";
            this.comboBoxSearchStatus.Size = new System.Drawing.Size(170, 24);
            this.comboBoxSearchStatus.TabIndex = 9;
            this.comboBoxSearchStatus.ValueMember = "status_name";
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(601, 377);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(170, 22);
            this.textBoxMaxPrice.TabIndex = 10;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(601, 349);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(170, 22);
            this.textBoxMinPrice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Мин. цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Макс. цена:";
            // 
            // repairstatusBindingSource2
            // 
            this.repairstatusBindingSource2.DataMember = "repair_status";
            this.repairstatusBindingSource2.DataSource = this.gadgetsDataSet;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.comboBoxSearchStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.comboBoxStatusChange);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnResetSort);
            this.Controls.Add(this.btnSortByStatus);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gadgetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairstatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairstatusBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnSortByStatus;
        private System.Windows.Forms.Button btnResetSort;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private GadgetsDataSet gadgetsDataSet;
        private System.Windows.Forms.BindingSource repairstatusBindingSource;
        private GadgetsDataSetTableAdapters.repair_statusTableAdapter repair_statusTableAdapter;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.ComboBox comboBoxStatusChange;
        private System.Windows.Forms.BindingSource repairstatusBindingSource1;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSearchStatus;
        private System.Windows.Forms.BindingSource repairstatusBindingSource2;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}