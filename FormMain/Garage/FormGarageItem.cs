using Carwow.ThreeLayer.Dto;
using Carwow.ThreeLayer.infrastructure;
using Carwow.ThreeLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormGarageItem : Form
	{
		private int _carId;
		private string _imageFile = @"C:\Users\ispan\Desktop\汽車照\";
		private string _imagePath;
		public FormGarageItem(int carId)
		{
			InitializeComponent();
			_carId = carId;
		}

		private void FormGarageItem_Load(object sender, EventArgs e)
		{
			GarageDto dto = new CarRepository().GetItem(_carId);

			    lblCarId.Text = _carId.ToString();
				comboBoxBrand.Text= dto.Brand;
			    txtModel.Text= dto.Model;
			    comboBoxType.Text= dto.Type;
				txtPrice.Text = dto.Price.ToString();
				txtFuel.Text = dto.Fuel;
				txtYear.Text = dto.Year;
				txtDescription.Text = dto.Description;
			string imagePath = @"C:\Users\ispan\Desktop\汽車照\" + dto.Image;
			pictureBox1.Image = Image.FromFile(imagePath);


		}

		private void butDelete_Click(object sender, EventArgs e)
		{
			CarRepository repo = new CarRepository();
			repo.Delete(_carId);
			
				

			// 新增完成，關閉自己，並通知 owner 更新內容
			IGrid owner = this.Owner as IGrid; // 若用as轉型且失敗，會傳回null，不會丟出例外
			owner.Display();
			MessageBox.Show("紀錄已刪除");

			this.DialogResult = DialogResult.OK;


		}

		private void butUpdate_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtPrice.Text, out int uprice);
			if (!isInt) 
			{ MessageBox.Show("請輸入正整數");
				return;
			}
			var item = new GarageDto
			{

				Id = _carId,
				Brand = comboBoxBrand.Text,
				Model = txtModel.Text,
				Type = comboBoxType.Text,
				Price = uprice,
				Image= _imagePath,
				Fuel = txtFuel.Text,
				Year = txtYear.Text,
				Description = txtDescription.Text
			};
			CarRepository repo = new CarRepository();
			repo.Update(item);

			// 新增完成，關閉自己，並通知 owner 更新內容
			IGrid owner = this.Owner as IGrid; // 若用as轉型且失敗，會傳回null，不會丟出例外
			owner.Display();
			MessageBox.Show("紀錄已更新");
		

			this.DialogResult = DialogResult.OK;
		}

		private void butImageUpload_Click(object sender, EventArgs e)
		{
			var file = new OpenFileDialog();
			file.Filter = "Image Files *(*.jpg,*.jpeg,*.png| *.jpg;*.jpeg;*.png";

			var result =file.ShowDialog();

			if (result != DialogResult.OK) 
			{
				return;
			}

			string imageResult =_imageFile +file.FileName;

			if(File.Exists(file.FileName)) 
			{
				pictureBox1.Image=Image.FromFile(file.FileName);
			}

			_imagePath =Path.GetFileName(file.FileName);

			IGrid owner = this.Owner as IGrid; // 若用as轉型且失敗，會傳回null，不會丟出例外
			owner.Display();
			MessageBox.Show("照片已上傳");

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
