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
	public partial class FormMain : Form
	{
		private int _memberId;
		public FormMain(int memberId)
		{
			InitializeComponent();
			_memberId = memberId;
		}

		private void butPM_Click(object sender, EventArgs e)
		{
			var frm =new FormUpdateProf(_memberId);
			frm.ShowDialog();
		}

		private void butPS_Click(object sender, EventArgs e)
		{
			var frm =new FormPriceSearch();
			frm.ShowDialog();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void butGarage_Click(object sender, EventArgs e)
		{
			var frm = new FormGarage(_memberId);
			frm.ShowDialog();
		}
	}
}
