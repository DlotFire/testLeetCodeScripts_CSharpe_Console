using System;
using System.Diagnostics;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class leetCode_1
{
    public int NumbInt = 12;
    public uint NumbUint = 1230456;
    public int[] nums;
    public int[] nums2;

    //private Stopwatch stopwatch;

    public leetCode_1()
    {
        //nums = new int[] { 0, 1, 0, 3, 12 };
        nums = new int[] { 0, 0,1};

        //stopwatch = new Stopwatch();
        //Console.WriteLine(Reverse(NumbInt));

        //Console.WriteLine(reverseBits((uint)NumbUint));

        //Console.WriteLine(SingleNumber(nums));
        //Console.WriteLineArray(interscet(nums,nums2));

        //Console.WriteLineArray(PlusOne(nums));
        PritnfArray(MoveZeroes(nums));
    }

    /// <summary>
    /// 打印数组
    /// </summary>
    /// <param name="nums"></param>
    private void PritnfArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }

    /// <summary>
    /// 32位整数反转
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
    private uint reverseBits(uint n)
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
    /// 找出那个只出现了一次的元素
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
    /// 计算两个数组的交集
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    private int[] interscet(int[] nums1, int[] nums2)
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
    /// 数组加1
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
    /// 移动零
    /// </summary>
    /// <param name="nums"></param>
    private int[] MoveZeroes(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].Equals(0))
            {
                for (int j = i; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j] ^ nums[j + 1];
                    nums[j + 1] = nums[j] ^ nums[j + 1];
                    nums[j] = nums[j] ^ nums[j + 1];
                }
            }
        }
        return nums;
    }
}