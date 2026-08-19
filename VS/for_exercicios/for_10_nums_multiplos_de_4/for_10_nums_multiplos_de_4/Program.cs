int num, resto, m = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = num % 4;

    if (resto == 0)
    {
        Console.WriteLine(num + " é múltiplo de 4!");
        m++;
    }
}

Console.WriteLine("A quantidade de múltiplos de 4 são: " + m);