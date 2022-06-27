// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Определение числа на четность");
int numberx = -11;
Console.WriteLine($"Дано число: {numberx}");
if (numberx % 2 == 0) 
{
    Console.WriteLine ("Число четное");
}
else 
{
    Console.WriteLine ($"Число нечетное, остаток {numberx % 2}");
}



