using System.Net;

Console.WriteLine("--------------------");
Console.WriteLine("     CALCULADORA    ");
Console.WriteLine("--------------------\n");
Console.WriteLine("Escolha a opção e digite um número para usar a calculadora.");
Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n");
Console.Write("Opção: ");
string option = Console.ReadLine();

switch (option)
{
    case "1":

        double valorSum1, valorSum2, total;

        Console.Write("\n\nDigite o primeiro valor para a soma e pressione enter: ");
        valorSum1 = double.Parse(Console.ReadLine());

        Console.Write("\nDigite o segundo valor e pressione enter: ");
        valorSum2 = double.Parse(Console.ReadLine());

        total = valorSum1 + valorSum2;

        Console.WriteLine($"\n\nO resultado da soma de {valorSum1} + {valorSum2} = {total}.");

        Console.WriteLine("Fim do Programa.");

        Console.ReadLine();
        break;

    case "2":

        double valorSub1, valorSub2, totalSub;

        Console.Write("\n\nDigite o primeiro valor para a subtração e pressioner enter: ");
        valorSub1 = double.Parse(Console.ReadLine());

        Console.Write("\nDigite o segundo valor para a subtração e pressione enter: ");
        valorSub2 = double.Parse(Console.ReadLine());

        totalSub = valorSub1 - valorSub2;

        Console.WriteLine($"\n\nO valor de {valorSub1} - {valorSub2} = {totalSub}. ");

        if (totalSub < 0)
            Console.WriteLine("\nEste valor é um valor negativo!");

        Console.WriteLine("Fim do Programa.");
        Console.ReadLine();

        break;

    case "3":

        double valorMult1, valorMult2, totalMult;

        Console.Write("\n\nDigite o primeiro valor para fazer a multiplicação e pressione enter: ");
        valorMult1 = double.Parse(Console.ReadLine());

        Console.Write("\nDigite o segundo valor para fazer a multiplicação e pressione enter: ");
        valorMult2 = double.Parse(Console.ReadLine());

        totalMult = valorMult1 * valorMult2;

        Console.WriteLine($"\n\nO valor de {valorMult1} multiplicado por {valorMult2} = {totalMult}");

        Console.WriteLine("Fim do Programa.");

        Console.ReadLine();
        break;

    case "4":

        double valorDiv1, valorDiv2, totalDiv;

        Console.Write("\n\nDigite o dividendo para fazer a divisão e pressione enter: ");
        valorDiv1 = double.Parse(Console.ReadLine());

        Console.Write("\nDigite o divisor para fazer o divisor e pressione enter: ");
        valorDiv2 = double.Parse(Console.ReadLine());

        if (valorDiv2 == 0)
        {
            Console.WriteLine("\n\nNão é possivel dividir por 0\nPressione enter.");
            Console.ReadLine();
        }
        else
        {
            totalDiv = valorDiv1 / valorDiv2;
            Console.WriteLine($"\n\nA divisão de {valorDiv1} / {valorDiv2} = {totalDiv}");

            string restDivision;
            Console.Write("\n\nCaso queira saber o resto da divisão, pressione 0: ");
            restDivision = Console.ReadLine();

            if (restDivision == "0")
            {
                Console.WriteLine($"\no valor do resto da divisão é {valorDiv1 % valorDiv2}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nFim do Programa. ");
                Console.ReadLine();
            }


        }

    break;

    default:
        Console.WriteLine("Digito Incorreto.");
        Console.ReadLine();
    break;
}
