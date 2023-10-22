System.Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

void suma (int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
        {
            sum = sum + i;
        }
    System.Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: " + sum);
}

suma (m, n);