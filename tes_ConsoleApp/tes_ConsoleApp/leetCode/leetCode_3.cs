using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp
{
    /// <summary>
    /// 初级算法 - 字符串
    /// </summary>
    class leetCode_3
    {
        public leetCode_3()
        {
            //ReverseString_init();
            FirstUniqChar_init();
        }

        /// <summary>
        /// 反转字符串 - 初始化 (通过)
        /// </summary>
        private void ReverseString_init()
        {
            char[] s = new char[] { 'h', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            //ReverseString(ref s);

            string str = new string(s);
            ReverseVowels(ref str);
            s = str.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s[i]} ");
            }
        }

        /// <summary>
        /// 反转字符串 (通过)
        /// </summary>
        /// <param name="s"></param>
        private void ReverseString(ref char[] s)
        {
            int leng = s.Length / 2;
            int charLeng = s.Length - 1;
            for (int i = 0; i < leng; i++)
            {
                //temp = s[i];
                //s[i] = s[charLeng - i];
                //s[charLeng - i] = temp;
                s[i] ^= s[charLeng - i];
                s[charLeng - i] ^= s[i];
                s[i] ^= s[charLeng - i];
            }
        }
        
        /// <summary>
        /// 反转字符串中的元音字母 (通过,232ms)
        /// </summary>
        /// <param name="s"></param>
        private string ReverseVowels(ref string s)
        {
            List<int> index = new List<int>();
            List<char> value = new List<char>();
            HashSet<char> vowels = 
                new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    index.Add(i);
                    value.Add(s[i]);
                }
            }

            char[] cha = s.ToCharArray();
            for (int i = 0; i < index.Count; i++)
            {
                cha[index[i]] = value[index.Count - 1 - i];
            }
            s = new string(cha);
            return s;
        }

        /// <summary>
        /// 寻找第一个不重复的字符（未通过）
        /// </summary>
        private void FirstUniqChar_init()
        {
            //string s = "leetcode";
            //string s = "loveleetcode";
            //string s = "aadadaad";
            string s = "";
            //string s = Globe.Instance.FileReadLongValue("Resources/LeetCode_3_longStr.txt");
            
            Console.WriteLine(FirstUniqChar_1(ref s));
        }

        /// <summary>
        /// 寻找第一个不重复的字符
        /// (大部分通过，但是有一个长达31713的字符串超时了，没通过)
        /// </summary>
        /// <param name="s"></param>
        /// <returns>返回它的索引。如果不存在，则返回 -1</returns>
        private int FirstUniqChar_1(ref string s)
        {
            char[] cha = s.ToCharArray();
            int len = cha.Length;
            if (len == 1)
            {
                return 0;
            }
            bool[] bl = new bool[len];
            int UniqIndex = -1;
            for (int i = 0; i < len - 1; i++)
            {
                if (bl[i])
                {
                    continue;
                }

                for (int j = i + 1; j < len; j++)
                {
                    if (cha[i] == cha[j])
                    {
                        bl[i] = true;
                        bl[j] = true;
                    }
                }
            }

            for (int i = 0; i < len; i++)
            {
                if (!bl[i])
                {
                    UniqIndex = i;
                    break;
                }
            }
            return UniqIndex;
        }
        
    }
}
