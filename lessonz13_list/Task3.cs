using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz13_list
{
    internal class Task3
    {
        public void Start()
        {
            List<Fruit> list = new List<Fruit>();
            list.Add(new Fruit("apple", 10));
            list.Add(new Fruit("orange", 10));
            Fruit f = new Fruit("orange", 10);
            string s = f;


            //Проблемы будут с методами: contains, remove, indexOf


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\nУдалить по индесу");
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("Проверить наличие апельсинка");
            //list.Contains(new Fruit("orange", 10));

        }


    }

    class Fruit
    {
        public string name;
        public int price;

        public Fruit(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return name + " " + price;
        }
    }
}
