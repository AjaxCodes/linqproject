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
        static void Main2() // ask michael, this would be skip one(index 0), why am i tied up on returning the first michael, 
                            //silly AJ trix are for kids
        {
            List<string> names = new List<string>() { "mike", "brad", "nevin", "zack", "mike" };

            var skipDuplicates = names.Skip(4);
            foreach (var value in skipDuplicates)
            {
                Console.WriteLine("SKIP 0: {0}", value);
            }
           
        }


        static void Main3() 
        {
            List<string> namesClassGrades = new List<string>() 
            { 
                "80, 100, 92, 89, 65",
                "93, 81, 78, 84, 69",
                "73, 88, 83, 99, 69",
                "98, 100, 66, 74, 55"
            };




        }





    }




}
