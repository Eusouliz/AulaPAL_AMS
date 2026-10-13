double cont = 0, n, expoente, resto;

while (cont <= 7)
{
    Console.WriteLine("Digite um número: ");
    n = double.Parse(Console.ReadLine());

    resto = n % 2;

    if (resto == 0)
    {
        Console.WriteLine(n + "²");
    }

    else
    {
        expoente = Math.Pow(n, 2);

        Console.WriteLine(expoente);
    }

    cont++;
}