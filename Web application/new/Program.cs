// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a Number");
int size= Convert.ToInt32(Console.ReadLine());
int[]num = new int[size];
Random rnd= new Random();
for(int i=0; i<size; i++)
{
    num[i] = rnd.Next(0,999);
    Console.Write($"{num[i]}, ");
}
Console.WriteLine();
int sum=0;
for(int i=0; i<size; i++)
{
    sum = sum + num[i];
}
Console.WriteLine($"{sum}");