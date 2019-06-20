using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverageNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0;
            int sum = 0, choice;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Veuillez insérer n°" + i + " entier");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("La chaîne de caractère n'est pas un entier. Veuillez recommencer");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                sum += choice;
            }

            Console.WriteLine("\nThe Sum is : " + sum + "\nThe Average is : " + sum / 10);
            Console.ReadLine();
        }
    }
}
