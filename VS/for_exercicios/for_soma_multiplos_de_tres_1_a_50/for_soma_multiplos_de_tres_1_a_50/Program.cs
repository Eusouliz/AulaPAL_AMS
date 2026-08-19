int soma=0, resto;

for(int i=1; i<=50; i++)
{
    resto = i % 3;

    if (resto == 0)
    {
        soma = soma + i;
    }
}
Console.WriteLine("A soma dos múltiplos de 3 é: " + soma);