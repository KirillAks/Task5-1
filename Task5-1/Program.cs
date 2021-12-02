using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        // Сформировать одномерный массив из 7 чисел и определить среднее арифметическое 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите семь чисел");
            int[] array = new int[7];            
            float arithmeticMean = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                arithmeticMean += array[i];                
            }
            Console.WriteLine("Среднее арифметическое равно {0:f2}", arithmeticMean / 7);
            Console.ReadKey();
        }
    }
}
