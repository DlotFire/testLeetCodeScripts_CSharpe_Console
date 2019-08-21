using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes_ConsoleApp.randomCode
{
    /// <summary>
    /// 随机题-简单1
    /// </summary>
    class RandomCode_1
    {
        public RandomCode_1()
        {
            //NumJewelsInStones_init();
            //ToLowerCase_init();

            //UniqueMorseRepresentations_init();
        }

        private void NumJewelsInStones_init()
        {
            string J, S;
            J = "aA"; S = "aAAbbbb";

            Console.WriteLine(NumJewelsInStones(J, S));
        }

        /// <summary>
        /// 宝石与石头（通过）
        /// </summary>
        /// <param name="J"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        private int NumJewelsInStones(string J, string S)
        {
            /*给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。
             * S 中每个字符代表了一种你拥有的石头的类型，你想知道你拥有的石头中有多少是宝石。
             * J 中的字母不重复，J 和 S中的所有字符都是字母。字母区分大小写，因此"a"和"A"是不同类型的石头。*/

            int nums = 0;
            for (int a = 0; a < J.Length; a++)
            {
                for (int b = 0; b < S.Length; b++)
                {
                    if (J[a] == S[b])
                    {
                        nums++;
                    }
                }
            }

            return nums;
        }

        private void ToLowerCase_init()
        {
            string str = "Hello";

            Console.WriteLine(ToLowerCase(str));
        }

        /// <summary>
        /// 大写字母转换成小写字母（通过）
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ToLowerCase(string str)
        {
            char[] cha = new char[str.Length];
            for (byte i = 0; i < str.Length; i++)
            {
                if (str[i] <= 90 && str[i] >= 65)
                {
                    cha[i] = (char)(str[i] + 32);
                }
                else
                {
                    cha[i] = str[i];
                }
            }
            return new string(cha);
        }

        private void  UniqueMorseRepresentations_init()
        {
            string[] words = new string[] { "gin", "zen", "gig", "msg" };

            Console.WriteLine(UniqueMorseRepresentations(words));
        }

        /// <summary>
        /// 唯一摩尔斯密码词(通过)
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        private int UniqueMorseRepresentations(string[] words)
        {
            string[] hashMoscode = new string[] { ".-","-...","-.-.","-..",
                ".","..-.","--.","....","..",".---","-.-",".-..","--","-.",
                "---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-",
                "-.--","--.."};
            
            string scode;
            HashSet<string> recordMoscode = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                scode = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    scode += hashMoscode[ words[i][j] - 97];
                }

                if (!recordMoscode.Contains(scode))
                {
                    recordMoscode.Add(scode);
                }
            }
            

            return recordMoscode.Count;
        }
    }
}
