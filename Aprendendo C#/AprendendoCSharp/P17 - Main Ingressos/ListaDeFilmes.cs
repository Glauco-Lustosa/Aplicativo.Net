using System;


namespace FilmesList
{
    class ListaDeFilmes

    {
        public void marvel()
        {
            string filmes = "";
            filmes = Console.ReadLine();
            int filme = Convert.ToInt32(filmes);

            switch (filme)
            {
                case 1:
                    Console.WriteLine("Homem de Ferro ");
                    break;

                case 2:
                    Console.WriteLine("o Incrivel Hulk");
                    break;

                case 3:
                    Console.WriteLine("Homem de Ferro 2");
                    break;

                case 4:
                    Console.WriteLine(" Thor");
                    break;
                case 5:
                    Console.WriteLine("Capitão America: O Primeiro Vingador");
                    break;

                case 6:
                    Console.WriteLine("Os Vingadores ");
                    break;

                case 7:
                    Console.WriteLine("Homem De Ferro 3");
                    break;

                case 8:
                    Console.WriteLine("Thor: O Mundo Sombrio ");
                    break;

                case 9:
                    Console.WriteLine("Capitão America : Soldado Invernal");
                    break;

                case 10:
                    Console.WriteLine("Guardiões Das Galaxias ");
                    break;

                case 11:
                    Console.WriteLine("Vingadores : Era de Ultron");
                    break;

                case 12:
                    Console.WriteLine("Homem-Formiga ");
                    break;

                case 13:
                    Console.WriteLine("Capitão America:Guerra Civil ");
                    break;

                case 14:
                    Console.WriteLine("Doutor Estranho ");
                    break;

                case 15:
                    Console.WriteLine("Guardiões das Galáxias Vol.2 ");
                    break;

                case 16:
                    Console.WriteLine("Homem - Aranha: De Volta Ao Lar ");
                    break;

                case 17:
                    Console.WriteLine("Thor:Ragnarok");
                    break;

                case 18:
                    Console.WriteLine("Pantera Negra ");
                    break;

                case 19:
                    Console.WriteLine("Vingadores Guerra Infinita ");
                    break;

                case 20:
                    Console.WriteLine("Homem - Formiga e a Vespa");
                    break;

                case 21:
                    Console.WriteLine("Capitã Marvel ");
                    break;

                case 22:
                    Console.WriteLine("Vingadores Ultimato");
                    break;

                case 23:
                    Console.WriteLine("Spider-Man Far From home");
                    break;

                default:
                    Console.WriteLine("Filme selecionado Invalido ");


                    break;


            }

            









        }





        public void filmesDisponiveis()
        {

            Console.WriteLine("1- Homem de Ferro ");

            Console.WriteLine("2- O Incrivel Hulk");

            Console.WriteLine("3- Homem de Ferro 2");

            Console.WriteLine("4- Thor");

            Console.WriteLine("5- Capitão America: O Primeiro Vingador");

            Console.WriteLine("6- Os Vingadores ");

            Console.WriteLine("7- Homem De Ferro 3");

            Console.WriteLine("8- Thor: O Mundo Sombrio ");

            Console.WriteLine("9- Capitão America : Soldado Invernal");

            Console.WriteLine("10- Guardiões Das Galaxias ");

            Console.WriteLine("11- Vingadores : Era de Ultron");

            Console.WriteLine("12- Homem-Formiga ");

            Console.WriteLine("13- Capitão America:Guerra Civil ");

            Console.WriteLine("14- Doutor Estranho ");

            Console.WriteLine("15- Guardiões das Galáxias Vol.2 ");

            Console.WriteLine("16- Homem - Aranha: De Volta Ao Lar ");

            Console.WriteLine("17 - Thor:Ragnarok");

            Console.WriteLine("18 - Pantera Negra ");

            Console.WriteLine("19 - Vingadores Guerra Infinita ");

            Console.WriteLine("20- Homem - Formiga e a Vespa");

            Console.WriteLine("21- Capitã Marvel ");

            Console.WriteLine("22- Vingadores Ultimato");

            Console.WriteLine("23- Spider-Man Far From home");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Digite o Numero do Filme Desejado");









        }

        public void limparCampos()
        {

            Console.ReadLine();
            Console.Clear();
            Console.Beep();

        }




















    }
}
