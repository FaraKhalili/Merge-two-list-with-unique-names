using System;
using System.Collections.Generic;

namespace Merge_two_list_with_unique_names
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] x = { "ali", "zafar", "goli", "amin", "nikita" };
            string[] y = { "ali", "hassan", "amin" };
            List<string> xl = new List<string>(x);
            List<string> yl = new List<string>(y);


            foreach (string itemx in xl)
            {
                Console.WriteLine(itemx);
            }
            foreach (string item in yl)
            {
                if (!xl.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
