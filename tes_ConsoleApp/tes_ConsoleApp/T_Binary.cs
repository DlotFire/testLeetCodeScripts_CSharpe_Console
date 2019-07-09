using System.Collections;
using System.Collections.Generic;
using System;

public class T_Binary
{
    public int FunctionGetBinaryParameter = 10;//getBinary函数参数
    public uint FunctiondHammingWeightParameter = 3;//HammingWeight函数参数
    public string str1;
    public string str2;

    public T_Binary()
    {
        Console.WriteLine("===== T_Binary Construct! =====");
        //Console.WriteLine(Convert.ToString(FunctionGetBinaryParameter, 2));

        //GetBinary(FunctionGetBinaryParameter);
        TesShiftBinary();

        //Console.WriteLine(HammingWeight(FunctiondHammingWeightParameter));

        //Console.WriteLine(IsPowerOFtwo(FunctionGetBinaryParameter));
        //Console.WriteLine(AddBinary(str1, str2));//!
    }

    /// <summary>
    /// 获取二进制数
    /// </summary>
    /// <param name="num"></param>
    private void GetBinary(int num)
    {
        char[] charbit = new char[32];
        for (int i = 0; i < 32; i++)
        {
            if (((num >> i) & 1).Equals(1))
            {
                charbit[31 - i] = '1';
            }
            else
            {
                charbit[31 - i] = '0';
            }
        }
        Console.WriteLine(new string(charbit));
    }

    /// <summary>
    /// 返回其二进制表达式中数字位数为 ‘1’ 的个数
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private int HammingWeight(uint n)
    {
        int result = 0;
        for (int i = 0; i < 32; i++)
        {
            if (((n >> i) & 1).Equals(1))
            {
                result++;
            }
        }
        return result;
    }

    /// <summary>
    /// 判断它是否是 2 的幂次方
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private bool IsPowerOFtwo(int n)
    {
        int result = 0;
        for (int i = 0; i < 32; i++)
        {
            if (((n >> i) & 1).Equals(1))
            {
                result++;
            }
            if (result > 1)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 判断它是否是 2 的幂次方
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private bool IsPowerOFtwo2(int n)
    {
        if (n <= 0)
            return false;
        if ((n & (n - 1)) == 0)
            return true;
        return false;
    }

    /// <summary>
    /// 测试进制位移
    /// </summary>
    private void TesShiftBinary()
    {
        Console.WriteLine(2 << 1);//
        Console.WriteLine(3 << 4);//3 * 2的4次方
        Console.WriteLine(2 << 4 + 2 << 5);

        char a = '0';
        //char b = '1';
        a = (char)(a ^ (3 << 4));
        Console.WriteLine(Convert.ToInt32("10101", 2));

    }

    /// <summary>
    /// 给定两个二进制字符串，返回他们的和（用二进制表示）
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private string AddBinary(string a, string b)
    {
        //"10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101"
        //"110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"
        List<char> listChar = new List<char>(a);
        //char bit = '0';
        for (int i = 0; i < b.Length; i++)
        {
            if (i >= listChar.Count)
            {
                listChar.Add('0');
            }
            listChar[i] += (char)(b[i] ^ '0');
            //if (listChar[i] >= 50)
            //{
            //    listChar[i] = '0';
            //}
        }

        //for (int i = 0; i < listChar.Count; i++)
        //{
        //    if (listChar[i] >= 50)
        //    {

        //    }
        //}

        //return Convert.ToString(Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2), 2);
        return new string(listChar.ToArray());
    }
}
