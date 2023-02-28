using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace cbu
{
    internal class Verificar
    {
        string cbu = "";
        //Bloque 1
        string numBanco { set; get; }
        string numSucursal { set; get; }
        string numVerificador { set; get; }
        string numBancoYSucursal { set; get; }
        List<int> digVerificacionBanco = new List<int>() { 7, 1, 3, 9, 7, 1, 3 };
        List<int> digVerificacionCuenta = new List<int>() { 3, 9, 7, 1, 3, 9, 7, 1, 3, 9, 7, 1, 3 };
        //Bloque 2
        string numCuentaCliente { set; get; }
        string numVerificador2 { set; get; }
        Dictionary<string, string> bancos = new Dictionary<string, string>();

        public Verificar(string cbu, Dictionary<string, string> bancos)
        {
            this.cbu = cbu;
            DefBanco(cbu);
            DefSucursal(cbu);
            DefVerificador(cbu);
            DefBancoYSucursal(cbu);
            DefCuentaCliente(cbu);
            DefVerificador2(cbu);
            this.bancos = bancos;
            if (VerificarBanco() && VerificarCuenta())
            {
                MessageBox.Show($"Su banco, sucursal y cuenta fueron confirmados exitosamente.\n Tu banco es: {MostrartTuBanco()}");

            }
            else
            {
                MessageBox.Show($"CBU ingresado es invalido.");
            }
            

        }


        /*
         * cbu 285 0015  7  4009545123498  8
         *     012 3456  7  8901234567890  1
         *     971 3971     9713971397139
         */

        private void DefBanco(string cbu)
        {
            this.numBanco = cbu.Substring(0, 3);
            //MessageBox.Show(this.numBanco);
        }
        private void DefSucursal(string cbu)
        {
            this.numSucursal = cbu.Substring(3, 4);
            //MessageBox.Show(this.numSucursal);
        }
        private void DefVerificador(string cbu)
        {
            this.numVerificador = cbu.Substring(7, 1);
            //MessageBox.Show(this.numVerificador);
        }
        private void DefBancoYSucursal(string cbu)
        {
            this.numBancoYSucursal = cbu.Substring(0, 7);
            //MessageBox.Show(this.numBancoYSucursal);
        }
        private void DefCuentaCliente(string cbu)
        {
            this.numCuentaCliente = cbu.Substring(8, 13);
            //MessageBox.Show(this.numCuentaCliente);
        }
        private void DefVerificador2(string cbu)
        {
            this.numVerificador2 = cbu.Substring(21, 1);
            //MessageBox.Show(this.numVerificador2);
        }

        private bool VerificarBanco()
        {
            int suma = 0;
            for (int i = 0; i < numBancoYSucursal.Length ; i++)
            {
                suma = suma + Convert.ToInt32(numBancoYSucursal[i].ToString()) * digVerificacionBanco[i];
            }
            suma %= 10;
            if ((10 - suma) == Convert.ToInt32(numVerificador))
            {
                return true;
            }
            return false;
        }

        private bool VerificarCuenta()
        {
            int suma = 0;
            for (int i = 0; i < numCuentaCliente.Length; i++)
            {
                suma = suma + Convert.ToInt32(numCuentaCliente[i].ToString()) * digVerificacionCuenta[i];
            }
            suma %= 10;
            if ((10 - suma) == Convert.ToInt32(numVerificador2))
            {
                return true;
            }

            return false;
        }

        private string MostrartTuBanco()
        {
            foreach(KeyValuePair<string,string> banco in bancos)
            {
                if(banco.Key == numBanco)
                {
                    return $"{banco.Value}";
                }
            }

            return null;
        }

    }
}
