using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Repos
{
    public interface IGenericRepo<T> where T : class 
    {
        T getbyid(int id);
        IEnumerable<T> getall();
        IEnumerable<T> find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Remove(T entity);

        void addRange(IEnumerable<T> ets);
        void RemoveRange(IEnumerable<T> ets);
    }
}
