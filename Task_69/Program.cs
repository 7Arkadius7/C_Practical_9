Console.Clear();

Console.WriteLine("Пожалуйста, введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int PowerRec(int arg1, int arg2)
{
    return arg2 == 0 ? 1 : PowerRec(arg1, arg2 - 1) * arg1;
    if (arg2 == 0) return 1;
    else return PowerRec(arg1, arg2 - 1) * arg1;
}
System.Console.WriteLine(PowerRec(a, b));