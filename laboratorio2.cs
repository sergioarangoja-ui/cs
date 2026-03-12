//2 Triaje de Urgencias
using System;

class Program
{
    static void Main()
    {
        double temperatura, presion;
        Console.Write("Ingrese la temperatura corporal: ");
        temperatura = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la presion sistolica: ");
        presion = double.Parse(Console.ReadLine());
        Console.WriteLine("Temperatura: " + temperatura);
        Console.WriteLine("Presión: " + presion);
        if (temperatura > 39 || presion > 180)
        {
            Console.WriteLine("Triaje: ROJO (Crítico)");
            Console.WriteLine("Recomendación: Atención inmediata requerida.");
        }
        else if (temperatura > 38 || presion > 140)
        {
            Console.WriteLine("Triaje: AMARILLO (Urgente)");
            Console.WriteLine("Recomendación: Atención médica lo antes posible.");
        }
        else
        {
            Console.WriteLine("Triaje: VERDE (Estable)");
            Console.WriteLine("Recomendación: Puede esperar atención normal.");
        }
        Console.ReadKey();
    }
}
