using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String kg = "";
            Double N1 = 0, N2 = 0, N3 = 0;
            int go = 0;
            do
            {
                Console.Title = "Menú de variables";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                              Selecciona tu variable");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[a] Seno de X     [b] Coseno de X     [c] Tangente de X     [d] Raíz cuadrade de X\n" +
                    "[e] Potencia de Y^X     [f] Verificar si X es par o impar     [g] Salir del programa");
                kg = Console.ReadLine();
                if (kg!= "g")
                {
                    Console.WriteLine("Ingrese el dato que vamos a calcular ");
                    do
                    {
                        try
                        {
                            N1 = Double.Parse(Console.ReadLine());
                            go = 1;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ingrese un dato numérico");
                        }
                    } while (go == 0);
                }
                switch (kg)
                {
                    case "a":
                        N2 = Math.Sin(N1);
                        Console.WriteLine("El Seno de \"" + N1 + "\" es igual a: " + N2);
                        go = 0;
                        break;
                    case "b":
                        N2 = Math.Cos(N1);
                        Console.WriteLine("El Coseno de \"" + N1 + "\" es igual a: " + N2);
                        go = 0;
                        break;
                    case "c":
                        N2 = Math.Tan(N1);
                        Console.WriteLine("La Tangente de \"" + N1 + "\" es igual a: " + N2);
                        go = 0;
                        break;
                    case "d":
                        N2 = Math.Sqrt(N1);
                        Console.WriteLine("La raíz cuadrada de \"" + N1 + "\" es igual a: " + N2);
                        go = 0;
                        break;
                    case "e":
                        Console.WriteLine("Ingrese el dato \"Y\" a elavar a la " + N1 + " potencia");
                        N3 = Double.Parse(Console.ReadLine());
                        N2 = Math.Pow(N3,N1 );
                        Console.WriteLine("La potencia \"" + N1 + "\" del numero \"" + N3 + "\" es igual a: " + N2);
                        go = 0;
                        break;
                    case "f":
                        if (N1 % 2 == 0)
                        {
                            Console.WriteLine("El numero \" " +N1+ " \"  es par.");
                        }
                        else
                        {
                            Console.WriteLine("El numero\"" + N1 + "\" es impar.");
                        }
                        go = 0;
                        break;
                    case "g":
                        Console.WriteLine("Fue un placer de ayudar con este sistema \n hasta la proxima");
                        go = 1;
                        break;
                    default:
                        go = 0;
                        break;
                }
                Console.WriteLine("\n Puedes presionar la tecla que sea si quieres continuar!!");
                Console.ReadKey();
            } while (go == 0);
        }
    }
}
