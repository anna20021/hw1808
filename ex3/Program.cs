// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine ("number from 1 to 7");
int number = int.Parse(Console.ReadLine());
if ( number <= 5)
{
    Console.WriteLine("work day");
}
else 
{ 
    Console.WriteLine("day off");
}
