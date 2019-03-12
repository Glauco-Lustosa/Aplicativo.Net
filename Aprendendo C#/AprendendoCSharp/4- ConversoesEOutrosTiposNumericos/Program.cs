using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            // Double admite pontos flutuantes
            double salario = 1200.50;
            Console.WriteLine(salario);
            // O valor INT só suporta um valor de até 32 bits um pouco maior que  2BI.
            int salarioINT = (int)salario;// Essa linha estamos fazendo um cast ou seja transformando um numero double em INT.
            Console.WriteLine(salarioINT);
            // Long é um valor INT porem ele ocupa 64bits ou seja ocupa mais espaço na memoria.
            long idade = 1300000000;
            Console.WriteLine(idade);

            // Short é um numero de 16 bits de memoria que o valro maximo é 16 mil.
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            // Tem uma precisao mais curta de numeros depois da casa decimal. Como o float nao é muito usado temos que usar o sufixo F para expecificar um float
            float altura = 1.80f;
            Console.WriteLine(altura);
                       
            Console.ReadLine();








        }
    }
}
