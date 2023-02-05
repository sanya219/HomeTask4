/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/* int Power(int baseNumber, int pow)
{
    int result = 1;
    for(int i = 1; i <= pow; i++)
        result *= baseNumber;
    return result;
    
}

Console.Write("Please, enter base: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter power: ");
int powNum = Convert.ToInt32(Console.ReadLine());

int result = Power(baseNum, powNum);
Console.WriteLine($"{baseNum} raised to the power of {powNum} is {result}."); */
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int DigitSum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum > 0 ? sum: -sum; // Потому что при отрицательных числах сумма получалась отрицательной (видимо, остаток от деления отрицательный)
}

Console.Write("Please, enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(number);
Console.WriteLine($"The summ of digits in the number {number} is {sum}"); */
/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
