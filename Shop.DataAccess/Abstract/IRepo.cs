using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Shop.DataAccess.Abstract
{
    public interface IRepo<T>
    {
        int Add(T entity);
        int Add(List<T> entities);
        List<T> GetAll();
        List<T> GetSome(Expression<Func<T, bool>> where);
    }
}
