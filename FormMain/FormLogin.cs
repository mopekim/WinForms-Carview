using Carwow.ThreeLayer.infrastructure;
using Carwow.ThreeLayer.Service;
using FormMain.Members_maintain;
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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormCreatePro();
			frm.ShowDialog();
		}

		private void butLogin_Click(object sender, EventArgs e)
		{
			MemberRepository repo = new MemberRepository();	
			MemberService service = new MemberService(repo);

			try
			{
				bool validationResult = service.IsValid(txtAccount.Text, txtPwd.Text);
				if(validationResult == false)
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次");
					return;
				}
				
				MemberRepository link =new MemberRepository();
				int memberId = link.GetByAccount(txtAccount.Text).Id;

				//txtAccount.Text =string.Empty; 
				//txtPwd.Text = string.Empty;

				

				var frm = new FormMain(memberId);
				frm.Owner = this;

				this.Hide();

				frm.ShowDialog();
			}catch(Exception ex) {MessageBox.Show(ex.Message); return; }
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			txtAccount.Text = "chunyu";
			txtPwd.Text = "chunyu66";
			//待取消
			//密碼可改星號
		}
	}
}
