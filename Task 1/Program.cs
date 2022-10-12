// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количесвто элементов': ");
int n = Convert.ToInt32(Console.ReadLine());
int [] ArrayFirst = new int [n];
int [] ResultArray = new int [n];

for (int i=0; i<n; i++)
ArrayFirst[i]=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("["+string.Join(",",ArrayFirst)+"]");
ResultArray[0]= ArrayFirst[0]+ ArrayFirst[n-1]+ArrayFirst [n-2];//n-1
 ResultArray[1]= ArrayFirst[0]+ ArrayFirst[1]+ArrayFirst [n-1];//1
 for (int i=1; i<n;i++)
 {
    ResultArray[i+1]=ArrayFirst[i-1]+ArrayFirst[i]+ArrayFirst[i+1];
 }
 Console.WriteLine("["+string.Join(",", ResultArray)+"]");
 int maxValue = ResultArray[0];
 for (int i = 1; i<n; i++)
 {
    if (maxValue<ResultArray[i])
    maxValue=ResultArray[i];

 }
Console.WriteLine(maxValue);
