int num;

Console.WriteLine("Digite um número inteiro: ");
num = int.Parse(Console.ReadLine());

for(int i=2; i<num; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(i);
}