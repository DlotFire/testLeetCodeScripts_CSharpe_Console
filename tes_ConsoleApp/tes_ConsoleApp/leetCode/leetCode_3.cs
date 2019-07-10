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
            Console.WriteLine("===== LeetCode_3 Construct! =====");

            ReverseString_init();
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
    }
}
