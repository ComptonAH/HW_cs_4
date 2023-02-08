// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Enter a number: ");

int number = Convert.ToInt32(Console.ReadLine());
int length = Convert.ToInt32(Convert.ToString(number).Length);
int[] Array = new int[number];
int sum = 0; 


for (int i = 0; i <= length; i++)
{
    if (i==length)
    {
        for (int index = 0; index < length; index++)
        {
            sum = sum + Array[index];
        }
    }
    else
    {
    int digit = number%10;
    number = number/10;
    Array[i] = digit;
    }
}

Console.WriteLine(sum);