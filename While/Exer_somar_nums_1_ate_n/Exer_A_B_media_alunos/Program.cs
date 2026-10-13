int cont = 1, n, soma = 0;

Console.WriteLine("Digite um número: ");
n = int.Parse(Console.ReadLine());

while(cont <= n)
{
    soma = soma + cont;

    cont++;
}
Console.WriteLine("A soma de todos os números de 1 até " + n + " é: " + soma);