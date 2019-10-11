using System;

namespace SIETE
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio2Guia7
    {
        //Arreglo
        static decimal[] num;
        static void Main(string[] args)
        {
            //Base
            int par = 0;
            int impar = 0;
            //Consulta
            Console.Write("¿Cuántos números? ");
            int esonopar = Convert.ToInt32(Console.ReadLine());
            num = new decimal[esonopar];
            //Proceso en FOR
            for (int i = 1; i <= esonopar; i++)
            {
                Console.Clear();
                Console.WriteLine("Escriba el número {0} a analizar: ", i);
                num[i - 1] = Convert.ToDecimal(Console.ReadLine());
                //Proceso en IF
                if (num[i - 1] % 2 == 0)
                {
                    par += 1;
                }
                //Proceso en ELSE
                else
                {
                    if (num[i - 1] % 2 >= 1)
                    {
                        impar += 1;
                    }
                }
            }
            //Mostrar
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hay {0} números pares", par);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hay {0} números impares", impar);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }


}
