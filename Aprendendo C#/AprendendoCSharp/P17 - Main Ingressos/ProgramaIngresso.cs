using CriandoLogin;
using FilmesList;
using Pagamento;
using System;



namespace P17___Main_Ingressos
{
    class ProgramaIngresso
    {



        static void Main(string[] args)
        {


            Console.WriteLine("P17 - Sistema de cadastro e Compras");
            Console.WriteLine("");

            SistemaLogin logincreator = new SistemaLogin();
            logincreator.CriandoLogin();

            Console.WriteLine("Escolha o seu filme ");

            ListaDeFilmes novalista = new ListaDeFilmes();
            novalista.filmesDisponiveis();
            novalista.marvel();
            logincreator.limparCampos();
           

            Console.WriteLine("Escolha o tipo do seu Ingresso");


            SistemaPagamento novoSistema = new SistemaPagamento();
            novoSistema.EscolhaIngressos();

            Console.ReadLine();


















        }










    }
}
