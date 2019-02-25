using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Primos
    {
        bool repe;


        public void primos()
        {

            do{

            
            int a = 0;
            int num1 = 0;
            string linea = string.Empty ;
            Console.WriteLine("Ingrese número");


            linea = Console.ReadLine();

            if (int.TryParse(linea, out num1))
            {

                for (int i = 1; i < (num1 + 1); i++)
                {
                    if (num1 % i == 0)
                    {

                        a++;
                    }
                }

                if (a != 2)
                {
                    Console.WriteLine("No es primo");
                }
                else
                {
                    Console.WriteLine("Si es primo");
                }
                repe = false;
            }
            else
            {
                Console.WriteLine("GG.\n"+
                    "\nIntentalo de nuevo.");
                repe = true;
            }

            }while (repe == true);

        }




    }
}
