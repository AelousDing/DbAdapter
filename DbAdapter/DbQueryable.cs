using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DbAdapter
{
    /// <summary>
    /// select * from T
    /// where **
    /// order by ** asc/desc
    /// group by **
    /// having **
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueryModel<T>
    {
        public Expression<Func<T, bool>> Where { get; set; }
        public Expression<Func<T, bool>>[] WhereIf { get; set; }
        public Expression<Action<T, OrderByType>> OrderBy { get; set; }
        public Expression<Action<T>> GroupBy { get; set; }
        public bool WithCache { get; set; }
        public Expression<Action<T>> Having { get; set; }
    }
}
