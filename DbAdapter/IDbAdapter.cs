using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAdapter
{
    public interface IDbAdapter
    {
        List<T> ToList<T>(QueryModel<T> query);
        Task<List<T>> ToListAsync<T>();
    }
}
