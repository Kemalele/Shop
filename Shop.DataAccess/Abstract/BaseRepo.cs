using System;
using Shop.DataAccess.Abstract;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Shop.DataAccess;
using Shop.Domain;

namespace Shop
{
    public class BaseRepo<T> : IDisposable,IRepo<T> where T:Entity, new()
    {
        private readonly DbSet<T> _table;

        protected ShopContext Context { get; }

        public BaseRepo(): this(new ShopContext())
        {
            
        }

        public BaseRepo(ShopContext shopContext)
        {
            Context = shopContext;
            _table = Context.Set<T>();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public int Add(T entity)
        {
            _table.Add(entity);
            return Context.SaveChanges();
        }

        public int Add(List<T> entities)
        {
            _table.AddRange(entities);
            return Context.SaveChanges();
        }


        public virtual List<T> GetAll() => _table.ToList();


        public List<T> GetSome(Expression<Func<T, bool>> where) => _table.Where(where).ToList();

    }
}
