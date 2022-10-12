// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a 5 digit number:");
string n = Convert.ToString(Console.ReadLine());

void Check(string n)
{
    if (n[0]==n [4] || n[1]==n [3]){
        Console.WriteLine("Палиндром");
    }
    else Console.WriteLine("Не палиндром");
}
if (n!.Length==5)
{
    Check(n);

}
else Console.WriteLine("неверное число");