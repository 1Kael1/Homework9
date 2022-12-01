// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }

    if (numM != 0 && numN == 0)
    {
        return AkkermanFunction(numM - 1, 1);
    }

    if (numM > 0 && numN > 0)
    {
        return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
    }

    return AkkermanFunction(numM, numN);
}

Console.Write("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

int akkermanFunction = AkkermanFunction(m, n);

Console.WriteLine(akkermanFunction);