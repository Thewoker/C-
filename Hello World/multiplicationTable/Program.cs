namespace multiplicationTable
{

    class Program
    {

       
        static void Main (string[] args)
        {
            /*Realice un programa que solicite al usuario el ingreso de un número
            y que le muestre los diez primeros valores de la tabla de multiplicar de ese número.*/
            int number = 0;

            Console.WriteLine("Enter the number which you want to know its multiplication table");
            number = int.Parse(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
               
                Console.WriteLine(number + " * "  + i + " = " + (number*i) );
            }

        }
    }
}