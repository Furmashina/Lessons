using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lessonz12_equals
{
    internal class Task2
    {
        public void Start()
        {
            //Есть класс Phone с полями: модель, память, цвет, цена. Два телефона одинаковы, если совпадает модель, память, цвет
            Phone phone1 = new Phone("Iphone 11", "green", 64, 50_000);
            Phone phone2 = new Phone("Iphone 11", "green", 64, 51_000);
            Phone phone3 = new Phone("Iphone 11", "green", 256, 60_000);


            Console.WriteLine(phone1.Equals(phone2));
            Console.WriteLine(phone1.Equals(phone3));

            //object ob = phone1; //записываем объект класса Phone в переменную типа object
            //Phone p = (Phone)ob; //конвертируем объект из типа object обратно в Phone


            Console.WriteLine("Есть класс Account. Два телефона одинаковы, если совпадает логин");
            Account acc1 = new Account("login1", "pass1", 20, "Russia");
            Account acc2 = new Account("login2", "pass2", 21, "Russia");
            Account acc3 = new Account("login1", "pass3", 31, "USA");


            Console.WriteLine(acc1.Equals(acc3));
            Console.WriteLine(acc1.Equals(acc2));

            //object ob = acc1; //записываем объект класса Account в переменную типа object
            //Account acc = (Account)ob; //конвертируем объект из типа object обратно в Account

            Console.WriteLine("Пример работы toString");
            Console.WriteLine(phone1);//toString вызывать не обязательно, он автоматически вызовется, если объект поместить в  Console.WriteLine
            Console.WriteLine(acc1.ToString()); 



        }
    }

    class Account
    {
        public string login;
        public string password;
        public int age;
        public string country;

        public Account(string login, string password, int age, string country)
        {
            this.login = login;
            this.password = password;
            this.age = age;
            this.country = country;
        }

        public override bool Equals(object obj)
        {
            Account acc = (Account)obj;
            return acc.login == login;
        }
        public override string ToString()
        {
            return login + " " + password + " " + age + " " + country;
        }
    }

    class Phone
    {
        public string model;
        public string color;
        public int memory;
        public int price;

        public Phone(string model, string color, int memory, int price)
        {
            this.model = model;
            this.color = color;
            this.memory = memory;
            this.price = price;
        }
        public override bool Equals(object obj)
        {
            Phone p = (Phone)obj;
            return p.model == model && p.memory == memory && p.color == color;
        }

        public override string ToString()
        {
            return model + " " + color + " " + memory + " " + price;
        }
    }
}
