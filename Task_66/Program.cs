Console.Clear();

Console.WriteLine("Пожалуйста, введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (numberM < numberN) Console.WriteLine(SumDigit(numberM, numberN));
else Console.WriteLine(SumDigit(numberN, numberM));

int SumDigit(int M, int N)
{
    if (M == N + 1) return 0;
    SumDigit(M + 1, N);
    sum = sum + M;
    return sum;
}