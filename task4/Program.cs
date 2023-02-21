// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// Пример:
// 5-> 2,4
// 8 ->2,4,6,8

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.Write($"{number} -> ");
while (count <= number)
{
    Console.Write($"{count}, ");
    count+=2;
}

