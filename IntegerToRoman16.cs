using System;
using System.ComponentModel;


namespace Csharpproject
{
   /* 
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter word");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num);

            Console.WriteLine(IntToRoman(num));
        }
        static string IntToRoman(int num) 
        {
            string res = "";
            int k;
            string result = "";
            string snum = Convert.ToString(num);

            for(int i = 0; i < snum.Length; i++)
            {
                int count = 0;
                k = snum.Length - i - 1;

                Console.WriteLine($"i = {i}              k = {k}");

                string s = Convert.ToString(snum[i]);
                
                for(int j = 0; j < int.Parse(s); j++)
                {
                    result = result + NumToChar(k);  

                    count++;

                    Console.WriteLine($"j = {j}              result = {result}");
                }

                res = res + PearSimbols(result[result.Length - 1], count);
            }
            return res;
        }
        static char NumToChar(int n)
        {
            switch (n)
            {
                case 0:
                    return 'I';
                case 1:
                    return 'X';
                case 2:
                    return 'C';
                case 3:
                    return 'M';
                default: 
                    return '?';
            }
        }
        static string PearSimbols(char x, int c)
        {
            string result = "";
            string s = "";
            string k = "";

            switch (x)
            {
                case 'I':
                    s = "V";
                    break;
                case 'X':
                    s = "L";
                    break;
                case 'C':
                    s = "D";
                    break;
                case 'M':
                    for (int i = 0; i < c; i++)
                    {
                        s = s + "M";
                    }
                    break;
                default:
                    s = "?";
                    break;
            }
            
            switch (x)
            {
                case 'I':
                    k = "X";
                    break;
                case 'X':
                    k = "C";
                    break;
                case 'C':
                    k = "M";
                    break;
                default:
                    k = "?";
                    break;
            }

            if (c < 4)
            {
                for (int i = 0; i < c; i++)
                {
                    result = result + x;
                }
            }
            if (c == 4)
            {
                result = x + s; 
            }
            if(c == 5)
            {
                result = s;
            }
            if(c > 5 && c < 9)
            {
                result = s;
                for (int i = 0; i < c - 5; i++)
                {
                    result = result + x;
                }
            }
            if (c == 9)
            {
                if(x == 'M')
                {
                    result = s;
                }
                else
                {
                    result = x + k;
                }
            }
            return result;
        }
    }*/
}