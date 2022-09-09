using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_logic_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            -Написать программу, фильтрующую не подходящие модели телефонов.Требования к модели: цвет black или white
            //true || true = true
            //true || false = true
            //false || true = true
            //false || false = false
            //Console.Write("Enter color: ");
            //string color = Console.ReadLine();
            //if(color == "white" || color == "black")
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine("not ok");
            //}




            //+Определить, можно ли кормить кота. Кота можно кормить если он не поймал ни одной мышки или если его вес меньше 4.5 кг.
            //Исходные данные:
            //int mouse = 0; //кол-во мышек
            //double weight = 3.5;
            //if(mouse == 0 || weight < 4.5)
            //{
            //    Console.WriteLine("кормим");
            //}
            //else
            //{
            //    Console.WriteLine("не кормим");
            //}



            //Комбинация:

            //+Определить, подходит ли модель телефона, если требуется модель, удовлетворяющая параметрам:
            //цена: меньше 50000
            //память: от 32
            //цвет: черный или белый

            Console.Write("Enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter memory: ");
            int memory = int.Parse(Console.ReadLine());
            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            //2 * 3 * (4 + 5)
            if (price <= 50_000 && memory >= 32 && (color == "black" || color == "white"))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }
        }
       
    }
}
