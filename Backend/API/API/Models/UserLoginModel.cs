using System;
namespace API.Models
{
	public class UserLoginModel
	{
		public string _username;
		public string _password;
		public UserLoginModel(string Username, string Password)
		{
			_username = Username;
			_password = Password;
		}
	}
}

