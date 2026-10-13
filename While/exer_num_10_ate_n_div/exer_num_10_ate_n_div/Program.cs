double cont = 10, n, divisao;

Console.WriteLine("Digite um número: ");
n = double.Parse(Console.ReadLine());

while(cont <= n)
{
    divisao = cont / 3;

    Console.WriteLine("O resultado é: " + divisao);

    cont++;
}