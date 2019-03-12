using System;

namespace _7__Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idade = 17;
            int quantidade = 2;
            string acesso = "Acesso Permitido";
            string acesso2 = "Acesso Negado";
            bool acompanhado = quantidade >= 2;

            // || --> significa ou && --> Significa e 
            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine(acesso);

            }
            else
            {
                Console.WriteLine(acesso2);

            }
            Console.ReadLine();

        }
    }
}
