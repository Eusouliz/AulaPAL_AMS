int idade, qtd=0;

for(int i=1; i<=5; i++)
{
    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade > 18)
    {
        qtd = qtd + 1;
    }
}
Console.WriteLine("A quantidade de pessoas maiores de 18 são: " + qtd);