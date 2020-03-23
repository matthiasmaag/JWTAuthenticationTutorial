using System.Collections.Generic;
using JWTAuthenticationTutorial.Entities;

namespace JWTAuthenticationTutorial.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}