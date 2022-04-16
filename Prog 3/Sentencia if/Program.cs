using System;
namespace SentenciaIf
{
    public static class SentenciaIF
    {
        public static void Main (string[] args)
        {
            //Se crea una variable llamada keyinfo de tipo ConsoleKey Info
            ConsoleKeyInfo keyinfo;
            String texto;
            
            
            Console.WriteLine("Ingresa un texto");
            texto = Console.ReadLine();

            if(texto.Length == 0) { return; }

            Console.WriteLine("Vamos a ver tu texto... Como deseas verlo?.\n1. para(Mayusculas)\n2. para (Minusculas)\n3. para (Original)");
            
            // Se le aplica el metodo readkey que se guarda en la variable de tipo keyinfo declarada anteriormente
            keyinfo = Console.ReadKey();

            // Se realiza la evaluacion y modificacion del texto
            if (keyinfo.Key == ConsoleKey.D1)
            {
                Console.WriteLine("\n");
                Console.WriteLine(texto.ToUpper());
            }
            if (keyinfo.Key == ConsoleKey.D2)
            {
                Console.WriteLine("\n");
                Console.WriteLine(texto.ToLower());
            }
            if (keyinfo.Key == ConsoleKey.D3)
            {
                Console.WriteLine("\n");
                Console.WriteLine(texto);
            }
            else { Console.WriteLine("\nAdios"); }




        }
    }
}
