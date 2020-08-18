using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //o Número representa uma letra, nesse caso
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);//converte o resultado da expreção em uma letra
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia" + 2020;
            Console.WriteLine(titulo);
            string cursosProgramacao = 
@"- .NET
Java
JavaScript";//tem que por o @ na frente pra concatenar a string em varias linhas
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
