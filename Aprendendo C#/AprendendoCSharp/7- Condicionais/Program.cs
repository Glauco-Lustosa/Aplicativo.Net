using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 7- Condicionais");

            int idade = 17;
            int quantidade =2;
            string acesso = "Acesso Permitido";
            string acesso2 = "Acesso Negado";


            if (idade >= 18)
            {
                Console.WriteLine(acesso);




            }
            else
            {
                if (quantidade >= 2)
                {
                    Console.WriteLine("Esta acompanhado " + acesso);


                }
                else
                {
                    Console.WriteLine(acesso2);
                }

                

            }
         Console.ReadLine();

        }
    }
}
