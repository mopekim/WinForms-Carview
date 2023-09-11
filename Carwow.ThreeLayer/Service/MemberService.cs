using Carwow.ThreeLayer.Dto;
using Carwow.ThreeLayer.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer.Service
{
	public class MemberService
	{
		private readonly MemberRepository _repo;
		public MemberService(MemberRepository repo)
		{
			_repo = repo;
		}

		public void Update (MemberDto dto) 
		{ 
			_repo.Update (dto);
		}
		public MemberDto Get (int memberId)
		{
			return _repo.Get (memberId);
		}
		public void Create(MemberDto dto)
		{
			var data = _repo.Search(dto.Account);
			if (data != null && data.Count > 0) throw new Exception("帳號已存在，請再輸入帳號一次");

			 _repo.Create(dto);
		}
		public bool IsValid(string account, string password)
		{
			//Account,Password必填
			if(string.IsNullOrEmpty(account)) { throw new ArgumentNullException(nameof(account), "帳號必填");}
			if (string.IsNullOrEmpty(password)) { throw new ArgumentNullException(nameof(password), "密碼必填"); }

			//取得單一使用人
			MemberLgDto dto =_repo.GetByAccount(account);
			if (dto == null) { return false; }

			//判斷密碼正確與否
			string passwordInDb = dto.Password;

			//不拘大小寫
			return (passwordInDb.ToLower() == password.ToLower());
		}
	}

}
