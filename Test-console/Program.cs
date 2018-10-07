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
            int n;
            Console.Write("Введите размер массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0} элемент массива: ", i);
                x[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (int i = 0; i < x.Length; i++)


            {
                Console.Write(x[i] + " ");

            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 5 == 0)
                {
                    x[i] = 0;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < x.Length; i++)


            {
                Console.Write(x[i] + " ");

            }


            Console.ReadLine();


            /* int n;
             string surname;
             Console.Write("Введите количество фамилий: ");
             n = Convert.ToInt32(Console.ReadLine());


             string[] surn = new string[n];
             for (int i = 0; i < n; i++)
             {
                 Console.Write("Введите фамилию: ", i);
                 surn[i] = Convert.ToString(Console.ReadLine());



             }
             for (int i = 0; i < surn.Length; i++)


             {
                 Console.Write(surn[i] + " ");

             }
             Console.WriteLine();

             for (int i = n - 1; i >= 0; i--)
             {
                 Console.Write(surn[i] + " ");
             }

             Console.ReadLine();*/


            /*{
              int[] numbers = { 1, 2, 3, 4, 78, 55, 64, 17 };
              int s = 0;

              foreach (int num in numbers)
              {
                s = numbers.Sum() / numbers.Length;

              }

             Console.WriteLine("Среднее арифметическое " + s);
             for (int i = 0; i < numbers.Length; i++)
             {
             Console.Write(numbers[i] + " ");
             }

             Console.ReadLine();

             for (int i = 0; i < numbers.Length; i++)
            {
             if (numbers[i] < s)
            {
            numbers[i] = -1;
            }

             else if (numbers[i] > s)
            {
            numbers[i] = 1;
            }

            Console.WriteLine(numbers[i]);
            Console.ReadKey();*/


            /* static void Main(string[] args){

            string[] name = new string [5];
            name[0] = "Katya";
            name[1] = "Masha";
            name[2] = "Sasha";
            name[3] = "Vadim";
            name[4] = "Misha";


            Print(name);
            Console.ReadLine();
            }

            public static void Print(string[] name)
            {

            for (int i = 0; i < name.Length; i++)
            {
               Console.WriteLine(name[i] + " ");*/


            /*static void Main(string[] args)
                    {


                        Console.Write("Введите логин: ");
                        var name = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        var pass = Console.ReadLine();           
                        bool Data = Login(name, pass);
                        Console.WriteLine(Data);
                        Console.ReadKey();
                    }

                    public static bool Login(string name, string pass)
                    {
                        if (name == "name" && pass == "password")
                        { 
                            return true;     
                        }

                        else
                        {
                            return false;
                        }*/


            /*static void Main(string[] args)
            {

                int[] x = ReadArray();



            }

            public static int[] ReadArray()
            {
                int n;
                Console.Write("Введите размер массива: ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] x = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите {0} элемент массива: ", i);
                    x[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write(x[i] + " ");

                }
                return x;*/
            }





        }
    }










