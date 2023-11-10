using System;
namespace API.Models
{
    public class UserService : IUserService
    {
        public bool Login(string username, string password)
        {
            if (username == "admin")
            {
                if (password == "admin")
                {
                    return true;
                }
            }
            return false;
        }

        public bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }

}

