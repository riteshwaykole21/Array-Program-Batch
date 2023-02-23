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
                int[] number = { 20, 30, 40, 50, 60, 70, 80, 68};
                int[] number1 = { 1, 2, 30, 4, 5, 6, 7 };
                int[] number2 = new int[15];
                int num = 0;
                for(int i = 0; i < number.Length; i++)
                {
                    number2[i] = number[i];    
                }
                for(int i = 8; i < number2.Length; i++)
                {
                    number2[i] = number1[num];
                    num ++;
                }
                foreach (int iteam in number2)
                {
                    Console.WriteLine(iteam);
                }

            }
        }
    }
}
    
        

    

