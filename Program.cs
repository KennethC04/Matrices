using System;

namespace ejercicio231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[5, 6];
            string[] nombres = new string[5];

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("Ingrese nombre");
                nombres[f] = Console.ReadLine();
                for (int c = 0; c < 6; c++)
                {
                    Random r = new Random();
                    notas[f, c] = r.Next(1, 100);
                }
            }
            for (int f = 0; f < 5; f++)
            {
                Console.Write(nombres[f] + "  ");
                for (int c = 0; c < 6; c++)
                {
                    Console.Write(notas[f, c] + "-");
                }
                Console.WriteLine();
            }

            //promedio por estudiante
            double[] promedioEstudiante = new double[5];
            for (int f = 0; f < 5; f++)
            {
                double promedio = 0;
                for (int c = 0; c < 6; c++)
                {
                    promedio += notas[f, c];
                }
                promedio /= 6;
                promedioEstudiante[f] = promedio;
            }

            //promedio por asignatura
            double[] promedioAsignatura = new double[6];
            for (int c = 0; c < 6; c++)
            {
                double promedio = 0;
                for (int f = 0; f < 5; f++)
                {
                    promedio += notas[f, c];
                }
                promedio /= 5;
                promedioAsignatura[c] = promedio;
            }

            //imprimir promedio por asignatura
            Console.WriteLine("Promedio por asignatura:");
            for (int c = 0; c < 6; c++)
            {
                Console.WriteLine("Asignatura " + c + ": " + promedioAsignatura[c]);
            }

            Console.ReadLine();
        }
    }
}


