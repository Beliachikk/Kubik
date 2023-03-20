using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тау_кита_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            string[] str1 = new string[str.Length];
            str1[0] = str[str.Length / 2];
            for (int i = 1; i <= str.Length / 2; i++)
            {
                str1[i * 2 - 1] =str[str.Length / 2 - i];
                if ((str.Length / 2) + i < str.Length)
                {
                    str1[i * 2] = str[(str.Length / 2) + i];
                }
            }

            for (int i = 0; i < str1.Length; i++)
            {
                string w = str1[i];
                string w1 = "";

                w1 += w[w.Length / 2];
                for (int j = 1; j <= w.Length / 2; j++)
                {
                    w1 += w[(w.Length / 2) - j];
                    if (w.Length / 2 + j < w.Length)
                    {
                        w1 += w[(w.Length / 2) + j];
                    }
                }
                str1[i] =w1;
            }

            foreach (string a in str1)
            {
                Console.Write(a + " ");
            }
        }
    }
}

