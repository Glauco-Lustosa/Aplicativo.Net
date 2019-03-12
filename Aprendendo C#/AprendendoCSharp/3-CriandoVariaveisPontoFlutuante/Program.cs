using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            string cabeçalho;
            cabeçalho = "Meu salario é: ";

            // .NET ele le o ponto como virgula na hora de Compilar.
            double salario;
            salario = 1200.70;

            Console.WriteLine(cabeçalho + salario );
            // Para fazer contas com Double o numero tem que estar com ponto flutuante se não na hora da Compilação ele acaba perdendo o numero depois da Virgula.
            double idade;
            idade = 15.0 / 2.0;

            Console.WriteLine(cabeçalho + idade);



            Console.WriteLine("A execução acabou.Tecle enter para sair. . . ");
            Console.ReadLine();
           









        }
    }
}
