using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPattern
{
	class User : IUser
	{
		public User(Guid id)
		{
			ID = id;
		}



		public Guid ID { get; set; }

	}
}
