using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ENCADEANDO LAÇOS FOR
namespace D1_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuando projeto 13 - Calculando Poupança");
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento, você tera R$ "+ valorInvestido);
            Console.WriteLine("Aperte a tecla ENTER para finalizar o processo");
            Console.ReadLine();
        }
    }
}
