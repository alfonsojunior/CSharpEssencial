// See https://aka.ms/new-console-template for more information
Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();
string nome = "Maria";
String sobrenome = "Silva";

Console.WriteLine($"O nome é: {nome} {sobrenome}");
Console.WriteLine();

object idade = 20;
object valor1 = 8.55m;
object nome1 = "João";
dynamic ativa = true;
dynamic letra = 'A';
Console.WriteLine($"A idade é: {idade}");
Console.WriteLine($"O valor1 é: {valor1}");
Console.WriteLine($"O nome1 é: {nome1}");
Console.WriteLine($"A ativa é: {ativa}");
Console.WriteLine($"A letra é: {letra}");
Console.WriteLine();

Console.ReadLine();
