using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_methods_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать класс Scales (весы) с полями:
            //марка и максимальный вес, который они могут выдеражть
            //создать методы:
            //public int CalcWeight()  - вовзращает случайное число от 50 до 140 - вес юзера
            //public double CalcMusculesPercent(int height, int weight) - считают процент мышц по формулу: height * weight / 100
            //public double CalcOilPercent(int height, int weight) - считают процент жира по формулу: 100% - процент мышечной массы
            //public double CalcWaterPercent(int height, int weight) - считают процент воды по формулу: height / weight

            int height = 180;
            Scales scales = new Scales();
            int weight = scales.CalcWeight();
            Console.WriteLine("weight = "+weight);
            double result = scales.CalcMusculesPercent(height, weight);
            Console.WriteLine("Процент мышцы: "+result);
            result = scales.CalcOilPercent(height, weight);


            //Создать массив весов и найти весы, которые имеют наибольший предел прочности (maxWeight)
            Scales[] arr = new Scales[5];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Scales s = new Scales();
                s.mark = "mark" + i;
                s.maxWeight = random.Next(100, 200);
                arr[i] = s;
                Console.WriteLine(arr[i].mark+" "+arr[i].maxWeight);
            }

            //найдем весы
            int max = 0; //максимум предела прочности
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].maxWeight > max)
                {
                    max = arr[i].maxWeight;
                    maxIndex = i;
                }
            }
            Console.WriteLine("Самый прочные весы: " + arr[maxIndex].mark);







        }

    }
}


class Scales
{
    public string mark;
    public int maxWeight;

    //  - вовзращает случайное число от 50 до 140 - вес юзера
    public int CalcWeight()
    {
        Random random = new Random();
        int weight = random.Next(50, 140);
        return weight;
    }
    //- считают процент мышц по формулу: height* weight / 100
    public double CalcMusculesPercent(int height, int weight)
    {
        double muscles = height * weight / 100;
        return muscles;
    }
    //- считают процент жира по формулу: 100% - процент мышечной массы
    public double CalcOilPercent(int height, int weight)
    {
        double oil = 100 - CalcMusculesPercent(height, weight);
        return oil;
    }
    //- считают процент воды по формулу: height / weight
    public double CalcWaterPercent(int height, int weight)
    {
        return height / weight;
    }

}