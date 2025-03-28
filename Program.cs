// Supostamente isso devia mostrar os valores sem o truncamento

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine(d);
Console.WriteLine($"quotient: {d}");
Console.WriteLine(e);
Console.WriteLine($"remainder: {e}");