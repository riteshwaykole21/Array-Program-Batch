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
            int i, n, sum = 0;
            for (i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine(sum);
        }
    }
}
