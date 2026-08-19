string sexo;
double altura, qtd=0;

for(int i=1; i<=4; i++)
{
    Console.WriteLine("Digite o sexo: ");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite a altura: ");
    altura = double.Parse(Console.ReadLine());

    if ((sexo == "M") || (sexo == "m"))
    {
        qtd++;
    }
    else if ((sexo == "F") || (sexo == "f"))
    {
        Console.WriteLine("Você é do sexo feminino: " + altura);
    }
}
Console.WriteLine("A quantidade de homens é: " + qtd);