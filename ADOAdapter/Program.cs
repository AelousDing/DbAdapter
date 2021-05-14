using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ADODbAdapter adapter = new ADODbAdapter();
            var products = adapter.ToList<Models.Product>(p=>p.ProductId==1);
            Console.ReadLine();
        }
    }
}
