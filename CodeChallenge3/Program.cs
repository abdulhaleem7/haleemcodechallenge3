using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "bca";
            char[] str1 = str.ToCharArray();
            string str2 = "kjhabciuy";
            int n = str1.Length;
            string w = "";
            List<string> alpha = new List<string>();
            var f = true;

            for (int i = 0; i < n; i++)
            {
            
                for (int j = n - 1; j >= 0; j--)
                {

                    var temp = str1[i];
                    str1[i] = str1[j];
                    str1[j] = temp;
                    w = new string(str1);
                    if (!alpha.Contains(w))
                    {
                        alpha.Add(w);
                    }
                    str1 = w.ToCharArray();
                }
                str1 = str.ToCharArray();
                for (int j = 0; j <n; j++)
                {

                    var temp = str1[i];
                    str1[i] = str1[j];
                    str1[j] = temp;
                    w = new string(str1);
                    if (!alpha.Contains(w))
                    {
                        alpha.Add(w);
                    }
                    str1 = w.ToCharArray();
                }
                str1 = str.ToCharArray();
            }
            foreach (var item in alpha)
            {
                Console.WriteLine(item);
            }
            foreach (var item in alpha)
            {
                if (str2.Contains(item))
                {
                    f = true;
                    break;
                }
                else
                {
                    f = false;
                  
                }
            }
            Console.WriteLine(f);
        }
       
       


    } 
}
 

    

