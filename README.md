--MEUS EXERCICIOS DE ESTUDOS EM C#--

Este projeto tem como objetivo o estudo e a prática da linguagem
C#, trabalhando a lógica da programação juntamente com as particularidades
da linguagem e a aplicação de conceitos como Programação Orientada a Objetos
através de exercícios de algoritmos.


//RECEBE UM NUMERO E VERIFICA SE É PRIMO//

        Console.WriteLine("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());
        int i = 1, divisores = 0;

        while(i <= numero){
            if(numero % i == 0){
                divisores += 1;
            }
            i++;
        }
        if(divisores == 2){
            Console.WriteLine(numero + " É primo!");
        }
        else{
            Console.WriteLine(numero + " Não é primo!");
        }

        //RECEBE UM NUMERO E VERIFICA SE É PERFEITO//

        Console.WriteLine("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        int divisores = 0;

        for(int i = 1; i < numero; i++){
            if(numero % i == 0){
                divisores = divisores + i;
            }
        }
        if(divisores == numero){
            Console.WriteLine(numero + " É um número perfeito!");
        }
        else
            Console.WriteLine(numero + " Não é um número perfeito!");

//RECEBE UMA PALAVRA E VERIFICA SE É PALÍNDROMO//

        Console.WriteLine("Escreva uma pálavra");

        string palavra = Console.ReadLine();
        char[] caracteres = palavra.ToCharArray();
        Array.Reverse(caracteres);
        string palavraInvertida = new string(caracteres);

        Console.WriteLine(palavraInvertida);

        if(palavra.Equals(palavraInvertida, StringComparison.OrdinalIgnoreCase)){
            Console.WriteLine(palavra + " É um palíndromo");
        }
        else
            Console.WriteLine(palavra + " Não é um palíndromo");

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
}                Console.WriteLine("\n1. Criar Conta");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Transferir");
            Console.WriteLine("5. Consultar Saldo");
            Console.WriteLine("6. Mostrar todas as contas");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
            
            string opcao = Console.ReadLine();

//JOGO DE ADIVINHAÇÃO DE NÚMERO//

        Random random = new Random();
        int numRandom = random.Next(1,100), i = 10;

        Console.WriteLine("Adivinhe o número entre 1 e 100, voçê terá 10 tentativas!\n");

        Console.WriteLine("Digite um número: ");
        int entrada = Convert.ToInt32(Console.ReadLine());

        while(i > 0){
            if(entrada < numRandom){
                Console.WriteLine("Número baixo demais!\n");
                Console.WriteLine("Tente novamente: ");
                entrada = Convert.ToInt32(Console.ReadLine());

            } else if(entrada > numRandom) {
                Console.WriteLine("Número alto demais!\n");
                Console.WriteLine("Tente novamente: ");
                entrada = Convert.ToInt32(Console.ReadLine());

            } else if(entrada == numRandom){
                Console.WriteLine($"Parabens, voçê acertou o número em {i} tentativas!");
                break;
            } 

            i--;
        }

//CADASTRO DE ALUNOS//

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();
        int i = 1;

        while(i < 4){
            Console.WriteLine($"\nDigite o nome do aluno {i}: ");
            string vNome = Console.ReadLine() ?? "Sem nome";

            Console.WriteLine($"Digite a idade do aluno {i}: ");
            int vIdade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Digite a nota do aluno {i}: ");
            double vNota = Convert.ToDouble(Console.ReadLine());

            Aluno alun = new Aluno(vNome, vIdade, vNota);
            alunos.Add(alun);

            i++;
        }

        Console.WriteLine("\nAlunos no sistema: \n");

        foreach(Aluno aluno in alunos){
            Console.WriteLine("-");
            aluno.ShowInfos();
        }
    }
}

class Aluno{
    public string Nome;
    public int Idade;
    public double Nota;

    public Aluno(string vNome, int vIdade, double vNota){
        Nome = vNome;
        Idade = vIdade;
        Nota = vNota;
    }

    public void ShowInfos(){
        Console.WriteLine($"O nome é {Nome}, A idade é {Idade} e a nota é {Nota}");
    }
}