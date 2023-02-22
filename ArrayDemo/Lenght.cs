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
                Console.WriteLine("Enter The Element Of An Array");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] Arr = new int[size];
                Console.WriteLine("----------------------------------");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter The Element");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Arr[i] = number;
                }
                Console.WriteLine("---------------------------------------------------");
                foreach (int item in Arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
    
        

    

