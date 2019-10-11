using System;

namespace SIETE
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio4Guia7
    {
        //Arreglo
        public static int[,] meitrix;
        //Main
        static void Main(string[] args)
        {
            MeitrixData();
            ShowMeitrix();
            Console.ReadKey();
        }
        //Función consulta
        public static void MeitrixData()
        {
            meitrix = new int[5, 5];
            Console.WriteLine("¿Cuáles son los números que desea agregar a la matriz?");
            //Proceso en FOR
            for (int a = 0; a < 5; a++)
            {
                //Proceso en FOR
                for (int b = 0; b < 5; b++)
                {
                    string number;
                    number = Console.ReadLine();
                    meitrix[a, b] = int.Parse(number);
                }
            }
        }
        //Función mostrar
        public static void ShowMeitrix()
        {
            //Proceso en FOR
            for (int i = 0; i < 5; i++)
            {
                //Proceso en FOR
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine(meitrix[i, f]);
                }
            }
        }
    }
}
