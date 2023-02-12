using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class Lenght
    {
        public void Array1()
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int[] arr = array;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the element");
                int data = Convert.ToInt32(Console.ReadLine());
                array[i] = data;
            }
            Console.WriteLine("Your elements are given below: ");
            foreach (int item in array)
            {
                Console.WriteLine(item);    
            }
        }
    }
}

    

    

