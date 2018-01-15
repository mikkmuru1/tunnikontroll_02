using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm mis lubab sisestada N+1 hulga erinevaid sõnu, kuni sisestatakse [-1]");
            Console.WriteLine("");
            List<string> allInput = new List<string>();
            

            // Asks user input until [-1] is entered.
            while (true)
            {
                Console.Write("Sisesta sõna: ");
                string userInput = Console.ReadLine();
               
                
                if (userInput != "-1")
                {
                    allInput.Add(userInput);
                }
                else
                    break;
                
            }

            // Display all input 
            Console.WriteLine($"Sisestasid sõnad: {string.Join(", ", allInput)}");

            // Display random input
            Random rnd = new Random();
            int inputx = rnd.Next(allInput.Count);
            Console.WriteLine("Suvaline sõna on: " + allInput[inputx]);

            Console.WriteLine("");                      
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey();
            
        }
    }
}
