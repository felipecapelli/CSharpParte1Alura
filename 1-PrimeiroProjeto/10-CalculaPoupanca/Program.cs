using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorDoMes = 1;

            while (contadorDoMes <=12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+ contadorDoMes + " meses, você terá R$ " + valorInvestido);
                //contadorDoMes = contadorDoMes + 1;
                //contadorDoMes += 1;
                contadorDoMes++;
            }

            Console.ReadLine();
        }
    }
}
