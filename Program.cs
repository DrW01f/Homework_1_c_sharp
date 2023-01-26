// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число");
int first_count = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите второе число");
int second_count = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Немного магии...");
if (first_count > second_count)
{
    Console.WriteLine ($"Большее число {first_count} ");
    Console.WriteLine ($"Меньшее число {second_count} ");
}
else
{
    Console.WriteLine ($"Большее число {second_count} ");
    Console.WriteLine ($"Меньшее число {first_count} ");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

