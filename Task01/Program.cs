// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
//int num = new Random().Next();
// Комбинация для вывода рандомного числа в диапазоне от нуля до заданного num
int num = new Random().Next(100, 1000);
int a = num / 100;
int b = num % 10;
Console.WriteLine(num);
Console.WriteLine($"{a}{b}");