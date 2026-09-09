double cont = 0, num = 0, resto;

while (cont <= 3)
{
    Console.WriteLine("Digite um número: ");
    num = double.Parse(Console.ReadLine());

    resto = num % 3;

    if(resto == 0)
    {
        Console.WriteLine(num + " é múltiplo de três!");
    }

    cont++;
}