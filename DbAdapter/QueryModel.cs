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
    /// order by **
    /// group by **
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueryModel<T>
    {
        public Expression<Func<T,bool>> Where { get; set; }
        public Expression<Action<T>> OrderBy { get; set; }

    }
}
