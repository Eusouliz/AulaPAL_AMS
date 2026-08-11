int N, soma=0;

for(int i=1; i<=10; i++)
{
    Console.WriteLine("Digite um número: ");
    N = int.Parse(Console.ReadLine());

    soma = N + soma;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A soma dos números são: " + soma);
}