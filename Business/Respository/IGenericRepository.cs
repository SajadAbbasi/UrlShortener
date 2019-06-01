using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IRepository<T>
    {
        T GetById(int id);

        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        void Edit(T entity);

        void Insert(T entity);

        void Delete(T entity);
    }
}
