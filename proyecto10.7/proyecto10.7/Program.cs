using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sumatoria = 0;
                int posicion, numero;
                

                for (int i = 0; i < 10; i++)
                {
                    posicion = i + 1;
                    Console.Write("Dame el numero de la posicion #"+posicion+": ");
                    numero = int.Parse(Console.ReadLine());

                    if (i>4)
                    {
                        sumatoria = sumatoria + numero;
                    }                   
                }
                Console.WriteLine("La sumatoria de los ultimos 5 numeros es "+sumatoria);
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");
            }
            Console.ReadKey();
        }
    }
}
