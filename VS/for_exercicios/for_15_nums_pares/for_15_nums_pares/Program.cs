int num, resto, qtd=0;

for(int i=1; i<=15; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = num % 2;

    if (resto == 0)
    {
        Console.WriteLine(num + " é um número par!");
        qtd++;
    }
}
Console.WriteLine("A quantidade de números pares são: " + qtd);