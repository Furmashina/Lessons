using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz14_inheritance
{
    internal class Task1
    {
        public void Start()
        {

            //В РОДИТЕЛЬСКОМ КЛАССЕ КОНСТРУКТОР ПОКА НЕ СОЗДАЕМ!!!!!!!!!!!!!!!!!!!!!
            Student student = new Student();
            Tutor tutor = new Tutor();

            student.name = "Ivan";
            student.lastname = "Ivanov";
            student.averageMark = 4;


            tutor.name = "Semen";
            tutor.lastname = "Semenov";
            tutor.studentCount = 5;

            student.Print();
            tutor.Print();
            Console.WriteLine("ToString:");
            Console.WriteLine(student.ToString());
            Console.WriteLine(tutor); //ToString вызывается автоматически
        }
    }

    //Родительский (базовый) класс
    class Human
    {
        //В РОДИТЕЛЬСКОМ КЛАССЕ КОНСТРУКТОР ПОКА НЕ СОЗДАЕМ!!!!!!!!!!!!!!!!!!!!!
        public string name;
        public string lastname;
        //virtual означает, что метод можно будет изменить в наследнике с помощью ключевого слова override
        public virtual void Print()
        {
            if (name == null)
            {
                Console.Write("Noname ");
            }
            else
            {
                Console.Write(name+" ");
            }
            if (lastname == null)
            {
                Console.Write("Nolastname ");
            }
            else
            {
                Console.Write(lastname + " ");

            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return name + " " + lastname;
        }

    }
    
    //класс Student наследутся от класса Human
    class Student : Human
    {
        public double averageMark;

        //переопределяем метод (изменяем в наследнике реализацию относительно реализации в родительском классе)
        public override void Print()
        {
            base.Print(); //вызываем родительский метод Print()
            Console.WriteLine("avgMark = "+averageMark);
        }

        public override string ToString()
        {
            return base.ToString() + " avgMarj = " + averageMark;
        }
    }

    //класс Tutor наследутся от класса Human
    class Tutor : Human
    {
        public int studentCount;

        //переопределяем метод (изменяем в наследнике реализацию относительно реализации в родительском классе)
        public override void Print()
        {
            base.Print();
            Console.WriteLine("studentCount = " + studentCount);
        }

        public override string ToString()
        {
            return base.ToString() + " studentCount = " + studentCount;
        }
    }


}
