﻿Console.Write("Введите число: ");

string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Это число палиндром.");
  }
  else Console.WriteLine($"Это число не палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Что то не то, введите корректное число.");