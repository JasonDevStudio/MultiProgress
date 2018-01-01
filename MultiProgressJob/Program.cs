using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiProgressJob
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                decimal.TryParse(args.FirstOrDefault(), out var number);
                Console.WriteLine(number);
                Console.ReadLine();
            }
        }
    }
}
