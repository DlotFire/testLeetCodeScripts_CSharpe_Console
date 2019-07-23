using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp.查找算法
{
    class SearchAlgorithm_1
    {
        public SearchAlgorithm_1()
        {
            BinarySearch_1_init();
        }

        private void BinarySearch_1_init()
        {
            int[] array = new int[170];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            int reslut = BinarySearch_1(ref array, 16, array.Length);
            Console.WriteLine($" reslut is {reslut}");
        }

        /// <summary>
        /// 二分查找（折半查找）(测试)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int BinarySearch_1(ref int[] array, int value, int n)
        {
            int low = 0, hight = n - 1, middle = 0;
            int loopNum = 0;
            while (low <= hight)
            {
                loopNum++;
                Console.WriteLine($"loopnums: {loopNum}.");
                middle = (low + hight) / 2;
                if (array[middle] == value)
                {
                    return middle;
                }
                if (array[middle] > value)
                {
                    hight = middle;
                }
                if (array[middle] < value)
                {
                    low = middle;
                }
            }
            return -1;
        }
    }
}
