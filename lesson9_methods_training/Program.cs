using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_methods_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать класс Engine с полями: модель, объем двигателя, кол-во потребляемого масла, качество масла
            //Создать метод расчета выброса вредных вещест, который ВОЗВРАЩАЕТ (return) кол-во выбросов, считает их по формуле: объем*кол-во масла+качество масла

            //В мейне создать меню:
            //1.Вывести кол - во вреднех веществ у каждого двигателя
            //2.ИЗменить объем двигателя у модели x(где x и новый объем юзер вводит с консоли
            Engine[] arr = new Engine[5];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Engine en = new Engine();
                en.model = "model" + (i + 1);
                en.engineVolume = int.Parse(Console.ReadLine());
                en.oilConsumingVolume = rnd.Next(1, 2);
                en.oilQuality = rnd.Next(5, 10);
                arr[i] = en;
            }

            int input = 0;
            while (input != 3)
            {
                Console.WriteLine("1.Вывести кол - во вреднех веществ у каждого двигателя\n" +
                    "2.ИЗменить объем двигателя у модели x(где x и новый объем юзер вводит с консоли");
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i].model+" " + arr[i].engineVolume+" "+arr[i].GetVibrosi());
                    }
                }
                else if(input == 2)
                {
                    Console.Write("Enter model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter new engine volume: ");
                    double newEngineVolume = int.Parse(Console.ReadLine());

                    //надо найти двигатель с моделью model
                    for (int i = 0; i < arr.Length; i++)
                    {
                       
                        if(model == arr[i].model)
                        {
                            arr[i].engineVolume = newEngineVolume;

                        }
                    }


                }
            }
        }
    }



    class Engine
    {
        public string model;
        public double engineVolume;
        public double oilConsumingVolume; //потребление масла
        public int oilQuality;

        public double GetVibrosi()
        {
            return engineVolume * oilConsumingVolume + oilQuality;
        }
    }
}
