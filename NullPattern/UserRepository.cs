using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPattern
{
	public class UserRepository : IUserRepository
	{

		IQueryable<User> users;
		//	public object GetUser(int ID)
		//	{ 
		//	  List<object> objs=new List<object>(){
		//		new {
		//			Name="Tohid",
		//			ID=1
		//		},
		//		new {
		//		Name="Asghar",
		//		ID=2
		//		}
		//	  };


		//}
		public UserRepository()
		{
			users = new List<User>{
				new User(Guid.NewGuid()),
				new User(Guid.NewGuid()),
				new User(Guid.NewGuid())
			};
			
		}



		public IUser GetByID(Guid guid)
		{
			IUser Specificuser = users.SingleOrDefault(user => user.ID == guid);

			return (Specificuser == null ? Specificuser = new NullUser() : Specificuser);

		}
	}
}
