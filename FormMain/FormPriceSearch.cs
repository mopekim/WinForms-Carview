using Carwow.ThreeLayer.Dto;
using Carwow.ThreeLayer.infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormPriceSearch : Form
	{
		private List<CarDto> car;
		public FormPriceSearch()
		{
			InitializeComponent();
		}

		private void FormPriceSearch_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void butSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		private void Display()
		{
			string m1;
			string m2;


			if (comboBrand.Text == "搜尋品牌:")
			{
				m1 = null;
			}
			else
			{
				m1 = comboBrand.Text;
			}

			if (comboType.Text == "搜尋車種:")
			{
				m2 = null;
			}
			else
			{
				m2 = comboType.Text;
			}

			int? minP1;
			int? maxP1;
			bool isInt = int.TryParse(txtMin.Text, out int minP);
			if (string.IsNullOrEmpty(txtMin.Text))
			{
				minP1 = null;
				//MessageBox.Show("請輸入正整數");
			}
			else if (isInt)
			{
				minP1 = minP;
			}
			else
			{
				MessageBox.Show("請輸入正整數");
				return;
			}
			bool isInt2 = int.TryParse(txtMax.Text, out int maxP);
			if (string.IsNullOrEmpty(txtMax.Text))
			{
				maxP1 = null;
				//MessageBox.Show("請輸入正整數");
			}
			else if (isInt2)
			{
				maxP1 = maxP;
			}
			else
			{
				MessageBox.Show("請輸入正整數");
				return;
			}



			car = new CarRepository().Search(m1, m2, minP1, maxP1);
			dataGridView1.DataSource = car;

			//car = new CarRepository().Search(null, null, null, null);
			//dataGridView1.DataSource = car;

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int carId = car[e.RowIndex].Id;

			var frm = new FormAllDetail(carId);
			frm.ShowDialog();
		}
	}
}
