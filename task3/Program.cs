//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Пример:
// 4 -> Да
// -3 -> Нет
// 7 -> Нет
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
    Console.Write($"{number} -> Да");
else
    {
       Console.Write($"{number} -> Нет"); 
    }
