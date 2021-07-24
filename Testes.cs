using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestesL
{
    class Testes
    {
        //questão 1
        static int CalcularFatorial(int num)
        {
            var result = 0;

            for (; num > 0; num--)
            {
                if (num-1 != 0)
                {
                    result = num * (num - 1);
                }
            }

            return result;
        }
        //questão 2
        static double CalcularPremio(int prizeVal, string type, int overridePrize)
        {
            double result = 0;

            if (overridePrize != null)
            {
                if (overridePrize > 0)
                {
                    result = prizeVal * overridePrize;
                }
                else
                {
                    Console.WriteLine("Multiplicador próprio inválido!");
                    result = prizeVal;
                }
                
            }
            else
            {
                result = type switch
                {
                    "vip" => prizeVal * 1.2,
                    "premium" => prizeVal * 1.5,
                    "deluxe" => prizeVal * 1.8,
                    "special" => prizeVal * 2,
                    _ => result
                };
            }
            
            return result;
        }
        //questão 3
        static int ContarNumerosPrimos(int num)
        {
            int result = 0;

            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        break;
                    }
                }

                result++;

            }

            return result;
        }
        //questão 4
        static int CalcularVogais(string palavra)
        {
            int result = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i].Equals("a") || palavra[i].Equals("e") || palavra[i].Equals("i") || palavra[i].Equals("o") || palavra[i].Equals("u"))
                {
                    result++;
                }
            }
            
            return result;
        }
        //questão 5
        static string CalcularValorComDescontoFormatado(string preco, string desconto)
        {
            double auxDesconto;
            double resultParsed;
            int precoParsed;
            int descontoParsed;
            
            precoParsed = Int32.Parse(Regex.Replace(preco, "[^0-9]", ""));
            descontoParsed = Int32.Parse(Regex.Replace(desconto, "[^0-9]", ""));
            auxDesconto = descontoParsed * 0.01;

            resultParsed = precoParsed - (precoParsed * auxDesconto);

            return resultParsed.ToString();
        }
        //questão 6
        static int CalcularDiferencaData(string dataFinal, string dataInicial)
        {
            int result = 0;
            DateTime dataFinalParsed;
            DateTime dataInicialParsed;
            
            dataFinalParsed = DateTime.Parse(dataFinal);
            dataInicialParsed = DateTime.Parse(dataInicial);

            result = (dataFinalParsed - dataInicialParsed).Days;
            
            return result;
        }
        //questão 7
        static int[] ObterElementosPares(int[] vetor)
        {
            int[] result = new int[]{};

            for (int i = 0; i < vetor.Length; i++)
            {
                if ((vetor[i] % 2) == 0)
                {
                    result[i] = vetor[i];
                }
            }

            return result;
        }
        //questão 8
        static string[] BuscarPessoa(string[] vetor, string nomeBusca)
        {
            string[] result = new String[]{};

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Contains(nomeBusca))
                {
                    result[i] = vetor[i];
                }
            }

            return result;
        }
        //questão 9
        static int[][] TransformarEmMatriz(string vetorInts)
        {
            int k = 0;
            string[] auxArrayString = new string[] { };
            int[] auxArrayParsed = new int[] { };
            int[][] result = new int[][]{};

            auxArrayString = Regex.Split(vetorInts, @",");
            for (int i = 0; i < auxArrayString.Length; i++)
            {
                auxArrayParsed[i] = Int32.Parse(auxArrayString[i]);
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i][j] = auxArrayParsed[k];
                    k++;
                }
            }
            
            return result;
        }
        //questão 10
        static int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {
            int[] result = new int[] { };

            result = vetor1.Except(vetor2).ToArray();
            
            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo! Bem-vindo a minha classe de exercícios em C#");
        }
    }
}