using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine("*********     Exercicio 9     *********");
            Console.WriteLine("***************************************");

            Console.WriteLine("");

            int salario;
            int reajuste;
            int salario_final;

            Console.Write("Informe seu salário: R$ ");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o percentual de reajuste: ");
            reajuste = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            salario_final = salario + ((salario * reajuste) / 100);

            Console.WriteLine($"Seu novo salário será de R$ {salario_final} reais.");

            Console.ReadKey();

        }
    }
}
