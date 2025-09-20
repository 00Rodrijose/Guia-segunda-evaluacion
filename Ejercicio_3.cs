using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList()
            {
                "PAPA", "LIBRO", "AUTO", "CASA", "ARBOL"
            };

            Console.WriteLine("Contenido del Arrylist.");

            foreach (String x in obj)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Ingrese un texto en mayusculas para buscar: ");
            String elementoBuscar = Console.ReadLine().ToUpper();
            if (obj.Contains(elementoBuscar))
            {
                Console.WriteLine("Ingrese el nuevo dato en mayusculas");
                String nuevoDato = Console.ReadLine().ToUpper();
                int index = obj.IndexOf(elementoBuscar);
                obj[index] = nuevoDato;

                Console.WriteLine("Elemento actualizado.");
            }
            else
            {
                Console.WriteLine("El elemento no se encuentra en la lista.");
            }

            Console.WriteLine("Contenido del Arrylist.");
            foreach (String x in obj)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
