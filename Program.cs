using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Formula de Bhaskara---\n");

            Console.Write("Informe o valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1, x2; 
           
            if (a == 0)
            {
                Console.WriteLine("\nIsso não é uma equação de segundo grau\n");
            }
            else if (delta < 0)
            {
                Console.WriteLine($"\nO valor de {delta:N2} para delta, não tem raiz com número real\n");
            }
            else 
            {
                x1 = (- b + Math.Sqrt(delta)) / 2 * a;

                x2 = (- b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine($"\nx1 = {x1:N2} e x2 = {x2:N2}\n");

            }

        }
    }
}
