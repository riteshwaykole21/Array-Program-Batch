using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ArrayDemo
{
    public class Lenght
    {
        public void Array1()
        {
            {
                int[] num = { 45, 68, 98, 78, 98, 78 };
                Array.Reverse(num);
                Console.WriteLine("Reverse Array is ");
                foreach (int i in num)
                Console.Write(i + " ");
            }
        }
    }
}
    
        

    

