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
            //FirstUniqChar_init();

            //IsPalindrome_init();

            //IsAnagram_Init();
            MyAtoi_init();
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
        /// 寻找第一个不重复的字符（通过）
        /// </summary>
        private void FirstUniqChar_init()
        {
            //string s = "leetcode";
            //string s = "loveleetcode";
            //string s = "aadadaad";
            string s = "";
            //string s = Globe.Instance.FileReadLongValue("Resources/LeetCode_3_longStr.txt");//一个长达31713的字符

            Console.WriteLine(FirstUniqChar_1(ref s));
        }

        /// <summary>
        /// 寻找第一个不重复的字符（通过）
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

        /// <summary>
        /// 验证它是否是回文串,只考虑字母和数字字符（通过）
        /// </summary>
        private void IsPalindrome_init()
        {
            string s;
            //s = "A man, a plan, a canal: Panama";//true
            //s = "race a car";//false
            //s = "12344321";//true
            s = "abb";//false

            Console.WriteLine(IsPalindrome(ref s));
        }

        /// <summary>
        /// 验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写（通过）
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool IsPalindrome(ref string s)
        {
            char[] cha = s.ToUpper().ToCharArray();
            List<char> chaList = new List<char>();
            char chaValue;
            for (int i = 0; i < s.Length; i++)
            {
                chaValue = cha[i];
                if (chaValue < 48 || chaValue > 90)
                {
                    continue;
                }
                if (chaValue > 57 && chaValue < 65)
                {
                    continue;
                }

                chaList.Add(cha[i]);
            }

            int len = chaList.Count / 2;
            bool eventNums = chaList.Count % 2 == 0;
            int offes = eventNums ? 1 : 0;
            int count = eventNums ? len : len + 1;
            for (int i = 0; i < count; i++)
            {
                if (chaList[len + i] != chaList[len - offes - i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 判断 t 是否是 s 的字母异位词（通过）
        /// </summary>
        private void IsAnagram_Init()
        {
            string s, t;
            s = "anagram"; t = "nagaram";//true
            //s = "rat"; t = "car";//false
            //s = ""; t = "";//true;
            Console.WriteLine(IsAnagram(ref s, ref t));
        }

        /// <summary>
        /// 判断 t 是否是 s 的字母异位词(通过)
        ///   数量、种类相同，排列不同
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        private bool IsAnagram(ref string s, ref string t)
        {
            if (s.Length != t.Length)
                return false;

            bool isAnagr = true;
            bool sameWordOnbit = true;

            byte[] DictS = new byte[256];
            Byte[] DictT = new byte[256];

            for (int i = 0; i < s.Length; i++)
            {
                DictS[s[i]]++;
                DictT[t[i]]++;

                if (s[i] == t[i] && !sameWordOnbit)
                {
                    sameWordOnbit = true;
                }
            }

            for (int i = 0; i < DictS.Length; i++)
            {
                if (DictS[i] != DictT[i])
                {
                    isAnagr = false;
                }
            }

            return isAnagr & sameWordOnbit;
        }

        private void MyAtoi_init()
        {
            string s;
            //s = "42";
            //s = "   -42";
            //s = "4193 with words";
            //s = "words and 987";//0
            //s = "-91283472332";//-2147483648
            s = "+-2";//0

            Console.WriteLine(MyAtoi(ref s));
        }

        /// <summary>
        /// 实现一个atoi函数，将字符串转换成整数（通过）
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int MyAtoi(ref string str)
        {
            double result = 0;
            bool positive = true;
            char cha;
            for (int i = 0; i < str.Length; i++)
            {
                cha = str[i];
                if (cha == 32)
                {
                    continue;
                }
                else if (cha == '-' || cha == '+' || (str[i] >= 48 && str[i] <= 57))
                {
                    positive = !(cha == '-');
                    if (cha == '-' || cha == '+')
                    {
                        i++;
                        if (i >= str.Length)
                        {
                            break;
                        }
                    }
                    while (str[i] >= 48 && str[i] <= 57)
                    {
                        result *= 10;
                        result += (str[i] - 48);
                        i++;
                        if (i >= str.Length)
                        {
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    break;
                }
            }

            if (positive)
            {
                return result >= int.MaxValue ? int.MaxValue : (int)result;
            }
            else
            {
                return result <= int.MinValue ? int.MinValue : (int)result * -1;
            }

        }
    }
}
