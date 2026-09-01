double num, cont = 10, divisao;

Console.WriteLine("Digite um número: ");
num = double.Parse(Console.ReadLine());

while(cont <= num)
{
    divisao = cont / 3;
    Console.WriteLine(divisao);

    cont++;
}