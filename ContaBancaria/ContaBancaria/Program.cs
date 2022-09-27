using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variavel auxialar 
            string aux;
            double valor;
            int opcao;

            // declarar e instânciar objetos da classe Conta
            Conta minhaconta = new Conta();
            Conta suaconta = new Conta();

            // entrada de dados
            Console.WriteLine("Entrada de dados da minha conta");
            Console.Write("No. da minha conta: ");
            aux = Console.ReadLine();
            minhaconta.numero = aux;
            Console.Write("Saldo inicial da minha conta R$: ");
            aux = Console.ReadLine();
            minhaconta.saldo = Convert.ToDouble(aux);
            Console.Write("Limite da minha conta R$: ");
            aux = Console.ReadLine();
            minhaconta.limite = Convert.ToDouble(aux);

            Console.WriteLine("Entrada de dados da sua conta");
            Console.Write("No. da sua conta: ");
            aux = Console.ReadLine();
            suaconta.numero = aux;
            Console.Write("Saldo inicial da sua conta R$: ");
            aux = Console.ReadLine();
            suaconta.saldo = Convert.ToDouble(aux);
            Console.Write("Limite da sua conta R$: ");
            aux = Console.ReadLine();
            suaconta.limite = Convert.ToDouble(aux);

            Console.Clear();
            aux = minhaconta.VerSaldo();
            Console.WriteLine(aux);
            aux = suaconta.VerSaldo();
            Console.WriteLine(aux);

            do
            {
                Console.WriteLine("\n\n----- VMV Bank -----" +
                "\n               1 - Sacar" +
                "\n               2 - Depositar" +
                "\n               3 - Consultar Saldo" +
                "\n               4 - Sair do Pograma" +
                "\n               Digite sua opcao: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n Digite o valor desejado do saque: R$ ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        minhaconta.Sacar(valor);
                        suaconta.Sacar(valor);
                        break;
                    case 2:
                        Console.WriteLine("\n Digite o valor desejado do deposito: R$ ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        minhaconta.Depositar(valor);
                        suaconta.Depositar(valor);
                        break;
                    case 3:
                        Console.WriteLine(minhaconta.VerSaldo());
                        Console.WriteLine(suaconta.VerSaldo());
                        break;
                    case 4:
                        Console.WriteLine("Programa finalizado com sucesso");
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida...");
                        break;
                }
            }
            while (opcao != 4);
         }
    }
}
