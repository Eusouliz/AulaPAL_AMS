double cont=0, notaA, notaB, media;
string nome;

while (cont <= 5)
{
    Console.WriteLine("Digite o nome do aluno: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite a nota A: ");
    notaA = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota B: ");
    notaB = double.Parse(Console.ReadLine());

    media = notaA + notaB / 2;

    Console.WriteLine(nome + " - Tem média: " + media);

    cont++;
}