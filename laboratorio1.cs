//1 Registro de Paciente
using System;
class Program
{
    static void Main()
    {
        string nombre, seguro;
        int edad;
        double peso, estatura, imasac;
        Console.Write("Ingrese el nombre del paciente: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese la edad: ");
        edad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el peso en kg: ");
        peso = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la estatura en metros: ");
        estatura = double.Parse(Console.ReadLine());
        Console.Write("Tiene seguro? (si/No): ");
        seguro = Console.ReadLine();
        imasac = peso /  (estatura * estatura);
        Console.WriteLine("Ficha del paciente");
        Console.WriteLine("Nmbre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("IMASAC: " + imasac);
        Console.WriteLine("Seguro: " + seguro);

       Console.ReadKey();
    }
}
