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
            int[] num = {45, -68, 98, -78, 99, -75 };
            int a, b;
            a = num[0];
            b = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if(num[i] < 0)
                {
                    Console.WriteLine("The Negetive Number is" + num[i]);
                }
            }
        }
    }
}   

    

    

