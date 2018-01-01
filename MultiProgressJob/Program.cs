using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                var process = Process.GetCurrentProcess();
                double memory_size = Convert.ToDouble(process.PeakWorkingSet64) / 1024 / 1024;
                Console.WriteLine("进程使用的最大物理内存量 [{0}] M", memory_size);

                Console.ReadLine();
            }
        }
    }
}
