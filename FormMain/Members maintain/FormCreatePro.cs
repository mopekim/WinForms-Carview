using Carwow.ThreeLayer.Dto;
using Carwow.ThreeLayer.infrastructure;
using Carwow.ThreeLayer.Service;
using FormMain.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain.Members_maintain
{
	public partial class FormCreatePro : Form
	{
		public FormCreatePro()
		{
			InitializeComponent();
		}

		private void butRegister_Click(object sender, EventArgs e)
		{
			var vm = new MemberVM
			{
				Name = txtName.Text,
				PhoneNumber = txtPhoneNumber.Text,
				Email = txtEmail.Text,
				Account = txtAccount.Text,
				Password = txtPwd.Text,

			};

			MemberDto dto = vm.ToDto();
			MemberRepository repo = new MemberRepository();
			MemberService service = new MemberService(repo);

			//service.Create(dto);
			try
			{
				service.Create(dto);

			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
				return;
			}
			MessageBox.Show("已更新成功");


			this.DialogResult = DialogResult.OK;
		}
	}
}
