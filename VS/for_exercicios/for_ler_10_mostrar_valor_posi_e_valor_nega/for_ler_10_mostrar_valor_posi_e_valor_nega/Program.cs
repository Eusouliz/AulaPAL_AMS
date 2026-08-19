int num, quantp=0, quantn=0;

for(int i=1; i<=10; i++)
{
    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num > 0)
    {
        Console.WriteLine(num + ": Esse número é positivo");
        quantp++;
    }

    else if (num < 0)
    {
        Console.WriteLine(num + ": Esse número é negativo");
        quantn++;
    }
   
}

Console.WriteLine("A quantidade de negativos: " + quantn);
Console.WriteLine("A quantidade de positivos: " + quantp);
