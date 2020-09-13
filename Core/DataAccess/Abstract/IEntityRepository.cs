using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> Include(params Expression<Func<T, object>>[] expressions);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
