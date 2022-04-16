using System;

namespace media_y_desviacion_estandar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] alturaXPersona = new double[10];
            double[] restaElevadaAl2do = new double[10];
            double resultadoRestaElevadaAl2do = 0;
            double resultadoRaizCompleta = 0;
            double rangoPorEncima = 0;
            double rangoPorDebajo = 0;
            double acumuladorDeRestultados = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingresa la altura de la persona en la pocicion {i + 1}.\n");
                alturaXPersona[i] = double.Parse(Console.ReadLine());
                acumuladorDeRestultados = CalcularMedia(acumuladorDeRestultados, alturaXPersona[i], i);

            }

            for (int i = 0; i < 10; i++)
            {
                restaElevadaAl2do[i] = CalcualarDesviacionEstandar(alturaXPersona[i], acumuladorDeRestultados);
                Console.WriteLine(restaElevadaAl2do[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                resultadoRestaElevadaAl2do = resultadoRestaElevadaAl2do + restaElevadaAl2do[i];
            }

            Console.WriteLine($"\n\n{resultadoRestaElevadaAl2do}");

            resultadoRaizCompleta = CalculoRaizYNMenos1(resultadoRestaElevadaAl2do);

            Console.WriteLine($"\n\n{resultadoRaizCompleta}");


            for(int i = 0; i < 10; i++)
            {
                if(alturaXPersona[i] < acumuladorDeRestultados)
                {
                    Console.WriteLine($"La Persona N° {i + 1} esta por debajo de la media con, {alturaXPersona[i]}cm.\n");
                }
                else
                {
                    Console.WriteLine($"La Persona N° {i + 1} esta por encima de la media con, {alturaXPersona[i]}cm.\n");
                }
            }

            rangoPorEncima = acumuladorDeRestultados + resultadoRaizCompleta;
            rangoPorDebajo = acumuladorDeRestultados - resultadoRaizCompleta;

            Console.WriteLine("\n\nLas Personas que se encuentran dentro del estandar son:");

            for (int i = 0; i < 10; i++)
            {
                if(alturaXPersona[i] >= rangoPorDebajo && alturaXPersona[i] <= rangoPorEncima)
                {
                    Console.WriteLine($"Persona N° {i + 1} con {alturaXPersona[i]}cm.\n");
                }
            }


        }

        public static double CalcularMedia(double datoAcumulado, double datoIngresante, int posicion)
        {
            if (posicion < 9)
            {
                return  (datoAcumulado + datoIngresante);
            }
            else
            {
                return ((datoAcumulado + datoIngresante)/ (posicion+1));
            }
            
        }

        public static double CalcualarDesviacionEstandar(double alturaDelaPersona, double media)
        {
            return (Math.Pow((alturaDelaPersona - media), 2));
        }

        public static double CalculoRaizYNMenos1(double resultadoSuperior)
        {
            return (Math.Sqrt(resultadoSuperior / 9));
        }
    }
}
