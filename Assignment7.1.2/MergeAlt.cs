using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._1._2
{
    internal class MergeAlt
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine("The merged string will be merged as so: ");
            Console.WriteLine(MergeStrings(word1, word2));

            string word3 = "ab";
            string word4 = "pqrs";
            Console.WriteLine("The merged string will be merged as so: ");
            Console.WriteLine(MergeStrings(word3, word4));
        }

        public static string MergeStrings(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder(word1.Length + word2.Length);
            int maxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }

                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }
            return sb.ToString();
        }
    }
}
