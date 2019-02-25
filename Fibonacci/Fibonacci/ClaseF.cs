using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class ClaseF
    {

        int num1 = 0, num2 = 1, rep = 0, aux = 0, x = 0;

       

        public void metodoFibon()
        {
            string linea = String.Empty;
            
            Console.WriteLine("Cantidad de veces que se repite : "); linea = Console.ReadLine();
            //rep = int.Parse(linea); NO SE NECESITA


            if(int.TryParse(linea, out x)){

            for (int i = 0; i < x; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = aux + num1;
                Console.WriteLine(num1);
            
            }

        }else{
            Console.WriteLine("GG.");
        }











        }



    }
}
