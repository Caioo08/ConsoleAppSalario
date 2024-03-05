using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu salário bruto: ");
            double sal_b = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor do vale alimentação: ");
            int val = int.Parse(Console.ReadLine());

            Console.Write("Quantos filhos você tem: ");
            int n_fil = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor por filho: ");
            double v_fil = double.Parse(Console.ReadLine());

            Console.Write("Quantos horas extras o funcionário fez: ");
            int h_ex = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor de cada hora extra: ");
            double v_ex = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor do INSS: ");
            double inss = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor do IRPF: ");
            double irpf = double.Parse(Console.ReadLine());



            double sal_liq = (sal_b + val) + (n_fil * v_fil) + (h_ex * v_ex);
            sal_liq = sal_liq - inss;
            sal_liq = sal_liq - irpf;

            Console.WriteLine("O seu salário líquido é R$ " + sal_liq);
            Console.ReadKey();

        }
    }
}
