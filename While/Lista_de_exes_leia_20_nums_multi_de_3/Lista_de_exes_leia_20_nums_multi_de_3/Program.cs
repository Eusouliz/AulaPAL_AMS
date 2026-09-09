int cont = 0, resto, num, qtd = 0;

while(cont <= 20)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = num % 3;

    if (resto == 0) {
        Console.WriteLine("É múltiplo de 3!" + qtd);

        qtd++;
    }

    cont++;
}

Console.WriteLine("A quantidade de números múltiplos de 3 são: " + qtd);