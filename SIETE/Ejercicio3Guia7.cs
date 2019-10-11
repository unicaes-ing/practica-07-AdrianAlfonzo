using System;

namespace SIETE
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio3Guia7
    {
        //Arreglo bidimensional
        public static String[][] info;
        //Mostrar
        static void Main(string[] args)
        {
            Team();
            Console.ReadKey();
            TeamData();
            Console.ReadKey();
        }
        //Consulta
        public static void Team()
        {
            //Base
            int group, players;
            Console.WriteLine("¿Cuántos equipos jugarán en la liga?");
            group = Convert.ToInt32(Console.ReadLine());
            info = new String[group][];
            //Proceso en FOR
            for (int gru = 0; gru < info.Length; gru++)
            {
                Console.Clear();
                Console.WriteLine("¿Cuántos jugadores tiene el equipo {0}?", gru + 1);
                players = Convert.ToInt32(Console.ReadLine());
                info[gru] = new String[players];
                //Proceso en FOR
                for (int inte = 0; inte < info[gru].Length; inte++)
                {
                    Console.WriteLine("¿Cuál es el nombre del jugador número {0}?", inte + 1);
                    info[gru][inte] = Console.ReadLine();
                }
            }
        }
        public static void TeamData()
        {
            Console.Clear();
            Console.WriteLine("--->La Liga 2019<---");
            for (int p = 0; p < info.Length; p++)
            {
                Console.WriteLine("Equipo {0}: ", p + 1);
                for (int t = 0; t < info[p].Length; t++)
                {
                    Console.WriteLine(info[p][t] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
