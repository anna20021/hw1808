Console.WriteLine ("enter a number from 100 till 999");
int number = int.Parse (Console.ReadLine());
int a = 0;
a = number / 10;
a = a % 10;
Console.WriteLine(a);