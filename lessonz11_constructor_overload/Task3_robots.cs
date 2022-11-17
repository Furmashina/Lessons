using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz11_constructor_overload
{
    internal class Task3_robots
    {
        public void Start()
        {
//Создать класс Robot с полем x -координата на плоскости.
//Создать перегруженные методы движения:

//goLeft() - робот движется влево на 1 единицу
//goRight() - робот движется вправо на 1 единицу

//goLeft(int distance) - робот движется влево на distance единиц
//goRight(int distance) - робот движется вправо на distance единиц

//Создать метод print, выводящий на консоль текущую позицию робота.
//В мейне создать объект класса Robot, подвигать робота в разные направления.

            Robot r = new Robot();
            r.GoRight(5);
            r.GoLeft(3);
            r.GoRight();


            

        }
    }

    class Robot
    {
        public int x;
        public void GoLeft()
        {
            x--;
            Console.WriteLine("left");
        }
        public void GoRight()
        {
            x++;
            Console.WriteLine("right");
        }

        public void GoRight(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                GoRight();
            }
        }

         public void GoLeft(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                GoLeft();
            }
        }



    }
}
