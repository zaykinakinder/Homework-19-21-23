// See https://aka.ms/new-console-template for more information
int []array = new int [8];
for (int i = 0;i <array.Length; i++)
{
    array [i] = new Random().Next(0,10);

}
Console.WriteLine("["+string.Join(",",array)+"]");
