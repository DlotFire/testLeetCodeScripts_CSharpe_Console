using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp
{
    public class Globe
    {
        private static Globe instance;
        public static Globe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Globe();
                }
                return instance;
            }
        }

        public int NumbInt = 12;
        public  uint NumbUint = 1230456;
        public  int[] numbs = new int[] { 52, 1, 32, 0, -342, 3002, 99 };
        public  int[] nums;
        public  int[] nums2;


        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="nums"></param>
        public  void PritnfArray(ref int[] nums)
        {
            PritnfArray(ref nums, nums.Length);
        }

        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="nums"></param>
        public  void PritnfArray(ref int[] nums, int length)
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
               
        /// <summary>
        /// 读取一个文件的内容
        /// </summary>
        public  string FileReadLongValue(string SubPath)
        {
            string value = null;

            return value;
        }

        /// <summary>
        /// 获取当前工程路径
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPath()
        {
            string currentPath = Environment.CurrentDirectory;

            return currentPath;
        }
    }
}
