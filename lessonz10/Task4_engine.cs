using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz10
{
    internal class Task4_engine
    {
        public void Start()
        {
            //Возьмем пример из lesson9_methods_training и перезапишем заполнение массива через конструктор
            Engine[] arr = new Engine[5];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Engine("model" + (i + 1), int.Parse(Console.ReadLine()), rnd.Next(5, 10), rnd.Next(1, 2));
                
            }
        }
    }
    class Engine
    {
        public string model;
        public double engineVolume;
        public double oilConsumingVolume; //потребление масла
        public int oilQuality;

        public Engine(string model, double engineVolume, double oilConsumingVolume, int oilQuality)
        {
            this.model = model;
            this.engineVolume = engineVolume;
            this.oilConsumingVolume = oilConsumingVolume;
            this.oilQuality = oilQuality;
        }

        public double GetVibrosi()
        {
            return engineVolume * oilConsumingVolume + oilQuality;
        }
    }
}
