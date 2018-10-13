using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.App
{
    class Program
    {
        private static int number;

        static void Main(string[] args)
        {

            int number = GetNumber();
            Console.ReadLine();

        }


        public static int GetNumber()
        {
            
            
            Console.Write("Введите число: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number + " - число ");

            }
            catch (FormatException)

            {
                Console.WriteLine ("Не является числом");
            }
 
            return number;


        }
               


}
}












