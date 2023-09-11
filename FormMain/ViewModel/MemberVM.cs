
using Carwow.ThreeLayer.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormMain.ViewModel
{
	public class MemberVM
	{
		[Display(Name = "編號")]
		public int Id { get; set; }

		[Display(Name = "會員名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(20, ErrorMessage = "長度不可大於{1}")]
		public string Name { get; set; }

		[Display(Name = "手機號碼")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(10, ErrorMessage = "{0} 長度必須在 {2} 和 {1} 之間。", MinimumLength = 9)]
		public string PhoneNumber { get; set; }

		[Display(Name = "信箱")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(30, ErrorMessage = "長度不可大於{1}")]
		public string Email { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(10, ErrorMessage = "長度不可大於{1}")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(10, ErrorMessage = "長度不可大於{1}")]
		public string Password { get; set; }

    }
	public static class MemberEditExts
	{
		public static MemberDto ToDto(this MemberVM view)
		{
			return new MemberDto
			{
				Id = view.Id,
				Name = view.Name,
				PhoneNumber = view.PhoneNumber,
				Email = view.Email,
				Account = view.Account,
				Password = view.Password,

			};
		}
		public static  MemberVM ToViewModel	(this MemberDto dto)
		{
			return new MemberVM
			{
				Id = dto.Id,
				Name = dto.Name,
				PhoneNumber = dto.PhoneNumber,
				Email = dto.Email,
				Account = dto.Account,
				Password = dto.Password,
			};
		}
	}
}
