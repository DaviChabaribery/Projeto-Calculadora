using System.Net;

Console.WriteLine("--------------------");
Console.WriteLine("     CALCULADORA    ");
Console.WriteLine("--------------------\n");
Console.WriteLine("Escolha a opção e digite um número para usar a calculadora.");
Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n");
Console.Write("Opção: ");
string option = Console.ReadLine();

if (option == "1")
{
    double valorSum1, valorSum2, total;

    Console.Write("Digite o primeiro valor para a soma e pressione enter: ");
    valorSum1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor e pressione enter: ");
    valorSum2 = double.Parse(Console.ReadLine());

    total = valorSum1 + valorSum1;

    Console.WriteLine($"O resultado da soma de {valorSum1} + {valorSum2} = {total}.");

    Console.ReadLine();

    Console.WriteLine("Fim do Programa.");
}

else if (option == "2")
{
    double valorSub1, valorSub2, totalSub;

    Console.Write("Digite o primeiro valor para a subtração e pressioner enter: ");
    valorSub1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor para a subtração e pressione enter: ");
    valorSub2 = double.Parse(Console.ReadLine());

    totalSub = valorSub1 - valorSub2;

    Console.WriteLine($"O valor de {valorSub1} - {valorSub2} = {totalSub}. ");
    if (totalSub < 0)
    {
        Console.WriteLine("Este valor é um valor negativo!");
    }
    
     Console.WriteLine("Fim do Programa.");
}
else if(option == "3")
{
    double valorMult1, valorMult2, totalMult;

    Console.Write("Digite o primeiro valor para fazer a multiplicação e pressione enter: ");
    valorMult1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor para fazer a multiplicação e pressione enter: ");
    valorMult2 = double.Parse(Console.ReadLine());

    totalMult = valorMult1 * valorMult2;

    Console.WriteLine($"O valor de {valorMult1} multiplicado por {valorMult2} = {totalMult}");

    Console.WriteLine("Fim do Programa.");
}

else if (option == "4")
{
    double valorDiv1, valorDiv2, totalDiv;

    Console.Write("Digite o dividendo para fazer a divisão e pressione enter: ");
    valorDiv1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o divisor para fazer o divisor e pressione enter: ");
    valorDiv2 = double.Parse(Console.ReadLine());

    if (valorDiv2 == 0)
    {
        Console.WriteLine("Não é possivel dividir por 0");
    }
    else
    {
        totalDiv = valorDiv1 / valorDiv2;
        Console.WriteLine($"A divisão de {valorDiv1} / {valorDiv2} = {totalDiv}");
        
        string restDivision;
        Console.Write("Caso queira saber o resto da divisão, pressione 0: ");
        restDivision = Console.ReadLine();
        
        if (restDivision == "0")
        {
            Console.WriteLine($"o valor do resto da divisão é {valorDiv1 % valorDiv2}.");
        } 
        else
        {
            Console.WriteLine("Fim do Programa.");
        }  
    }
}