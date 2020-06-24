using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parashak_demoex
{
	public partial class ProductAddForm : Form
	{
		public ProductAddForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ProductAddForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "parashakDataSet1.ProductSale". При необходимости она может быть перемещена или удалена.
			this.productSaleTableAdapter.Fill(this.parashakDataSet1.ProductSale);
			SqlConnection con = ("Data Source=DESKTOP-R0P0EBE\MSSQLSRV;Initial Catalog=Parashak;User ID=parashchak;Password=***********");
			SqlCommand command=()
		}
	}
}
