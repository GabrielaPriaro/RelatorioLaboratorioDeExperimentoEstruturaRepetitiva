//Utilizando estrutura repetitiva For:
//Problema "experiencias" (adaptado de URI 1094)
//Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para
//organizar os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano,
//quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada. Este
//laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas
//informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia
//utilizada e a quantidade de cobaias utilizadas em cada experimento. Faça um programa que leia um
//valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um
//inteiro que representa a quantidade de cobaias utilizadas e uma letra ('C', 'R' ou 'S'), indicando o tipo
//de cobaia (R:Rato S:Sapo C:Coelho). Apresente o total de cobaias utilizadas, o total de cada tipo de
//cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o
//percentual deve ser apresentado com dois dígitos após o ponto. 

using System;
using System.Globalization;

namespace RelatorioLaboratorioDeExperimentoEstruturaRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, quantCobaias, totalCobaias, totalSapos, totalRatos, totalCoelhos;
            string tipoCobaia;
            double percSapos, percRatos, percCoelhos;

            CultureInfo CI = CultureInfo.InvariantCulture;

            totalCobaias = 0;
            totalSapos = 0;
            totalRatos = 0;
            totalCoelhos = 0;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                quantCobaias = int.Parse(Console.ReadLine());

                Console.Write("Tipo de cobaia (S - sapo, R - rato, C - coelho): ");
                tipoCobaia = Console.ReadLine();

                switch (tipoCobaia.ToUpper())
                {
                    case "S":
                        totalSapos = totalSapos + quantCobaias;
                        break;
                    case "R":
                        totalRatos = totalRatos + quantCobaias;
                        break;
                    case "C":
                        totalCoelhos = totalCoelhos + quantCobaias;
                        break;
                    default:
                        Console.WriteLine("Tipo de cobaia nao existe");
                        i--;
                        break;
                }

                totalCobaias = totalCobaias + quantCobaias;
            }

            percSapos = (double)totalSapos / totalCobaias * 100;
            percRatos = (double)totalRatos / totalCobaias * 100;
            percCoelhos = (double)totalCoelhos / totalCobaias * 100;

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine($"Total Cobaias: {totalCobaias}");
            Console.WriteLine($"Total Sapos: {totalSapos}");
            Console.WriteLine($"Total Ratos: {totalRatos}");
            Console.WriteLine($"Total Coelhos: {totalCoelhos}");
            Console.WriteLine($"Percentual de Sapos: {percSapos.ToString("F2", CI)}");
            Console.WriteLine($"Percentual de Ratos: {percRatos.ToString("F2", CI)}");
            Console.WriteLine($"Percentual de Coelhos: {percCoelhos.ToString("F2", CI)}");
        }
    }
}
