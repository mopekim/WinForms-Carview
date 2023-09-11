using Carwow.ThreeLayer.Dto;
using Carwow.ThreeLayer.infrastructure;
using Carwow.ThreeLayer.Interface;
using FormMain.Garage;
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
	public partial class FormGarage : Form,IGrid
	{
		private int _memberId;
		private List<GarageDto> dto;
		public FormGarage(int memberId)
		{
			InitializeComponent();
			_memberId = memberId;
		}

		private void FormGarage_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int carId = dto[e.RowIndex].Id;

			var frm = new FormGarageItem(carId);
			frm.Owner= this;
			frm.ShowDialog();
		}

		public void Display()
		{
			dto = new CarRepository().Search(_memberId);
			dataGridView1.DataSource = dto;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var frm =new FormGarageNew(_memberId);
			frm.Owner= this;
			frm.ShowDialog();
		}
	}
}
