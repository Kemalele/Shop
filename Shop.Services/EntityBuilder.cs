using System;
using System.Collections.Generic;
using System.Text;
using Shop.DataAccess;

namespace Shop.Domain
{
    public static class EntityBuilder
    {
        public static User CreateUser(string phoneNumber, string email,string address,string password)
        {
            return new User
            {
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address,
                Password = password
            };
        }

        public static DbController CreateDbController()
        {
            return new DbController();
        }
    }
}
