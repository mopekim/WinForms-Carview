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
	public partial class FormAllDetail : Form
	{
		private int _carId;
		public FormAllDetail(int carId)
		{
			InitializeComponent();
			_carId = carId;
		}

		private void FormAllDetail_Load(object sender, EventArgs e)
		{
			DetailDto dto = new CarRepository().Get(_carId);

			txtFuel.Text = dto.Fuel;
			txtYear.Text = dto.Year;
			txtPrice.Text =dto.Price.ToString();
			txtDescription.Text = dto.Description;
			txtSeller.Text = dto.Name;
			txtPhoneNumber.Text = dto.PhoneNumber;
			txtEmail.Text = dto.Email;

			string imagePath = @"C:\Users\ispan\Desktop\汽車照\" + dto.Image;
			pictureBox1.Image = Image.FromFile(imagePath);

		}
	}
}
