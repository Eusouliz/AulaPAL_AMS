Console.ForegroundColor = ConsoleColor.Green;

int idade;
Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

for(int i=0; i<=idade; i++)
{
    Console.WriteLine(i);
}