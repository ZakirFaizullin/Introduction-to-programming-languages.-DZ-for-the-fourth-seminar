// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] FillArray()
{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}
int[] array = FillArray();
System.Console.WriteLine(string.Join(",", array));