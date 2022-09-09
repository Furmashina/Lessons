using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_max_min_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            //Сгенерировать 10 случ чисел и найти наибольшее и наименьшее, и сумму всех случайных чисел

            int max = 0; //берем начальное значение самое маленькое
            int min = 1000; //берем начальное значение самое больше
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int val = rnd.Next(1, 10);
                if(val > max)
                {
                    max = val;
                }
                if(val < min)
                {
                    min = val;
                }
                sum += val;//sum = sum + val; 

                Console.Write(val+" ");
            }
            Console.WriteLine();
            Console.WriteLine("max = "+max);
            Console.WriteLine("min = "+min);
            Console.WriteLine("sum = "+sum);








        }
    
    }
}
