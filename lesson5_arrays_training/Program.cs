using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_arrays_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1. Создать массив случайных чисел на n элементов, где n юзер вводит с консоли
            //Вывести все элементы на консоль
            //Далее сгенерировать еще один элемент и проверить, есть ли он в массиве
            //Console.Write("Enter n: ");
            //int n = int.Parse(Console.ReadLine()); //4
            //int[] arr = new int[n];
            ////0 1 2 3
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(1, 10);
            //}
            //int a = rnd.Next(1, 10);
            //Console.WriteLine("Сгенерированное число: " + a);
            //bool x = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //    if (a == arr[i])
            //    {
            //        x = true; //означаеТ, что нашли число в массиве
            //    }
            //}
            //Console.WriteLine();
            //if (x)
            //{
            //    Console.WriteLine("есть");
            //}
            //else
            //{
            //    Console.WriteLine("нет");
            //}



            //Task 2.  Создать массив случайных чисел на n элементов в диапазоне [-10;10], где n юзер вводит с консоли
            //Вывести все элементы на консоль
            //Найти сумму элементов и найти количество чисел в массиве, которые были бы больше этой суммы
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine()); //4
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum = "+sum);
            int coin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > sum)
                {
                    coin++;
                }
            }
            Console.WriteLine(coin);


        }
    }
}
