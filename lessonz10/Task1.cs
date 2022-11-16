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
            //было
            //Registration r1 = new Registration();
            //r1.Initialise("Ivan", "Ivanov", "Russia", "Moscow", 20);


            //r1.name = "ivan";
            //r1.lastname = "Ivanov";
            //r1.country = "Russia";
            //r1.city = "Moscow";
            //r1.age = 20;

            //Registration r2 = new Registration();
            //r2.Initialise("Semen", "Semnov", "Russia", "Moscow", 20);



            //r2.name = "semen";
            //r2.lastname = "Ivanov";
            //r2.country = "Russia";
            //r2.city = "Moscow";
            //r2.age = 20;



            //стало

            Registration r3 = new Registration("Ivan", "Invaov", "Russia", "Moscow", 20);
            r3.PrintInfo();

        }
    }
    class Registration
    {
        public string name;
        public string lastname;
        public string country;
        public string city;
        public int age;

        //Отличия конструкторов от методов:
        //1. Конструкторы не имеют вообще никакого типа возвращаемого значения (ни void, ни int....)
        //2. Конструкторы должны называться всегда в точноки, как их класс
        //3. Конструкторы всегда вызываются автоматически в момент создания объекта (когда пишем слово new). Нет возможности их вызвать врунчую

        public Registration(string name, string lastname, string country, string city, int age)
        {
            //Когда локальная и глобальная переменные имеют одинаковые имена, приоритет всегда отдается локальной
            //Для решения этой проблемы используется ключевого словов this. Оно явно обозначает, что это поле класса
            this.name = name;
            this.lastname = lastname;
            this.country = country;
            this.city = city;
            this.age = age;
        }




        





        public void PrintInfo()
        {
            Console.WriteLine($"{name} {lastname} {country} {city} {age}");
        }


        public void Initialise(string name1, string lastname1, string country1, string city1, int age1)
        {
            name = name1;
            lastname = lastname1;
            country = country1;
            city = city1;
            age = age1;
        }

    }
}
