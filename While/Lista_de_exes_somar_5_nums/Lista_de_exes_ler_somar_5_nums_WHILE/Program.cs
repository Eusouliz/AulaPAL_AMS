double soma = 0, num, cont = 1;

while(cont <= 5)
{
    Console.WriteLine("Digite o número: ");
    num = double.Parse(Console.ReadLine());

    soma = soma + num;

    Console.WriteLine("A soma dos cinco números digitados é: " + soma);

    cont++;
}