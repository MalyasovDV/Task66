

int SumBetween(int m, int n)
{   
    int sum = 0;
    sum += m;
    ++m;
    if (m <= n)
        sum += SumBetween(m, n);
    return sum;
}

int m = 1;
int n = 15;

Console.WriteLine("\nСумма чисел в промежутке [{0};{1}] равна : {2} \n", m, n, SumBetween(m, n));

m = 4;
n = 8;

Console.WriteLine("Сумма чисел в промежутке [{0};{1}] равна : {2}\n", m, n, SumBetween(m, n));