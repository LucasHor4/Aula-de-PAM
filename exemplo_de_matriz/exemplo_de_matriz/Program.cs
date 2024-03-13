using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_de_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Num_Linha = 3, Num_Coluna = 3;
            int[,] Mat = new int[Num_Linha, Num_Coluna];
            int Lin, Col;

            Console.WriteLine("Cadastrando os dados na matriz \n");
            Console.WriteLine("\n Informe o valor de cada posição da matriz");

            for (Lin = 0; Lin < Num_Coluna; Lin++)
            {
                for (Col = 0; Col < Num_Coluna; Col++)
                {
                    Console.Write("Mat[{0}] [{1}] = ", Lin, Col);

                    //Int.Parse para converter os dados inseridos para INT
                    Mat[Lin, Col] = int.Parse(Console.ReadLine());
                }  //Fim do for de colunas
            } //fim do for de linhas
            Console.WriteLine("\n Exibir os dados da matriz: \n");
            for (Lin = 0; Lin < Num_Linha; Lin++)
            {
                for(Col = 0; Col < Num_Coluna;Col++)
                {
                    Console.Write(" {0} ", Mat[Lin, Col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
