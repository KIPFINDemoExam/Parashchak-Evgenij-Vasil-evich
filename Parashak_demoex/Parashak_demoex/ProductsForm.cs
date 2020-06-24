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
	public partial class ProductsForm : Form
	{
		private int count=0;

		public ProductsForm()
		{
			InitializeComponent();
			int count=0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			count++;
			GroupBox groupBox = new GroupBox();
			groupBox.Name = "groupBox" + count;
			CreateParams createParams= new CreateParams();
			groupBox.Parent = groupBox1;
			groupBox.Show();


		}
	}
}
