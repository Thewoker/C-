using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero 
{
    public class Caja
    {
        //Datos
        private int id;
        private int antiguedadEnPositivo;
        private double dinero;
        private Persona cliente;
        private CajeroAutomatico cajero;
        

        //Constrctor
        public Caja(Persona cliente, double dinero, CajeroAutomatico cajero)
        {
            this.cliente = cliente;
            this.dinero = dinero;
            this.cajero = cajero;


            

            //Se genera un numero random para asginarlo a ID
            this.id = new Random().Next(1, 10000); ;
        }


        //**getters & setters

        public double Dinero
        {
            get { return dinero; }
            
        }

        //**Metodos**
        

        //Meter Plata
        public void IngresoDinero(double dineroIngresado)
        {

            this.dinero +=dineroIngresado;
            Console.WriteLine($"Tu Saldo es de {this.dinero}");
        }
        


        //Sacar Plata
        public void SacarDinero(double dineroSacado)
        {
            bool aptoCredito;
            Registro registro = new Registro(dineroSacado, cajero, ToString());


            //Operacion apto para credito
            if (registro.Meses() > 2)
            {
                aptoCredito = true;
                
            }
            else aptoCredito = false;

            //Si es apto de credito
            if (dinero >= 0 && ((dinero - dineroSacado) >= -80000) && aptoCredito)
            {
                this.dinero -= dineroSacado;
                
                Console.WriteLine("bbbrrrrrrrrrrbrrrrrrrrrrrbrrrrr...");
                registro.RegistroDeTodo();
                return;

            }
            //Si esta Activo
            if (dinero >= 0 && ((dinero - dineroSacado) >=-20000) && cliente.EnActividadLaboral)
            {
                this.dinero -= dineroSacado;
                
                Console.WriteLine("bbbrrrrrrrrrrbrrrrrrrrrrrbrrrrr...");
                registro.RegistroDeTodo();

            }
            //Si es Jubilado
            if (dinero >= 0 && ((dinero - dineroSacado) >= -10000) && !cliente.EnActividadLaboral)
            {
                this.dinero -= dineroSacado;
                new Registro(dineroSacado, cajero, ToString());
                Console.WriteLine("bbbrrrrrrrrrrbrrrrrrrrrrrbrrrrr...");
            }


            Console.WriteLine($"Tu Saldo es de {this.dinero}");
        }

        //Motodo toString
        public override string ToString()
        {
            return $"\n\nCaja: {id}\n{cliente.ToString()}\nDinero: {dinero}\n";
        }


    }
}
