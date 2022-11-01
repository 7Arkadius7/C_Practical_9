Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int a = Convert.ToInt32(Console.ReadLine());

void NumbersRec(int arg1)
{
    if (arg1 == 0) return;
    System.Console.Write($"{arg1} ");
    NumbersRec(arg1 - 1);
}

NumbersRec(a);