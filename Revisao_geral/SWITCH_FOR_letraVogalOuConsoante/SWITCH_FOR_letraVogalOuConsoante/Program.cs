string letra;

for (int i=1; i <= 25; i++)
{
    Console.WriteLine("Digite uma letra: ");
    letra = Console.ReadLine();

    switch (letra)
    {
        case "a":
        case "A":
            Console.WriteLine("É uma vogal!");

            break;

        case "e":
        case "E":
            Console.WriteLine("É uma vogal!");

            break;

        case "i":
        case "I":
            Console.WriteLine("É uma vogal!");

            break;

        case "o":
        case "O":
            Console.WriteLine("É uma vogal!");

            break;

        case "u":
        case "U":
            Console.WriteLine("É uma vogal!");

            break;

        default:
            Console.WriteLine("É uma consoante!");

            break;
    }
}