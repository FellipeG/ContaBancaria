using System;
using System.Globalization;

namespace ProjetoContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string TitularDaConta { get; private set; }
        public double SaldoDaConta { get; private set; }

        public ContaBancaria(int numeroDaConta, string titularDaConta)
        {
                Numero = numeroDaConta;
                TitularDaConta = titularDaConta;
        }

        public ContaBancaria(int numeroDaConta, string titularDaConta, double depositoInicial) : this(numeroDaConta, titularDaConta)
        {
            Deposito(depositoInicial);
        }
        
        public void Deposito(double valor)
        {
            SaldoDaConta += valor;
        }

        public void Saque(double valor)
        {
            if(valor <= SaldoDaConta)
            {
                SaldoDaConta -= (valor + 5.0);
            }
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + TitularDaConta + ", Saldo: $ " + SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}