using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// FORMA DIFERENTE DE FAZER O ENCADEAMENTO
namespace F15_ForEncadeado2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuando projeto 14 - Palavra chave BREAK");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
