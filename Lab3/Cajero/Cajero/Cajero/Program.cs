using System;
    
    namespace Cajero
{
    class Cajero
    {
        public static void Main(string[] args)
        {
            Registro registro = new Registro();
            Console.WriteLine(registro.AumentarMeses());
            Console.WriteLine(registro.AumentarMeses());
            Console.WriteLine(registro.AumentarMeses());
            Console.WriteLine(registro.AumentarMeses());
            Persona p1 = new Persona("Leonel FJR", 20);
            CajeroAutomatico ca1 = new CajeroAutomatico("AV. Siempre viva 1234");
            Caja c1 = new Caja(p1, 0, ca1);



            Console.WriteLine(c1.Dinero);
            c1.IngresoDinero(2000);
            Console.WriteLine(c1.Dinero);
            c1.SacarDinero(40000);
            Console.WriteLine(c1.Dinero);

        }
    }
}
