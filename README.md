//ESTE DOCUMENTO GUARDA MEUS EXERCICIOS DE ESTUDOS EM C#//

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