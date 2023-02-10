using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class Lenght
    {
        public void Array()
        {
            int[] num = { 45, 68, 98, 78, 98, 78 };
            int a, b;
            a = num[0];
            b = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > a)
                {
                    a = num[i];
                }
                else if (num[i] < b)
                {
                    b = num[i];
                }
            }
            Console.WriteLine("Maximum number is " + a);
            Console.WriteLine("Minimum number is " + b);
        }
    }
}   

    

    

