using System;
using System.Globalization;

namespace ProjetoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;
            Console.Write("Entre com o número da conta: ");
            int numDaConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char existeDepInicial = char.Parse(Console.ReadLine());
            if (existeDepInicial == 's')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numDaConta, titular, valorDepositoInicial);
            } else
            {
                contaBancaria = new ContaBancaria(numDaConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double valorDoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valorDoDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double valorDoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valorDoSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
        }
    }
}
