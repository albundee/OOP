using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Printextention
    {
        public static void PrintCollection(System.Collections.IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
