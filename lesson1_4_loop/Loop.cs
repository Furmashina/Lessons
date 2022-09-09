using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_4_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сгенерировать 10 случ чисел
            //Random rnd = new Random();
            //int count = 0;
            //while (count < 10)
            //{
            //    int val = rnd.Next(1, 10);
            //    Console.WriteLine(count+": "+val);
            //    count = count + 1;
            //}

            //2. Сгенерировать три случ числа и найти наибольшее среди них
            //Random rnd = new Random();
            //int a = rnd.Next(1, 10);
            //int b = rnd.Next(1, 10);
            //int c = rnd.Next(1, 10);
            //Console.WriteLine(a+" "+b+" "+c);
            //if (a > b && a > c)
            //{
            //    Console.WriteLine("а больше всех");
            //}
            //else if (b > c && b > a)
            //{
            //    Console.WriteLine("б больше всех");    
            //}
            //else if (c > a && c > b)
            //{
            //    Console.WriteLine("c больше всех");
            //}
            //else
            //{
            //    Console.WriteLine("числа равны");
            //}


            //3. Вывести фразу hello world 10 Раз
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter+" hello world");
            //    counter = counter + 1;
            //}

            //4. Вывести 10 случ чисел в диапазоне от 10 до 20
            //Random rnd = new Random();
            //int counter = 0;

            //while (counter < 10)
            //{
            //    int a = rnd.Next(10, 20); //[1;10)    
            //    Console.WriteLine(counter+": "+a);
            //    counter = counter + 1;
            //}


            //5. Вывести подряд числа от -1 до 5 (-1 0 1 2 3 4 5)
            //int a = -1;

            //while (a < 6)
            //{
            //    Console.WriteLine(a );
            //    a = a + 1;

            //}

            //6. Юзер вводит число n с консоли 
            //Сгенерировать n случ чисел в диапазон еот 5 до 15 и вывести их на консоль
            Random rnd = new Random();
            Console.WriteLine("Введите число ");
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                int a = rnd.Next(5, 15);
                Console.WriteLine(n+": "+a);
                n = n - 1;
            }






        }
    }
}
