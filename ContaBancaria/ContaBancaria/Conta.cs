using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        // declarar os atributos
        public string numero;
        public double saldo;
        public double limite;

        // metodos
        public void Sacar(double valor)
        {
            if(valor <= (saldo + limite))
            {
                saldo = saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public string VerSaldo()
        {
            return "------------------------------- \n" +
                "No. Conta: " + numero +
                "\nSaldo R$ " + numero +
                "\nLimite R$ " + numero +
                "\nTotal R$ " + (saldo + limite);

        }
    }
}
