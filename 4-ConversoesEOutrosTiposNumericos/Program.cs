using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CONVERSORES E OUTROS TIPOS NÚMERICOS
namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.500;

            Console.WriteLine("Meu salário em Double é: " + salario);

            // O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine("Meu salário em Inteiro é: " + salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade = 13000000000000000;

            Console.WriteLine("A idade é: " + idade);

            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;

            Console.WriteLine("A quantidade de produto é: " + quantidadeProdutos);

            float altura = 1.80f;

            Console.WriteLine("A altuera é: " + altura);
            Console.ReadLine();
        }
    }
}
