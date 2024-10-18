Console.Clear();
double numero01, numero02, resultado;
string operacao;

Console.WriteLine("-----------");
Console.WriteLine("Calculadora");
Console.WriteLine("-----------\n");

Console.WriteLine("----------------------");
Console.WriteLine("Operações disponíveis:");
Console.WriteLine("----------------------");
Console.WriteLine("A. Soma");
Console.WriteLine("B. Subtração");
Console.WriteLine("C. Multiplicação");
Console.WriteLine("D. Divisão");
Console.WriteLine("----------------------\n");

Console.Write("Operação: ");
operacao = Console.ReadLine()!.ToUpper();
Console.Write("Número 01: ");
numero01 = Convert.ToDouble(Console.ReadLine());
Console.Write("Número 02: ");
numero02 = Convert.ToDouble(Console.ReadLine());

switch(operacao)
{
    case "A":
        resultado = numero01 + numero02;
        break;
    case "B":
        resultado = numero01 - numero02;
        break;
    case "C":
        resultado = numero01 * numero02;
        break;
    case "D":
        resultado = numero01 / numero02;
        break;
    default:
        Console.WriteLine("Operação não suportada!");
        return;
}

Console.WriteLine($"Resultado: {resultado:N4}");

