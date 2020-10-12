using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakAMedthod
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;

            age = DisplayGetUserAge();

        }

        static int DisplayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponse;


            do
            {
                validResponse = true;

                Console.WriteLine("Enter Age:");
                userResponse = Console.ReadLine();

                if (!int.TryParse(userResponse, out age))
                {
                    Console.WriteLine("Please enter a valid age.");
                    validResponse = false;
                }
            } while (!validResponse);

            return age;
        }
    }

}



