using System;

namespace P12___Trabalhando_Com_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine(" Após " + contadorMes + " meses, voce terá " + valorInvestido);








            }




            Console.ReadLine();









        }
    }
}
