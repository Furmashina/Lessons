using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_methods
{
    internal class Task2
    {

        public void Start()
        {
            Random random = new Random();
            Rectangle[] arr = new Rectangle[10];

            
            for (int i = 0; i < arr.Length; i++)
            {
                Rectangle rec = new Rectangle();
                rec.a = random.Next(1, 10);
                rec.b = random.Next(1, 10);
                arr[i] = rec;
            }
            int input = 0;
            while (input != 6)
            {
                Console.WriteLine("1.Вывести стороны всех прямоугольников(выводит и стороны и площадь, вывод площади сделать через метод)\r\n2.Найти прямоугольник с наибольшей площадью\r\n3.Найти прямоугольник с наименьшей площадью\r\n4.Найти сумму площадей прямоугольника\r\n5.Вывести прямоугольники, чья площадь находится в диапазоне от m до n\r\n6.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i].PrintInfo();
                        }
                        break;
                     case 2:
                        int max_s = arr[0].GetSquare();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].GetSquare() > max_s)
                            {
                                max_s = arr[i].GetSquare();
                            }
                        }
                        Console.WriteLine(max_s);
                        break;

                     case 3:
                        int min_s = arr[0].GetSquare();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].GetSquare() < min_s)
                            {
                                min_s = arr[i].GetSquare();
                            }
                        }
                        Console.WriteLine(min_s);
                        break;



                }
            }

        }
    }


    class Rectangle
    {
        public int a;
        public int b;

        public void PrintInfo()
        {
            Console.WriteLine(a+" "+b+", square = "+GetSquare());
        }

        public int GetSquare()
        {
            return a * b;
        }


    }





}
