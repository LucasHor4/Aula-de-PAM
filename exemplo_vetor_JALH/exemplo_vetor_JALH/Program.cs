using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_vetor_JALH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int i;
            for(i = 0; i < 10; i++)
            {
                Console.Write("DIGITE O {0}º Nome:", i + 1);
                nomes[i] = Console.ReadLine();
            }
            Console.ReadKey();

            for(i = 0; i<10; i++)
            {
                Console.WriteLine("{0}º Nome:{1}", i+1, nomes[i]);
            }
            Console.ReadKey();


        }
    }
}
