using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_methods
{
    internal class Task1
    {

        public void Start()
        {
            

            Calculator calc = new Calculator();
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Random random = new Random();
            //int a = random.Next(1, 10);
            //int b = random.Next(1, 10);

            //возвращает - return
            //выводить - void (Console.WriteLine())

            int result = calc.Minus(4, 3);
            Console.WriteLine(result * result);
            calc.Minus(3, 2);

            //сложить 2 и 3
            //Вычесть 10 и 2
            //Умножить оба результата и вывести результат умножения на консоль
            int x = calc.Sum(2, 3);
            int y = calc.Minus(10, 2);
            double result1 = calc.Umn(x, y);
            Console.WriteLine(result1);
        }
    }



    class Calculator
    {

        //a,b - параметры метода Sum
        public int Sum(int a, int b)
        {
            return a + b; //возвращает
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
        public double Umn(double a, double b)
        {
            return a * b;
        }

    }
}
