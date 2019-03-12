using System;

namespace Exercicio_Imposto_de_Renda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Imposto de Renda");

            double salario = 3300.0;

            double qualquer  {
                get {

                    return 1;
                }
                
            }
                
            Console.WriteLine(qualquer);


            if (salario >= 1900.00 || salario <= 2800.0)
            {
                Console.WriteLine("Valor do IR 7.5% , Valor r$ 142 Reais");






            }
            else if (salario >= 2800.01 || salario <= 3751.0)
            {

                Console.WriteLine("Valor do IR 15% , Valor R$ 350 Reais");





            }
            else if (salario >= 3751.01 || salario <= 4664.00)
            {
                Console.WriteLine("Valor do IR é de 22,5% , Valor R$ 636 Reais");
            }













        }
    }
}
