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
                Console.WriteLine("Enter The size Of Array");
                int option = Convert.ToInt32(Console.ReadLine());
                int size = 0;
                int[] number = new int [option];
                
                for(int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine("enter the element of an Array");
                    size = Convert.ToInt32(Console.ReadLine()); 
                    number[i] = size;
                }
                
                for(int i = 0; i < number.Length; i++)  
                {
                    if (number[i] % 2 == 0)
                    {
                        Console.WriteLine("Its Even Number " + number[i]);
                    }
                    else
                    {
                        Console.WriteLine("Its Odd Number " + number[i]);
                    }
                }
            }
        }
    }
}
    
        

    

