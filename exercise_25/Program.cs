Console.WriteLine("Enter a number you want to power: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the power of your number: ");

int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1;

for (int i = 1; i < num2; i++)
{
    result = result*num1;
}
Console.WriteLine(result);