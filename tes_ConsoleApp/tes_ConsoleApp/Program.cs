using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            //CallStartDesign();

            //Console.WriteLine("nothing to write....");
            stopwatch.Start();
            new T_Binary();
            new SortArray();
            stopwatch.Stop();
            Console.WriteLine($" |-- stopWatch SortArray && T_binary:" +
                $"{stopwatch.ElapsedMilliseconds}\n");
            stopwatch.Reset();

            stopwatch.Start();
            new leetCode_1();
            new leetCode_2();
            new leetCode_3();
            stopwatch.Stop();            

            Console.WriteLine("\n==== Program End =====");
            Console.WriteLine($" |-- stopWatch leetCode:{stopwatch.ElapsedMilliseconds}\n");
            stopwatch.Reset();
        }
        
    }
}
