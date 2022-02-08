using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Xamarin.Forms;

namespace Calculadora.ConsoleApp
{
    public class View1
    {
    public static void questoes() 
        {

            string option = Console.ReadLine();
            string n1, n2;
            while (true)
            {
                Console.WriteLine("1 - Para Imobiliária |\n2 - Para Hotpão\n3 - Para nome e idade\n4 - Para temperatura\n " +
                "5 - Para salário\n 6 - Para Sair !!!");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Digite o primeiro número : ");
                    n1 = Console.ReadLine();
                    Console.WriteLine("Digite o segundo número : ");
                    n2 = Console.ReadLine();
                    float area = calculaTerreno(n1, n2);
                    Console.WriteLine("A área do terreno é de " + area + "unidades de medida");
                }

                else if (option == "2")
                {
                    Console.WriteLine("Digite o primeiro número : ");
                    n1 = Console.ReadLine();
                    Console.WriteLine("Digite o segundo número : ");
                    n2 = Console.ReadLine();

                    float total = calculaHotpao(n1, n2);
                    float poupanca = total * 0.1f;
                    Console.WriteLine("O lucro com paes e broas foi de " + total + ", ele deve guardar "
                        + poupanca + "na poupanca");
                }

                else if (option == "3")
                {
                    Console.WriteLine("Digite o primeiro número : ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o segundo número : ");
                    string idade = Console.ReadLine();

                    int dias = calculaIdade(idade);

                    Console.WriteLine(nome + "voce ja viveu " + dias + " dias.");
                }

                else if (option == "4")
                {
                    Console.WriteLine("Digite a temperatura em graus celcius");
                    string celcius = Console.ReadLine();
                    float fahn = calculaTemperatura(celcius);
                    Console.WriteLine(celcius + "Cº equivalem a " + fahn + "Fº.");
                }

                else if (option == "5")
                {
                    Console.WriteLine("Digite o salario");
                    string sal = Console.ReadLine();
                    float salario = calculaSalario(sal);
                    float desc = salario * 0.92f;
                    Console.WriteLine("O salario eh de : " + sal + "com aumento fica " + salario + "e com o desconto fica "
                    + desc);

                }
                else if (option == "6")
                    break;
            }
        }
    public static float calculaTerreno(string floor, string height)
    {
            float n1, n2;
            n1 = float.Parse(floor);
            n2 = float.Parse(height);
            float resul = n1 * n2;
            return resul;
        } 
    public static float calculaHotpao(string broa, string pao)
    {
        int n1, n2;
        n1 = Convert.ToInt32(broa);
        n2 = Convert.ToInt32(pao);
        float total = n1 * 1.5f + (n2 * 0.12f); 
        return total;
    }
    public static int calculaIdade(string idade)
        {
            int idadeInt = Convert.ToInt32(idade);            
            return idadeInt * 365;
        }
    public static float calculaTemperatura(string celcius)
    {
        float fahn =    float.Parse(celcius) * 1.8f + 32;
        return fahn ;
    }

    public static float calculaSalario(string salario)
    {
        float salarioAumento = float.Parse(salario) * 1.15f;
        return salarioAumento;
    }
    }
}