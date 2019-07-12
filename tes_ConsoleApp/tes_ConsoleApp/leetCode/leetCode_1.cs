using System;
using System.Diagnostics;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace tes_ConsoleApp
{
    /// <summary>
    /// 初级算法 - 数组1
    /// </summary>
    public class leetCode_1
    {
        public leetCode_1()
        {
            Console.WriteLine("===== LeetCode_1 Construct! =====");
            LeetCode_1_Init();
            //stopwatch = new Stopwatch();
            //Console.WriteLine(Reverse(NumbInt));

            //Console.WriteLine(reverseBits((uint)NumbUint));

            //Console.WriteLine(SingleNumber(nums));
            //Console.WriteLineArray(interscet(nums,nums2));

            //Console.WriteLineArray(PlusOne(nums));
            //MoveZeroes(Globe.numbs);
            //Console.WriteLine(MaxProfit(Globe.numbs));//!

            //IsValidSudoku_init();
            MaxProfit_1_init();
        }

        private void LeetCode_1_Init()
        {
            //Globe.numbs = new int[] { 0, 1, 0, 3, 12 };
            //nums = new int[] { 0, 0, 1 };
            Globe.numbs = new int[] { 7, 1, 5, 3, 6, 4 };

            //nums = new int[] {-1278640323,349172856, 1873509219, 2086212774, 0,
            //    -1001344505, -61069976, 746705870, -173131555, -1898820175,
            //    802998965, -916055673, 344084770, -1664334387, -1886907515,
            //    171107295, -2065649057, -1628881728, -1900147601, -342880452,
            //    -2037018488, -104769833, 0, 0, 374941067, 536619007, -298730590,
            //    -1594869648, 1855390876, 904830187, -809158725, -1923547142, 1340100626,
            //    953054962, 1195315949, 0, 1281604841, 58893147, 2109018765, -928102085,
            //    -348541385, 1222161829, -319162010, -1229679355, 635148638, 1343064576,
            //    1235762604, 808863719, -1399893584, 262412042, 852755753, 2122991509, -439470997,
            //    1284528791, 0, -1255542315, 1381099667, -612012457, 1158700697,
            //    -1931432559, -382355048, 386876825, -410932959, -881191573,
            //    2108126972, 66895034, 571651517, -807893976, 1722089493, 0 };


        }

        /// <summary>
        /// 32位整数反转（通过,68ms）
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private int Reverse(int x)
        {
            long longX = (long)x;
            long bit = x.ToString().Length;
            bit = x >= 0 ? bit : bit - 1;
            //Console.WriteLine(bit);
            long num = 0;
            List<long> listNum = new List<long>();
            for (long i = 0; i < 10; i++)
            {
                longX = Math.DivRem(longX, 10, out num);
                //Console.WriteLine(x);
                listNum.Add(num);
            }

            num = listNum[0];

            for (int i = 1; i < bit; i++)
            {
                num = listNum[i] + num * 10;
                Console.WriteLine(listNum[i] + " --list  " + num);
                //Console.WriteLine(num);
            }

            if (num < -(int)Math.Pow(2, 31) || num > ((int)Math.Pow(2, 31) - 1)) return 0;

            return (int)num;
        }

        /// <summary>
        /// 整数的二进制反转
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private uint ReverseBits(uint n)
        {
            //  2147483648 (10000000000000000000000000000000)
            string str = Convert.ToString(n, 2);
            int strLen = str.Length;
            for (int i = 0; i < 32 - strLen; i++)
            {
                str = str.Insert(0, "0");
            }
            Console.WriteLine(str);
            char[] numChars = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                numChars[i] = str[str.Length - i - 1];
            }

            //for (int i = 0; i < numChars.Length; i++)
            //{
            //    numChars[i] = numChars[i].Equals('1') ? '0' : '1';
            //}

            str = new string(numChars);
            Console.WriteLine(str);
            return Convert.ToUInt32(str, 2);
            //return 0;
        }

        /// <summary>
        /// Char数组每一位取反
        /// </summary>
        /// <returns></returns>
        private char[] ConvertCharArray(char[] numChars)
        {

            for (int i = 0; i < numChars.Length; i++)
            {
                numChars[i] = numChars[i].Equals('1') ? '0' : '1';
            }

            return numChars;
        }

        /// <summary>
        /// 判断一个整数数组是否存在重复元素（通过）
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private bool ContainsDuplicate(int[] nums)
        {
            //         List<int> listNum = new List<int>();
            //         for(int i = 0;i < nums.Length;i++)
            //         {
            //             if (listNum.Contains(nums[i]))
            //                 return true;
            //             else
            //                 listNum.Add(nums[i]);

            //         }
            //         return false;

            // for(int i = 0;i < nums.Length;i++)
            // {
            //     for(int j = i+1; j<nums.Length;j++)
            //     {
            //         if(nums[i] == nums[j])
            //             return true;
            //     }
            // }
            // return false;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 找出那个只出现了一次的元素（通过）
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int SingleNumber(int[] nums)
        {
            List<int> SingleNum = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (SingleNum.Contains(nums[i]))
                {
                    SingleNum.Remove(nums[i]);
                }
                else
                {
                    SingleNum.Add(nums[i]);
                }
            }
            return SingleNum[0];
        }

        /// <summary>
        /// 计算两个数组的交集（通过）
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        private int[] Interscet(int[] nums1, int[] nums2)
        {
            List<int> nums1List = new List<int>(nums1.Length < nums2.Length ? nums1 : nums2);
            List<int> nums2List = new List<int>(nums1.Length < nums2.Length ? nums2 : nums1);
            List<int> interscetList = new List<int>();
            for (int i = 0; i < nums1List.Count; i++)
            {
                for (int j = 0; j < nums2List.Count; j++)
                {
                    if (nums1List[i].Equals(nums2List[j]))
                    {
                        interscetList.Add(nums2List[j]);
                        //nums1List.Remove(nums2List[j]);
                        nums2List.Remove(nums2List[j]);
                        break;
                    }
                }

            }
            return interscetList.ToArray();
        }

        /// <summary>
        /// 数组加1（通过）
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        private int[] PlusOne(int[] digits)
        {
            digits[digits.Length - 1]++;
            if (digits[digits.Length - 1] >= 10)
            {
                int nextNum = 0;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    digits[i] += nextNum;
                    nextNum = 0;
                    if (digits[i] >= 10)
                    {
                        digits[i] = 0;
                        nextNum = 1;
                    }
                }
                if (nextNum > 0)
                {
                    int[] result = new int[digits.Length + 1];
                    result[0] = 1;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        result[i + 1] = digits[i];
                    }
                    return result;
                }

            }

            return digits;

            //int[] result = new 
        }

        /// <summary>
        /// 移动零 (通过)
        /// </summary>
        /// <param name="nums"></param>
        private int[] MoveZeroes(int[] nums)
        {
            List<int> listInt = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    listInt.Add(nums[i]);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < listInt.Count)
                {
                    nums[i] = listInt[i];
                }
                else
                {
                    nums[i] = 0;
                }
            }

            Globe.PritnfArray(ref nums);

            return nums;
        }

        private void MaxProfit_1_init()
        {
            //int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int[] prices = new int[] { 2, 4, 1 };
            //int[] prices = new int[] { 7, 6, 4, 3, 1 };

            int result = MaxProfit_1(ref prices);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 买卖一支股票（只交易一次），计算所能获取的最大利润（通过,1288ms）
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        private int MaxProfit_1(ref int[] prices)
        {
            int leng = prices.Length;
            if (leng < 1)
            {
                return 0;
            }
            int result = 0;
            int minValue = prices[0];
            //int maxValue = 0;
            for (int i = 0; i < leng; i++)
            {
                if (prices[i] <= minValue)
                {
                    minValue = prices[i];
                    for (int j = i; j < leng; j++)
                    {
                        if (prices[j] - minValue >= result)
                        {
                            result = prices[j] - minValue;
                        }
                    }
                }
            }            
            
            return result;
        }

        /// <summary>
        /// 判断一个 9x9 的数独是否有效 - 初始数据
        /// </summary>
        private void IsValidSudoku_init()
        {
            char[][] board = new char[][]
            {
                new char[]  {'5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[]  {'6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[]  {'.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[]  {'8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[]  {'4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[]  {'7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[]  {'.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[]  {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[]  {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };//不规则数组

            bool bl = IsValidSudoku(ref board);
            Console.WriteLine(bl);
        }

        /// <summary>
        /// 判断一个 9x9 的数独是否有效(未通过)
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool IsValidSudoku(ref char[][] board)
        {
            HashSet<char> arow = new HashSet<char>();
            HashSet<char> column = new HashSet<char>();
            char value = '1';
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    

                    value = board[i + j * 3][0];
                    if (value == '.')
                    {
                        continue;
                    }
                }
            }

            //for (int i = 0; i < board.Length; i++)
            //{
            //    HashSet<char> rankAarry = new HashSet<char>();
            //    for (int j = 0; j < board[i].Length; j++)
            //    {
            //        if (board[i][j] == '.')
            //        {
            //            continue;
            //        }
            //        if (rankAarry.Contains(board[i][j]))
            //        {
            //            return false;
            //        }
            //        rankAarry.Add(board[i][j]);
            //        //Console.Write(board[i][j]);
            //    }
            //    //Console.Write('\n');
            //}
            return true;
        }
    }
}