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


            // Asks user input until [-1] is entered.
            while (true)
            {
                Console.Write("Sisesta sõna: ");
                string userInput = Console.ReadLine();
                string[] allInput = new string[] {userInput};
                
                if( userInput == "-1")
                {
                    // Displays all the input 
                    Console.WriteLine("");
                    Console.WriteLine("Sisestasid sõnad:{0} , ", allInput);

                    // Chooses a random word and displays it
                    Console.WriteLine("");
                    Console.WriteLine("Suvaline sõna: ");

                    break;    
                    
                }

                
            }

            Console.WriteLine("");                      
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey();
            
        }
    }
}
