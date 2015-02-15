namespace Problem_1.StringBuilder_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder("Hello Extension Methods heLLo");
            string substring = result.Substringmodif(2, 10);
            Console.WriteLine(substring);
            string removeText = result.RemoveText("hello");
            Console.WriteLine(removeText);
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums.AppendAll());
            List<string> str = new List<string> { "qw", "as", "zx", "d  c ", "FF" };
            Console.WriteLine(str.AppendAll());
        }
    }
}
