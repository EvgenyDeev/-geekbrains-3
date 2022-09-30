/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Clear();
Console.WriteLine("Введите 5-ти значное число: ");
string? n = Convert.ToString(Console.ReadLine());
for ( int i = 0; i < n.Length / 2; i++  )
{
    if ( n[i] == n[n.Length - 1 - i])
    Console.WriteLine("Это число полиндром!");

    else
    Console.WriteLine("Это число НЕ полиндром!");
    return;
}

