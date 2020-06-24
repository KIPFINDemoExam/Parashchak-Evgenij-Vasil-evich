namespace Parashak_demoex
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.parashakDataSet = new Parashak_demoex.ParashakDataSet();
			this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productSaleTableAdapter = new Parashak_demoex.ParashakDataSetTableAdapters.ProductSaleTableAdapter();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductbindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new Parashak_demoex.ParashakDataSetTableAdapters.ProductTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.parashakDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductbindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.ProductName,
            this.quantityDataGridViewTextBoxColumn,
            this.clientServiceIDDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.productSaleBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(65, 30);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(644, 191);
			this.dataGridView2.TabIndex = 1;
			// 
			// parashakDataSet
			// 
			this.parashakDataSet.DataSetName = "ParashakDataSet";
			this.parashakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productSaleBindingSource
			// 
			this.productSaleBindingSource.DataMember = "ProductSale";
			this.productSaleBindingSource.DataSource = this.parashakDataSet;
			// 
			// productSaleTableAdapter
			// 
			this.productSaleTableAdapter.ClearBeforeFill = true;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// saleDateDataGridViewTextBoxColumn
			// 
			this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
			this.saleDateDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
			this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
			// 
			// productIDDataGridViewTextBoxColumn
			// 
			this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
			this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
			this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "Товары";
			this.ProductName.Name = "ProductName";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// clientServiceIDDataGridViewTextBoxColumn
			// 
			this.clientServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ClientServiceID";
			this.clientServiceIDDataGridViewTextBoxColumn.HeaderText = "ClientServiceID";
			this.clientServiceIDDataGridViewTextBoxColumn.Name = "clientServiceIDDataGridViewTextBoxColumn";
			// 
			// ProductbindingSource
			// 
			this.ProductbindingSource.DataMember = "Product";
			this.ProductbindingSource.DataSource = this.parashakDataSet;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.parashakDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductbindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView2;
		private ParashakDataSet parashakDataSet;
		private System.Windows.Forms.BindingSource productSaleBindingSource;
		private ParashakDataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientServiceIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource ProductbindingSource;
		private ParashakDataSetTableAdapters.ProductTableAdapter productTableAdapter;
	}
}

