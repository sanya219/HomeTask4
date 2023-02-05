/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Power(int baseNumber, int pow)
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
Console.WriteLine($"{baseNum} raised to the power of {powNum} is {result}.");