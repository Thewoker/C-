using System;

namespace Fechas

{
    public static class Fechas
    {
        static void Main(string[] args)
        {

            

            DateTime[] fecha1 = { Convert.ToDateTime("03/03/2020 00:00:00"), Convert.ToDateTime("04/04/2020 00:00:00") };
            DateTime[] fecha2 = { Convert.ToDateTime("05/05/2020 00:00:00"), Convert.ToDateTime("06/06/2020 00:00:00") };
            DateTime[] fecha3 = { Convert.ToDateTime("07/07/2020 00:00:00"), Convert.ToDateTime("08/08/2020 00:00:00") };
            DateTime[] fecha4 = { Convert.ToDateTime("09/09/2020 00:00:00"), Convert.ToDateTime("10/10/2020 00:00:00") };
            DateTime[] fecha5 = { Convert.ToDateTime("25/05/2020 00:00:00"), Convert.ToDateTime("25/07/2020 00:00:00") };

            DateTime[][] fechasAComprobar = { fecha1, fecha2, fecha3, fecha4, fecha5 };

            for (int i = 0; i <= fechasAComprobar.Length; i++)
            {
                for (int j = 1; j <= fechasAComprobar.Length; j++)
                {
                try
                {
                    if (UnirONoFechas(fechasAComprobar[i], fechasAComprobar[j]) != null)
                    {
                        fechasAComprobar[i] = UnirONoFechas(fechasAComprobar[i], fechasAComprobar[j]);
                    }

                }catch (Exception ex) { }
                }
            }

            //deberia imprimir empieza el 5/5 y termina el 8/8
            for (int i = 0; i <= fechasAComprobar.Length; i++) 
            {
                for (int j = 0; j <2; j++)
                {
                    Console.WriteLine($"{fechasAComprobar[i][j]}");

                }
                Console.WriteLine("\n");
            }
                
        
            
            

            
            
            
        }

        
        public static DateTime[] UnirONoFechas(DateTime[] fecha1, DateTime[] fecha2)
        {
            //En caso de que se puedan anidar
            DateTime[] fechaAnidadas = new DateTime[2];

            //si el inicio de una fecha1 el menor que el final de fecha2 y el inicio de fecha1 es mayor que que el inicio de fecha2  OO
            //el final de fecha1 es mayor al inicio de fecha2 y el final de fecha1 es menor al final de fecha2
            try
            {
                if (fecha1[0] <= fecha2[1] && fecha1[0] >= fecha2[0] || fecha1[1] >= fecha2[0] && fecha1[1] <= fecha2[1])
                {
                    //inicio menor al inicio y final menor al final
                    if (fecha1[0] <= fecha2[0] && fecha1[1] <= fecha2[1])
                    {
                        fechaAnidadas[0] = fecha1[0];
                        fechaAnidadas[1] = fecha2[1];
                        return fechaAnidadas;
                    }
                    //inicio mayor al inicio y final mayor al final
                    if (fecha1[0] >= fecha2[0] && fecha1[1] <= fecha2[1])
                    {
                        fechaAnidadas[0] = fecha2[0];
                        fechaAnidadas[1] = fecha1[1];
                        return fechaAnidadas;

                    }
                    //inicio mayor al inicio y final menor al final
                    if (fecha1[0] >= fecha2[0] && fecha1[1] <= fecha2[1])
                    {
                        fechaAnidadas[0] = fecha2[0];
                        fechaAnidadas[1] = fecha2[1];
                        return fechaAnidadas;
                    }
                }
            }catch (Exception ex)
            {
                return null;
            }


            return null;
        }
        
        
        
        
    }
    
}