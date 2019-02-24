using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleList.Model;

namespace SimpleList.Data
{
	public class UserList
	{
		public List<User> Users { get; set; } = new List<User>();

		public UserList()
		{
			Users.Add(new User
			{
				FirstName = "Kees",
				LastName = "Hiemstra",
				CountryName = "Netherlands",
				DeparmentName = "Central management",
				FunctionName = "Admistrator"
			});
			Users.Add(new User
			{
				FirstName = "Jan",
				MiddleName = "de",
				LastName = "Blok",
				CountryName = "Netherlands",
				DeparmentName = "Onsite",
				FunctionName = "Teamlead"
			});
		}
	}
}
