using System;
using System.Collections.Generic;
namespace Shop.DataAcess.Abstract
{
    public interface IRepo<T>
    {
        int Add(T entity);
        int Add(List<T> entities);
        List<T> GetAll();
        List<T> GetSome(Expression<Func<T, bool>> where);
        List<T> GetAll<TSortField>(Expression<Func<T, TSortField>> orderBy,
        bool ascending);
    }
}
