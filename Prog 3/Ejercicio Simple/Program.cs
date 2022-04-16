using System;
namespace EjerciciosSimples
{
    public class EjerciciosSimple
    {
        public static void Main (string[] args)
        {
            int a;
            int b;
            int opcion;
            Console.WriteLine("Que operacion quieres realizar?\n1. Suma\n2.Resta\n3.Division\n4.Multiplicacion");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero para asignarle a la variable 'A'");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero para asignarle a la variable 'B'");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("A es igual a:" + a);
            Console.WriteLine("B es igual a:" + b);

            switch (opcion)
            {
                case 1: Console.WriteLine("Tu resultado es : " + (a + b));
                        break;
                case 2:
                    Console.WriteLine("Tu resultado es : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Tu resultado es : " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Tu resultado es : " + (a * b));
                    break;
                    default: Console.WriteLine("La opcion elegida no existe.");
                    break;

            }
        }
    }
}