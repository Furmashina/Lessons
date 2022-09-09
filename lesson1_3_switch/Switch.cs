using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_3_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Определить название дня недели по его номеру с помощью оператора switch
            //Console.Write("Enter day number: ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //{
            //    case 1: //if(dayNumber == 1)
            //        Console.WriteLine("пн");
            //        break;
            //    case 2: //else if(dayNumber == 2)
            //        Console.WriteLine("вт");
            //        break;
            //    case 3: //else if(dayNumber == 3)
            //        Console.WriteLine("ср");
            //        break;
            //    case 4: //else if(dayNumber == 4)
            //        Console.WriteLine("чт");
            //        break;
            //    case 5: //else if(dayNumber == 5)
            //        Console.WriteLine("пт");
            //        break;
            //    case 6: //else if(dayNumber == 6)
            //        Console.WriteLine("сб");
            //        break;
            //    case 7: //else if(dayNumber == 7)
            //        Console.WriteLine("вс");
            //        break;
            //    default: //else
            //        Console.WriteLine("Неверный номер дня недели");
            //        break;

            //}





            //-Определить расписание для тренировок с помощью оператора switch,
            //если в пн, ср - тренировка рук, вт, чт - тренировка ног, пт - спина, сб, вс - отдых.
            //Оптимизировать switch, сгруппировав похожие условия.

            Console.Write("Enter day name: ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "пн": //if(day == "пн" || day == "ср")
                case "ср":
                    Console.WriteLine("arms");
                    break;
                case "вт":  //else if(day == "вт" || day == "чт")
                case "чт":
                    Console.WriteLine("legs");
                    break;
                case "пт": 
                    Console.WriteLine("back");
                    break;
                case "сб":
                case "вс":
                    Console.WriteLine("отдых");
                    break;


                
            }
        }
    }
}
