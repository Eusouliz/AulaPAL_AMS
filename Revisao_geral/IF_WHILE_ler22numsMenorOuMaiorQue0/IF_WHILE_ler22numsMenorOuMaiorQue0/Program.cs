int cont = 0, num;

while (cont <= 22)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if(num > 0)
    {
        Console.WriteLine(num + " é maior que 0!");

    }
    else if(num < 0)
    {
        Console.WriteLine(num + " é menor que 0!");
    }
    else
    {
        Console.WriteLine(num + " é igual a 0!");
    }
    cont++;
}