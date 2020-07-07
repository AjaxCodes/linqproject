using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkSheet
{
    class LinqList
    {
        static void Main1()
        {
            var list = new List<string>() { "the", "bike", "this", "it", "thenth", "mathamatics" };
            // Use extension method.
            var names = list.Where (l => l.Contains("th"));
            // Use instance method.
            foreach (var item in names )
            {
                Console.WriteLine();
            }
            
        }
    }
}
