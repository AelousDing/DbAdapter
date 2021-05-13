using DbAdapter;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarAdapter
{
    public class SqlSugarDbAdapter : IDbAdapter
    {
        private SqlSugarClient db;

        public SqlSugarClient Db
        {
            get { return db; }
            protected set { db = value; }
        }
        public SqlSugarDbAdapter(string connectionString)
        {
            db = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = connectionString,
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
                //ConfigureExternalServices = new ConfigureExternalServices
                //{
                //    DataInfoCacheService = new HttpRuntimeCache()
                //}
            });
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                string s = sql + "\r\n" +
                db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value));
                Console.WriteLine(s);
            };
        }
        public List<T> ToList<T>(Expression<Func<T, bool>> where) where T : class
        {
            return db
                .Queryable<T>()
                .Where(where)
                .ToList();
        }

        public List<T> ToList<T>(Expression<Func<T, bool>>[] whereIf)
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>(Expression<Action<T, DbAdapter.OrderByType>> orderBy)
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

        public Task<List<T>> ToListAsync<T>()
        {
            throw new NotImplementedException();
        }

        public List<T> ToList<T>()
        {
            throw new NotImplementedException();
        }
    }
}
