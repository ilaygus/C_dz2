//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine ("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);
if ((num<100) || (num>999))
{
    Console.WriteLine ("ошибка");
}
else 
{
  int result = ((num/10)%10);
  Console.WriteLine ($"вторая цифра числа{num} -> {result}"); 
}