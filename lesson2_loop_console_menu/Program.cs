using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_loop_console_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать систему авторазации.

            //Создать две переменные, хранящие администраторский логин и пароль:
            //String login = "admin";
            //String pass = "admin123";

            //Создать консольное меню с двумя пунктами
            //1.Войти в систему
            //2.Показать секретное слово
            //3.Сменить логин и пароль
            //4.Выйти из учетной записи//5.Выход(завершение работы программы)

            //При выборе пункта 1 программа запрашивает у пользователя логин и пароль с консоли и если они совпадают с login, pass, программа выводит "Успешный вход в систему", иначе - "Не успешный" и запоминает пользователя, если он зашел успешно.
            //При выборе пункта 2 программа программа проверяет, был ли выполнен успешный вход и если да, то выводит на консоль секретное слово "secret", иначе говорит "Вам нужно авторизоваться".
            //При выборе пункта 3 программа проверяет, был ли выполнен вход в систему.Если был, то запрашивает значения для нового логина и пароля и сохраняет их в переменные login и pass.Если вход не был выполнен, программа выводит текст "Для смены логина и пароля необходимо сначала авторизоваться".
            //При выборе пункта 4 программа удаляет из памяти вошедшего ранее пользователя(если он входил), таким образом для доступа к пунктам 2 и 3 ему понадобится авторизоваться снова.


            //ЧТО ДЕЛАЕТ ВОСКЛ ЗНАК? Конвертирует буленовое значение в противоположное
            //bool b = true;
            //Console.WriteLine(!b);
            //b = false;
            //Console.WriteLine(!b);

           

            string login = "admin";
            string pass = "admin123";
            string secret_word = "it's a secret";
            bool isEnter = false;
            string input = "";
            while (input != "5")
            {
                //if (enter == false)
                if (!isEnter)
                {
                    Console.WriteLine("1.Войти в систему");
                    Console.WriteLine("5.Выход(завершение работы программы)");
                }
                else
                {
                   
                    Console.WriteLine("2.Показать секретное слово");
                    Console.WriteLine("3.Сменить логин и пароль");
                    Console.WriteLine("4.Выйти из учетной записи");
                    Console.WriteLine("5.Выход(завершение работы программы)");

                }
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.Write("Enter login: ");
                            string l = Console.ReadLine();
                            Console.Write("Enter password: ");
                            string p = Console.ReadLine();
                            if (l == login && p == pass)
                            {
                                Console.WriteLine("Welcome!");
                                isEnter = true;// если юзер вошел в акк
                            }
                            else
                            {
                                Console.WriteLine("Invalid login or password");
                            }
                            break;
                        }
                    case "2":
                        //проверяем, что юзер входил в аккаунта
                        //if (enter == true)
                        if (isEnter)
                        {
                            Console.WriteLine(secret_word);
                        }
                        else
                        {
                            Console.WriteLine("Enter to your account first");
                        }
                        break;

                    case "3":
                        if (isEnter)
                        {
                            Console.Write("Enter new password: ");
                            pass = Console.ReadLine();
                            Console.WriteLine("Password changed");
                            
                        }
                        else
                        {
                            Console.WriteLine("Enter to your account first");
                        }
                        break;

                    case "4":
                        //проверяем, что юзер входил в аккаунта
                        //if (enter == true)
                        if (isEnter)
                        {
                            isEnter = false;
                            Console.WriteLine("You exited from account");
                        }
                        else
                        {
                            Console.WriteLine("Enter to your account first");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Bye-bye!");
                        break;



                }

            }

        }
    }
}
