using System;
namespace LoginBiblioteca
{
    public class Login
    {

        private string glauco;
        private string senha;

        public Login(string novoNome,string novaSenha)
        {
            glauco = novoNome;
            senha = novaSenha;


        }

     

        public void tentativaDeNome(string tentativaNome)
        {
            if (tentativaNome == glauco)
            {
                Console.WriteLine(" Nome Correto ");
                Console.WriteLine("Digite sua senha ");
                string nomeDaSenha = Console.ReadLine();
                tentativaDeSenha(nomeDaSenha); 

            }
            else 
            {
                Console.WriteLine("Nome incorreto , tente novamente ");
                string nomeDoLogin = Console.ReadLine();
                tentativaDeNome(nomeDoLogin);

            }
            

        }

        public void tentativaDeSenha(string tentativaSenha)
        {

            if (tentativaSenha == senha)
            {
                Console.WriteLine(" Senha Correto ");


            }
            else
            {
                Console.WriteLine("Senha incorreto , tente novamente ");
                string nomeDaSenha = Console.ReadLine();
                tentativaDeSenha(nomeDaSenha);

            }


        }

    }
}