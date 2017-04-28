using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern
{
	class Program
	{
		static IUserRepository UserRepository = new UserRepository();
		static void Main(string[] args)
		{
			var user = UserRepository.GetByID(Guid.NewGuid);
		}
	}
}
