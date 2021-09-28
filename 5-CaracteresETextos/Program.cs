using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CARACTERES E TEXTOS
namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 de Caracteres e Outros Tipos");

            //character
            char primeiraLetra = 'a';

            Console.WriteLine("Primeira letra: " + primeiraLetra);

            primeiraLetra = (char)65;

            Console.WriteLine("Primeira letra: "+ primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);

            Console.WriteLine("Primeira letra: "+ primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2021;

            Console.WriteLine(titulo);

            string cursosProgramacao = @" - .NET - Java - JavaScript - CSharp";

            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Aperte a qualquer tecla para parar o serviço");

            Console.ReadLine();
        }
    }
}
