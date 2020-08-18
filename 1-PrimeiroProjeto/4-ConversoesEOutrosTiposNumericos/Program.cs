using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro; //o int armazena até 32 bits
            salarioEmInteiro = (int) salario;
            Console.WriteLine(salarioEmInteiro);

            long idade; //o long armazena até 64 bits
            idade = 13000000000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos; //o long armazena até 16 bits
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f; //o float aguenta menos casas decimais que o double - o f eh pra deixar claro que eh um float, pq o c# pensa que o numero é um double
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
