// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double valor1 = 10.5;
float valor2 = 20.5f;
decimal valor3 = 30.5m;

Console.WriteLine($"Valor do double: {valor1}");
Console.WriteLine($"Valor do float: {valor2}");
Console.WriteLine($"Valor do decimal: {valor3}");
Console.WriteLine();

Console.ReadLine();

Console.WriteLine("Comparando a precisão de double, float e decimal");
Console.WriteLine();

float valor4 = 1f/3f;
double valor5 = 1d/3d;
decimal valor6 = 1m/3m ;

Console.WriteLine($"Valor do float: {valor4}");
Console.WriteLine($"Valor do double: {valor5}");
Console.WriteLine($"Valor do decimal: {valor6}");
Console.WriteLine();

Console.ReadLine();