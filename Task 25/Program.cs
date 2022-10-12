// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");

double n = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Введите второе число:");
double m = Convert.ToDouble (Console.ReadLine());
double b = Math.Pow(n,  m);

Console.WriteLine(b);
