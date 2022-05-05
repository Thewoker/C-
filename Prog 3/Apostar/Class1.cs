using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apostar
{
    internal class Dado
    {
        int num;

        public int Num { get { return num; } }

        public int DevolverResultadoDado() {
            

            num = new Random().Next(1,7);

            return num;
        }
    }
}
