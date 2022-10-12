// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result =1;
for(int i=2; i<=n; i++)
{
    result = result *i;
}
Console.WriteLine(result);

