int[] numbers = { -4, -3, -9, 6, -8, 12, 22, -19, 56, 34 };
int result = 0;
foreach (int number in numbers)
{
    if (number > 0)
    {
        result++;
    }
}
Console.WriteLine($"число элементов больше нуля: {result}");