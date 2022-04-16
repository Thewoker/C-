namespace yearMounthDay
{

    class Program
    {

        static void Main (string [] args)
        {

            String[] diasEnero = new String[31];
            String[] diasFebrero = new String[28];
            String[] diasMarzo = new String[31];
            String[] diasAbril = new String[30];
            String[] diasMayo = new String[31];
            String[] diasJunio = new String[30];
            String[] diasJulio = new String[31];
            String[] diasAgosto = new String[31];
            String[] diasSeptiembre = new String[30];
            String[] diasOctubre = new String[31];
            String[] diasNovienbre = new String[30];
            String[] diasDiciembre = new String[31];

            String[] diasSemana = new String[7];
            String[] diasAno = new String[365];

            diasSemana[0] = "Lunes";
            diasSemana[1] = "Martes";
            diasSemana[2] = "Miercoles";
            diasSemana[3] = "Jueves";
            diasSemana[4] = "Viernes";
            diasSemana[5] = "Sabado";
            diasSemana[6] = "Domingo";

            

            

            for (int i = 0; i < 365; i += 0)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i < 365) { diasAno[i] = diasSemana[j]; }
                    i++;
                }
            }






            void designarMeses(int diasDelMes, String[] mes)
            {
                String ultimoDia;

                for (int i = 1; i < diasDelMes+1; i += 0)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (i < diasDelMes + 1) { mes[i] = diasSemana[j]; }
                        i++;
                        ultimoDia = diasSemana[j];
                    }
                }

                

            }

        }

        
    }
}