using LoginBiblioteca;
using System;
namespace P16___Sistemas_de_Login
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string nome;
            string senha;
            Console.WriteLine("Crie seu nome ");
            nome = Console.ReadLine();

            Console.WriteLine("Crie sua senha ");
            senha = Console.ReadLine();

            Login novoLogin = new Login(nome,senha);


            Console.WriteLine("Digite seu Nome ");
            string nomeDoLogin = Console.ReadLine();
            novoLogin.tentativaDeNome(nomeDoLogin);

            Console.ReadLine();
            
            


        }
    }
}
