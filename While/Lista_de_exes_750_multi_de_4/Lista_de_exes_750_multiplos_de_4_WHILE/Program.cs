double resto, cont = 0, qtd=0;

while (cont <= 750)
{
    resto = cont % 4;

    if(resto == 0)
    {
        Console.WriteLine(cont + " é múltiplo de 4!");
        qtd++;
    }

    cont++;
}

Console.WriteLine("A quantidade de números múltiplos de 4 é: " + qtd);