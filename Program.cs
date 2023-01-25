// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine ("Введите первое число");
int first_count = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите второе число");
int second_count = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Немного магии...");
if (first_count > second_count)
{
    Console.WriteLine ($"Больше число {first_count} ");
}
else
{
    Console.WriteLine ($"Больше число {second_count} ");
}