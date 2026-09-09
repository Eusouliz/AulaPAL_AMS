double cont = 1, qtd = 0;
string resposta;

while(cont <= 30)
{
    Console.WriteLine("Digite sua resposta: \n" +
        "A, B, C ou D");
    resposta = Console.ReadLine();

    if (resposta == "A")
    {
        qtd++;
    }
    else if (resposta == "C")
    {
        qtd++;
    }
    else if (resposta == "D")
    {
        qtd++;
    }

    cont++;
}

Console.WriteLine("A quantidade final de pontos é: " + qtd);