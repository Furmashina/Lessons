using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_2_arrays_console_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу -авторизацию по логину и паролю. Создать два массива: один хранит логин(arrLogins), другой - пароль(arrPasswords).
            //Каждая пара логин-пароль находится на одинаковом индексе в обоих списках.То есть, к примеру, под индексом 0 в массиве arrLogins будет
            //хранится логин пользователя, а его пара - пароль будет храниться под индексом 0, но уже в массиве arrPasswords.

            //Создать консольное меню:

            //1.Зарегистрироваться
            //2.Вход в систему
            //3.Удалить логин и пароль
            //4.Выход из аккаунта
            //5.Отобразить приватный текст, доступный только авторизованному пользователю
            //6.Выход

            //При выборе пункта 1 программа запрашивает логин и пароль у пользователя для его регистрации и добавляет их в массивы, если их там еще нет.
            //Если такая пара логин-пароль уже есть в массивах, программа выводит текст "Пара логин-пароль уже заняты".

            //При выборе пункта 2 пользователь вводит логин и пароль для авторизации.Программа проверяет, что такая пара есть и в успешном случае
            //выводит на консоль "Успешная авторизация", иначе "Неверный логин или пароль".

            //При выборе пункта 3 программа завершает совю работу.


            string[] arrLogins = new string[5];
            string[] arrPasswords = new string[5];
            arrLogins[0] = "a";
            arrPasswords[0] = "b";
            string secret_word = "I like Java";
            int authorisedIndex = -1; //-1 означает, что юзер не входил в аккаунт
            // \n - символ ентера (переноса на новую строку)
            //Console.WriteLine("hello\nworld");
            int index = 1;
            int input = 0;
            while(input != 6)
            {
                Console.WriteLine("1.Зарегистрироваться\n" +
                    "2.Вход в систему\n" +
                    "3.Удалить логин и пароль\n" +
                    "4.Выход из аккаунта\n" +
                    "5.Отобразить приватный текст, доступный только авторизованному пользователю\n" +
                    "6.Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.Write("enter login: ");
                            string login = Console.ReadLine();
                            //Делаем проверку на дубликат
                            bool isExist = false;
                            for (int i = 0; i < arrLogins.Length; i++)
                            {
                                if (login == arrLogins[i])
                                {
                                    isExist = true;
                                }
                            }
                            //если логин свободен, создаем аккаунт
                            if (!isExist)
                            {
                                Console.Write("enter pass: ");
                                string pass = Console.ReadLine();
                                arrLogins[index] = login;
                                arrPasswords[index] = pass;
                                index++;
                            }
                            else
                            {
                                Console.WriteLine("Логин занят");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("enter login: ");
                            string login = Console.ReadLine();
                            Console.Write("enter pass: ");
                            string pass = Console.ReadLine();
                            //Проверяем, что логин и пароль существуют
                            bool isExist = false;
                            for (int i = 0; i < arrLogins.Length; i++)
                            {
                                if (login == arrLogins[i] && pass == arrPasswords[i])
                                {
                                    isExist = true;
                                    authorisedIndex = i; //запоминаем индекс, под которым находится аккаунт юзера
                                }
                            }
                            //если логин и пароль нашлись, входим в акк
                            if (isExist)
                            {

                                Console.WriteLine("Welcome!");
                               
                            }
                            else
                            {
                                Console.WriteLine("Неверный логин или пароль");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (authorisedIndex >= 0)
                            {
                                arrLogins[authorisedIndex] = null;
                                arrPasswords[authorisedIndex] = null;
                                authorisedIndex = -1; //выход из аккаунта
                                Console.WriteLine("Account removed");
                            }
                            else
                            {
                                Console.WriteLine("Вы должны войти в аккаунт");
                            }
                            break;
                        }
                    case 4:
                        {
                            if (authorisedIndex >= 0)
                            {
                                authorisedIndex = -1;
                                Console.WriteLine("Good bye!");
                            }
                            else
                            {
                                Console.WriteLine("Вы должны войти в аккаунт");
                            }
                            break;
                        }
                    case 5:
                        {
                            if (authorisedIndex >= 0) {
                                Console.WriteLine(secret_word);
                            }
                            else
                            {
                                Console.WriteLine("Вы должны войти в аккаунт");
                            }
                            break;
                        }

                }
            }
        }
    }
}
