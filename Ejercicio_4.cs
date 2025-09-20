using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>()
            {
                11, 20, 3, 4, 0, 6
            };

            Console.WriteLine("Contenido de la lista:");
            foreach (int x in num)
            {
                Console.WriteLine(x);
            }

            int mayor = num[0];
            int menor = num[0];
            int posimayor = 0, posimenor = 0;

            for (int i = 1; i < num.Count; i++)
            {
                if (num[i] > mayor)
                {
                    mayor = num[i];
                    posimayor = i;
                }
                if (num[i] < menor)
                {
                    menor = num[i];
                    posimenor = i;
                }
            }

            List<int> inter = new List<int>(num);
            inter.Sort();
            int intermedio = inter[inter.Count / 2];
            int posiinter = num.IndexOf(intermedio);

            Console.WriteLine("El numero mayor es: " + mayor + " y se encuentra en la posicion: " + (posimayor));
            Console.WriteLine("El numero menor es: " + menor + " y se encuentra en la posicion: " + (posimenor));
            Console.WriteLine("El numero intermedio es: " + intermedio + " y se encuentra en la posicion: " + (posiinter));

            Console.ReadKey();
        }
    }
}
