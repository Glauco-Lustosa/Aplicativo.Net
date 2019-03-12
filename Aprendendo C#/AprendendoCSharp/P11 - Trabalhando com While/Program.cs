using System;

namespace P11___Trabalhando_com_While
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorinvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <=12)
            {
                valorinvestido = valorinvestido + valorinvestido * 0.0036;

                Console.WriteLine(" Apos " + contadorMes + " mes,voce tera R$ " + valorinvestido);

                contadorMes++;
            }



            Console.ReadLine();






        }
    }
}
