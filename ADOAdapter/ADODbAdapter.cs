using DbAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOAdapter
{
    public class ADODbAdapter : IDbAdapter
    {
        public List<T> ToList<T>()
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(Expression<Func<T, bool>> where) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(Expression<Func<T, bool>>[] whereIf)
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(Expression<Action<T, OrderByType>> orderBy)
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(Expression<Action<T>> groupBy)
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(bool withCache)
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(Expression<Having<T, bool>> having)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ToListAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}
