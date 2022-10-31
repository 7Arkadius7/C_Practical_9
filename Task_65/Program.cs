Console.Clear();

Console.WriteLine("Пожалуйста, введите начальное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите конечное число");
int numberN = Convert.ToInt32(Console.ReadLine());

// string NumbersRec(int arg1, int arg2)
// {
//     if (arg1 <= arg2) return $"{arg1} " + NumbersRec(arg1 + 1, arg2);
//     else return String.Empty;
// }
// System.Console.WriteLine(NumbersRec(numberM, numberN));

void NumbersFromMToN(int numM, int numN)
{
    if (numM < numN)
    {
        System.Console.Write($"{numM} ");
        NumbersFromMToN(numM + 1, numN);
    }
    if (numM > numN)
    {
        System.Console.Write($"{numM} ");
        NumbersFromMToN(numM - 1, numN);
    }
    if (numM == numN)
     System.Console.Write($"{numM} ");
}
NumbersFromMToN(numberM, numberN);