// See https://aka.ms/new-console-template for more information

using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
class Program{
    static void Main()
    {
        //CRIANDO CONTA BANCÁRIA//
        Console.WriteLine("Digite o número da conta:");
        int numeroConta = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine() ?? "Sem nome!";

        ContaBancaria conta = new ContaBancaria(numeroConta, titular);

        Console.WriteLine("Conta criada com sucesso!\n");
        conta.ExibirDados();

        conta.Depositar();

        conta.Sacar();

    }
}
//CLASSE CONTA BANCÁRIA//
class ContaBancaria
{
    public int NumeroConta;
    public string Titular;
    public double Saldo;

    public ContaBancaria(int numeroConta, string titular){
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = 0;
    }

    public void ExibirDados(){
        Console.WriteLine($"Dados da conta: {NumeroConta} | Titular: {Titular} | Saldo: R${Saldo}\n");
    }

    public void Depositar(){
        Console.WriteLine("Digite um valor para depósito: \n");
        double deposito = double.Parse(Console.ReadLine() ?? "0\n");

        Saldo += deposito;
        Console.WriteLine($"Seu Saldo agora é: R${Saldo:F2}\n");
    }
    public void Sacar()
    {
        Console.Write("Digite um valor para saque: \n");
        
        if (double.TryParse(Console.ReadLine(), out double saque))
        {
            if (saque > 0 && saque <= Saldo)
            {
                Saldo -= saque;
                Console.WriteLine($"Saque de R${saque:F2} realizado com sucesso!\n");
                Console.WriteLine($"Seu saldo restante é R${Saldo:F2}\n");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido!\n");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um valor numérico.\n");
        }
    }
}  