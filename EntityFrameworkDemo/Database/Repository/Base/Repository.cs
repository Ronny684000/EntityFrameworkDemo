using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;

namespace EntityFrameworkDemo.Database.Repository
{
    public class Repository<E> : IRepository<E> where E : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }
        public void Add(E entity)
        {
            Context.Set<E>().Add(entity);
        }

        public void AddRange(IEnumerable<E> entities)
        {
            Context.Set<E>().AddRange(entities);
        }

        public IEnumerable<E> Find(Expression<Func<E, bool>> predicate)
        {
            return Context.Set<E>().Where(predicate);
        }

        public E Get(int id)
        {
            return Context.Set<E>().Find(id);
        }

        public IEnumerable<E> GetAll()
        {
            return Context.Set<E>().ToList();
        }

        public void Remove(E e)
        {
            Context.Set<E>().Remove(e);
        }

        public void Update(E entity)
        {
            Context.Set<E>().AddOrUpdate(entity);
        }
    }
}
