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
            //new leetCode_1();
            //new leetCode_2();
            //new leetCode_3();
            //new leetCode_6();
            Type[] types = Assembly.GetAssembly(typeof(Program)).GetTypes();
            string typeName;
            for (int i = 0; i < types.Length; i++)
            {
                typeName = types[i].Name;
                Console.WriteLine($"\n======== {typeName} ========");
                if (typeName.Contains("leetCode"))
                {
                    types[i].GetConstructor(BindingFlags.CreateInstance | BindingFlags.Public
                        ,null,new Type[] { },null).Invoke(null);
                }
            }
            stopwatch.Stop();

            Console.WriteLine("\n==== Program End =====");
            Console.WriteLine($" |-- stopWatch leetCode:{stopwatch.ElapsedMilliseconds}\n");
            stopwatch.Reset();
        }

    }
}
