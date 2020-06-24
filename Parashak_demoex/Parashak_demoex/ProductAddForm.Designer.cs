namespace Parashak_demoex
{
	partial class ProductAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddForm));
			this.parashakDataSet1 = new Parashak_demoex.ParashakDataSet();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productSaleTableAdapter = new Parashak_demoex.ParashakDataSetTableAdapters.ProductSaleTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.parashakDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// parashakDataSet1
			// 
			this.parashakDataSet1.DataSetName = "ParashakDataSet";
			this.parashakDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "ProductSale";
			this.bindingSource1.DataSource = this.parashakDataSet1;
			// 
			// productSaleTableAdapter
			// 
			this.productSaleTableAdapter.ClearBeforeFill = true;
			// 
			// ProductAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProductAddForm";
			this.Text = "ProductAddForm";
			this.Load += new System.EventHandler(this.ProductAddForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.parashakDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource bindingSource1;
		private ParashakDataSet parashakDataSet1;
		private ParashakDataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
	}
}