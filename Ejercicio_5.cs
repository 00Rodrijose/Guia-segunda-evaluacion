using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas palabras desea ingresar? ");
            int cc = int.Parse(Console.ReadLine());
            List<String> palabras = new List<String>();
            for (int i = 0; i < cc; i++)
            {
                Console.WriteLine("Palabra: " + (i + 1));
                palabras.Add(Console.ReadLine());
            }

            int[] longitud = new int[palabras.Count];
            for (int i = 0; i < palabras.Count; i++)
            {
                longitud[i] = palabras[i].Length;
            }

            Console.WriteLine("Palabras: ");
            for (int i = 0; i < palabras.Count; i++)
            {
                Console.WriteLine(palabras[i] + " -> Indice" + i);
            }

            Console.WriteLine("Longitudes: ");
            for (int i = 0; i < longitud.Length; i++)
            {
                Console.WriteLine(longitud[i] + " -> Indice" + i);
            }

            Console.ReadKey();
        }
    }
}
