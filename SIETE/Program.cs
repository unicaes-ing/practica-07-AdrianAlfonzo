using System;

namespace SIETE
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.09.19
    //-------Luis Adrián Alfonzo Morán-------
    class Program
    {
        static void Main(string[] args)
        {
            //Base
            int cantidad;
            int menor= 0;
            int mayor= 0;
            //Consulta
            Console.Write("¿Cuántas personas se estudiarán? ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[cantidad];
            Console.Clear();
            //Proceso en FOR
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("¿Cuántos años tiene la persona #{0}? ", i+1);
                edades[i] = Convert.ToInt32(Console.ReadLine());
                //Proceso en IF
                if (edades[i] < 18)
                {
                    menor += + 1;
                }
                else
                {
                    mayor += 1;
                }
                Console.WriteLine();
            }
            //Mostrar
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hay {0} menores de edad.", menor);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hay {0} mayores de edad.", mayor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
