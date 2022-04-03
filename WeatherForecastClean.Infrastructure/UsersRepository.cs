using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastClean.Application;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Infrastructure
{
    public class UsersRepository : IUsersRepository
    {
        List<Users> users = new List<Users>()
       {
          new Users {UserID = 1, FirstName = "Syed", LastName = "Shamail", Age = 23},
          new Users {UserID = 2, FirstName = "Test", LastName = "User", Age = 22},
          new Users {UserID = 3, FirstName = "Salman", LastName = "Ahmed", Age = 21},
          new Users {UserID = 4, FirstName = "Test", LastName = "User2", Age = 25}
       };
        public List<Users> GetAllUsers()
        {
            return users;
        }
    }
}
