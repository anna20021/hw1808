// Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

Console.WriteLine ("number");
int number = int.Parse(Console.ReadLine());
int a = 0;
if (number < 100)
{
    Console.WriteLine(" число не имеет 3 цифры");
}
else 
{
a = number % 10;
Console.WriteLine(a);
}