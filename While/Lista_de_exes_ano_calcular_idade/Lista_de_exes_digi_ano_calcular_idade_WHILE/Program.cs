int cont = 1, idade, anoatual, anonasc;

Console.WriteLine("Digite o ano atual: ");
anoatual = int.Parse(Console.ReadLine());

while(cont <= 4)
{
    Console.WriteLine("Digite o ano de nascimento: ");
    anonasc = int.Parse(Console.ReadLine());

    idade = anoatual - anonasc;

    Console.WriteLine("A idade dessa pessoa é: " + idade);

    cont++;
}
