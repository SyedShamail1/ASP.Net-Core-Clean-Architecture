using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repo;

        public UsersService(IUsersRepository repo)
        {
            _repo = repo;
        }
        public List<Users> GetUsers()
        {   
            List<Users> users = _repo.GetAllUsers();

            List<Users> SNameUsers = new List<Users>();

            foreach (var user in users)
            {
                if (user.FirstName.StartsWith("S"))
                    SNameUsers.Add(user);
            }

            return SNameUsers;  
        }
    }
}
