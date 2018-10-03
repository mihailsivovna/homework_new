using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.App
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string username = "name";
                string password = "password";
                bool result;



                var k = 1;

                do
                {


                    Console.Write("Введите логин: ");
                    var name = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    var pass = Console.ReadLine();



                    if (result = true)
                    {
                        if (username == name && password == pass)


                        {

                            Console.WriteLine("Успешный вход");
                            break;
                        }
                    }

                    else

                        result = false;

                    {
                        Console.WriteLine("Неправильный логин или пароль");


                    }

                    Console.WriteLine();
                    k++;



                } while (k <= 5);



                if (k > 5)

                {
                    Console.WriteLine(" Аккаунт заблокирован. Повторите попытку позже ");

                }



                Console.ReadLine();


            
            }

        }
    }
}


