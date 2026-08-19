double resto, m=0;

for(int i=1; i<=300; i++)
{
    resto = i % 3;

    if (resto == 0)
    {
        Console.WriteLine(i + " é múltiplo de 3!");
        m++;
    }
}
Console.WriteLine("Quantidade de números: " + m);