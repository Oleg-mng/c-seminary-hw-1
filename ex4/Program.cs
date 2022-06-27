//Задача 4, Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел
int number1 = 186;
int number2 = 19;
int number3 = -10;
Console.WriteLine($"Даны числа: {number1}, {number2}, {number3}");
int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine($"{max} - это максимальное число");