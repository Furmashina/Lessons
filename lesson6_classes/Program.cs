using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_classes
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать атрибуты паспорта (серия, номер, имя, фамилия, город) в программе и сохрнить 10 паспортов
            Passport p1 = new Passport(); //создаем объект класса Passport и сохраняем его в переменную p1
            p1.seria = 1234;
            p1.number = 123456;
            p1.name = "Ivan";
            p1.lastname = "Ivanov";
            p1.city = "Moscow";

            Passport p2 = new Passport(); //создаем объект класса Passport и сохраняем его в переменную p1
            p2.seria = 2234;
            p2.number = 223456;
            p2.name = "Semen";
            p2.lastname = "Ivanov";
            p2.city = "SPB";


            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);

            //сохраним паспорта в массиве
            Passport[] arr = new Passport[10];
            string name = "Ivan";
            arr[0] = p1;
            arr[1] = p2;
            
            //выведем паспорта из пассива:
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine(arr[i].name + " " + arr[i].lastname);
                }
            }



            //Создадим консольное меню:
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("1. Вывести все паспорта");
                Console.WriteLine("2. Вывести паспорта с определенным городом");
                Console.WriteLine("3. Вывести паспорта с определенной фамилией");
                Console.WriteLine("4. Выход");
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] != null)
                        {
                            //Console.WriteLine(arr[i].seria+" "+arr[i].name + " " + arr[i].lastname);
                            arr[i].PrintInfo();
                        }
                    }
                }
                else if(input == 2)
                {
                    Console.Write("Enter city: ");
                    string city = Console.ReadLine();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] != null && arr[i].city == city)
                        {
                            //Console.WriteLine(arr[i].seria + " " + arr[i].name + " " + arr[i].lastname);
                            arr[i].PrintInfo();
                        }
                    }
                }
                else if (input == 3)
                {
                    Console.Write("Enter lastname: ");
                    string lastname = Console.ReadLine();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] != null && arr[i].lastname == lastname)
                        {
                            //Console.WriteLine(arr[i].seria + " " + arr[i].name + " " + arr[i].lastname);
                            arr[i].PrintInfo();
                        }
                    }
                }

            }

            



        }
    }


    class Passport
    {
        //поля класса:
        public int seria;
        public int number;
        public string name;
        public string lastname;
        public string city;


        public void PrintInfo()
        {
            Console.WriteLine(seria + " " + number+" "+ name + " " + lastname);
        }


    }

    


}
