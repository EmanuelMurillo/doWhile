using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            decimal num1, num2, resultado = 0;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                //Pedir opción

                Console.WriteLine("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //Pedir los dos números

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese el primer número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Hacer la operación según la opción escogida
            switch(opcion)
            {
                case 1:
                    resultado = (num1 + num2);
                    break;

                case 2:
                    resultado = (num1 - num2);
                    break;

                case 3:
                    resultado = (num1 * num2);
                    break;

                case 4:
                    if(num2 !=0)
                    {
                        resultado = (num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("El divisor no es válido");
                    }
                    break;
            }
            Console.WriteLine("El resultado es: {0}", resultado);


            Console.ReadKey();

        }   
    }
}
