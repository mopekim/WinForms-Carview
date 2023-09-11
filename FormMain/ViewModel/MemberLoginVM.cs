using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain.ViewModel
{
	public class MemberLoginVM
	{
		[Display(Name = "編號")]
		public int Id { get; set; }
        [Display(Name = "帳號")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(10, ErrorMessage = "長度不可大於{1}")]

		public string Account { get; set; }
		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(10, ErrorMessage = "長度不可大於{1}")]
		public string Password { get; set; }    
    }
}
