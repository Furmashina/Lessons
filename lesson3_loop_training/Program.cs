using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_loop_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дерево растет каждый год n см в год, где n - случайное число в диапазоне от 1 до 4
            //Выведите на консоль историю роста дерева за 5 лет, а также найдите наибольшую величину роста дерева за все года.

            //Пример вывода истории роста:
            //год 1, выросло на 1 см
            //год 2, выросло на 4 см
            //год 3, выросло на 3 см
            //год 4, выросло на 2 см
            //год 5, выросло на 3 см
            //Наибольшая величина роста: 4 см
            //int year = 0;
            //int maxHeight = 0;
            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    int height = rnd.Next(1, 4);
            //    year += 1;
            //    Console.WriteLine($"год {year}, выросло на {height} см");
            //    if(height > maxHeight)
            //    {
            //        maxHeight = height;
            //    }
            //}
            //Console.WriteLine($"Наибольшая величина роста: {maxHeight} см");


            //Добавьте к задаче 1 на рост дерева подсчет его текущей высоты.
            //Выведите историю роста за 5 лет.

            //Пример вывода истории роста:
            //год 1, выросло на 1 см, высота дерева 1 см
            //год 2, выросло на 4 см, высота дерева 5 см
            //год 3, выросло на 3 см, высота дерева 8 см
            //год 4, выросло на 2 см, высота дерева 10 см
            //год 5, выросло на 3 см, высота дерева 13 см

            //int year = 0;
            //int maxHeight = 0;
            //int total_height = 0;
            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    int height = rnd.Next(1, 4);
            //    total_height += height;
            //    year += 1;
            //    Console.WriteLine($"год {year}, выросло на {height} см, высота дерева {total_height} см");
            //    if (height > maxHeight)
            //    {
            //        maxHeight = height;
            //    }
            //}
            //Console.WriteLine($"Наибольшая величина роста: {maxHeight} см");


            //Дерево растет первые три года на 1 см в год, последующие года оно растет по 2 см в год.
            //Выведите на консоль историю роста дерева за 10 лет

            //Что должно получиться:
            //год 1, высота 1 см
            //год 2, высота 2 см
            //год 3, высота 3 см
            //год 4, высота 5 см
            //год 5, высота 7 см
            //и так до 10 - и лет

            

            int height = 0;
            for (int year = 1; year <= 10; year++)
            {
                if (year >0 && year <= 3) 
                {
                    height++;
                }
                else
                {
                    height += 2;
                }
                
                Console.WriteLine($"год {year}, высота {height} см");
            }



        }
    }
}
