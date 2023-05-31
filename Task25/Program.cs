// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Сalculation(int A, int B)
{
int result = A;
int count = 1;
while (count < B)
{
    result = result * A;
    count ++;
}
return result;
}



System.Console.WriteLine($"Введите число A:");
int A = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Введите число B:");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Сalculation(A, B));