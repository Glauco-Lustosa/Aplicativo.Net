using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Criando_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 23;

            Console.WriteLine("Minha idade é " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("C# irá dar preferencia a regra matemática efetuando primeiro a multiplicação "+ idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Porém no momento se a gente colocar parenteses ele irá dar preferencia ao que esta dentro do mesmo " + idade);


            Console.WriteLine("Execução finalizada tecle enter para sair");

            Console.ReadLine();


        }
    }
}
