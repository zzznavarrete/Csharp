using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseF f = new ClaseF();


            Primos p = new Primos();
            bool rep = false;


       do {

           Console.Clear();
            int opc = 0;

            Console.WriteLine("---------- MENU ----------\n" +
                "\n1) Fibonacci\n" +
                "\n2) Primos\n"); opc = int.Parse(Console.ReadLine());


            switch (opc)
            {
                case(1):
                    f.metodoFibon();
                    break;
                case (2):
                    p.primos();
                    break;
                default:
                    Console.WriteLine("GG");
                    break;

            }

            string opc2;
            
            Console.WriteLine("\nDesea Continuar ?\n"+
                "Si (S) / No (N)"); opc2 = Console.ReadLine().ToUpper();

            if (opc2.Equals("S"))
            {
                rep = true;
                

            }
            else 
            {
                rep = false;

                Console.WriteLine("Presione una tecla para salir");
                Console.ReadKey();
            }

       }while(rep == true);
                
           


        }
    }
}
