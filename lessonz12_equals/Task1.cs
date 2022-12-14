using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz12_equals
{
    internal class Task1
    {
        public void Start()
        {
            //Сравнивать два объекта класса Fruit через метод Equals
            //Для этого нужно обязательно переопределить (переписать родительскую версию) данный методв в классе Fruit
            Fruit f1 = new Fruit("apple", 10);
            Fruit f2 = new Fruit("apple", 10);
            Console.WriteLine(f1 == f2); //сравнение по ссылке
            Console.WriteLine(f1.name == f2.name);
            Console.WriteLine(f1.Equals(f2)); //два фрукта считаются равными, если совпадает название и цена
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

        public override bool Equals(object obj)
        {
            Fruit f = (Fruit)obj; //конвертация из родительского типа в тип наслединка (во Fruit)
            return f.name == name && f.price == price;
        }
    }

}
