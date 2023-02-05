// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int num7 = num % 7;
int num23 = num % 23;
if ((num7 == 0) & (num23 == 0))
{
    Console.WriteLine ($"Число {num} является кратным 7 и 23");
}
else 
{
    Console.WriteLine ($"Число {num} не является кратным 7 и 23");
}