//Fazer a repetição de 1 até o número digitado pelo usuário

int cont = 1, num;

Console.WriteLine("Digite um número final para a repetição: ");
num = int.Parse(Console.ReadLine());

while (cont <= num)
{
    Console.WriteLine(cont);
    cont++;
}