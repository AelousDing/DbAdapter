using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectString = "Server=192.168.70.237;Database=Test;User ID = ztkm;Password = admin_2019;Trusted_Connection=false;MultipleActiveResultSets=true";

            SqlSugarDbAdapter adapter = new SqlSugarDbAdapter(connectString);
            var products = adapter.ToList<Models.Product>(p => p.ProductId == 1);


            Console.ReadLine();
        }
    }
}
