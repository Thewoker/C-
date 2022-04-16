using System;
using System.Collections; //Paquete para utilizar arraylist
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public class Registro
    {
        private double monto;
        private CajeroAutomatico cajero;
        private string cliente;
        ArrayList listaMovimientos = new ArrayList();

        //Contructores (2)
        public Registro(double monto, CajeroAutomatico cajero, string cliente)
        {
            this.monto = monto;
            this.cajero = cajero;
            this.cliente = cliente;
        }

        public Registro() { }

        

        public void RegistroDeTodo()
        {
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            listaMovimientos.Add($"{cliente}Monto Extraido: {this.monto}\n{cajero.ToString()}\nFecha: {Date}\n ");
            
            foreach (var item in listaMovimientos)
            {
                Console.WriteLine(item.ToString());
            }
        }


        //metodos


        //Pasar mes
        private static int mes = 0;
        public int Meses()
        {
            return mes;
        }
        public int AumentarMeses()
        {
            mes++;
            return mes;
        }
    }
}
