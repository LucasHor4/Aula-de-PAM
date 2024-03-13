using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Lin, Col;
            const int QTD_Linha =  3;
            const int QTD_Coluna = 5;
            string[,] Nomes = new string[QTD_Linha, QTD_Coluna];

            string nome = "(º@º) ";
            int contador = 1;
            for (Lin = 0; Lin < QTD_Linha; Lin++)
                for (Col = 0; Col < QTD_Coluna; Col++)
                Nomes[Lin, Col] = nome + contador++;

            Console.WriteLine("\n **** Nomes cadastrado na matriz ***** \n");
            exibirDados(Nomes); //Camada de método
            Console.ReadKey();

            //Lucas Hora & João Attila
        }
        static void exibirDados(string[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write("{0}\t", m[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
