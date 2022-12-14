using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz13_list
{
    internal class Task2
    {
        public void Start()
        {
            List<string> list = new List<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ": " + list[i]);
            }

            Console.WriteLine("Проверить, есть ли строка в списке");
            Console.Write("Enter value: ");
            string val = Console.ReadLine();
            if (list.Contains(val)) //принимает значение, ищем его в списке и возвращает true, либо false
            {
                Console.WriteLine("Есть");
            }
            else
            {
                Console.WriteLine("Нет");
            }


            Console.WriteLine("Узнать индекс, под которым находится строчка и прибавить к ней строку hello: ");
            Console.Write("Какую строчку изменить: ");
            val = Console.ReadLine();
            int index = list.IndexOf(val); //вернет индекс, если нашел val в списке или -1, есил не нашел
            if (index != -1)
            {
                list[index] += "hello";
                Console.WriteLine("Новое значение: " + list[index]);
            }
            else
            {
                Console.WriteLine("Строка не найдена");
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
            val = Console.ReadLine();
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
