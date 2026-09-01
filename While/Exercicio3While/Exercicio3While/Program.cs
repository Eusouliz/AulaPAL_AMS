int cont=1, num;
double mult;

while (cont <= 3)
{
    Console.WriteLine("Digite um valor: ");
    num = int.Parse(Console.ReadLine());

    mult = num * 7;

    Console.WriteLine(num + " x 7 = " + mult);

    cont++;
}