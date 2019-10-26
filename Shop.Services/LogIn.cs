using System;
using Shop.Services;
using Shop.Domain;
namespace Shop.Services
{
    public class LogInService
    {
        public bool LogIn(string email, string password)
        {
            
            var userRepo = EntityBuilder.CreateUserRepo();
            if (userRepo.IsExists(email, password))
                return true;

            return false;

        }
    }
}
