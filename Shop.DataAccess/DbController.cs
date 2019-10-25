using System;
using System.Collections.Generic;
using System.Text;
using Shop.Domain;

namespace Shop.DataAccess
{
    public class DbController
    {
        public void Insert(Entity enttity)
        {
            using(var context = new ShopContext())
            {
                context.Add(enttity);
                context.SaveChanges();
            }
        }

    }
}
