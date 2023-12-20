using App.DataAccess.Context;
using App.Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Implementation
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        public readonly ApplicationDbContext _dbcontext;

        public GenericRepo(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add(T entity)
        {
            _dbcontext.Set<T>().Add(entity);
        }

        public void addRange(IEnumerable<T> ets)
        {
            _dbcontext.Set<T>().AddRange(ets);
        }

        public IEnumerable<T> find(Expression<Func<T, bool>> expression)
        {
          return  _dbcontext.Set<T>().Where(expression);
        }

        public IEnumerable<T> getall()
        {
            return _dbcontext.Set<T>().ToList();
        }

        public T getbyid(int id)
        {
            return _dbcontext.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _dbcontext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> ets)
        {
            _dbcontext.Set<T>().RemoveRange(ets);
        }
    }
}
