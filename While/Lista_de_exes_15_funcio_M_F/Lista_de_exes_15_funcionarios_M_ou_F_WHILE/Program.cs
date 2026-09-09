double cont = 0;
string nome, sexo;

while (cont <= 15)
{
    Console.WriteLine("Digite o nome do funcionário: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite o sexo do funcionário: ");
    sexo = Console.ReadLine();

    if ((sexo == "M") || (sexo == "m"))
    {
        Console.WriteLine(nome + ": Necessita fazer o exame!");
    }

    else if ((sexo == "F") || (sexo == "f"))
    {
        Console.WriteLine("O sexo foi digitado incorretamente. Digite M.");
    }

    cont++;
}