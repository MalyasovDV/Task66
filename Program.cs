

int SumBetween(int m, int n)
{   
    int sum = 0;
    sum += m;
    ++m;
    if (m <= n)
        sum += SumBetween(m, n);
    return sum;
}

Console.WriteLine("Введите значения начала и конца промежутка");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма чисел в промежутке [{0};{1}] равна : {2} ", m, n, SumBetween(m, n));
Console.WriteLine(SumBetween(m, n));