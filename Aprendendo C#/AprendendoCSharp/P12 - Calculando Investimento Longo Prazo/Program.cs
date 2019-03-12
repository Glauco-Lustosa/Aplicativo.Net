using System;

namespace P12___Calculando_Investimento_Longo_Prazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12");

            double rendimento = 1.0036;
            double valorInvestido = 1000;


            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {

                    valorInvestido *= rendimento;


                }
                rendimento += 0.0010;
            }

            Console.WriteLine(" Ao Termino do investimento , voce tera R$ " + valorInvestido);


            Console.ReadLine();






        }
    }
}
