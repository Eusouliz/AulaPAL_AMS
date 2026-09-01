int cont = 1, anonasc, anoatual, idade;

Console.WriteLine("Digite o ano atual: ");
anoatual = int.Parse(Console.ReadLine());

while (cont <= 5)
{
    Console.WriteLine("Digite seu ano de nascimento: ");
    anonasc = int.Parse(Console.ReadLine());

    idade = anoatual - anonasc;
    Console.WriteLine("A idade desta pessoa é: " + idade);

    cont++;
}