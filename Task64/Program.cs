Console.Clear();

Console.WriteLine("Пожалуйста, введите число N");
int n = Convert.ToInt32(Console.ReadLine());

void NumbersRec(int arg1)
{
    if (arg1 == 0) return;
    System.Console.Write($"{arg1} ");
    NumbersRec(arg1 - 1);
}

NumbersRec(n);