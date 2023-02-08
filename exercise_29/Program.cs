// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter number of elements of an array: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[elements];

for (int i = 0; i < elements; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int digits in Array) Console.Write($"{digits} ");