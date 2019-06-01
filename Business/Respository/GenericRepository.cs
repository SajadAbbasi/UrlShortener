using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        public EFFirstContext context;
        public DbSet<T> dbset;
        public GenericRepository(EFFirstContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,string includeProperties = "")
        {
            IQueryable<T> query = dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }

        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

    }
}
