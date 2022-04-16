using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yearMounthDay
{
    internal class mounthDay
    {
        private String[] diasSemana = new String[7];
        private String[] diasMes = new String[32];
        private String[] diasAno = new String[365];

        public void setDiasSemana(String day, int position)
        {
            this.diasSemana[position] = day;
        }
        public String getDiasSemana(int position)
        {
            return this.diasSemana[position];
        }

        public String getDiasMes(int position)
        {
            return this.diasMes[position];
        }


        public void diasDelMes(int cantDias)
        {

        }
    }
}
