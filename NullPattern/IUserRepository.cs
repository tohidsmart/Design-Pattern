using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPattern
{
	interface IUserRepository
	{
		IUser GetByID(Guid  guid);
	}
}
