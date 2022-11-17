using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz11_constructor_overload
{
    internal class Task2_methods
    {
        public void Start()
        {
            //ПРАВИЛА ПЕРЕГРУЗКИ МЕТОДОВ
            //1. должны иметь разное кол-во параметров
            //2. если кол-во параметров совпадает, они должны отличаться типами данных этих параметров
            //2. если кол-во параметров совпадает и их типы совпадают, они должны отличаться порядком следования параметров
            //Также перегнуженные методы могут иметь разный тип возвращаеомго значения, но новой перегрузки это не создает


            //Задача
            //Создать класс Calculator с методом sum, который будет способен принимать параметры в разных типах:

            //public int sum(int a, int b)
            //public int sum(String a, String b)
            //public int sum(int a, String b)
            //public int sum(String a, int b)
            //public double sum(double a, double b)
            Calculator calc = new Calculator();
            calc.Sum(2, 3);
            calc.Sum("2", "3");
            calc.Sum("2", 3);
            calc.Sum(2, "3");

            int result = calc.Sum(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("result = "+result);

           
        }
    }

    public class Calculator 
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
       
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        public int Sum(int a, string b)
        {
            return a + int.Parse(b);
        }
        public int Sum(string a, int b)
        {
            return b + int.Parse(a);
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
    }

}
