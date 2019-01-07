using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallStartDesign();

            Console.WriteLine("nothing to write....");

        }

        /// <summary>
        /// 执行23种设计模式中的一种
        /// </summary>
        static void CallStartDesign()
        {
            DesignMethod.StartDesign design = new DesignMethod.StartDesign();
            design.Go();
        }
    }
}
