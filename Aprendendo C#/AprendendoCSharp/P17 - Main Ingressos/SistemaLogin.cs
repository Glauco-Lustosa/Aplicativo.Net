using System;

namespace CriandoLogin


{
    public class SistemaLogin
    {


        string nomeDigitado;
        string nomeConferir;
        string senhaDigitado;
        string senhaConferir;




        public void CriandoLogin()
        {
                      
            Console.WriteLine(" Crie seu login agora ");
            nomeDigitado = Console.ReadLine();
            Console.WriteLine("O nome criado foi : " + nomeDigitado);
            limparCampos();



            Console.WriteLine(" Crie Sua Senha agora ");
            senhaDigitado = Console.ReadLine();
            Console.WriteLine(" Sua senha é " + senhaDigitado);
            limparCampos();


            Console.WriteLine(" Confirme seus dados ");
            Console.WriteLine(" Digite sua conta novamente ");
            nomeConferir = Console.ReadLine();
            limparCampos();

            Console.WriteLine(" Confirme seus dados ");
            Console.WriteLine(" Digite sua senha novamente ");
            senhaConferir = Console.ReadLine();
            limparCampos();


            Verificar();

            

        }


        public void Verificar()
        {


            if (nomeDigitado == nomeConferir)
            {
                Console.WriteLine("Nome Confirmado com sucesso ");

                if (senhaDigitado == senhaConferir)
                {
                    Console.WriteLine("Senha Confirmada com sucesso ");

                    limparCampos();

                }
                else
                {
                    Console.WriteLine("Senha incorreta ");
                    limparCampos();
                }

                limparCampos();
            }
            else
            {
                Console.WriteLine("O nome informado esta errado ");

            }

        }



        public void limparCampos()
        {

            Console.ReadLine();
            Console.Clear();
            Console.Beep();

        }














    }

}
