Console.Clear();

Console.WriteLine("Пожалуйста, введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int arg1, int arg2)
{
    if (arg1 > 0 & arg2 == 0)
        return AckermannFunction(arg1 - 1, 1);
    if (arg1 > 0 & arg2 > 0)
        return AckermannFunction(arg1 - 1, AckermannFunction(arg1, arg2 - 1));
    return arg2 + 1;
}

Console.WriteLine($"Функция Аккермана для m = {m}, n = {n} равна {AckermannFunction(m, n)}");