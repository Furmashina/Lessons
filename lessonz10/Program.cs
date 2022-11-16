using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            new Task1().Start();
            //или так:
            //Task1 task1 = new Task1();
            //task1.Start();


            //создаем объект и сразу вызваем у него метод без сохранения объекта в отдельную переменную
            //потому что переменная обычно нужна для выполнения более одного действи с объектом (вызвать не 1, а два и более методов)
            //А сздесь объект нужен ранди одного единственного метода
            //new Task3_increment().Start();
        }
    }

    
   
}
