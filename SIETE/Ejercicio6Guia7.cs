using System;

namespace SIETE
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio6Guia7
    {
        //Base
        public static Random valorRandom;
        //Arreglo
        public static int[,] numerito;
        //Main
        static void Main(string[] args)
        {
            //Base
            int opt;
            //Arreglo
            numerito = new int[6, 6];
            do
            {
                Console.Clear();
                Console.WriteLine("Selecciona una opción...");
                Console.WriteLine("[1] Crear una matriz");
                Console.WriteLine("[2] Ver la matriz creada");
                Console.WriteLine("[3] Salir");
                Console.WriteLine();
                opt = int.Parse(Console.ReadLine());
                //Proceso en SWITCH
                switch (opt)
                {
                    case 1:
                        SetFecha();
                        break;
                    case 2:
                        GetFecha();
                        break;
                }
            } while (opt != 3);
        }
        public static void SetFecha()
        {
            Console.Clear();
            valorRandom = new Random();
            numerito = new int[10, 10];
            //Proceso en FOR
            for (int i = 0; i < numerito.GetLength(0); i++)
            {
                //Proceso en FOR
                for (int j = 0; j < numerito.GetLength(1); j++)
                {
                    numerito[i, j] = valorRandom.Next(10, 99);
                }
            }
            Console.WriteLine("Usted ha creado una matriz...");
            Console.WriteLine("Presione [ENTER] para regresar al menú principal...");
            Console.ReadLine();
        }
        public static void GetFecha()
        {
            Console.Clear();
            for (int i = 0; i < numerito.GetLength(0); i++)
            {
                Console.WriteLine("...");
                //Proceso en FOR
                for (int j = 0; j < numerito.GetLength(1); j++)
                {
                    //Proceso en IF
                    if (numerito[i, j] == 0)
                    {
                        Console.WriteLine("00");
                    }
                    //Proceso en ELSE
                    else
                    {
                        //Proceso en IF
                        if ((numerito[i, j] != 0) && (numerito[i, j] % 2 == 0))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                        Console.WriteLine(numerito[i, j]);
                    }
                    Console.WriteLine("...");
                }
                //Proceso en IF
                if (i < 9)
                {
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.WriteLine("<----------------------------------------------------------->");
                Console.WriteLine("Presione [ENTER] para regresar al menú principal...");
                Console.ReadLine();
            }
        }
    }
}
