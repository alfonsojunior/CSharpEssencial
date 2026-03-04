// See https://aka.ms/new-console-template for more information

Console.WriteLine("Declarando variáveis numéricas");
Console.WriteLine();
byte valor1 = 255;
sbyte valor2 = -127;
short valor3 = -32768;
ushort valor4 = 65535;
int valor5 = -2147483648;
uint valor6 = 4294967295;
long valor7 = -9223372036854775808;
const int valor8 = 999;

Console.WriteLine($"Valor do byte: {valor1}");
ExibirValor("sbyte", valor2);
ExibirValor("short", valor3);
ExibirValor("ushort", valor4);
ExibirValor("int", valor5);
ExibirValor("uint", valor6);
ExibirValor("long", valor7);
ExibirValor("const", valor8);
Console.WriteLine();

Console.ReadLine();


static void ExibirValor(string tipo, object valor)
{
    Console.WriteLine($"Valor do {tipo}: {valor}");
}