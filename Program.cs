// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// Console.WriteLine ("Введите первое число");
// int first_count = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите второе число");
// int second_count = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Немного магии...");

// if (first_count > second_count)
// {
//     Console.WriteLine ($"max = {first_count} ");
// }

// else
// {
//     Console.WriteLine ($"max = {second_count} ");

// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

// Console.WriteLine ("Введите первое число");
// int first_count = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите второе число");
// int second_count = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите третье число");
// int third_count = int.Parse(Console.ReadLine()!);
// int max = first_count;

// if (second_count > max)
// {
//     max = second_count;
// }

// if (third_count > max)
// {
//     max = third_count;
// }

// Console.WriteLine (max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Введите число");
int count = int.Parse(Console.ReadLine()!);

if (count % 2 == 0)
{
    Console.WriteLine ("да");
}

else 
{
    Console.WriteLine ("нет");
}