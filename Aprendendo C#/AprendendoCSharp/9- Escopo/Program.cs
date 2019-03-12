using System;

namespace _7__Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 9 - Escopo");

            int idade = 17;
            string acesso = "Acesso Permitido";
            string acesso2 = "Acesso Negado";
            string mensagem;
            bool acompanhado = true;

            if (acompanhado == true)
            {
                mensagem = ("João esta acompanhado");

            }
            else
            {
                mensagem = ("João não esta acompanhado");
            }
           

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine(acesso);
                Console.WriteLine(mensagem);
            }
            else
            {
                Console.WriteLine(acesso2);

            }
            Console.ReadLine();

        }
    }
}
