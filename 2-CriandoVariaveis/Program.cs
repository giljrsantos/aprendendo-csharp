using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CRIANDO VARIÁVEIS
namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Crianco Variaveis");

            int idade;
            idade = 34;

            Console.WriteLine(idade);

            idade = 10;

            Console.WriteLine(idade);

            idade = 10 + 5;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;

            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");

            Console.ReadLine();
        }
    }
}
