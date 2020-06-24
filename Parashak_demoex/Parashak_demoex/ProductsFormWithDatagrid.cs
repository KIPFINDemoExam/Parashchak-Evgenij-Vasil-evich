using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parashak_demoex
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "parashakDataSet.Product". При необходимости она может быть перемещена или удалена.
			this.productTableAdapter.Fill(this.parashakDataSet.Product);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "parashakDataSet.ProductSale". При необходимости она может быть перемещена или удалена.
			this.productSaleTableAdapter.Fill(this.parashakDataSet.ProductSale);

		}
	}
}
