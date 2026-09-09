double dobro, num, cont = 0;

Console.WriteLine("Digite um número: ");
num = double.Parse(Console.ReadLine());

while(cont <= num)
{
    dobro = cont * 2;

    Console.WriteLine(cont + " x 2 = " + dobro);

    cont++;
}
