using System;
using System.Collections.Generic;
using System.Text;
using Shop.Domain;
using System.Linq;

namespace Shop.DataAccess
{
    public class DbControllee
    {
        public void Insert(Entity enttity)
        {
            using(var context = new ShopContext())
            {
                context.Add(enttity);
                context.SaveChanges();
            }
        }

        public bool isUserExists(string name, string password)
        {
            using(var context = new ShopContext())
            {
                var result =
                context.Users
                    .Where(x => x.Email == name)
                    .Where(x => x.Password == password)
                    .ToList();

                if (result.Count > 0)
                    return true;

                return false;
            }
        }
    }
}
