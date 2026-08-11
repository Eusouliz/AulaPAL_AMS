string tipoins, nome, peri, adnot, mes_ano;
double ins, salbase, salmini, qhe, INSS, porcperi=0, the, horaextra=0, calcnot=0, salbruto, salliqui;

Console.WriteLine("Digite o nome do funcionário: ");
nome = Console.ReadLine();

Console.WriteLine("Digite o valor do salário base: ");
salbase = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do salário mínimo: ");
salmini = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o mês referente ao pagamento: ");
mes_ano = Console.ReadLine();

Console.WriteLine("Digite a quantidade de horas extras: ");
qhe = double.Parse(Console.ReadLine());

Console.WriteLine("Periculosidade? (sim ou não): ");
peri = Console.ReadLine();

Console.WriteLine("Digite o tipo de insalubridade (minimo, médio, máximo): ");
tipoins = Console.ReadLine();

Console.WriteLine("Adicional noturno? (sim ou não): ");
adnot = Console.ReadLine();

Console.WriteLine("Digite o valor do INSS: ");
INSS = double.Parse(Console.ReadLine());

switch (tipoins)
{
    case "minimo":
        ins = (salmini * 10) / 100;
        break;

    case "médio":
        ins = (salmini * 20) / 100;
        break;

    case "máximo":
        ins = (salmini * 30) / 100;
        break;

    default:
        ins = 0;
        break;
}

if (peri == "sim")
{
    porcperi = (salbase * 30) / 100;
}
else if (peri == "não")
{
    porcperi = 0;
}

the = (salbase + ins + porcperi) / 220 * 1.5 * horaextra;

switch (adnot)
{
    case "sim":
        calcnot = (salbase * 20) / 100;
        break;

    case "não":
        calcnot = 0;
        break;
}

salbruto = salbase + the + ins + porcperi + calcnot;

if (salbruto <= 1174.86)
{
    INSS = (salbruto * 8) / 100;
}
else if ((salbruto >= 1174.86) && (salbruto <= 1958.10))
{
    INSS = (salbruto * 9) / 100;
}
else if ((salbruto >= 1958.10) && (salbruto <= 3916.20))
{
    INSS = (salbruto * 11) / 100;
}
else
{
    INSS = (3916.20 * 11) / 100;
}

salliqui = salbruto - INSS;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DADOS INFORMADOS: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Nome do funcionário: " + nome);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Mês de referência: " + mes_ano);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário base: " + salbase);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário mínimo: " + salmini);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Horas extras: " + horaextra);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Insalubridade: " + tipoins);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Adicional noturno: " + adnot);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("_______________");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("CÁLCULOS DO FUNCIONÁRIO: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Valor da insalubridade: " + ins);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Valor da periculosidade: " + peri);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Valor hora extra: " + the);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Adicional noturno: " + calcnot);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário bruto: " + salbruto);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Desconto INSS: " + INSS);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário líquido: " + salliqui);