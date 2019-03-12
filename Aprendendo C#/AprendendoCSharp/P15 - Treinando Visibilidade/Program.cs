using System;
using BibliotecaLogin;

namespace Visibilidade
{
    public class Program
    {




        static void Main(string[] args)
        {

             Login novoLog = new Login();
             novoLog.glauco = "Sua Conta aqui";
            
       
            Console.WriteLine(novoLog.glauco);

            Console.WriteLine("Digite alguma coisa aqui");
            novoLog.Glauco = Console.ReadLine();
            Console.WriteLine(novoLog.Glauco);

            if (novoLog.verificador == true)
            {

                Console.WriteLine("Acesso Liberado");


            }
            else
            {
                Console.WriteLine("Acesso Negado");


            }



            Console.ReadLine();







        }
    }
}
