// Задача 10 нужно решить через ЦЕЛЫЕ ЧИСЛА, без строчек

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное целое число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

int twoDigit = threeDigitNumber / 10; // делаем двухзначное число

int secondDigit = twoDigit % 10; // берем остаток от деления двухзначного числа

Console.WriteLine($"Вторая цифра трехзначного числа {threeDigitNumber} - {secondDigit}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine(); // почему здесь подчеркивает? не понимаю...

if (number.Length > 2) // и здесь указывает на number, что не так? Вроде все работает.
{
    Console.WriteLine("третья цифра - " + number[2]);
}

else Console.WriteLine("третьей цифры нет");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber != 6 && dayNumber != 7) Console.WriteLine("Рабочий день");
else Console.WriteLine("Выходной");

// или так (но почему то такой вариант не работал. Что не так?)
// if(dayNumber == 6 && dayNumber ==7) Console.WriteLine("Выходной");
// else Console.WriteLine("Рабочий день");
