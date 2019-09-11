using System;
using System.Collections.Generic;

namespace tes_ConsoleApp
{
    /// <summary>
    /// 初级算法 - 数组2
    /// </summary>
    class leetCode_2
    {
        int[] numsArray;
        int resluat = 0;

        public leetCode_2()
        {
            numsArray = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            //resluat = RemoveDuplicates(numsArray);
            //resluat = RemoveDuplicates_list(ref numsArray);//1200ms
            //resluat = RemoveDuplicates_hashSet(ref numsArray); //592ms

            //Globe.Instance.PritnfArray(ref numsArray, resluat);
        }

        private void RemoveDuplicates_Init()
        {
            numsArray = new int[] {1,1,1,2,2,2,3,4,
                0, 0, 1, 1, 1, 2, 2, 3, 3, 4,
                13,14,15,6,16,17,18,19,20,21,22,23,24,25,26,27,28,29
                -1278640323,349172856, 1873509219, 2086212774, 0,
                -1001344505, -61069976, 746705870, -173131555, -1898820175,
                802998965, -916055673, 344084770, -1664334387, -1886907515,
                171107295, -2065649057, -1628881728, -1900147601, -342880452,
                -2037018488, -104769833, 0, 0, 374941067, 536619007, -298730590,
                -1594869648, 1855390876, 904830187, -809158725, -1923547142, 1340100626,
                953054962, 1195315949, 0, 1281604841, 58893147, 2109018765, -928102085,
                -348541385, 1222161829, -319162010, -1229679355, 635148638, 1343064576,
                1235762604, 808863719, -1399893584, 262412042, 852755753, 2122991509, -439470997,
                1284528791, 0, -1255542315, 1381099667, -612012457, 1158700697,
                -1931432559, -382355048, 386876825, -410932959, -881191573,
                2108126972, 66895034, 571651517, -807893976, 1722089493, 0 };

        }

        /// <summary>
        /// 从排序数组中删除重复项
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int RemoveDuplicates(ref int[] nums)
        {
            int length = 0;

            return length;
        }

        /// <summary>
        /// 从排序数组中删除重复项 -list处理 (通过)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int RemoveDuplicates_list(ref int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                nums[i] = list[i];
            }
            return list.Count;
        }

        /// <summary>
        /// 从排序数组中删除重复项 -list处理 (通过)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int RemoveDuplicates_hashSet(ref int[] nums)
        {
            HashSet<int> list = new HashSet<int>();
            int[] numsCopy = new int[nums.Length];
            int numsCopyIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                    numsCopy[numsCopyIndex] = nums[i];
                    numsCopyIndex++;
                }
            }

            numsCopy.CopyTo(nums, 0);

            return list.Count;
        }


    }
}
