using System;
class Program
{
    static void Main()
    {
        string[] nombres = { "helado", "jugo", "hamburguesa ", "leche ", "cafe " };
        double[] precios = { 4000, 2500, 3000, 5000, 2000 };
        int[] stock = { 10, 15, 8, 6, 20 };
        int opcion = 0;
        int total = 0;
        double dinero = 0;
        
         do
         {
            Console.WriteLine("\n1 ver 2 buscar 3 vender 4 salir ");
            opcion=int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine(nombres[i] + " " + precios[i] + " " + stock[i]);
                    break;
                case 2:
                    Console.Write("nombre:");
                    string nom=Console.ReadLine();
                    for(int i=0;i<5; i++)
                     if (nombres[i]==nom)
                      Console.WriteLine("precios:"+ precios[i] + "stock:" + stock[i]);
                      break;
                case 3:
                    Console.Write("producto:");
                    string p =Console.ReadLine();
                    Console.Write("cantidad:");
                    int c =int.Parse(Console.ReadLine());
                    for (int i=0; i <5; i++)
                     if (nombres[i]==p && c <= stock[i])
                     {
                         stock[i] -= c;
                            total += c;
                            dinero += c * precios[i];
                            Console.WriteLine("venta hecha");
                     }
                     break;
             } 
        
             
        }  while(opcion != 4);
        
        Console.WriteLine("vendidos: " + total);
        Console.WriteLine("dinero: " + dinero);
    }
}
