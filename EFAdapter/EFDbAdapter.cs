using DbAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFAdapter
{
    public class EFDbAdapter : IDbAdapter
    {
        public List<T> ToList<T>(Expression<Func<T, bool>> where) where T : class
        {
            using (var context = new EFAdapterDbContext())
            {
                return context
                    .Set<T>()
                    .Where(where)
                    .ToList();
            };
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

        public List<T> ToList<T>()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ToListAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}
