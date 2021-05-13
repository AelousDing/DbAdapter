using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EFDbAdapter adapter = new EFDbAdapter();
            var products = adapter.ToList<Models.Product>(p => p.ProductId == 1);

            Console.ReadLine();
        }
    }
}
