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

namespace FormMain.Garage
{
	public partial class FormGarageNew : Form
	{
		private int _memberId;
		private string _imageFile = @"C:\Users\ispan\Desktop\汽車照\";
		private string _imagePath;
		public FormGarageNew(int memberId)
		{
			InitializeComponent();
			_memberId = memberId;
		}

		private void butCreate_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtPrice.Text, out int uprice);
			if (!isInt)
			{
				MessageBox.Show("請輸入正整數");
				return;
			}
			var item = new GarageNewDto
			{
				Brand = comboBoxBrand.Text,
				Model = txtModel.Text,
				Type = comboBoxType.Text,
				Price = uprice,

			};

			CarRepository repo = new CarRepository();
            int carId = repo.Create(item, _memberId);

			

			var dto = new GarageNewDsDto
			{
				Fuel = txtFuel.Text,
				Year = txtYear.Text,
				Description = txtDescription.Text,
				Image = _imagePath,



			};
			string imagePath = @"C:\Users\ispan\Desktop\汽車照\" + dto.Image;
			pictureBox1.Image = Image.FromFile(imagePath);


			repo.Reload(dto, carId);
			

			IGrid owner = this.Owner as IGrid; // 若用as轉型且失敗，會傳回null，不會丟出例外
			owner.Display();

			MessageBox.Show("已新增成功");

			this.DialogResult = DialogResult.OK;

		}

		private void FormGarageNew_Load(object sender, EventArgs e)
		{
			
		}

		private void butImageLoad_Click(object sender, EventArgs e)
		{
			var file = new OpenFileDialog();
			file.Filter = "Image Files *(*.jpg,*.jpeg,*.png| *.jpg;*.jpeg;*.png";

			var result = file.ShowDialog();

			if (result != DialogResult.OK)
			{
				return;
			}

			string imageResult = _imageFile + file.FileName;

			if (File.Exists(file.FileName))
			{
				pictureBox1.Image = Image.FromFile(file.FileName);
			}

			_imagePath = Path.GetFileName(file.FileName);

			IGrid owner = this.Owner as IGrid; // 若用as轉型且失敗，會傳回null，不會丟出例外
			owner.Display();
			MessageBox.Show("照片已上傳");

		}
	}
}
