using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать класс Fruit c полями название, цена, цвет
            Fruit[] arr = new Fruit[5];
            Fruit f1 = new Fruit();
            f1.name = "apple";
            f1.price = 10;

            Fruit f2 = new Fruit();
            f2.name = "orange";
            f2.price = 15;
            f2.color = "orange";

            arr[0] = f1;
            arr[1] = f2;


            Console.WriteLine("1. Вывести все фрукты из массива");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    arr[i].PrintInfo();
                }
            }

            Console.WriteLine("1. Вывести все фрукты ценой ниже x");
            Console.Write("Enter price: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i].price < x)
                {
                    arr[i].PrintInfo();
                }
            }




        }
    }

    class Fruit
    {
        public string name;
        public string color;
        public int price;

        public void PrintInfo()
        {
            Console.WriteLine($"{name} {color} {price}");
        }

    }
}
