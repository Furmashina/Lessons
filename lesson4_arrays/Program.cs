using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[50];
            //string[] arr2 = new string[50];
            //double[] arr3 = new double[50];


            //Заполнить массив случ числами и вывести их на консоль
            //int[] arr = new int[5];
            //Random rnd = new Random();
            //arr[0] = rnd.Next(1,10);
            //arr[1] = rnd.Next(1, 10);
            //arr[2] = rnd.Next(1, 10);
            //arr[3] = rnd.Next(1, 10);
            //arr[4] = rnd.Next(1, 10);

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);


            //Через цикл:
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i] = rnd.Next(1, 10);
            //    Console.WriteLine(arr[i]);
            //}


            //Сгенерировать массив на 10 случ чисел, вывести их на консоль, найти макс, минимум
            int[] arr = new int[5];
            Random rnd = new Random();
            //arr.Length - количество элементов в массиве (5)

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(20, 30);
                Console.WriteLine(arr[i]);
            }

            int max = arr[0];
            int min = arr[0];
            //-1 -5 -3 -5
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("max: "+max);
            Console.WriteLine("min: "+ min);



        }
    }
}
