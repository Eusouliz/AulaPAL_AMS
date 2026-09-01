int cont = 0;
double num, quad;

Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());

while (cont <= num)
{
    quad = Math.Pow(cont, 2);

    Console.WriteLine(cont + "² = " + quad);
    cont++;
}