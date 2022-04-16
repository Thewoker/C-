using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public class CajeroAutomatico
    {
        private string direccion;
        private int id;

        public CajeroAutomatico(string direccion)
        {
            this.direccion = direccion;
            this.id = new Random().Next(1, 10000);
            
        }

        
        

        public override string ToString()
        {
                    


            return $"Direccion: {direccion}\nID Cajero: {id}" ;
        }
    }
}
