string nome, sexo;
int idade;

for(int i=1;i<=3; i++)
{
    Console.WriteLine("Digite o nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o sexo (M ou F): ");
    sexo = Console.ReadLine();

    if ((idade > 21)&&(sexo == 'M'))
    {
        Console.WriteLine(nome + " possui " + idade);
    }
}