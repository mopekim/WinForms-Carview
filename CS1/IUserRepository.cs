using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
	public interface IUserRepository
	{
		Members GetByAccount(string account);
		Members Get(string memberId);

	}
	public class Members
	{
        public int Id { get; set; }
        public string  Account { get; set; }
        public string  Password { get; set; }
    }
}
