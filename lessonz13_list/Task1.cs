using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz13_list
{
    internal class Task1
    {
        public void Start()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ": " + list[i]);
            }

            Console.WriteLine("Проверить, есть ли число в спиское");
            Console.Write("Enter value: ");
            int val = int.Parse(Console.ReadLine());
            if (list.Contains(val)) //принимает значение, ищем его в списке и возвращает true, либо false
            {
                Console.WriteLine("Есть");
            }
            else
            {
                Console.WriteLine("Нет");
            }


            Console.WriteLine("Узнать индекс, под которым находится число и увеличить его в 20 раза: ");
            Console.Write("Какое число вы хотите увеличить в 2 раза: ");
            val = int.Parse(Console.ReadLine());
            int index = list.IndexOf(val); //вернет индекс, если нашел val в списке или -1, есил не нашел
            if (index != -1)
            {
                list[index] *= 2;
                Console.WriteLine("Новое значение: " + list[index]);
            }
            else
            {
                Console.WriteLine("Число не найдено");
            }

            Console.WriteLine("Удалить значение по индексу");
            Console.Write("Введите индекс: ");
            index = int.Parse(Console.ReadLine());
            list.RemoveAt(index);
            Console.WriteLine("Элементы после удаления: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ": " + list[i]);
            }

            Console.WriteLine("Удалить значение");
            Console.Write("Введите значение, которое нужно удалить: ");
            val = int.Parse(Console.ReadLine());
            list.Remove(val);
            Console.WriteLine("Элементы после удаления: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ": " + list[i]);
            }


            Console.WriteLine("Очистка всего списка");
            list.Clear(); //все элементы удаляются, размер списка становится 0
        }
    }
}
