using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList.Model
{
	public class User : Person
	{
		public User()
		{
		}

		public User(string functionName, string deparmentName, User manager)
		{
			FunctionName = functionName;
			DeparmentName = deparmentName;
			Manager = manager;
		}

		public string DeparmentName { get; set; }
		public string FunctionName { get; set; }
		public User Manager { get; set; }
	}
}
