//Requisitos
//Requisito 01: 
//Nossa calculadora deve ter a possibilidade de somar dois números

//Requisito 02: 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma

//Requisito 03:
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

//Requisito 04: 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
 
//Requisito 05

//Nossa calculadora deve validar a opções do menu


//BUG 01
 
//    Nossa calculadora deve realizar as operações com "0"  

//BUG 02

//      Nossa calculadora deve realizar as operações com números com duas casas decimais

using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string strPrimeiroNumero, strSegundoNumero;
            string opcao;

            float primeiroNumero, segundoNumero, resultadoOperacao = 0f;
            Console.WriteLine("Digite 1 para calculadora, ou qualquer coisa para as outras questoes");
            string questao = Console.ReadLine();
            if (questao == "1")
            {
            do
            {
                Console.WriteLine("Calculadora Top 1.3");

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicar");

                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;
                else if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("As opções válidas são de 1 - 5 ou s");
                    continue;
                }    
                 
                Console.Write("Digite o primeiro número: ");

                strPrimeiroNumero = Console.ReadLine();

                Console.Write("Digite o segundo número: ");

                strSegundoNumero = Console.ReadLine();

                primeiroNumero = float.Parse(strPrimeiroNumero);

                segundoNumero = float.Parse(strSegundoNumero);                

                if (opcao == "1")
                {
                    resultadoOperacao = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultadoOperacao = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    resultadoOperacao = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {
                    try
                    {                        
                        resultadoOperacao = primeiroNumero / segundoNumero;
                    }
                    catch (DivideByZeroException div)
                    {
                        Console.WriteLine(div.Message);
                        continue;
                    }
                }

                Console.WriteLine(Math.Round(resultadoOperacao, 2));

                //Console.ReadLine();               
            }

            while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4");
        }
        else            
            View1.questoes();           
            }
    }
}