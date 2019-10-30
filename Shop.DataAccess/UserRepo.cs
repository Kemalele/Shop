using System;
using Shop.Domain;
using Shop.DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Shop.DataAccess
{
    public class UserRepo : BaseRepo<User>
    { 

        public bool IsExists(string email, string password)
        {
            using (Context)
            {
                var result =
                Context.Users
                 .Where(x => x.Email == email)
                 .Where(x => x.Password == password)
                 .ToList();

                if (result.Count > 0)
                    return true;

                return false;
            }
        }
    }
}
