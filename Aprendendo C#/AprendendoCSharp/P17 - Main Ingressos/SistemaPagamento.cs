using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento

{
    class SistemaPagamento
    {

        public double valorIngresso = 32.90;
       
        

        public void EscolhaIngressos() {

            Console.WriteLine("1- Ingresso tipo Inteiro");

            Console.WriteLine("2- Ingresso tipo Meia");


            string ingresso = "";
            ingresso = Console.ReadLine();
            int newingresso = Convert.ToInt32(ingresso);


            if (newingresso == 1)
            {
                Console.WriteLine("O Ingresso escolhido foi Inteiro , O valor é de:" + valorIngresso);





            }
            else if (newingresso == 2)
            {
                Console.WriteLine("O Ingresso escolhido foi meia , O valor é de:" + valorIngresso/2);




         






            }














        }



      
    }
}
