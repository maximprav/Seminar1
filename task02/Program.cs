// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine($"Число {b} кратно числу {a}");
}
else
{
    int num = a - b;
    Console.WriteLine($"Число {b} не кратно числу {a}");
    Console.WriteLine($"Остаток {num}");
}