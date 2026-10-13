string nome;
double notaA, notaB, media, cont = 0;

while(cont <= 5)
{
    Console.WriteLine("Digite o nome do aluno: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite a nota A deste aluno: ");
    notaA = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota B deste aluno: ");
    notaB = double.Parse(Console.ReadLine());

    media = notaA + notaB / 2;

    Console.WriteLine("A média de " + nome + " é: " + media);

    cont++;
}