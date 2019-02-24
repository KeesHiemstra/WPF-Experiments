using System.Collections.Generic;
using System.Collections;
using System.Windows;
using SimpleList.Model;
using SimpleList.Data;

namespace SimpleList
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//public List<User> Users { get; private set; } = new List<User>();
		//public Data.UserList Users;

		public UserList Data = new UserList();
		//public List<User> Users = new Users();

		public MainWindow()
		{
			InitializeComponent();

			InitializeDataGridUserList();
		}

		private void InitializeDataGridUserList()
		{
			DataGridUserList.AutoGenerateColumns = true;
			DataGridUserList.ItemsSource = Data.Users;
		}

		private void ButtonAddHCRecord_Click(object sender, RoutedEventArgs e)
		{
			Data.Users.Add(new User
			{
				FirstName = "Gerrit",
				LastName = "Brommer",
				CountryName = "Netherlands"
			});
		}
	}
}
