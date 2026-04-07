// 4 VACUNAS 
using System;

class Program
{
    static void Main()
    {
        int vacunas, total = 0;
        double promedio;
        for (int dia = 1; dia <= 7; dia++)
        {
            Console.Write("Ingrese la cantidad de vacunas del dia " + dia + ": ");
            vacunas = int.Parse(Console.ReadLine());
            total = total + vacunas;
        }
        promedio = total / 7;
        Console.WriteLine("Total de vacunas en la semana: " + total);
        Console.WriteLine("Promedio diario: " + promedio);
        Console.ReadKey();
    }
}
