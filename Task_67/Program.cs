Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int numberM = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = num % 10;
    if (num > 0) sum += SumDigit(num / 10);
    return sum;
}
System.Console.WriteLine(SumDigit(numberM));