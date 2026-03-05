// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual: {dataAtual}");

DateTime dataEspecifica = new DateTime(2026, 3, 5);
Console.WriteLine($"Data específica: {dataEspecifica}");

DateTime dataComHora = new DateTime(2026, 3, 5, 14, 30, 0);
Console.WriteLine($"Data com hora: {dataComHora}");

Console.WriteLine($"\nAno: {dataAtual.Year}");
Console.WriteLine($"Mês: {dataAtual.Month}");
Console.WriteLine($"Dia: {dataAtual.Day}");
Console.WriteLine($"Hora: {dataAtual.Hour}");
Console.WriteLine($"Minuto: {dataAtual.Minute}");
Console.WriteLine($"Segundo: {dataAtual.Second}");
Console.WriteLine($"Milissegundo: {dataAtual.Millisecond}");

Console.WriteLine($"Adicionar dias: {dataAtual.AddDays(5)}");
Console.WriteLine($"Adicionar meses: {dataAtual.AddMonths(2)}");
Console.WriteLine($"Adicionar anos: {dataAtual.AddYears(1)}");
Console.WriteLine($"Adicionar horas: {dataAtual.AddHours(10)}");

Console.WriteLine($"Dia da semana: {dataAtual.DayOfWeek}");
Console.WriteLine($"Dia do ano: {dataAtual.DayOfYear}");

Console.WriteLine($"Data em formato longo: {dataAtual.ToLongDateString()}");
Console.WriteLine($"Data em formato curto: {dataAtual.ToShortDateString()}");
Console.WriteLine($"Hora em formato longo: {dataAtual.ToLongTimeString()}");
Console.WriteLine($"Hora em formato curto: {dataAtual.ToShortTimeString()}");

Console.WriteLine($"Data e hora formatadas: {dataAtual:yyyy-MM-dd HH:mm:ss}");

Console.ReadKey();
