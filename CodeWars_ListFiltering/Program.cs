using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars_ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/
        }

        // First solution
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> output = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item is int x)
                    output.Add(x);
            }
            return output;
        }

        // Refactored solution
        public static IEnumerable<int> GetIntegersFromListTwo(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }
}
