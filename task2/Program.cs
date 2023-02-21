// Напишите программу, которая принимает на вход три числа и выдает маскиально из этих чисел.
// Пример:
// 2,3,7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max_number = 0;
if (number1 > number2)
        max_number = number1;
        else
        {
            max_number = number2;
        
        }
if (number2 > number3)
        max_number = number2;
        else
        {
            max_number = number3;

        }

Console.Write($"{number1}, {number2}, {number3} -> {max_number}");