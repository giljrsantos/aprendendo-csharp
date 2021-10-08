using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// LAÇO REPETIÇÃO FOR
namespace C12_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuando projeto 12 - Calculando Poupança");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes ++){

                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
            }


            Console.WriteLine("Aperte a tecla ENTER para finalizar o processo");
            Console.ReadLine();
        }
    }
}
