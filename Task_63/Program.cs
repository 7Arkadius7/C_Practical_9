Console.Clear();

Console.WriteLine("Пожалуйста, введите конечное число");
int a = Convert.ToInt32(Console.ReadLine());


void NumbersRec(int arg1)
{
    if (arg1 == 0) return;
    NumbersRec(arg1 - 1);
    System.Console.Write($"{arg1} ");
}

// void NumbersRec(int arg1) // Выдает числа в обратном порядке
// {
//     if (arg1 == 0) return;
//     NumbersRec(arg1 - 1);
//     System.Console.Write($"{arg1} ");
// }

NumbersRec(a);