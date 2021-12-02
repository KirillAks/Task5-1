using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int sum = 0;
            int arithmeticMean = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                sum += array[i];
                arithmeticMean = sum / 7;
            }
            Console.WriteLine("Среднее арифметическое равно {0}", arithmeticMean);
            Console.ReadKey();
        }
    }
}
