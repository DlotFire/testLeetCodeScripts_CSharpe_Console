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

        /* 算法简介
         *  顺序查找又称为线性查找，是一种最简单的查找方法。
         *  适用于线性表的顺序存储结构和链式存储结构。该算法的时间复杂度为O(n)。
         *  
         *  基本思路
         *      从第一个元素m开始逐个与需要查找的元素x进行比较，当比较到元素值相同(即m=x)时返回元素m的下标，
         *      如果比较到最后都没有找到，则返回-1。
         *      
         *  优缺点
         *      缺点：是当n 很大时，平均查找长度较大，效率低；
         *      优点：是对表中数据元素的存储没有要求。另外，对于线性链表，只能进行顺序查找。
        */

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
