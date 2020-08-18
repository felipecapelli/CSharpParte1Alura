using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o projeto 13");

            for (int contadorDaLinha = 0; contadorDaLinha < 10; contadorDaLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorDaLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
