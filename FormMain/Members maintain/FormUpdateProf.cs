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

namespace FormMain
{
	public partial class FormUpdateProf : Form
	{
		private int _memberId;
		public FormUpdateProf(int memberId)
		{
			_memberId = memberId;
			InitializeComponent();
		}

		private void FormUpdateProf_Load(object sender, EventArgs e)
		{
			MemberRepository repo = new MemberRepository();
			MemberService service = new MemberService(repo);

			
			MemberDto dto = service.Get(this._memberId);
			MemberVM vm = dto.ToViewModel();

			txtName.Text = vm.Name;
			txtPhoneNumber.Text = vm.PhoneNumber;
			txtEmail.Text = vm.Email;
			lblAccount.Text = vm.Account;
			txtPwd.Text = vm.Password;

		}

		private void butUpdate_Click(object sender, EventArgs e)
		{
			var vm = new MemberVM
			{
				Id = _memberId,
				Name = txtName.Text,
				PhoneNumber = txtPhoneNumber.Text,
				Email = txtEmail.Text,
				Account=lblAccount.Text,
				Password = txtPwd.Text,

			};

			MemberDto dto = vm.ToDto();
			MemberRepository repo = new MemberRepository();
			MemberService service = new MemberService(repo);
			try
			{
				service.Update(dto);

			}catch(Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
				return;
			}
			MessageBox.Show("已更新成功");
			

			this.DialogResult = DialogResult.OK;
		}
	}
}
