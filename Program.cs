using System;

namespace Aula_PassagemAereas
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();

           bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            string[] nomes = new string[5];
            string[] destino = new string [5];
            string[] origem = new string[5];
            string[] data = new string [5];

            Console.Clear();
            
            Console.WriteLine("----Sistema de passagens aéreas----");
            
            
            
            do
            {
               Console.WriteLine("Digite a senha para acessar o sistema");
               string senha = Console.ReadLine();
               senhaValida = EfetuarLogin(senha);
               
            } while (!senhaValida);


            do
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro de passagens");
                        do
                        {
                            if(contador < 5 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º passageiro");
                            nomes[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o destino do voo: ");
                            destino[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a origem do voo: ");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a data do voo: ");
                            data[contador] = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Limite excedido!");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar outro passageiro? ");
                            resposta = Console.ReadLine();
                           }while (resposta == "Sim");
                           Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Listar passagens");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro: {nomes[i]} -- Destino: {destino[i]} -- Origem: {origem[i]} -- Data do voo: {data[i]} --");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por viajar conosco!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (escolha != 0);
            
            bool EfetuarLogin(string senha){
               if (senha == "passagem_aereas"){
                   return true;
               }else{
                   Console.WriteLine("Senha inválida, digite de novo!");
                   return false;
               }

            }
    }
}
}
