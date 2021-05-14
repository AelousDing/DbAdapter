using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DbAdapter
{
    /// <summary>
    /// 两种Adapter方式
    /// 1、建造者模式+适配器模式，链式调用
    /// 优点：重载时候，避免参数相同类型
    /// 缺点：调用的时候
    /// 2、只有适配器模式
    /// </summary>
    public interface IDbAdapter
    {
        List<T> ToList<T>();
        List<T> ToList<T>(Expression<Func<T, bool>> where) where T : class;
        List<T> ToList<T>(Expression<Func<T, bool>>[] whereIf);
        List<T> ToList<T>(Expression<Action<T, OrderByType>> orderBy);
        List<T> ToList<T>(Expression<Action<T>> groupBy);
        List<T> ToList<T>(bool withCache);
        List<T> HavingToList<T>(Expression<Func<T, bool>> having);
        Task<List<T>> ToListAsync<T>();
    }
}
