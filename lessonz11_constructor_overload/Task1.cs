using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz10
{
    internal class Task1
    {
        public void Start()
        {

            //ПРАВИЛА ПЕРЕГРУЗКИ КОНСТРУКТОРОВ
            //1. должны иметь разное кол-во параметров
            //2. если кол-во параметров совпадает, они должны отличаться типами данных этих параметров
            //2. если кол-во параметров совпадает и их типы совпадают, они должны отличаться порядком следования параметров
            

            //Сделать несколько конструкторов в классе Registration, чтобы можно было создавать объекты с разным количеством начальных данных
            //Обязательными данными считаются логин и пароль
            
            //Пример 1: есть только логин и пароль
            //Registration r1 = new Registration("login1", "pass1", null, null, 0);
            //Создав дополнительный конструктор вместо этого можно написать:
            Registration r2 = new Registration("login1", "pass1");

            //Пример 2: есть логин, пароль, страна
            //Registration r3 = new Registration("login1", "pass1", "Russia", null, 0);
            //Создав дополнительный конструктор вместо этого можно написать:
            Registration r4 = new Registration("login1", "pass1", "Russia");

            //Остальные конструкторы:
            Registration r5 = new Registration("login1", "pass1", "Russia", "Moscow");
            Registration r6 = new Registration("login1", "pass1", "Russia", "Moscow", 20);



        }
    }
    class Registration
    {
        public string login;
        public string password;
        public string country;
        public string city;
        public int age;

      

        public Registration(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public Registration(string login, string password, string country) : this(login, password)
        {
            this.country = country;
        }
        public Registration(string login, string password, string country, string city) : this(login, password, country)
        {
            this.city = city;
        }


        public Registration(string login, string password, string country, string city, int age) : this(login, password, country, city)
        {
            this.age = age;
        }




        





        public void PrintInfo()
        {
            Console.WriteLine($"{login} {password} {country} {city} {age}");
        }


       

    }
}
