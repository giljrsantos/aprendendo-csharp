using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ATRIBUIÇÕES DE VARIÁVEIS
namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Atribuições de Variáveis");

            int idade = 34;
            int idadeGilberto = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGilberto);

            Console.WriteLine("Aperte a qualquer tecla para parar o serviço");

            Console.ReadLine();
        }
    }
}
