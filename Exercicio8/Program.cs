using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario;
            int horas;
            double ht;
            double sl;
            double im;
            double sa;

            Console.WriteLine("Quantas horas você trabalhou?");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Você trabalhou " + horas);

            Console.WriteLine("Qual o valor do salario minimo?");
            salario = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Você recebe R$ " + salario);

            ht = salario / 2;

            Console.WriteLine("A hora trabalhada vale " + ht);

            sl = ht * horas;

            Console.WriteLine("O seu Salario Bruto é " + sl);

            im = (sl * 0.03);

            Console.WriteLine("O valor do seu imposto é " + im);

            sa = sl - im;

            Console.WriteLine("O seu salario final é " + sa);




























        }
    }
}
