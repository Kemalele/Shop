using System;
using Microsoft.EntityFrameworkCore;
using Shop.DataAccess;
using Shop.DataAcess.Abstract;
using Shop.Domain;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Shop
{
    public class BaseRepo<T> : IDisposable,IRepo<T> where T:Entity, new()
    {
        private readonly DbSet<T> _table;
        private readonly ShopContext _db;
        protected ShopContext Context => _db;

        public BaseRepo(): this(new ShopContext())
        {
            
        }

        public BaseRepo(ShopContext shopContext)
        {
            _db = shopContext;
            _table = _db.Set<T>();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public int Add(T entity)
        {
            _table.Add(entity);
            return _db.SaveChanges();
        }

        public int Add(List<T> entities)
        {
            _table.AddRange(entities);
            return _db.SaveChanges();
        }


        public virtual List<T> GetAll() => _table.ToList();


        public List<T> GetSome(Expression<Func<T, bool>> where) => _table.Where(where).ToList();

    }
}
