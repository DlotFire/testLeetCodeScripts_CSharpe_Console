using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;

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
            Type[] types = Assembly.GetAssembly(typeof(Program)).GetTypes();
            string typeName;
            for (int i = 0; i < types.Length; i++)
            {
                typeName = types[i].Name;
                if (typeName.Contains("leetCode"))
                {
                    Console.WriteLine($"\n======== {typeName} Construct! ========");
                    types[i].GetConstructor(new Type[0]).Invoke(null);
                }
            }
            stopwatch.Stop();

            Console.WriteLine("\n==== Program End =====");
            Console.WriteLine($" |-- stopWatch leetCode:{stopwatch.ElapsedMilliseconds}\n");
            stopwatch.Reset();
        }

    }
}
