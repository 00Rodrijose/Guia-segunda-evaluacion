using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int cantidadarray = 8;

            int[] array1 = new int[cantidadarray];
            int[] array2 = new int[cantidadarray];

            Console.WriteLine("Ingrese numeros enteros: "+ cantidadarray);

            for (int i = 0; i < cantidadarray; i++)
            {
                bool valido = false;
                while (!valido)
                {
                    Console.WriteLine("Numero en posicion: " + (i + 1));
                    String entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int num))
                    { 
                        array1[i] = num;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
                    }
                }
            }

            for (int i = 0; i < cantidadarray; i++)
            {
                array2[i] = array1[i] * 3;
            }

            for (int i = 0; i < cantidadarray; i++)
            {
                Console.WriteLine(array1[i]);
            }

            for (int i = 0; i < cantidadarray; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.ReadKey();
        }
    }
}
