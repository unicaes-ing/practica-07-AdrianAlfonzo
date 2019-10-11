using System;

namespace SIETE
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio5Guia7
    {
        //Arreglos
        public static int[,] MeitrixOne;
        public static int[,] MeitrixTwo;
        //Main
        static void Main(string[] args)
        {
            //Base
            int tot;
            MeitrixOne = new int[3, 3];
            //Consulta
            Console.WriteLine("¿Cuáles son los valores que desea agregar a la Primera Matriz?");
            //Proceso en FOR
            for (int i = 0; i < MeitrixOne.GetLength(0); i++)
            {
                //Proceso en FOR
                for (int j = 0; j < MeitrixOne.GetLength(1); j++)
                {
                    string num;
                    num = Console.ReadLine();
                    MeitrixOne[i, j] = int.Parse(num);
                }
            }
            Console.Clear();
            MeitrixTwo = new int[3, 3];
            Console.WriteLine("¿Cuáles son los valores que desea agregar a la Segunda Matriz?");
            //Proceso en FOR
            for (int i = 0; i < MeitrixTwo.GetLength(0); i++)
            {
                //Proceso en FOR
                for (int j = 0; j < MeitrixTwo.GetLength(1); j++)
                {
                    string num;
                    num = Console.ReadLine();
                    MeitrixTwo[i, j] = int.Parse(num);
                }
            }
            Console.Clear();
            tot = Add(MeitrixOne) + DoubleAdd(MeitrixTwo);
            Console.WriteLine("El resultado de las matrices es: {0}", tot);
            Console.ReadKey();
        }
        static int DoubleAdd(int[,] MatrixII)
        {
            int plus = 0;
            //Proceso en FOR
            for (int i = 0; i < MatrixII.GetLength(0); i++)
            {
                //Proceso en FOR
                for (int j = 0; j < MatrixII.GetLength(1); j++)
                {
                    plus = MatrixII[i, j];
                }
            }
            return plus;
        }
        static int Add(int[,] MatrixI)
        {
            int plus = 0;
            //Proceso en FOR
            for (int i = 0; i < MatrixI.GetLength(0); i++)
            {
                //Proceso en FOR
                for (int j = 0; j < MatrixI.GetLength(1); j++)
                {
                    plus = MatrixI[i, j];
                }
            }
            return plus;
        }

    }
}
