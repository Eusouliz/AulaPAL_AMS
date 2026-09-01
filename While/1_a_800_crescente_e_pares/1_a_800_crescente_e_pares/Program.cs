int cont=1, resto;

while (cont <= 800)
{
    resto = cont % 2;

    if (resto == 0)
    {
        Console.WriteLine(cont);
    }
    cont++;
}