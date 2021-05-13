using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DbAdapter
{
    public interface IDbAdapter
    {
        List<T> ToList<T>();
        List<T> ToList<T>(Expression<Func<T, bool>> where) where T : class;
        List<T> ToList<T>(Expression<Func<T, bool>>[] whereIf);
        List<T> ToList<T>(Expression<Action<T, OrderByType>> orderBy);
        List<T> ToList<T>(Expression<Action<T>> groupBy);
        List<T> ToList<T>(bool withCache);
        //List<T> ToList<T>(Expression<Func<T, bool>> having);
        Task<List<T>> ToListAsync<T>();
    }
}
