using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_logic_and_logic_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl+k+c - comment
            //ctrl+k+u - uncomment
            //Task 1. Написать программу авторизации.
            //Пользователь вводит логин и пароль, программа сверяет их с администраторскими и отвечает "Успешный вход" или "Неверный логин или пароль"
            //string login = "admin";
            //string password = "admin123";

            //Console.Write("Enter login: ");
            //string log = Console.ReadLine();
            //Console.Write("Enter password: ");
            //string pass = Console.ReadLine();
            ////true && true = true
            ////true && false = false
            ////false && true = false
            ////false && false = false

            //if (log == login && pass == password)
            //{
            //    Console.WriteLine("Welcome!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid login or password");
            //}



            //Task 2. Пользователь вводит число с консоли. Определить, входит ли это число в диапазон от - 10 до 10.
            //Console.Write("Enter a value: ");
            //int a = Convert.ToInt32(Console.ReadLine()); //"5" -> 5
            //if(a > -10 && a < 10)
            //{
            //    Console.WriteLine("входит");
            //}
            //else
            //{
            //    Console.WriteLine("Не входит");
            //}






            //Task 3. Написать программу, фильтрующую не подходящие модели телефонов.Требования к модели:
            //цена: до 50000
            //память: от 32
            //цвет: black

            Console.Write("Enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter memory: ");
            int memory = int.Parse(Console.ReadLine());
            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            if (price <= 50_000 && memory >= 32 && color == "black")
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
