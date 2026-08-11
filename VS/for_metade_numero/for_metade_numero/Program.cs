int num, met;

for (int i=1; i < 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    met = num / 2;
    Console.WriteLine("A metade deste número é: "+met);
}