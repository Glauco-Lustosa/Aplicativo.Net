using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5- Caracteres e Textos");

            // So podemos ter 1 caracter dentro dessa variavel usar aspas simples
            char primeiraLetra = 'a' ;
            Console.WriteLine(primeiraLetra);

            // Fazendo o cast do 65 para char obtemos uma letra , que esta correspondente na tabela ASCII 
            primeiraLetra = (char) 65;
            Console.WriteLine(primeiraLetra);

            // É o tipo usado para representação de texto

            string titulo = "Carater de Texto";
            Console.WriteLine(titulo);
            string Cursos = @"1- .NET - 
2 - Java ";
            Console.WriteLine(Cursos);











            Console.ReadLine();








        }
    }
}
