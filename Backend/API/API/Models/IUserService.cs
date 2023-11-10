using System;
namespace API.Models
{
	public interface IUserService
	{
        bool Register(string username, string password);
        bool Login(string username, string password);
    }
}

