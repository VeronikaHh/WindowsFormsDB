
namespace WindowsFormsDB
{
    partial class ExcursionForPeriod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcursionForPeriod));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excursions1DataSet = new WindowsFormsDB.Excursions1DataSet();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionTableAdapter = new WindowsFormsDB.Excursions1DataSetTableAdapters.ExcursionTableAdapter();
            this.excursionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfCustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 125);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "End date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excursionIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.distanceKMDataGridViewTextBoxColumn,
            this.countOfCustomersDataGridViewTextBoxColumn,
            this.excursionTypeDataGridViewTextBoxColumn,
            this.Payment});
            this.dataGridView1.DataSource = this.excursionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 474);
            this.dataGridView1.TabIndex = 5;
            // 
            // excursions1DataSet
            // 
            this.excursions1DataSet.DataSetName = "Excursions1DataSet";
            this.excursions1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.excursions1DataSet;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // excursionIdDataGridViewTextBoxColumn
            // 
            this.excursionIdDataGridViewTextBoxColumn.DataPropertyName = "excursionId";
            this.excursionIdDataGridViewTextBoxColumn.HeaderText = "excursionId";
            this.excursionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.excursionIdDataGridViewTextBoxColumn.Name = "excursionIdDataGridViewTextBoxColumn";
            this.excursionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // distanceKMDataGridViewTextBoxColumn
            // 
            this.distanceKMDataGridViewTextBoxColumn.DataPropertyName = "distanceKM";
            this.distanceKMDataGridViewTextBoxColumn.HeaderText = "distanceKM";
            this.distanceKMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.distanceKMDataGridViewTextBoxColumn.Name = "distanceKMDataGridViewTextBoxColumn";
            // 
            // countOfCustomersDataGridViewTextBoxColumn
            // 
            this.countOfCustomersDataGridViewTextBoxColumn.DataPropertyName = "countOfCustomers";
            this.countOfCustomersDataGridViewTextBoxColumn.HeaderText = "countOfCustomers";
            this.countOfCustomersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countOfCustomersDataGridViewTextBoxColumn.Name = "countOfCustomersDataGridViewTextBoxColumn";
            // 
            // excursionTypeDataGridViewTextBoxColumn
            // 
            this.excursionTypeDataGridViewTextBoxColumn.DataPropertyName = "excursionType";
            this.excursionTypeDataGridViewTextBoxColumn.HeaderText = "excursionType";
            this.excursionTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.excursionTypeDataGridViewTextBoxColumn.Name = "excursionTypeDataGridViewTextBoxColumn";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 8;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // ExcursionForPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcursionForPeriod";
            this.Text = "ExcursionForPeriod";
            this.Load += new System.EventHandler(this.ExcursionForPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Excursions1DataSet excursions1DataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private Excursions1DataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfCustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}