using System;

Console.Write("Введите два числа: ");
int FirstNumber = Console.Read();
Console.Write(", ");
int SecondNumber = Console.Read();
Console.WriteLine(".");

if (FirstNumber > SecondNumber)
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(FirstNumber);
}
else if (FirstNumber > SecondNumber)
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(SecondNumber);
}
else
{
   Console.WriteLine("Числа равны!");
}