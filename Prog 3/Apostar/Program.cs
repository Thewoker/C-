using System;

namespace Apostar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numeroApostado;
            Dado dado = new Dado();


            Console.WriteLine("Ingresa un numero al que deseas apostar!!");
            int.TryParse(Console.ReadLine(), out numeroApostado);

            

            if (dado.DevolverResultadoDado() == numeroApostado)
            {
                Console.WriteLine($"Acertaste Felicidades!!. Toco el {dado.Num}");
            }
            else
            {
                Console.WriteLine($"\nErraste, Suerte la proxima. Toco el {dado.Num}");
            }
        }
    }
}
