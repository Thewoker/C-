using System;

public class Program
{
	public static void Main()
	{
		/*Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes
		de marzo de 2022 fue un martes. Luego con esta información el sistema debe poder calcular que día será,
		el correspondiente a una fecha dada. Por lo cual el sistema podría preguntar, ingrese una fecha del mes 
		de marzo y le diré que día cae.*/
		String[] diasSemana = new String[7];
		String[] diasMes = new String[31];
		int contDias = 0;

		diasSemana[0] = "Lunes";
		diasSemana[1] = "Martes";
		diasSemana[2] = "Miercoles";
		diasSemana[3] = "Jueves";
		diasSemana[4] = "Viernes";
		diasSemana[5] = "Sabado";
		diasSemana[6] = "Domingo";

		while (contDias < 31)
		{

			for (int i = 0; i < 31; i += 0)
			{
				for (int j = 0; j < 7; j++)
				{
					if (i < 31) { diasMes[i] = diasSemana[j]; }
					i++;
				}
				contDias++;
			}

		}

		Console.WriteLine("Ingresa la fecha del mes que deseas conocer el dia de la semana");
		int diaElegido = int.Parse(Console.ReadLine());
		Console.WriteLine(diasMes[diaElegido]);



	}
}