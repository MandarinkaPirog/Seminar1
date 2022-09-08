//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
 //максимальное из этих чисел.

Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число:");
int max = Math.Max(Math.Max(num1,num2),num3);
Console.Write(max);
