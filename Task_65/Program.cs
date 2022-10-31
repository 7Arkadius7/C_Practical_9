Console.Clear(); 

Console.WriteLine("Пожалуйста, введите начальное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите конечное число");
int b = Convert.ToInt32(Console.ReadLine());


string NumbersRec(int arg1, int arg2)
{
    if (arg1 <= arg2) return $"{arg1} " + NumbersRec(arg1 + 1, arg2);
    else return String.Empty;
}

System.Console.WriteLine(NumbersRec(a, b));
System.Console.WriteLine();
