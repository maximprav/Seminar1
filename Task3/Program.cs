// // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) 
{
    Console.Write(" Monday ");
}
if (number == 2) 
{
    Console.Write(" Tuesday ");
}
if (number == 3) 
{
    Console.Write(" Wednesday ");
}
if (number == 4) 
{
    Console.Write(" Thursday ");
}
if (number == 5) 
{
    Console.Write(" Friday ");
}
if (number == 6) 
{
    Console.Write(" Saturday ");
}
if (number == 7) 
{
    Console.Write(" Sunday ");
}
if (number > 7) 
{
    Console.Write(" Неверно заданное число ");
}
if (number < 1) 
{
    Console.Write(" Неверно заданное число ");
}
