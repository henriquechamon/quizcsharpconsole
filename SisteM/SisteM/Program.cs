using System;

namespace Quiz

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pontos = 0;
        Inicio:
            Console.Clear();
            Console.Title = "Quiz C#";
            Console.WriteLine("Seja muito bem-vindo ao quiz em c#! (Console)");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Questão 1. Qual a cor que mais se assemelha ao sol?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("a. Azul");
            Console.WriteLine("b. Amarelo");
            Console.WriteLine("c. Rosa");
            string respostaq1 = Console.ReadLine();
            if (respostaq1 == "a")
            {
                Console.WriteLine("Resposta incorreta! Tente novamente ");
                Thread.Sleep(3000);
                goto Inicio;
            }
            if (respostaq1 == "b")
            {
                Console.WriteLine("Correto! Você ganhou 200 pontos. ");
                pontos = +200;
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Questão 2. Qual o nome correto do homem-aranha?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("a. Harry Styles");
                Console.WriteLine("b. Robin");
                Console.WriteLine("c. Peer-parker");
                string respostaq2 = Console.ReadLine();
                if (respostaq2 == "a")
                {
                    Console.WriteLine("Resposta incorreta! Tente novamente ");
                    Thread.Sleep(3000);
                    goto Inicio;

                }
                if (respostaq1 == "b")
                {
                    Console.WriteLine("Resposta incorreta! Tente novamente ");
                    Thread.Sleep(3000);
                    goto Inicio;
                }
                if (respostaq1 == "c")
           
                    Console.WriteLine("Correto! Você ganhou 200 pontos! ");
                    pontos = +200;
                    Thread.Sleep(3000);
                    Console.Clear();
                Console.WriteLine($"Fim! Total de pontos: {pontos} ");
                Thread.Sleep(4000);
                goto Inicio;
                }
            }
            if (respostaq1 == "c")
            {
                Console.WriteLine("Resposta incorreta! Tente novamente ");
                Thread.Sleep(3000);
                goto Inicio;
            }



        }
    }
}