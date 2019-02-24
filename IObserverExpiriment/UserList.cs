using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverExpiriment.Model;

namespace IObserverExpiriment
{
	public class UserList : IObservable<User>
	{
		public UserList()
		{
			observers = new List<IObserver<User>>();
		}

		private List<IObserver<User>> observers;

		public IDisposable Subscribe(IObserver<User> observer)
		{
			throw new NotImplementedException();
		}
	}
}
