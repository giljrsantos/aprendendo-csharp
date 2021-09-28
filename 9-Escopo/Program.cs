using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ESCOPO
namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escoco");
            int idadeJoao = 18;
            bool acompanhado = true;
            string mensgemAdicional;

            if (acompanhado == true)
            {
               mensgemAdicional = "João está acompanhado";
            }
            else
            {
              mensgemAdicional = "João não está acompanhado";
            }
          
            if(idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensgemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            Console.WriteLine("Aperte a tecla ENTER para finalizar o processo");
            Console.ReadLine();
        }
    }
}
