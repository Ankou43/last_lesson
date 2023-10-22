static void PrintNaturalNumbers(int n)
{
    if (n < 1)
    {
        return;
    }
    else
    {
        Console.Write(n);
        if (n > 1)
        {
            Console.Write(", ");
        }
        PrintNaturalNumbers(n - 1);
    }
}

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
PrintNaturalNumbers(N);