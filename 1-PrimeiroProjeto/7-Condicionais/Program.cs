using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeDoJoao = 16;
            int quantidadePessoas = 2;

            if(idadeDoJoao >= 18)
            {
                Console.WriteLine("João tem mais de 18 anos de idade. Pode entrar");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");    
                }
            }

            Console.ReadLine();
        }
    }
}
