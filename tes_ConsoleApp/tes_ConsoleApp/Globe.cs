using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp
{
    public static class Globe
    {
        public static int NumbInt = 12;
        public static uint NumbUint = 1230456;
        public static int[] numbs = new int[] { 52, 1, 32, 0, -342, 3002, 99 };
        public static int[] nums;
        public static int[] nums2;


        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="nums"></param>
        public static void PritnfArray(ref int[] nums)
        {
            PritnfArray(ref nums, nums.Length);
        }

        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="nums"></param>
        public static void PritnfArray(ref int[] nums, int length)
        {
            if (nums.Length < length)
            {
                throw new IndexOutOfRangeException(nums.ToString());
            }
            Console.WriteLine($"---length: {length} , printfArray:");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
