using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace кубик
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader kub = new StreamReader(@"C:\Users\USER\Downloads\Кубик Рубика\input_s1_13.txt");
            string line= kub.ReadLine();
            string[] omygod = line.Split(' ');
            int n = Convert.ToInt32(omygod[0]);
            int m = Convert.ToInt32(omygod[1]);


            string line2 = kub.ReadLine();
            string[] omygod1 = line2.Split(' ');
            int xn = Convert.ToInt32(omygod1[0]);
            int yn = Convert.ToInt32(omygod1[1]);
            int zn = Convert.ToInt32(omygod1[2]);
            for (int i = 0; i < m; i++)
            {
                string oh = kub.ReadLine();
                string[] twist= oh.Split(' ');
                string A = twist[0];
                int K = Convert.ToInt32(twist[1]);
                int S =int.Parse(twist[2]);
                int biba = 0;
                if (A == "Z"&&zn==K)
                {
                    if (S == +1)
                    {
                        zn = zn;
                        biba = yn;
                        yn = n + 1 - xn;
                        xn = biba;
                    }
                    if (S == -1)
                    {
                        zn = zn;
                        biba = xn;
                        xn = n + 1 - yn;
                        yn = biba;
                        
                    }
                }


                if (A == "X" && xn==K)
                {
                    if (S == +1)
                    {
                        xn = xn;
                        biba = zn;
                        zn = n + 1 - yn;
                        yn = biba;
                    }
                    if (S == -1)
                    {
                        xn = xn;
                        biba = yn;
                        yn = n + 1 - zn;
                        zn = biba;
                    } 
                }
                
                if (A == "Y" && yn==K)
                {
                    if (S == +1)
                    {
                      yn = yn;
                      biba = zn;
                      zn = n + 1 - xn;
                      xn = biba;
                    }
                    if (S == -1)
                    {
                      yn = yn;
                      biba = xn;
                      xn = n + 1 - zn;
                      zn = biba;
                        
                    }
                }   
            }
            Console.WriteLine(xn);
            Console.WriteLine(yn);
            Console.WriteLine(zn);
        }
    }
}
