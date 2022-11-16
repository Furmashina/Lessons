using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz10
{
    internal class Task2
    {
        public void Start()
        {
            //Сделать создание и сохранение гостей через конструктор
            Visitor[] arr = new Visitor[5];
            int indexName = 0;
            bool approve = true;
            Console.WriteLine("Введите имя гостя");
            string name = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i].name == name)
                {
                    approve = false;
                }
            }
            if (approve)
            {
                arr[indexName++] = new Visitor(name); //за счет конструктора создаем объект и сразу сохрнаяем в массиве
            }
        }
                
    }

    class Visitor
    {
        public string name;

        public Visitor(string name)
        {
            this.name = name;
        }

        public void PrintVisitorName()
        {
            Console.WriteLine(name);
        }
    }
}
