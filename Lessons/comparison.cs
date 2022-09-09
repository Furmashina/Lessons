using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Есть два числа. Определить их соотнешине (a>b, a<b, a ==b)
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("A = b");
            }
            else if(a > b)
            {
                Console.WriteLine("a>b");
            }
            else
            {
                Console.WriteLine("a < b");
            }
            

        }
    }
}
