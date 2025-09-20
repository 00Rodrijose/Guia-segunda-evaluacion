using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> fff = new List<String>();

            Console.WriteLine("Ingrese 10 elementos: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Elemento:" + (i + 1));
                fff.Add(Console.ReadLine());
            }

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==== Menu ====");
                Console.WriteLine("1) agregar un nuevo elemento");
                Console.WriteLine("2) Actualizar un elemento");
                Console.WriteLine("3) Eliminar un elemento");
                Console.WriteLine("4) Mostrar alfabeticamente (A-Z)");
                Console.WriteLine("5) Mostrar alfabeticamente en orden inverso");
                Console.WriteLine("6) Cerrar programa");
                Console.Write("Seleccione una opcion (1-6): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nuevo elemento: ");
                        String nuevoElemento = Console.ReadLine();
                        fff.Add(nuevoElemento);
                        Console.WriteLine("Elemento agregado.");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el elemento que desea actualizar: ");
                        String elementoActualizar = Console.ReadLine();
                        if (fff.Contains(elementoActualizar))
                        {
                            Console.WriteLine("Ingrese el nuevo valor: ");
                            String nuevoValor = Console.ReadLine();
                            int index = fff.IndexOf(elementoActualizar);
                            fff[index] = nuevoValor;
                            Console.WriteLine("Elemento actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("Elemento no encontrado.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el elemento que desea eliminar: ");
                        String elementoEliminar = Console.ReadLine();
                        if (fff.Remove(elementoEliminar))
                        {
                            Console.WriteLine("Elemento eliminado con exito.");
                        }
                        else
                        {
                            Console.WriteLine("Elemento no encontrado.");
                        }
                        break;

                    case 4:
                        fff.Sort();
                        Console.WriteLine("Elementos en orden alfabetico (A-Z): ");
                        foreach (String elemento in fff)
                        {
                            Console.WriteLine(elemento);
                        }
                        break;

                    case 5:
                        fff.Sort();
                        fff.Reverse();
                        Console.WriteLine("Elementos en orden alfabetico inverso (Z-A): ");
                        foreach (String elemento in fff)
                        {
                            Console.WriteLine(elemento);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Cerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Por favor, seleccione una opcion del 1 al 6.");
                        break;
                }
                if (opcion != 6)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }while (opcion != 6);

            Console.ReadKey();
        }
    }
}
